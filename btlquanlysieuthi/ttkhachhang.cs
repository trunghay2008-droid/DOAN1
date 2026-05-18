using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class ttkhachhang : Form
    {
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";

        public ttkhachhang()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadData();
        }
        private void ExecuteAction(string action, int? id = null, string name = null, string phone = null, string address = null)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand("sp_KhachHang_Action", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Action", action);
                    cmd.Parameters.AddWithValue("@MaKH", (object)id ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@TenKH", (object)name ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DienThoai", (object)phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DiaChi", (object)address ?? DBNull.Value);

                    con.Open();
                    if (action == "SELECT")
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvKhachHang.DataSource = dt;
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        LoadData();
                        ClearInputs();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
        private void LoadData() => ExecuteAction("SELECT");
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text)) { MessageBox.Show("Vui lòng nhập tên!"); return; }
            ExecuteAction("INSERT", null, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text);
            MessageBox.Show("Thêm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text)) return;
            ExecuteAction("UPDATE", int.Parse(txtMaKH.Text), txtTenKH.Text, txtSDT.Text, txtDiaChi.Text);
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text)) return;
            if (MessageBox.Show("Xác nhận xóa khách này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ExecuteAction("DELETE", int.Parse(txtMaKH.Text));
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e) => ExecuteAction("SELECT", null, txtTimKiem.Text);

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = r.Cells["MaKH"].Value.ToString();
                txtTenKH.Text = r.Cells["TenKH"].Value.ToString();
                txtSDT.Text = r.Cells["DienThoai"].Value.ToString();
                txtDiaChi.Text = r.Cells["DiaChi"].Value.ToString();
                txtMaKH.ReadOnly = true;
            }
        }
        private void ClearInputs()
        {
            txtMaKH.Clear(); txtTenKH.Clear(); txtSDT.Clear(); txtDiaChi.Clear();
            txtMaKH.ReadOnly = false;
        }
        private void btnLamMoi_Click(object sender, EventArgs e) { ClearInputs(); LoadData(); }
    }
}