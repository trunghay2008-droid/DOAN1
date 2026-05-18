using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace btlquanlysieuthi
{
    public partial class FormC : Form
    {
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";
        private int _maKH_DangNhap = 1;
        public FormC()
        {
            InitializeComponent();
            // Khi form mở lên thì nạp sản phẩm ngay
            this.Load += (s, e) => LoadCardsFromSQL();
            LoadCardsFromSQL();
            LoadNhanVien();
          }
        public FormC(int idKH) : this()
        {
            this._maKH_DangNhap = idKH;
        }
        public void LoadCardsFromSQL()
        {
            flpProductList.Controls.Clear();
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThiSanPham", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Khởi tạo Card từ FormB sau đó Đổ dữ liệu từ SQL vào Card
                    FormB card = new FormB();
                    card.SetData(
                        dr["ProductID"].ToString(),
                        dr["ProductName"].ToString(),
                        (decimal)dr["Price"],
                        (int)dr["Quantity"],
                        dr["ImagePath"]?.ToString()
                    );
                    //sự kiện click ở card
                    card.OnAddClick += (id, name, price, qty) =>
                    {
                        ThemSanPhamVaoGrid(id, name, price, qty);
                    };
                    flpProductList.Controls.Add(card);
                }
            }
        }
        private void ThemSanPhamVaoGrid(string id, string name, decimal price, int qty)
        {

            bool isExist = false;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells[0].Value?.ToString() == id)
                {
                    int currentQty = int.Parse(row.Cells[2].Value.ToString());
                    int newQty = currentQty + qty;
                    row.Cells[2].Value = newQty;
                    row.Cells[4].Value = newQty * price;
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                dgvOrder.Rows.Add(id, name, qty, price, qty * price);
            }
            TinhTongTien();
        }
        private void TinhTongTien()// nó sẽ lấy từ cột dgv
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells[4].Value != null)
                    total += (decimal)row.Cells[4].Value;
            }
            lblTotal.Text = "Tổng cộng: " + total.ToString("N0") + " VNĐ";
        }

        private void LoadNhanVien()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_LoadNhanVien", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbNhanVien.DataSource = dt;
                    cbNhanVien.DisplayMember = "TenNV"; // Hiển thị tên
                    cbNhanVien.ValueMember = "MaNV";
                }
            }
            catch (Exception) { MessageBox.Show("Lỗi tải NV: Nhân viên không tồn tại"); }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvOrder.Rows.Count == 0) return;
            decimal totalVal = 0;
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    totalVal += Convert.ToDecimal(row.Cells[4].Value);
                }
            }
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();
                try
                {
                    // 1. Gọi SP tạo hóa đơn
                    SqlCommand cmdOrder = new SqlCommand("sp_InsertOrder", con, trans);
                    cmdOrder.CommandType = CommandType.StoredProcedure;
                    cmdOrder.Parameters.AddWithValue("@maNV", cbNhanVien.SelectedValue);
                    cmdOrder.Parameters.AddWithValue("@maKH", this._maKH_DangNhap);
                    cmdOrder.Parameters.AddWithValue("@totalAmount", totalVal);

                    int newOrderID = Convert.ToInt32(cmdOrder.ExecuteScalar());

                    // 2. Vòng lặp gọi SP thêm chi tiết (Trigger trừ kho sẽ tự kích hoạt ở mỗi dòng)
                    foreach (DataGridViewRow row in dgvOrder.Rows)
                    {
                        if (!row.IsNewRow && row.Cells[0].Value != null)
                        {
                            SqlCommand cmdDetail = new SqlCommand("sp_InsertOrderDetail", con, trans);
                            cmdDetail.CommandType = CommandType.StoredProcedure;
                            cmdDetail.Parameters.AddWithValue("@OrderID", newOrderID);
                            cmdDetail.Parameters.AddWithValue("@ProductID", row.Cells[0].Value);
                            cmdDetail.Parameters.AddWithValue("@Quantity", row.Cells[2].Value);
                            cmdDetail.Parameters.AddWithValue("@UnitPrice", row.Cells[3].Value);
                            cmdDetail.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    MessageBox.Show("Thanh toán thành công! Mã đơn: " + newOrderID);

                    this.Tag = newOrderID;
                    dgvOrder.Rows.Clear();
                    lblTotal.Text = "Tổng cộng: 0 VNĐ";
                    LoadCardsFromSQL();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi: Không thể thanh toán đơn hàng số lượng hàng hóa không hợp lệ");
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow != null && !dgvOrder.CurrentRow.IsNewRow)
            {
                try
                {
                    DataGridViewRow row = dgvOrder.CurrentRow;
                    if (row.Cells[2].Value == null || !int.TryParse(row.Cells[2].Value.ToString(), out int newQty) || newQty <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng hợp lệ (số nguyên > 0)!");
                        return;
                    }
                    decimal unitPrice = Convert.ToDecimal(row.Cells[3].Value);
                    row.Cells[4].Value = newQty * unitPrice;
                    TinhTongTien();

                    MessageBox.Show("Đã cập nhật đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi khi cập nhật:Cập nhật đơn hàng không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trong bảng để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow != null && !dgvOrder.CurrentRow.IsNewRow)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dgvOrder.Rows.Remove(dgvOrder.CurrentRow);
                    TinhTongTien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        { 
        if (this.Tag == null || !int.TryParse(this.Tag.ToString(), out int maHD))
        {
            MessageBox.Show("Vui lòng thực hiện thanh toán trước khi in hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 2. Gọi cái Class đa năng "InAnService"
        InAnService boInAn = new InAnService(strCon);
            string tenNV = cbNhanVien.Text;
            string thongTinKH = $"Tên KH: {txtTenKH.Text}";
            // 3. Ra lệnh bắn thẳng dữ liệu sang file kia để nó tự lấy SQL
            boInAn.InHoaDon(maHD, txtTenKH.Text, cbNhanVien.Text, printPreviewDialog1, printDocument1);
}

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // dữ liệu đã được bắn sang từ bước 3, nút này kết nối vs file inAnService để lấy dữ liệu SQL, sẽ có 1 biến toàn cục kiểu DataTable để lưu dữ liệu SQL lấy về, sau đó ở sự kiện này sẽ vẽ dữ liệu đó lên hóa đơn InAnService boInAn = new InAnService(strCon);
        }
    }
}