using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlquanlysieuthi
{


    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cboQuyen.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn quyền");
                return;
            }

            string connStr = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("sp_KiemTraDangNhap", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@user", txtUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@quyen", cboQuyen.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        string quyen = dt.Rows[0]["Quyen"].ToString().ToLower();
                        int maNV = Convert.ToInt32(dt.Rows[0]["IDNguoiDung"]);

                        MessageBox.Show("Đăng nhập thành công (" + quyen + ")");
                        if (quyen == "khachhang")
                        {
                            FromKhachhang fKH = new FromKhachhang(quyen, maNV, connStr);
                            fKH.Show();
                        }
                        else
                        {
                            // Mở form quản trị (admin, quanly, nhanvien)
                            Form1 f = new Form1(quyen, maNV, connStr);
                            f.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản / mật khẩu / quyền");
                    }
                }
            }
            catch (SqlException)
            {
                // Bắt các lỗi cụ thể liên quan đến SQL (Server off, sai chuỗi kết nối, timeout...)
                MessageBox.Show("Lỗi kết nối CSDL: Không liên kết được với máy chủ ", "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            cboQuyen.Items.Add("admin");
            cboQuyen.Items.Add("quanly");
            cboQuyen.Items.Add("nhanvien");
            cboQuyen.Items.Add("khachhang");
            cboQuyen.SelectedIndex = 0;
            txtPass.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("Bạn có muốn thoát không?", "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmdangky loginForm = new frmdangky();
            loginForm.Show();
            this.Hide();
        }

        private void lblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int maNVDemo = 0;       // Truyền tạm số 0 (hoặc mã mặc định)
            string quyenDemo = "nhanvien"; // Truyền tạm quyền mặc định
            frmdoimk formDoiMK = new frmdoimk(maNVDemo, quyenDemo);
            formDoiMK.Show();
            this.Hide();
        }
    }
}
