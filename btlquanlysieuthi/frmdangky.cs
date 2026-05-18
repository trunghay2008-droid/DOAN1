using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class frmdangky : Form
    {
        string connStr = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";

        public frmdangky()
        {
            InitializeComponent();
        }

        private void frmdangky_Load(object sender, EventArgs e)
        {
            cbQuyen.Items.Clear();
            cbQuyen.Items.AddRange(new string[] { "khachhang", "nhanvien" });
            cbQuyen.SelectedIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            txtRePassword.UseSystemPasswordChar = true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra tính hợp lệ của dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin bắt buộc!", "Thông báo");
                return;
            }

            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Lỗi");
                return;
            }

            // 2. Thực thi Database
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_DangKyTaiKhoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Chuẩn hóa dữ liệu trước khi gửi
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txtTenNV.Text.Trim());
                        cmd.Parameters.AddWithValue("@Quyen", cbQuyen.Text.Trim());
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            MessageBox.Show($"Đăng ký thành công!\nMã định danh (ID) của bạn là: {result}",
                                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Hiển thị lỗi từ RAISERROR trong SQL (ví dụ: Trùng tên đăng nhập)
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)//thg này lỗi thì là lỗi winform hoặc lỗi khác không phải lỗi SQL
            {
                MessageBox.Show("Lỗi kỹ thuật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtTenNV.Clear();
            txtPassword.Clear();
            txtRePassword.Clear();
            cbQuyen.SelectedIndex = 0;
            txtUsername.Focus();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkHienMatKhau.Checked;
            txtPassword.UseSystemPasswordChar = !isChecked;
            txtRePassword.UseSystemPasswordChar = !isChecked;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            new frmlogin().Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            new frmlogin().Show();
            this.Hide();
        }
    }
}