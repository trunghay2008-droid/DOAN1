using System;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    public partial class FromKhachhang : Form
    {
        private string _quyen;
        private int _maKH_Login;
        private string connStr;
        private Form activeForm = null;

        public FromKhachhang(string quyen, int maKH, string connStr)
        {
            InitializeComponent();
            this._quyen = quyen;
            this._maKH_Login = maKH;
            this.connStr = connStr;
        }

        // Hàm "thần thánh" để nhúng Form con vào Panel bên phải
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        #region Các sự kiện Click Menu

        // 1. Chức năng Thêm/Sửa thông tin khách hàng
        private void btnThemThongTin_Click(object sender, EventArgs e)
        {
            // Truyền mã KH vào để Form này biết đang sửa cho ai
            // OpenChildForm(new frmThongTinChiTiet(_maKH_Login, connStr));
            MessageBox.Show("Đang mở Form cập nhật thông tin cá nhân...");
            OpenChildForm(new ttkhachhang());
        }

        // 2. Chức năng Đặt hàng (Mua sắm)
        private void btnDatHang_Click(object sender, EventArgs e)
        {
            // Mở giao diện chọn món, thêm vào giỏ hàng
            // OpenChildForm(new frmMuaSam(_maKH_Login, connStr));
            OpenChildForm(new FormC(this._maKH_Login));
        }

        // 3. Chức năng Lịch sử giao dịch
        private void btnLichSu_Click(object sender, EventArgs e)
        {
            // Form này sẽ SELECT bảng HoaDon dựa trên _maKH_Login
            OpenChildForm(new lichsugdkh(this._maKH_Login, this.connStr));
        }

        // 4. Chức năng Xem vận chuyển
        private void btnVanChuyen_Click(object sender, EventArgs e)
        {
            // Hiển thị tình trạng đơn hàng (Đang giao, Đã nhận...)
            // OpenChildForm(new frmVanChuyen(_maKH_Login, connStr));
            OpenChildForm(new FormTheoDoiDonHang(this._maKH_Login));
        }

        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}