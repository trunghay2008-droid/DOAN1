using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class qlytaikhoan : Form
    {
        // Chuỗi kết nối
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";
        int maTK = -1;
        int _maNV;
        string _quyen;

        public qlytaikhoan(int maNV, string quyen)
        {
            InitializeComponent();
            _maNV = maNV;
            _quyen = quyen;

            this.Load += qlytaikhoan_Load;
            dgvHienthiTK.CellClick += dgvHienthiTK_CellClick;
            cbQuyenhan.SelectedIndexChanged += cbQuyenhan_SelectedIndexChanged;
        }

        private void qlytaikhoan_Load(object sender, EventArgs e)
        {
            cbQuyenhan.Items.Clear();
            cbQuyenhan.Items.AddRange(new string[] { "admin", "quanly", "nhanvien", "khachhang" });
            cbQuyenhan.SelectedIndex = 0;

            LoadTK();
        }


        private void cbQuyenhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbQuyenhan.Text == "khachhang")
            {
                txtMaNV.Enabled = false; txtMaNV.Clear();
                txtMaKH.Enabled = true;
            }
            else
            {
                txtMaNV.Enabled = true;
                txtMaKH.Enabled = false; txtMaKH.Clear();
            }
        }

        private void ThucThiProcedure(string action, object vMaNV = null, object vMaKH = null)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand("sp_TaiKhoan_HanhDong", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Truyền tham số cho Procedure
                    cmd.Parameters.AddWithValue("@Action", action);
                    cmd.Parameters.AddWithValue("@MaTK", (maTK == -1) ? DBNull.Value : (object)maTK);
                    cmd.Parameters.AddWithValue("@TenDangNhap", txtTenTK.Text.Trim());
                    cmd.Parameters.AddWithValue("@MatKhau", txtMatkhau.Text.Trim());
                    cmd.Parameters.AddWithValue("@Quyen", cbQuyenhan.Text);
                    cmd.Parameters.AddWithValue("@MaNV", vMaNV ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaKH", vMaKH ?? DBNull.Value);

                    con.Open();

                    if (action == "SELECT")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvHienthiTK.DataSource = dt;

                        if (dgvHienthiTK.Columns["HoTen"] != null)
                            dgvHienthiTK.Columns["HoTen"].HeaderText = "Chủ tài khoản";
                    }
                    else
                    {
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show($"{action} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTK();
                            if (action != "UPDATE") ClearForm();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống: không thể thực hiện thao tác!"+action, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadTK() => ThucThiProcedure("SELECT");

        private void btnThemTk_Click(object sender, EventArgs e)
        {
            if (!KiemTraInput(out object vMaNV, out object vMaKH)) return;
            ThucThiProcedure("INSERT", vMaNV, vMaKH);
        }

        private void btnupdateTK_Click(object sender, EventArgs e)
        {
            if (maTK == -1)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!");
                return;
            }
            if (!KiemTraInput(out object vMaNV, out object vMaKH)) return;
            ThucThiProcedure("UPDATE", vMaNV, vMaKH);
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (maTK == -1) return;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ThucThiProcedure("DELETE");
            }
        }

        private void dgvHienthiTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvHienthiTK.Rows[e.RowIndex];

            maTK = Convert.ToInt32(row.Cells["MaTK"].Value);
            txtTenTK.Text = row.Cells["TenDangNhap"]?.Value?.ToString() ?? "";
            txtMatkhau.Text = row.Cells["MatKhau"]?.Value?.ToString() ?? "";
            txtMaNV.Text = row.Cells["MaNV"]?.Value?.ToString() ?? "";
            txtMaKH.Text = row.Cells["MaKH"]?.Value?.ToString() ?? "";
            cbQuyenhan.Text = row.Cells["Quyen"]?.Value?.ToString() ?? "";
        }

        bool KiemTraInput(out object maNV, out object maKH)
        {
            maNV = DBNull.Value;
            maKH = DBNull.Value;

            if (string.IsNullOrWhiteSpace(txtTenTK.Text) || string.IsNullOrWhiteSpace(txtMatkhau.Text))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!");
                return false;
            }

            if (cbQuyenhan.Text == "khachhang")
            {
                if (!int.TryParse(txtMaKH.Text, out int idKH))
                {
                    MessageBox.Show("Mã khách hàng phải là số!");
                    return false;
                }
                maKH = idKH;
            }
            else
            {
                if (!int.TryParse(txtMaNV.Text, out int idNV))
                {
                    MessageBox.Show("Mã nhân viên phải là số!");
                    return false;
                }
                maNV = idNV;
            }
            return true;
        }

        void ClearForm()
        {
            txtTenTK.Clear();
            txtMatkhau.Clear();
            txtMaNV.Clear();
            txtMaKH.Clear();
            cbQuyenhan.SelectedIndex = 0;
            maTK = -1;
        }
    }
}