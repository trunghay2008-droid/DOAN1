using Microsoft.Data.SqlClient;
using System.Data;

namespace btlquanlysieuthi
{
    public partial class FormA : Form
    {
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";
        string selectedImagePath = "";
        private FormC _formBanHang;

        public FormA(FormC banHang)
        {
            InitializeComponent();
            this.Load += FormA_Load;
            this._formBanHang = banHang;
        }

        private void FormA_Load(object sender, EventArgs e)
        {
            LoadComboBoxLoai();
            HienThiSanPham();
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


        private void HienThiSanPham()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    using SqlCommand cmd =new SqlCommand("sp_HienThiSanPham", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHienThiSP.DataSource = dt;
                    dgvHienThiSP.EnableHeadersVisualStyles = false;
                    dgvHienThiSP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 0, 130);
                    dgvHienThiSP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvHienThiSP.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

                }
            }
            catch (Exception) { MessageBox.Show("Lỗi hiển thị bảng: sản phẩm này không tồn tại"); }
        }


        private void ClearInput()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGia.Text = "0";
            txtSoLuong.Text = "0";
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = open.FileName;
                using (FileStream fs = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                {
                    picSP.Image = Image.FromStream(fs);
                }
            }
        }


        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên sản phẩm!");
                return false;
            }
            if (!decimal.TryParse(txtGia.Text, out _) || !int.TryParse(txtSoLuong.Text, out _))
            {
                MessageBox.Show("Giá và Số lượng phải là số hợp lệ!");
                return false;
            }
            return true;
        }

        private void SaveProduct(string action)
        {
            // Ép giá trị
            decimal.TryParse(txtGia.Text, out decimal gia);
            int.TryParse(txtSoLuong.Text, out int soLuong);
            bool isDelete = (action == "DELETE");
            using (SqlConnection con = new SqlConnection(strCon))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Product_CRUD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                // Thêm tham số bằng cách kiểm tra: Nếu là DELETE thì gửi DBNull, ngược lại gửi giá trị thật
                cmd.Parameters.AddWithValue("@Action", action);
                cmd.Parameters.AddWithValue("@ProductID", txtMaSP.Text.Trim());
                cmd.Parameters.AddWithValue("@ProductName", isDelete ? DBNull.Value : (object)txtTenSP.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", isDelete ? DBNull.Value : (object)gia);
                cmd.Parameters.AddWithValue("@Quantity", isDelete ? DBNull.Value : (object)soLuong);
                cmd.Parameters.AddWithValue("@CategoryID", isDelete ? DBNull.Value : (cbLoaiSP.SelectedValue ?? DBNull.Value));
                cmd.Parameters.AddWithValue("@ImagePath", isDelete || string.IsNullOrEmpty(selectedImagePath) ? DBNull.Value : (object)selectedImagePath);
                cmd.Parameters.AddWithValue("@Status", isDelete ? DBNull.Value : (object)(soLuong > 0 ? "Còn hàng" : "Hết hàng"));
                cmd.ExecuteNonQuery();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                {
                    SaveProduct("INSERT");
                    ClearInput();
                }
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm:Mã Sản phẩm đã tồn tại!");
            }
            HienThiSanPham();
            if (_formBanHang != null)
            {
                _formBanHang.LoadCardsFromSQL();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                SaveProduct("UPDATE");
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                HienThiSanPham();
                ClearInput();
                if (_formBanHang != null)
                {
                    _formBanHang.LoadCardsFromSQL();
                }
            }
            catch (Exception) { MessageBox.Show("Lỗi sửa: Sửa sản phẩm không thành công"); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã sản phẩm cần xóa!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    SaveProduct("DELETE");
                    HienThiSanPham();
                    ClearInput();
                    if (_formBanHang != null)
                    {
                        _formBanHang.LoadCardsFromSQL();
                    }
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception) { MessageBox.Show("Lỗi xóa: Xóa Sản phẩm không thành công"); }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            HienThiSanPham();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_TimSanPham", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text.Trim());
                    cmd.Parameters.AddWithValue("@Loai", cbLoaiSP.SelectedValue);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHienThiSP.DataSource = dt;
                    if (dt.Rows.Count == 0)
                        MessageBox.Show("Không tìm thấy sản phẩm!");
                }
            }
            catch (Exception)  {MessageBox.Show("Lỗi tìm kiếm: Có lỗi xảy ra khi tìm kiếm sản phẩm");}
        }
    }
}