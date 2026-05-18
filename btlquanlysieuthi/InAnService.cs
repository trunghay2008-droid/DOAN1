using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class InAnService
    {
        private string strCon;

        // Các biến tạm dùng chung cho việc hứng dữ liệu
        private DataTable dtDuLieuIn = new DataTable();
        private string tieuDeBaoCao = "";
        private string thongTinKHIn = "";
        private string tenNhanVienIn = "";
        private int maHoaDonIn = 0;

        private DataGridView dgvDuLieuBaoCao;
        public InAnService(string connectionString)
        {
            this.strCon = connectionString;
        }

        // =========================================================
        // HÀM 1: IN HÓA ĐƠN BÁN HÀNG
        // =========================================================
        public void InHoaDon(int maHD, string tenKH, string tenNV, PrintPreviewDialog previewDialog, PrintDocument printDoc)
        {
            this.maHoaDonIn = maHD;
            this.thongTinKHIn = tenKH;
            this.tenNhanVienIn = tenNV;

            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    SqlCommand cmd = new SqlCommand("sp_GetInvoiceDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@OrderID", maHD);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtDuLieuIn.Clear();
                    da.Fill(dtDuLieuIn);
                }

                tieuDeBaoCao = "HÓA ĐƠN BÁN HÀNG";
                // Điều này giúp ngăn chặn tuyệt đối lỗi chồng chữ, lặp chữ do += gây ra.
                var eventField = typeof(PrintDocument).GetField("PrintPage", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (eventField != null) eventField.SetValue(printDoc, null);

                // Bây giờ mới gán hàm vẽ duy nhất vào
                printDoc.PrintPage += new PrintPageEventHandler(VeGiaoDienHoaDon);

                previewDialog.Document = printDoc;
                ((Form)previewDialog).WindowState = FormWindowState.Maximized;
                previewDialog.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi in hóa đơn: " + ex.Message); }
        }

        private void VeGiaoDienHoaDon(object sender, PrintPageEventArgs e)
        {
            Font fontTenCuaHang = new Font("Arial", 14, FontStyle.Bold);
            Font fontSlogan = new Font("Arial", 10, FontStyle.Italic);
            Font fontTieuDe = new Font("Arial", 18, FontStyle.Bold);
            Font fontChuDam = new Font("Arial", 11, FontStyle.Bold);
            Font fontChuThuong = new Font("Arial", 11, FontStyle.Regular);

            Brush coVe = Brushes.Black;
            Pen netVe = new Pen(Color.Black, 1);

            int xLe = 80;
            int y = 50;

            // --- VẼ HEADER ---
            e.Graphics.DrawString("SIÊU THỊ QUẢN LÝ BÁN HÀNG", fontTenCuaHang, coVe, xLe + 180, y);
            y += 22;
            e.Graphics.DrawString("BẠN CỦA MỌI NHÀ", fontSlogan, coVe, xLe + 240, y);
            y += 40;
            e.Graphics.DrawString(tieuDeBaoCao, fontTieuDe, coVe, xLe + 200, y);
            y += 45;

            // --- VẼ THÔNG TIN CHUNG ---
            e.Graphics.DrawString($"Mã hóa đơn: {maHoaDonIn}", fontChuThuong, coVe, xLe, y);
            e.Graphics.DrawString($"Ngày lập: {DateTime.Now:dd/MM/yyyy HH:mm}", fontChuThuong, coVe, xLe + 350, y);
            y += 25;
            e.Graphics.DrawString($"Khách hàng: {thongTinKHIn}", fontChuThuong, coVe, xLe, y);
            e.Graphics.DrawString($"Người lập: {tenNhanVienIn}", fontChuThuong, coVe, xLe + 350, y);
            y += 35;

            // --- VẼ TIÊU ĐỀ CỘT CỦA BẢNG ---
            e.Graphics.DrawLine(netVe, xLe, y, xLe + 650, y);
            y += 5;

            e.Graphics.DrawString("STT", fontChuDam, coVe, xLe + 10, y);
            e.Graphics.DrawString("Tên Sản Phẩm", fontChuDam, coVe, xLe + 70, y);
            e.Graphics.DrawString("Số Lượng", fontChuDam, coVe, xLe + 350, y);
            e.Graphics.DrawString("Đơn Giá", fontChuDam, coVe, xLe + 460, y);
            e.Graphics.DrawString("Thành Tiền", fontChuDam, coVe, xLe + 560, y);
            y += 25;

            e.Graphics.DrawLine(netVe, xLe, y, xLe + 650, y);
            y += 15; // Tăng khoảng cách từ đường kẻ đến hàng đầu tiên một chút cho thoáng

            // --- VÒNG LẶP ĐỔ DATA TỪ SQL VÀO BẢNG ---
            int stt = 1;
            decimal tongTien = 0;

            foreach (DataRow row in dtDuLieuIn.Rows)
            {
                string tenSP = row["ProductName"].ToString();
                int sl = Convert.ToInt32(row["Quantity"]);
                decimal thanhTien = Convert.ToDecimal(row["ThanhTien"]);

                // Tránh lỗi chia cho 0 nếu số lượng bằng 0 ngoài ý muốn
                decimal gia = sl > 0 ? thanhTien / sl : 0;
                tongTien += thanhTien;

                if (tenSP.Length > 28) tenSP = tenSP.Substring(0, 25) + "...";

                e.Graphics.DrawString(stt.ToString(), fontChuThuong, coVe, xLe + 15, y);
                e.Graphics.DrawString(tenSP, fontChuThuong, coVe, xLe + 70, y);
                e.Graphics.DrawString(sl.ToString(), fontChuThuong, coVe, xLe + 370, y);
                e.Graphics.DrawString(gia.ToString("N0"), fontChuThuong, coVe, xLe + 460, y);
                e.Graphics.DrawString(thanhTien.ToString("N0"), fontChuThuong, coVe, xLe + 560, y);

                y += 25;
                e.Graphics.DrawLine(Pens.LightGray, xLe, y, xLe + 650, y);
                y += 10; // Tăng lên 10 thay vì 5 để chữ không bị sát vào đường kẻ mờ
                stt++;
            }

            // --- VẼ TỔNG TIỀN PHẢI THANH TOÁN DỰA TRÊN Y ĐỘNG ---
            // Vẽ đường chốt bảng ngăn cách phần sản phẩm và phần tổng tiền
            e.Graphics.DrawLine(netVe, xLe, y, xLe + 650, y);

            y += 20; // Dịch xuống 20 pixel từ đường kẻ chốt để vẽ tổng tiền
            Font fontTongTien = new Font("Arial", 13, FontStyle.Bold);
            e.Graphics.DrawString($"Tổng tiền: {tongTien.ToString("N0")} VND", fontTongTien, coVe, xLe + 380, y);

            y += 45; // Tiếp tục dịch xuống hẳn 45 pixel từ dòng tổng tiền để vẽ lời cảm ơn, để k bị đè chữ nữa!
            e.Graphics.DrawString("----------------- CẢM ƠN QUÝ KHÁCH -----------------", fontSlogan, coVe, xLe + 160, y);

            // Báo cho hệ thống biết đã vẽ xong hoàn toàn (Không sinh trang mới)
            e.HasMorePages = false;
        }

        // =========================================================================
        // HÀM 2: IN BÁO CÁO TỔNG HỢP ĐỘNG (Nhận DataGridView phục vụ form baocaothongke)
        // =========================================================================
        public void InBaoCaoTongHop(DataGridView dgv, string tieuDe, PrintPreviewDialog previewDialog, PrintDocument printDoc)
        {
            this.dgvDuLieuBaoCao = dgv;
            this.tieuDeBaoCao = tieuDe;

            try
            {
                // Reset event để không bị vẽ đè chéo giao diện của Hóa đơn lên Báo cáo
                var eventField = typeof(PrintDocument).GetField("PrintPage", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (eventField != null) eventField.SetValue(printDoc, null);

                // Chỉ định hàm vẽ giao diện báo cáo
                printDoc.PrintPage += new PrintPageEventHandler(VeGiaoDienBaoCao);

                previewDialog.Document = printDoc;
                ((Form)previewDialog).WindowState = FormWindowState.Maximized;
                previewDialog.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi in báo cáo: " + ex.Message); }
        }

        private void VeGiaoDienBaoCao(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // --- KHAI BÁO HỆ THỐNG FONT CHUẨN ---
            Font fontHeaderCongTy = new Font("Arial", 9, FontStyle.Regular);
            Font fontTenCongTy = new Font("Arial", 10, FontStyle.Bold);
            Font fontTieuDe = new Font("Arial", 16, FontStyle.Bold);
            Font fontHeaderTable = new Font("Arial", 10, FontStyle.Bold);
            Font fontData = new Font("Arial", 10, FontStyle.Regular);
            Font fontKyTenBold = new Font("Arial", 10, FontStyle.Bold);
            Font fontKyTenItalic = new Font("Arial", 10, FontStyle.Italic);

            // --- CẤU HÌNH TỌA ĐỘ LỀ CƠ BẢN ---
            int xLe = 40;
            int y = 40;
            int rowHeight = 30;
            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;

            if (dgvDuLieuBaoCao == null || dgvDuLieuBaoCao.Columns.Count == 0) return;
            int colWidth = (pageWidth - 80) / dgvDuLieuBaoCao.Columns.Count;

            // =========================================================================
            // PHẦN 1: HEADER THÔNG TIN SIÊU THỊ (GÓC TRÁI TRÊN CÙNG)
            // =========================================================================
            g.DrawString("Báo Cáo Buôn Bán Hôm Nay", fontTenCongTy, Brushes.Black, xLe, y);
            y += 18;
            g.DrawString("Địa chỉ: Mỹ hào, Hưng yên, Trường Đại Học spkt Hưng Yên", fontHeaderCongTy, Brushes.Gray, xLe, y);
            y += 16;
            g.DrawString("Điện thoại: 0123.456.789", fontHeaderCongTy, Brushes.Gray, xLe, y);
            y += 30;

            // =========================================================================
            // PHẦN 2: TIÊU ĐỀ CHÍNH CỦA BÁO CÁO (CĂN GIỮA TRANG)
            // =========================================================================
            string textTop = "";
            if (!string.IsNullOrEmpty(this.tieuDeBaoCao))
            {
                textTop = "BÁO CÁO THỐNG KÊ TỔNG HỢP";
            }

            SizeF sizeTieuDe = g.MeasureString(textTop, fontTieuDe);
            g.DrawString(textTop, fontTieuDe, Brushes.MidnightBlue, (pageWidth - sizeTieuDe.Width) / 2, y);
            y += 35;

            // Dòng thông tin phụ dưới tiêu đề
            string thongTinPhu = "Thời gian lập: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            SizeF sizePhu = g.MeasureString(thongTinPhu, fontKyTenItalic);
            g.DrawString(thongTinPhu, fontKyTenItalic, Brushes.Black, (pageWidth - sizePhu.Width) / 2, y);
            y += 25;

            // Đường kẻ kép tạo điểm nhấn ngăn cách Header
            g.DrawLine(Pens.Black, xLe, y, pageWidth - 40, y);
            g.DrawLine(Pens.Black, xLe, y + 2, pageWidth - 40, y + 2);
            y += 20;

            // =========================================================================
            // PHẦN 3: VẼ THANH TIÊU ĐỀ CỘT DỮ LIỆU (HEADER TABLE)
            // =========================================================================
            int currentX = xLe;
            for (int i = 0; i < dgvDuLieuBaoCao.Columns.Count; i++)
            {
                // Đổ nền màu tím đậm quyền lực/hiện đại thay vì màu xám đơn điệu
                g.FillRectangle(new SolidBrush(Color.FromArgb(75, 0, 130)), currentX, y, colWidth, rowHeight);
                g.DrawRectangle(Pens.Black, currentX, y, colWidth, rowHeight);

                string headerText = dgvDuLieuBaoCao.Columns[i].HeaderText;
                SizeF sizeHeaderCell = g.MeasureString(headerText, fontHeaderTable);

                // Căn chữ vào chính giữa ô Header
                float cellX = currentX + (colWidth - sizeHeaderCell.Width) / 2;
                float cellY = y + (rowHeight - sizeHeaderCell.Height) / 2;
                g.DrawString(headerText, fontHeaderTable, Brushes.White, cellX, cellY);

                currentX += colWidth;
            }
            y += rowHeight;

            // =========================================================================
            // PHẦN 4: ĐỔ DỮ LIỆU TỪ GRIDVIEW VÀO BẢNG
            // =========================================================================
            bool alternaterow = false;
            foreach (DataGridViewRow row in dgvDuLieuBaoCao.Rows)
            {
                if (row.IsNewRow) continue;

                currentX = xLe;
                for (int j = 0; j < dgvDuLieuBaoCao.Columns.Count; j++)
                {
                    string cellText = row.Cells[j].FormattedValue?.ToString() ?? "";

                    // Tạo hiệu ứng dòng chẵn dòng lẻ (Alternating Rows) cho dễ nhìn
                    Brush rowBackBrush = alternaterow ? new SolidBrush(Color.FromArgb(245, 245, 250)) : Brushes.White;
                    g.FillRectangle(rowBackBrush, currentX, y, colWidth, rowHeight);
                    g.DrawRectangle(Pens.LightGray, currentX, y, colWidth, rowHeight);

                    SizeF sizeText = g.MeasureString(cellText, fontData);
                    float textY = y + (rowHeight - sizeText.Height) / 2;

                    // Kiểm tra căn lề: Số tiền căn phải, text thông thường căn trái
                    if (dgvDuLieuBaoCao.Columns[j].DefaultCellStyle.Alignment == DataGridViewContentAlignment.MiddleRight)
                    {
                        g.DrawString(cellText, fontData, Brushes.Black, currentX + colWidth - sizeText.Width - 8, textY);
                    }
                    else
                    {
                        g.DrawString(cellText, fontData, Brushes.Black, currentX + 8, textY);
                    }
                    currentX += colWidth;
                }
                alternaterow = !alternaterow;
                y += rowHeight;

                // Xử lý ngắt trang tự động nếu bảng quá dài
                if (y + rowHeight > pageHeight - 180)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Kẻ đường chốt bảng dữ liệu
            g.DrawLine(Pens.Black, xLe, y, pageWidth - 40, y);
            y += 30;

            // =========================================================================
            // PHẦN 5: KHU VỰC CHỮ KÝ XÁC THỰC (KÝ TÊN ĐÓNG DẤU)
            // =========================================================================
            // Tính toán tọa độ đặt khu vực chữ ký nằm bên phải trang giấy
            int xKyTen = pageWidth - 280;

            g.DrawString("Hưng Yên, ngày " + DateTime.Now.ToString("dd") + " tháng " + DateTime.Now.ToString("MM") + " năm " + DateTime.Now.ToString("yyyy"), fontKyTenItalic, Brushes.Black, xKyTen - 20, y);
            y += 20;

            g.DrawString("Người lập báo cáo", fontKyTenBold, Brushes.Black, xKyTen + 25, y);
            y += 18;
            g.DrawString("(Ký, ghi rõ họ tên)", fontKyTenItalic, Brushes.Gray, xKyTen + 28, y);

            // Đẩy dòng chữ ký tên thật xuống dưới một khoảng trống để chừa không gian ký tên
            y += 75;
            string tenNhanVienKy = string.IsNullOrEmpty(this.tenNhanVienIn) ? "": this.tenNhanVienIn;
            SizeF sizeTenNV = g.MeasureString(tenNhanVienKy, fontKyTenBold);

            // Căn giữa tên nhân viên so với trục chữ ký
            g.DrawString(tenNhanVienKy, fontKyTenBold, Brushes.MidnightBlue, xKyTen + 80 - (sizeTenNV.Width / 2), y);

            e.HasMorePages = false; // Đã hoàn thành toàn bộ văn bản
        }
    }
}