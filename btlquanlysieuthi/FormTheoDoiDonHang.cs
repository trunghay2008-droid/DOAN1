using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class FormTheoDoiDonHang : Form
    {
        // Sử dụng Initial Catalog khớp với Database của bạn
        string strCon = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";
        int maKH_HienTai;

        public FormTheoDoiDonHang(int maKH)
        {
            InitializeComponent();
            this.maKH_HienTai = maKH;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();
                    
                    // Vì bảng Orders của bạn chưa có cột TrangThai test thử xem pphats
                    string sql = @"SELECT OrderID, OrderDate, TotalAmount, 
                                   N'Thành công' AS TrangThai 
                                   FROM Orders 
                                   WHERE MaKH = @maKH";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.Parameters.AddWithValue("@maKH", maKH_HienTai);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvDonHang.DataSource = dt;

                    // Đổi tên cột hiển thị cho đẹp
                    dgvDonHang.Columns["OrderID"].HeaderText = "Mã Đơn Hàng";
                    dgvDonHang.Columns["OrderDate"].HeaderText = "Ngày Đặt";
                    dgvDonHang.Columns["TotalAmount"].HeaderText = "Tổng Tiền";
                    dgvDonHang.Columns["TrangThai"].HeaderText = "Trạng Thái";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi tải dữ liệu: không thể tải dữ liệu từ cơ sở dữ liệu" );
            }
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Kiểm tra xem cột TrangThai có tồn tại không để tránh crash
                if (dgvDonHang.Rows[e.RowIndex].Cells["TrangThai"].Value != null)
                {
                    string trangThai = dgvDonHang.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                    UpdateTrackingGraphics(trangThai);
                }
            }
        }

        private void UpdateTrackingGraphics(string status)
        {
            // Reset màu xám ban đầu
            lblStep1.ForeColor = lblStep2.ForeColor = lblStep3.ForeColor = lblStep4.ForeColor = Color.Silver;

            // Logic thắp sáng dựa trên trạng thái
            switch (status.Trim())
            {
                case "Đã đặt":
                    lblStep1.ForeColor = Color.Green;
                    break;
                case "Đã xác nhận":
                    lblStep1.ForeColor = Color.Green;
                    lblStep2.ForeColor = Color.Green;
                    break;
                case "Đang giao":
                    lblStep1.ForeColor = Color.Green;
                    lblStep2.ForeColor = Color.Green;
                    lblStep3.ForeColor = Color.Orange;
                    break;
                case "Thành công":
                    lblStep1.ForeColor = Color.Green;
                    lblStep2.ForeColor = Color.Green;
                    lblStep3.ForeColor = Color.Green;
                    lblStep4.ForeColor = Color.DeepSkyBlue;
                    break;
            }
        }
    }
}