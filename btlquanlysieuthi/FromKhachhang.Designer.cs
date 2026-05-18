namespace btlquanlysieuthi
{
    partial class FromKhachhang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            spltContainer = new SplitContainer();
            pnlMenu = new Panel();
            btnThoat = new Button();
            btnVanChuyen = new Button();
            btnLichSu = new Button();
            btnDatHang = new Button();
            btnThemThongTin = new Button();
            lblMenuTitle = new Label();
            pnlContent = new Panel();
            ((System.ComponentModel.ISupportInitialize)spltContainer).BeginInit();
            spltContainer.Panel1.SuspendLayout();
            spltContainer.Panel2.SuspendLayout();
            spltContainer.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // spltContainer
            // 
            spltContainer.Dock = DockStyle.Fill;
            spltContainer.FixedPanel = FixedPanel.Panel1;
            spltContainer.IsSplitterFixed = true;
            spltContainer.Location = new Point(0, 0);
            spltContainer.Name = "spltContainer";
            // 
            // spltContainer.Panel1
            // 
            spltContainer.Panel1.Controls.Add(pnlMenu);
            // 
            // spltContainer.Panel2
            // 
            spltContainer.Panel2.Controls.Add(pnlContent);
            spltContainer.Size = new Size(1100, 615);
            spltContainer.SplitterDistance = 250;
            spltContainer.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(33, 37, 41);
            pnlMenu.Controls.Add(btnThoat);
            pnlMenu.Controls.Add(btnVanChuyen);
            pnlMenu.Controls.Add(btnLichSu);
            pnlMenu.Controls.Add(btnDatHang);
            pnlMenu.Controls.Add(btnThemThongTin);
            pnlMenu.Controls.Add(lblMenuTitle);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(250, 615);
            pnlMenu.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Dock = DockStyle.Bottom;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.ForeColor = Color.IndianRed;
            btnThoat.Location = new Point(0, 555);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(250, 60);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "🚪 Đăng xuất";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnVanChuyen
            // 
            btnVanChuyen.Dock = DockStyle.Top;
            btnVanChuyen.FlatAppearance.BorderSize = 0;
            btnVanChuyen.FlatStyle = FlatStyle.Flat;
            btnVanChuyen.Font = new Font("Segoe UI Semibold", 11F);
            btnVanChuyen.ForeColor = Color.White;
            btnVanChuyen.Location = new Point(0, 280);
            btnVanChuyen.Name = "btnVanChuyen";
            btnVanChuyen.Padding = new Padding(20, 0, 0, 0);
            btnVanChuyen.Size = new Size(250, 60);
            btnVanChuyen.TabIndex = 4;
            btnVanChuyen.Text = "🚚 Theo dõi vận chuyển";
            btnVanChuyen.TextAlign = ContentAlignment.MiddleLeft;
            btnVanChuyen.UseVisualStyleBackColor = true;
            btnVanChuyen.Click += btnVanChuyen_Click;
            // 
            // btnLichSu
            // 
            btnLichSu.Dock = DockStyle.Top;
            btnLichSu.FlatAppearance.BorderSize = 0;
            btnLichSu.FlatStyle = FlatStyle.Flat;
            btnLichSu.Font = new Font("Segoe UI Semibold", 11F);
            btnLichSu.ForeColor = Color.White;
            btnLichSu.Location = new Point(0, 220);
            btnLichSu.Name = "btnLichSu";
            btnLichSu.Padding = new Padding(20, 0, 0, 0);
            btnLichSu.Size = new Size(250, 60);
            btnLichSu.TabIndex = 3;
            btnLichSu.Text = "📜 Lịch sử mua hàng";
            btnLichSu.TextAlign = ContentAlignment.MiddleLeft;
            btnLichSu.UseVisualStyleBackColor = true;
            btnLichSu.Click += btnLichSu_Click;
            // 
            // btnDatHang
            // 
            btnDatHang.Dock = DockStyle.Top;
            btnDatHang.FlatAppearance.BorderSize = 0;
            btnDatHang.FlatStyle = FlatStyle.Flat;
            btnDatHang.Font = new Font("Segoe UI Semibold", 11F);
            btnDatHang.ForeColor = Color.White;
            btnDatHang.Location = new Point(0, 160);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Padding = new Padding(20, 0, 0, 0);
            btnDatHang.Size = new Size(250, 60);
            btnDatHang.TabIndex = 2;
            btnDatHang.Text = "\U0001f6d2 Đặt hàng mới";
            btnDatHang.TextAlign = ContentAlignment.MiddleLeft;
            btnDatHang.UseVisualStyleBackColor = true;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // btnThemThongTin
            // 
            btnThemThongTin.Dock = DockStyle.Top;
            btnThemThongTin.FlatAppearance.BorderSize = 0;
            btnThemThongTin.FlatStyle = FlatStyle.Flat;
            btnThemThongTin.Font = new Font("Segoe UI Semibold", 11F);
            btnThemThongTin.ForeColor = Color.White;
            btnThemThongTin.Location = new Point(0, 100);
            btnThemThongTin.Name = "btnThemThongTin";
            btnThemThongTin.Padding = new Padding(20, 0, 0, 0);
            btnThemThongTin.Size = new Size(250, 60);
            btnThemThongTin.TabIndex = 1;
            btnThemThongTin.Text = "👤 Thông tin cá nhân";
            btnThemThongTin.TextAlign = ContentAlignment.MiddleLeft;
            btnThemThongTin.UseVisualStyleBackColor = true;
            btnThemThongTin.Click += btnThemThongTin_Click;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.Dock = DockStyle.Top;
            lblMenuTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMenuTitle.ForeColor = Color.FromArgb(40, 167, 69);
            lblMenuTitle.Location = new Point(0, 0);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(250, 100);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "Tiệm Tạp Hóa xóm";
            lblMenuTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(846, 615);
            pnlContent.TabIndex = 0;
            // 
            // FromKhachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 615);
            Controls.Add(spltContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FromKhachhang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khu Vực Khách Hàng - Siêu Thị Hệ Thống";
            spltContainer.Panel1.ResumeLayout(false);
            spltContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spltContainer).EndInit();
            spltContainer.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer spltContainer;
        private Panel pnlMenu;
        private Label lblMenuTitle;
        private Button btnThemThongTin;
        private Button btnDatHang;
        private Button btnLichSu;
        private Button btnVanChuyen;
        private Button btnThoat;
        private Panel pnlContent;
    }
}