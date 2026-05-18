using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class lichsugdkh : Form
    {
        // Khai báo biến toàn cục của Form
        private string strCon;
        private int _idNguoiDung;

        public lichsugdkh(int idKH, string connectionString)
        {
            InitializeComponent();
            this._idNguoiDung = idKH;
            this.strCon = connectionString;

            // Thiết lập ngày mặc định
            dtpTuNgay.Value = DateTime.Now.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Now;

            this.Load += (s, e) => LoadLichSu();
        }

        private void LoadLichSu()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(this.strCon)) // Sửa lại đúng tên biến strCon
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_LichSuGiaoDich", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Truyền tham số khớp với Procedure
                    cmd.Parameters.AddWithValue("@MaKH", this._idNguoiDung);
                    cmd.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value.Date);
                    cmd.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLichSu.DataSource = dt;
                    TinhTong(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị lịch sử: " + ex.Message);
            }
        } // Thêm ngoặc đóng hàm LoadLichSu bị thiếu

        private void TinhTong(DataTable dt)
        {
            decimal tong = 0;
            // Lưu ý: Cột "Thành Tiền" phải khớp 100% với tên cột trong SQL Procedure
            foreach (DataRow r in dt.Rows)
            {
                if (r["Thành Tiền"] != DBNull.Value)
                    tong += Convert.ToDecimal(r["Thành Tiền"]);
            }
            lblTongTienValue.Text = string.Format("{0:N0} VNĐ", tong);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadLichSu();
        }
    }
}