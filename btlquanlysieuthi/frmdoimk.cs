using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class frmdoimk : Form
    {
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";
        int _maNV;      // Lưu mã nhân viên từ Form chính truyền sang
        string _quyen;   // Lưu quyền từ Form chính truyền sang
        public frmdoimk(int maNV, string quyen)
        {
            InitializeComponent();
            this._maNV = maNV;
            this._quyen = quyen;
            txtMaTK.UseSystemPasswordChar = true;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            txtXacNhanMK.UseSystemPasswordChar = true;
        }


        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra không được để trống dữ liệu
            if (string.IsNullOrWhiteSpace(txtMaTK.Text) || string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã tài khoản và Mật khẩu mới!", "Thông báo");
                return;
            }
            // 2. Kiểm tra mật khẩu mới gõ lại có khớp nhau không
            if (txtMatKhauMoi.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không khớp!", "Lỗi");
                return;
            }
            // 3. Kiểm tra định dạng Mã tài khoản nhập vào có phải là số nguyên hay không
            int maInput;
            if (!int.TryParse(txtMaTK.Text.Trim(), out maInput))
            {
                MessageBox.Show("Mã tài khoản phải là số hợp lệ!", "Lỗi nhập liệu");
                return;
            }
            // 4. Kiểm tra xem mã vừa gõ có trùng với mã nhân viên đang đăng nhập hệ thống không
            if (_maNV != 0 && maInput != _maNV)
            {
                MessageBox.Show("Mã tài khoản không chính xác với tài khoản đang đăng nhập!", "Lỗi xác thực");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();

                    // 1. Lấy mã nhân viên do người dùng tự gõ ở ô TextBox để kiểm tra dưới DB
                    int maXacThuc = int.Parse(txtMaTK.Text.Trim());

                    // 2. Kiểm tra xem mã nhân viên này có tồn tại trong bảng TaiKhoan không
                    string sqlCheck = "SELECT COUNT(*) FROM TaiKhoan WHERE MaNV = @ma";
                    SqlCommand cmdCheck = new SqlCommand(sqlCheck, con);
                    cmdCheck.Parameters.AddWithValue("@ma", maXacThuc); // Sửa thành maXacThuc

                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        // 3. Tiến hành cập nhật mật khẩu mới cho đúng mã nhân viên vừa tìm thấy
                        string quyenMoi = cbQuyen.SelectedItem?.ToString() ?? _quyen;
                        string sqlUpdate = "UPDATE TaiKhoan SET MatKhau = @mkMoi, Quyen = @quyen WHERE MaNV = @ma";
                        SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, con);

                        cmdUpdate.Parameters.AddWithValue("@mkMoi", txtMatKhauMoi.Text.Trim());
                        cmdUpdate.Parameters.AddWithValue("@quyen", quyenMoi);
                        cmdUpdate.Parameters.AddWithValue("@ma", maXacThuc); // Sửa thành maXacThuc

                        cmdUpdate.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật mật khẩu và quyền thành công!", "Thông báo");
                        this.Close(); // Đóng form sau khi thành công
                    }
                    else
                    {
                        MessageBox.Show("Mã tài khoản không tồn tại trên hệ thống!", "Lỗi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Thông báo lỗi");
            }
        }

        private void frmdoimk_Load(object sender, EventArgs e)
        {
            cbQuyen.Items.Clear();
            cbQuyen.Items.Add("admin");
            cbQuyen.Items.Add("quanly");
            cbQuyen.Items.Add("nhanvien");
            cbQuyen.SelectedItem = _quyen;
            if (_quyen.ToLower() != "admin")
            {
                cbQuyen.Enabled = false;
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhauMoi.UseSystemPasswordChar = !chkHienMatKhau.Checked;
            txtXacNhanMK.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmlogin fLogin = new frmlogin();
            fLogin.Show();
            this.Hide();
        }
    }
}