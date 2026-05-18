using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class frmqlkho : Form
    {
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";

        public frmqlkho()
        {
            InitializeComponent();
            this.Load += Frmqlkho_Load;
        }

        private void Frmqlkho_Load(object sender, EventArgs e)
        {
            LoadDataKho();
            LoadComboBoxLoai();
            HienThiLoiNhuan();
        }
        private void LoadDataKho()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    string sql = "SELECT * FROM v_ThongTinKho";

                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKho.DataSource = dt;
                    // Style DataGridView
                    dgvKho.EnableHeadersVisualStyles = false;
                    dgvKho.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 0, 130);
                    dgvKho.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvKho.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu từ View: " + ex.Message);
            }
        }

        private void HienThiLoiNhuan()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetTongLoiNhuan", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    object res = cmd.ExecuteScalar();
                    decimal tongLai = (res != DBNull.Value && res != null) ? Convert.ToDecimal(res) : 0;
                    lblLoiNhuan.Text = $"TỔNG LỢI NHUẬN THU VỀ: {tongLai:N0} VNĐ";
                    lblLoiNhuan.ForeColor = Color.DarkGreen;
                }
            }
            catch { lblLoiNhuan.Text = "Lợi nhuận: 0 VNĐ"; }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand("sp_NhapHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@tenNCC", txtTenNCC.Text.Trim());
                    cmd.Parameters.AddWithValue("@maSP", txtMaSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@tenSP", txtTenSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@sl", int.Parse(txtSoLuong.Text));
                    cmd.Parameters.AddWithValue("@giaN", decimal.Parse(txtGiaNhap.Text));
                    cmd.Parameters.AddWithValue("@maLoai", cbLoaiSP.SelectedValue);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Nhập hàng thành công!");
                    LoadDataKho();
                    HienThiLoiNhuan();// Hàm gom LoadDataKho và HienThiLoiNhuan
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không thể nhập hàng!");
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SP và Số lượng!");
                return false;
            }
            if (!int.TryParse(txtSoLuong.Text, out _) || !decimal.TryParse(txtGiaNhap.Text, out _))
            {
                MessageBox.Show("Số lượng và Giá nhập phải là số!");
                return false;
            }
            return true;
        }

        private void LoadComboBoxLoai()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand("sp_LoadCategory", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbLoaiSP.DataSource = dt;
                    cbLoaiSP.DisplayMember = "CategoryName";
                    cbLoaiSP.ValueMember = "CategoryID";

                }
            }
            catch (Exception) { MessageBox.Show("Lỗi load danh mục:Mục này không tồn tại "); }
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetChiTietHoaDon", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvKho.DataSource = dt;
                    FormatGridViewHoaDon(); // Tách hàm định dạng
                    MessageBox.Show("Đã tải báo cáo chi tiết hóa đơn!");
                }
            }
            catch (Exception) { MessageBox.Show("Lỗi kết nối: không thể xem Hóa đơn!"); }
        }
        // Hàm bổ trợ định dạng GridView
        private void FormatGridViewHoaDon()
        {
            string[] cols = { "Giá Vốn", "Giá Bán", "Thành Tiền", "Lợi Nhuận" };
            foreach (var col in cols)
            {
                if (dgvKho.Columns.Contains(col)) dgvKho.Columns[col].DefaultCellStyle.Format = "N0";
            }
            if (dgvKho.Columns.Contains("Lợi Nhuận"))
            {
                dgvKho.Columns["Lợi Nhuận"].DefaultCellStyle.ForeColor = Color.Red;
                dgvKho.Columns["Lợi Nhuận"].DefaultCellStyle.Font = new Font(dgvKho.Font, FontStyle.Bold);
            }
        }
        private void btnXemphieunhap_Click(object sender, EventArgs e)
        {
            LoadDataKho();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        SqlCommand cmd = new SqlCommand("sp_DeleteProduct", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductID", txtMaSP.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        txtMaSP.Clear(); txtTenSP.Clear();
                        LoadDataKho(); HienThiLoiNhuan();
                    }
                }
                catch { MessageBox.Show("Không thể xóa sản phẩm này (có ràng buộc dữ liệu)!"); }
            }
        }




        private void dgvKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvKho.Rows[e.RowIndex];
                    txtMaSP.Text = row.Cells["ProductID"].Value.ToString();
                    txtTenSP.Text = row.Cells["ProductName"].Value.ToString();
                    if (row.Cells["GiaNhap"].Value != null)
                        txtGiaNhap.Text = row.Cells["GiaNhap"].Value.ToString();
                    txtSoLuong.Text = row.Cells["TonKho"].Value.ToString();
                }

                catch (Exception)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi chọn dòng dữ liệu",
                                    "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaHoaDon_Click_1(object sender, EventArgs e)
        {
            if (dgvKho.CurrentRow == null || !dgvKho.Columns.Contains("OrderID")) return;

            string maHD = dgvKho.CurrentRow.Cells["OrderID"].Value?.ToString();
            if (string.IsNullOrEmpty(maHD)) return;

            if (MessageBox.Show($"Xóa vĩnh viễn hóa đơn {maHD}?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(strCon))
                    {
                        SqlCommand cmd = new SqlCommand("sp_DeleteOrder", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OrderID", maHD);

                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã xóa hóa đơn!");
                            btnXemHoaDon_Click(sender, e); HienThiLoiNhuan();
                        }
                    }
                }
                catch { MessageBox.Show("Lỗi khi xóa hóa đơn!"); }
            }
        }
    }
}