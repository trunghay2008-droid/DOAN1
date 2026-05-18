using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class Form1 : Form
    {
        private SqlDataAdapter da;
        private DataTable dt;
        private readonly string _quyen;
        private readonly int _maNV;
        private readonly string connStr;
        private readonly FormC _sharedFormC = new FormC();
        private Form currentFormChild;

        public Form1(string quyen, int maNV, string connStr)
        {
            InitializeComponent();
            _quyen = quyen;
            _maNV = maNV;
            this.connStr = connStr;
            LoadData();
            KhoiTaoForm();
        }

        private void KhoiTaoForm()
        {
            cbQuyen.Items.Clear();
            cbQuyen.Items.Add("kỹ sư");
            cbQuyen.Items.Add("quanly");
            cbQuyen.Items.Add("nhanvien");
            cbQuyen.SelectedIndex = 0;
            dgvHienThi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHienThi.MultiSelect = false;

            // Kiểm tra tránh sập nguồn khi danh sách dt chưa kịp có dữ liệu hoặc mã nhân viên hệ thống
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow[] rows = dt.Select($"MaNV = '{_maNV}'");
                if (rows.Length > 0)
                {
                    string tenNV = rows[0]["TenNV"].ToString();
                    lblXinchao.Text = $"Xin Chào: {tenNV}\nChức Vụ: {_quyen}\nSố Hiệu: {_maNV}";
                }
                else
                {
                    lblXinchao.Text = $"Xin Chào: Tài khoản hệ thống\nChức Vụ: {_quyen}\nSố Hiệu: {_maNV}";
                }
            }
            else
            {
                lblXinchao.Text = $"Xin Chào: User\nChức Vụ: {_quyen}\nSố Hiệu: {_maNV}";
            }

            DinhDangDataGridView();
        }

        private void DinhDangDataGridView()
        {
            dgvHienThi.EnableHeadersVisualStyles = false;
            dgvHienThi.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 0, 130);
            dgvHienThi.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHienThi.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgvHienThi.AutoResizeColumns();
        }

        private bool KiemTraMaNV(out int maNV)
        {
            if (!int.TryParse(txtMaNV.Text.Trim(), out maNV))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ! Vui lòng nhập số.");
                return false;
            }
            return true;
        }

        private void FormatGio()
        {
            if (dgvHienThi.Columns.Contains("GioVao"))
            {
                dgvHienThi.Columns["GioVao"].DefaultCellStyle.Format = @"hh\:mm\:ss";
            }
            if (dgvHienThi.Columns.Contains("GioRa"))
            {
                dgvHienThi.Columns["GioRa"].DefaultCellStyle.Format = @"hh\:mm\:ss";
            }
        }

        private void ClearInput()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtGioiTinh.Clear();
            txtNgaySinh.Clear();
            txtDienThoai.Clear();
            txtNgayVaoLam.Clear();
            txtLuong.Clear();
            txtPhuCap.Clear();
            txtTimKiem.Clear();
            cbQuyen.SelectedIndex = 0;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                splitContainer1.Panel2.Controls.Remove(currentFormChild);
                currentFormChild.Hide();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(childForm);
            splitContainer1.Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("sp_NhanVien_GetList", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);

                    dgvHienThi.DataSource = dt;
                    dgvHienThi.AutoResizeColumns();
                    DinhDangDataGridView();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi tải dữ liệu nhân viên: Vui lòng kiểm tra csdl");
            }
        }

        private void LoadChamCong()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = "SELECT * FROM vw_ChamCong";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvHienThi.DataSource = table;
                    dgvHienThi.AutoResizeColumns();
                }
                FormatGio();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi tải chấm công: Vui lòng kiểm tra csdl");
            }
        }

        private void LoadLuongNhanVien(int? maNV)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("sp_TongLuongThang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Kiểm tra null cho tham số mã nhân viên
                    cmd.Parameters.AddWithValue("@MaNV", maNV.HasValue ? (object)maNV.Value : DBNull.Value);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvHienThi.DataSource = table;
                    dgvHienThi.AutoResizeColumns();
                    if (dgvHienThi.Columns.Contains("MaNV")) dgvHienThi.Columns["MaNV"].HeaderText = "Mã user";
                    if (dgvHienThi.Columns.Contains("TenNV")) dgvHienThi.Columns["TenNV"].HeaderText = "Tên nhân viên";
                    if (dgvHienThi.Columns.Contains("Quyen")) dgvHienThi.Columns["Quyen"].HeaderText = "Chức vụ";
                    if (dgvHienThi.Columns.Contains("TongCong")) dgvHienThi.Columns["TongCong"].HeaderText = "Tổng công";
                    if (dgvHienThi.Columns.Contains("TongLuong")) dgvHienThi.Columns["TongLuong"].HeaderText = "Tổng lương";
                    if (dgvHienThi.Columns.Contains("PhuCap")) dgvHienThi.Columns["PhuCap"].HeaderText = "Phụ cấp";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lương: " + ex.Message);
            }
        }

        private void ChamCong(string loai)
        {
            if (!KiemTraMaNV(out int maNV)) return;

            if (_quyen.ToLower() != "admin" && _quyen.ToLower() != "quanly" && maNV != this._maNV)
            {
                MessageBox.Show("Bạn không thể chấm công cho nhân viên khác!", "Từ chối truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("sp_ChamCong", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@Ngay", DateTime.Today);
                    cmd.Parameters.AddWithValue("@Gio", DateTime.Now.TimeOfDay);
                    cmd.Parameters.AddWithValue("@Loai", loai);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvHienThi.DataSource = table;
                    dgvHienThi.AutoResizeColumns();
                    FormatGio();

                    string cc = (loai == "VAO") ? "vào" : "ra";
                    MessageBox.Show($"Chấm công {cc} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chấm công: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraMaNV(out int maMoi)) return;

                foreach (DataRow row in dt.Rows)
                {
                    if (row.RowState != DataRowState.Deleted && row["MaNV"].ToString() == txtMaNV.Text.Trim())
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!");
                        return;
                    }
                }

                decimal phuCap = 0;
                decimal.TryParse(txtPhuCap.Text.Trim(), out phuCap);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("sp_NhanVien_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(txtNgaySinh.Text));
                    cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@Quyen", cbQuyen.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@NgayVaoLam", DateTime.Parse(txtNgayVaoLam.Text));
                    cmd.Parameters.AddWithValue("@PhuCap", phuCap);
                    cmd.Parameters.AddWithValue("@Luong", decimal.Parse(txtLuong.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm thành công!");
                LoadData();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm nhân viên: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHienThi.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                    return;
                }

                decimal phuCap = 0;
                decimal.TryParse(txtPhuCap.Text.Trim(), out phuCap);

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("sp_NhanVien_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(txtNgaySinh.Text));
                    cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@Quyen", cbQuyen.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@NgayVaoLam", DateTime.Parse(txtNgayVaoLam.Text));
                    cmd.Parameters.AddWithValue("@PhuCap", phuCap);
                    cmd.Parameters.AddWithValue("@Luong", decimal.Parse(txtLuong.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa nhân viên: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    if (dgvHienThi.Columns.Contains("MaCC"))
                    {
                        int maCC = Convert.ToInt32(dgvHienThi.CurrentRow.Cells["MaCC"].Value);
                        SqlCommand cmd = new SqlCommand("sp_ChamCong_Delete", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaCC", maCC);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã xóa chấm công!");
                        LoadChamCong();
                    }
                    else if (dgvHienThi.Columns.Contains("MaNV"))
                    {
                        string maNV = dgvHienThi.CurrentRow.Cells["MaNV"].Value.ToString();
                        DialogResult result = MessageBox.Show($"Xác nhận xóa nhân viên {maNV} ?", "Cảnh báo", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand("sp_NhanVien_Delete", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@MaNV", maNV);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đã xóa nhân viên!");
                            LoadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa không thành công: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("sp_TimNhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvHienThi.DataSource = table;
                    dgvHienThi.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm thất bại: " + ex.Message);
            }
        }

        private void dgvHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                DataGridViewRow row = dgvHienThi.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString() ?? "";
                txtTenNV.Text = row.Cells["TenNV"].Value?.ToString() ?? "";
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString() ?? "";
                txtNgaySinh.Text = row.Cells["NgaySinh"].Value?.ToString() ?? "";
                txtDienThoai.Text = row.Cells["DienThoai"].Value?.ToString() ?? "";
                txtNgayVaoLam.Text = row.Cells["NgayVaoLam"].Value?.ToString() ?? "";
                txtLuong.Text = row.Cells["Luong"].Value?.ToString() ?? "";
                cbQuyen.SelectedItem = row.Cells["Quyen"].Value?.ToString() ?? "";
                if (dgvHienThi.Columns.Contains("PhuCap"))
                {
                    txtPhuCap.Text = row.Cells["PhuCap"].Value?.ToString() ?? "0";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi chọn dữ liệu từ bảng!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e) { ChamCong("VAO"); }
        private void btnCheckOut_Click(object sender, EventArgs e) { ChamCong("RA"); }

        private void btnTinhCongLuong_Click(object sender, EventArgs e)
        {
            if (_quyen.ToLower() != "admin")
            {
                MessageBox.Show("Chỉ admin mới được tính lương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraMaNV(out int maNV)) return;
            LoadLuongNhanVien(maNV);
        }

        private void btnXemTongCong_Click(object sender, EventArgs e) { LoadChamCong(); }
        private void btnxem_Click(object sender, EventArgs e) { LoadData(); }
        private void btnmenu_Click(object sender, EventArgs e) { currentFormChild?.Hide(); }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { Application.Exit(); }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmlogin loginForm = new frmlogin();
            loginForm.Show();
            this.Hide();
        }

        private void btnfrmdoimk_Click(object sender, EventArgs e)
        {
            if (_quyen.ToLower() != "admin")
            {
                MessageBox.Show("Chỉ admin mới được sử dụng chức năng này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenChildForm(new qlytaikhoan(_maNV, _quyen));
        }

        private void btnKho_Click(object sender, EventArgs e) 
        {
            if (_quyen.ToLower() != "admin" && _quyen.ToLower() != "quản lý")
            {
                MessageBox.Show("Chỉ admin,quản lý mới được sử dụng chức năng này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenChildForm(new frmqlkho());
        }
        private void btnBaocaothongke_Click(object sender, EventArgs e)
        {
            if (_quyen.ToLower() != "admin" && _quyen.ToLower() != "quản lý")
            {
                MessageBox.Show("Chỉ admin,quản lý mới được sử dụng chức năng này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            OpenChildForm(new baocaothongke()); 
        }
        private void btnKhachhang_Click(object sender, EventArgs e) { OpenChildForm(new ttkhachhang()); }
        private void FormA_Click_1(object sender, EventArgs e) { OpenChildForm(new FormA(_sharedFormC)); }
        private void FormC_Click(object sender, EventArgs e) { OpenChildForm(_sharedFormC); }

        private void lblHuongDan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HuongDanSuDung hdsd = new HuongDanSuDung();
            hdsd.ShowDialog();
            
        }
    }
}