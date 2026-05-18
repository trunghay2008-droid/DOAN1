using System;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class HuongDanSuDung : Form
    {
        private bool isWebViewInitialized = false;

        public HuongDanSuDung()
        {
            InitializeComponent();
        }

        private void HuongDanSuDung_Load(object sender, EventArgs e)
        {
            // Trạng thái ban đầu: Hiện chữ, ẩn video, chưa cần sáng nút quay lại
            webViewVideo.Visible = false;
            panelHuongDanChu.Visible = true;
            btnQuayLaiChu.Enabled = false; // Ẩn hoặc khóa tính năng quay lại khi đang ở màn hình chữ
        }

        private async void btnXemVideo_Click(object sender, EventArgs e)
        {
            // Tráo đổi giao diện: Ẩn chữ đi và hiện video lên
            panelHuongDanChu.Visible = false;
            webViewVideo.Visible = true;
            btnQuayLaiChu.Enabled = true; // Kích hoạt nút quay lại chữ hoạt động

            if (!isWebViewInitialized)
            {
                try
                {
                    await webViewVideo.EnsureCoreWebView2Async(null);
                    string driveEmbedUrl = "https://drive.google.com/file/d/1ALdfOfxdBf0_NcoqIJERe_urc4jZoU8h/preview";
                    webViewVideo.Source = new Uri(driveEmbedUrl);
                    isWebViewInitialized = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải video: " + ex.Message, "Lỗi kết nối");
                }
            }
            else
            {
                // Nếu video đã khởi tạo trước đó, khi bật lại ta chạy lệnh làm mới hoặc reload để video tiếp tục phát
                webViewVideo.CoreWebView2.Navigate("https://drive.google.com/file/d/1ALdfOfxdBf0_NcoqIJERe_urc4jZoU8h/preview");
            }
        }

        // CHỨC NĂNG QUAY LẠI CHỮ
        private void btnQuayLaiChu_Click(object sender, EventArgs e)
        {
            // Tráo giao diện ngược lại: Hiện panel chữ, ẩn WebView Video đi
            webViewVideo.Visible = false;
            panelHuongDanChu.Visible = true;
            btnQuayLaiChu.Enabled = false; // Đang ở màn chữ rồi thì khóa nút này lại

            // Mẹo nhỏ: Điều hướng WebView về trang trống "about:blank" để tắt tiếng video/dừng phát ngầm
            if (isWebViewInitialized && webViewVideo.CoreWebView2 != null)
            {
                webViewVideo.CoreWebView2.Navigate("about:blank");
            }
        }

        // CHỨC NĂNG THOÁT QUAY VỀ FORM MENU
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng form Hướng dẫn sử dụng hiện tại lại
            this.Close();

            // Lưu ý: Nếu ở frmMenu bạn gọi form này bằng lệnh `huongDan.ShowDialog()`, 
            // thì khi dùng lệnh `this.Close()` tại đây, form này tự đóng và frmMenu sẽ tự động hiện lại ra mà không cần viết thêm gì cả!
        }

        private void HuongDanSuDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng bộ nhớ WebView2 khi đóng hẳn form
            if (webViewVideo != null && webViewVideo.CoreWebView2 != null)
            {
                webViewVideo.Dispose();
            }
        }
    }
}