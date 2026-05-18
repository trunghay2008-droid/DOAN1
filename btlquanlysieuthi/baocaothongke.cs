using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class baocaothongke : Form
    {
        // Database btlqlysieuthi theo yêu cầu của bạn
        private string connectionString = @"Data Source=LAPTOP-UVCN4TCI;Initial Catalog=btlqlysieuthi;Integrated Security=True;TrustServerCertificate=True";
        private string tenBaoCaoHienTai = "Báo cáo thống kê";
        public baocaothongke()
        {
            InitializeComponent();
            ApplyModernStyling();
        }

        private void ApplyModernStyling()
        {
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 10);

            // Cấu hình DataGridView ban đầu
            dgvBaocao.BackgroundColor = Color.White;
            dgvBaocao.BorderStyle = BorderStyle.None;
            dgvBaocao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Hàm tổng quát để nạp dữ liệu từ Stored Procedure
        /// </summary>
        private void LoadBaoCao(string procedureName, string title)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure; // Chỉ định là chạy Procedure
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvBaocao.DataSource = dt;
                        ApplyFormatting(dgvBaocao);
                        this.Text = title;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi báo cáo: Không thể tải dữ liệu báo cáo", "Thông báo");
            }
        }

        private void ApplyFormatting(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;
            dgv.EnableHeadersVisualStyles = false;

            // Header Style
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 0, 130);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            // Row Style
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

            // Định dạng tiền tệ cho các cột chứa số tiền
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.HeaderText.Contains("Doanh Thu") ||
                    col.HeaderText.Contains("Lợi Nhuận") ||
                    col.HeaderText.Contains("Giá") ||
                    col.HeaderText.Contains("Tiền") ||
                    col.HeaderText.Contains("Chi Tiêu"))
                {
                    col.DefaultCellStyle.Format = "N0"; // Ví dụ: 1,000,000
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        // --- GÁN SỰ KIỆN CHO CÁC NÚT BẤM ---

        private void btnBaocaodoanhthu_Click_1(object sender, EventArgs e)
        {
            LoadBaoCao("sp_BaoCaoDoanhThuThang", "Báo Cáo Doanh Thu Theo Tháng");
        }

        private void btnTop5sp_Click_1(object sender, EventArgs e)
        {
            LoadBaoCao("sp_BaoCaoTopSanPham", "Top 10 Sản Phẩm Bán Chạy");
        }

        private void btnThongkedonhang_Click_1(object sender, EventArgs e)
        {
            LoadBaoCao("sp_ThongKeDonHang", "Thống Kê Phương Thức Thanh Toán");
        }

        private void btnThongkeLoiNhuan_Click_1(object sender, EventArgs e)
        {
            LoadBaoCao("sp_BaoCaoLoiNhuan", "Báo Cáo Lợi Nhận Gộp");
        }

        // Bạn có thể tạo thêm nút Khách Hàng và gọi như sau:
        private void btnKhachHang_Click_1(object sender, EventArgs e)
        {
            LoadBaoCao("sp_KhachHangThanThiet", "Top 20 Khách Hàng Thân Thiết");
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            {
                // 1. Kiểm tra xem có dòng dữ liệu nào để in không
                if (dgvBaocao.Rows.Count == 0 || (dgvBaocao.Rows.Count == 1 && dgvBaocao.Rows[0].IsNewRow))
                {
                    MessageBox.Show("Không có dữ liệu để xuất! Vui lòng chọn một danh mục báo cáo trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Gọi lớp dịch vụ và ném toàn bộ việc vẽ + hiển thị sang InAnService
                InAnService boInAn = new InAnService(connectionString);

                // Hãy chắc chắn rằng bạn đã kéo thả printPreviewDialog1 và printDocument1 từ Toolbox vào Form này nhé!
                boInAn.InBaoCaoTongHop(dgvBaocao, tenBaoCaoHienTai, printPreviewDialog1, printDocument1);
            }
        }
    }
}