namespace btlquanlysieuthi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnThoat = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnTinhCongLuong = new Button();
            dgvHienThi = new DataGridView();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtPhuCap = new TextBox();
            txtGioiTinh = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cbQuyen = new ComboBox();
            txtNgayVaoLam = new MaskedTextBox();
            txtNgaySinh = new MaskedTextBox();
            txtLuong = new TextBox();
            txtDienThoai = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCheckIn = new Button();
            btnXemTongCong = new Button();
            btnCheckOut = new Button();
            btnxem = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnNhanSu = new Button();
            btnLogOut = new Button();
            splitContainer1 = new SplitContainer();
            lblHuongDan = new LinkLabel();
            btnKhachhang = new Button();
            btnBaocaothongke = new Button();
            btnKho = new Button();
            btnfrmdoimk = new Button();
            FormC = new Button();
            FormA = new Button();
            pictureBox2 = new PictureBox();
            lblXinchao = new Label();
            groupBox3 = new GroupBox();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 37);
            panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(1001, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(26, 28);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "X";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(11, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 37);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 9);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 11;
            label3.Text = "Siêu Thị Mini";
            // 
            // btnTinhCongLuong
            // 
            btnTinhCongLuong.BackColor = Color.FromArgb(33, 11, 97);
            btnTinhCongLuong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinhCongLuong.ForeColor = Color.White;
            btnTinhCongLuong.Location = new Point(672, 549);
            btnTinhCongLuong.Name = "btnTinhCongLuong";
            btnTinhCongLuong.Size = new Size(123, 35);
            btnTinhCongLuong.TabIndex = 3;
            btnTinhCongLuong.Text = "💸 Tính Lương";
            btnTinhCongLuong.UseVisualStyleBackColor = false;
            btnTinhCongLuong.Click += btnTinhCongLuong_Click;
            // 
            // dgvHienThi
            // 
            dgvHienThi.ColumnHeadersHeight = 29;
            dgvHienThi.Location = new Point(40, 373);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowHeadersWidth = 51;
            dgvHienThi.Size = new Size(745, 159);
            dgvHienThi.TabIndex = 0;
            dgvHienThi.CellContentClick += dgvHienThi_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPhuCap);
            groupBox1.Controls.Add(txtGioiTinh);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbQuyen);
            groupBox1.Controls.Add(txtNgayVaoLam);
            groupBox1.Controls.Add(txtNgaySinh);
            groupBox1.Controls.Add(txtLuong);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(296, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 343);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý nhân sự:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 306);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 26;
            label2.Text = "Phụ cấp:";
            // 
            // txtPhuCap
            // 
            txtPhuCap.Location = new Point(125, 303);
            txtPhuCap.Name = "txtPhuCap";
            txtPhuCap.Size = new Size(193, 27);
            txtPhuCap.TabIndex = 25;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(128, 96);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(171, 27);
            txtGioiTinh.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 277);
            label10.Name = "label10";
            label10.Size = new Size(105, 20);
            label10.TabIndex = 23;
            label10.Text = "Lương Cơ Bản:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 240);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 22;
            label9.Text = "Ngày Vào Làm:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 206);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 21;
            label8.Text = "Chức vụ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 173);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 20;
            label7.Text = "Điện Thoại:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 132);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 19;
            label6.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 99);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 18;
            label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 66);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 17;
            label4.Text = "Tên Nhân Viên:";
            // 
            // cbQuyen
            // 
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Location = new Point(128, 203);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(171, 28);
            cbQuyen.TabIndex = 16;
            // 
            // txtNgayVaoLam
            // 
            txtNgayVaoLam.Location = new Point(128, 237);
            txtNgayVaoLam.Mask = "00/00/0000";
            txtNgayVaoLam.Name = "txtNgayVaoLam";
            txtNgayVaoLam.Size = new Size(171, 27);
            txtNgayVaoLam.TabIndex = 15;
            txtNgayVaoLam.ValidatingType = typeof(DateTime);
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(128, 129);
            txtNgaySinh.Mask = "00/00/0000";
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(171, 27);
            txtNgaySinh.TabIndex = 14;
            txtNgaySinh.ValidatingType = typeof(DateTime);
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(125, 270);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(196, 27);
            txtLuong.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(128, 170);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(171, 27);
            txtDienThoai.TabIndex = 8;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(128, 59);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(196, 27);
            txtTenNV.TabIndex = 5;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(128, 26);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(230, 27);
            txtMaNV.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 33);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã Nhân Viên:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnCheckIn);
            groupBox2.Controls.Add(btnXemTongCong);
            groupBox2.Controls.Add(btnCheckOut);
            groupBox2.Location = new Point(50, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(236, 214);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kiểm tra nhân sự:";
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(6, 45);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(221, 36);
            btnCheckIn.TabIndex = 1;
            btnCheckIn.Text = "Chấm Công giờ vào";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnXemTongCong
            // 
            btnXemTongCong.Location = new Point(6, 162);
            btnXemTongCong.Name = "btnXemTongCong";
            btnXemTongCong.Size = new Size(221, 36);
            btnXemTongCong.TabIndex = 5;
            btnXemTongCong.Text = "Xem Tổng Công";
            btnXemTongCong.UseVisualStyleBackColor = true;
            btnXemTongCong.Click += btnXemTongCong_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(6, 103);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(221, 36);
            btnCheckOut.TabIndex = 2;
            btnCheckOut.Text = "Chấm Công giờ về";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnxem
            // 
            btnxem.BackColor = Color.FromArgb(33, 11, 97);
            btnxem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxem.ForeColor = Color.White;
            btnxem.Location = new Point(50, 550);
            btnxem.Name = "btnxem";
            btnxem.Size = new Size(123, 35);
            btnxem.TabIndex = 7;
            btnxem.Text = "👁️‍🗨️ Xem";
            btnxem.UseVisualStyleBackColor = false;
            btnxem.Click += btnxem_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(33, 11, 97);
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(198, 550);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 35);
            btnThem.TabIndex = 8;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(33, 11, 97);
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(347, 550);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 35);
            btnSua.TabIndex = 9;
            btnSua.Text = "✅  Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(33, 11, 97);
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(497, 550);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 35);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnNhanSu
            // 
            btnNhanSu.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            btnNhanSu.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            btnNhanSu.FlatStyle = FlatStyle.Flat;
            btnNhanSu.Font = new Font("Segoe Fluent Icons", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhanSu.ForeColor = Color.White;
            btnNhanSu.Location = new Point(5, 176);
            btnNhanSu.Name = "btnNhanSu";
            btnNhanSu.Size = new Size(193, 41);
            btnNhanSu.TabIndex = 3;
            btnNhanSu.Text = "👤 Nhân Sự";
            btnNhanSu.UseVisualStyleBackColor = true;
            btnNhanSu.Click += btnmenu_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(11, 547);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(186, 38);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 31);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(33, 11, 97);
            splitContainer1.Panel1.Controls.Add(lblHuongDan);
            splitContainer1.Panel1.Controls.Add(btnKhachhang);
            splitContainer1.Panel1.Controls.Add(btnBaocaothongke);
            splitContainer1.Panel1.Controls.Add(btnKho);
            splitContainer1.Panel1.Controls.Add(btnfrmdoimk);
            splitContainer1.Panel1.Controls.Add(FormC);
            splitContainer1.Panel1.Controls.Add(FormA);
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.Controls.Add(lblXinchao);
            splitContainer1.Panel1.Controls.Add(btnLogOut);
            splitContainer1.Panel1.Controls.Add(btnNhanSu);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Panel2.Controls.Add(btnXoa);
            splitContainer1.Panel2.Controls.Add(btnSua);
            splitContainer1.Panel2.Controls.Add(btnThem);
            splitContainer1.Panel2.Controls.Add(btnxem);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(dgvHienThi);
            splitContainer1.Panel2.Controls.Add(btnTinhCongLuong);
            splitContainer1.Size = new Size(1030, 601);
            splitContainer1.SplitterDistance = 200;
            splitContainer1.TabIndex = 0;
            // 
            // lblHuongDan
            // 
            lblHuongDan.AutoSize = true;
            lblHuongDan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHuongDan.ForeColor = Color.White;
            lblHuongDan.LinkBehavior = LinkBehavior.NeverUnderline;
            lblHuongDan.LinkColor = Color.White;
            lblHuongDan.Location = new Point(22, 524);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(160, 20);
            lblHuongDan.TabIndex = 21;
            lblHuongDan.TabStop = true;
            lblHuongDan.Text = "Hướng Dẫn Sử Dụng?";
            lblHuongDan.LinkClicked += lblHuongDan_LinkClicked;
            // 
            // btnKhachhang
            // 
            btnKhachhang.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            btnKhachhang.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            btnKhachhang.FlatStyle = FlatStyle.Flat;
            btnKhachhang.Font = new Font("Segoe Fluent Icons", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhachhang.ForeColor = Color.White;
            btnKhachhang.Location = new Point(5, 266);
            btnKhachhang.Name = "btnKhachhang";
            btnKhachhang.Size = new Size(193, 41);
            btnKhachhang.TabIndex = 20;
            btnKhachhang.Text = "❤️ Khách hàng";
            btnKhachhang.UseVisualStyleBackColor = true;
            btnKhachhang.Click += btnKhachhang_Click;
            // 
            // btnBaocaothongke
            // 
            btnBaocaothongke.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            btnBaocaothongke.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            btnBaocaothongke.FlatStyle = FlatStyle.Flat;
            btnBaocaothongke.Font = new Font("Segoe Fluent Icons", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaocaothongke.ForeColor = Color.White;
            btnBaocaothongke.Location = new Point(5, 400);
            btnBaocaothongke.Name = "btnBaocaothongke";
            btnBaocaothongke.Size = new Size(193, 41);
            btnBaocaothongke.TabIndex = 19;
            btnBaocaothongke.Text = "📰  Báo cáo Thống kê";
            btnBaocaothongke.UseVisualStyleBackColor = true;
            btnBaocaothongke.Click += btnBaocaothongke_Click;
            // 
            // btnKho
            // 
            btnKho.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            btnKho.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            btnKho.FlatStyle = FlatStyle.Flat;
            btnKho.Font = new Font("Segoe Fluent Icons", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKho.ForeColor = Color.White;
            btnKho.Location = new Point(5, 353);
            btnKho.Name = "btnKho";
            btnKho.Size = new Size(193, 41);
            btnKho.TabIndex = 18;
            btnKho.Text = "🗃️  Kho";
            btnKho.UseVisualStyleBackColor = true;
            btnKho.Click += btnKho_Click;
            // 
            // btnfrmdoimk
            // 
            btnfrmdoimk.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            btnfrmdoimk.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            btnfrmdoimk.FlatStyle = FlatStyle.Flat;
            btnfrmdoimk.Font = new Font("Segoe Fluent Icons", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnfrmdoimk.ForeColor = Color.White;
            btnfrmdoimk.Location = new Point(6, 447);
            btnfrmdoimk.Name = "btnfrmdoimk";
            btnfrmdoimk.Size = new Size(192, 41);
            btnfrmdoimk.TabIndex = 17;
            btnfrmdoimk.Text = "🔒 Quản Lý tài Khoản";
            btnfrmdoimk.UseVisualStyleBackColor = true;
            btnfrmdoimk.Click += btnfrmdoimk_Click;
            // 
            // FormC
            // 
            FormC.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            FormC.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            FormC.FlatStyle = FlatStyle.Flat;
            FormC.Font = new Font("Segoe Fluent Icons", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormC.ForeColor = Color.White;
            FormC.Location = new Point(5, 308);
            FormC.Name = "FormC";
            FormC.Size = new Size(193, 41);
            FormC.TabIndex = 16;
            FormC.Text = "\U0001f6d2 Đơn Hàng";
            FormC.UseVisualStyleBackColor = true;
            FormC.Click += FormC_Click;
            // 
            // FormA
            // 
            FormA.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 8, 97);
            FormA.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 8, 97);
            FormA.FlatStyle = FlatStyle.Flat;
            FormA.Font = new Font("Segoe Fluent Icons", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormA.ForeColor = Color.White;
            FormA.Location = new Point(5, 221);
            FormA.Name = "FormA";
            FormA.Size = new Size(193, 41);
            FormA.TabIndex = 15;
            FormA.Text = "\U0001f9fe Sản Phẩm";
            FormA.UseVisualStyleBackColor = true;
            FormA.Click += FormA_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(33, 11, 97);
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(11, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 102);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // lblXinchao
            // 
            lblXinchao.AutoSize = true;
            lblXinchao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXinchao.ForeColor = Color.White;
            lblXinchao.Location = new Point(11, 113);
            lblXinchao.Name = "lblXinchao";
            lblXinchao.Size = new Size(109, 20);
            lblXinchao.TabIndex = 12;
            lblXinchao.Text = "Xin Chào, user";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Location = new Point(40, 266);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 88);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm nhân viên theo từ khóa";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(67, 37);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(170, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(33, 11, 97);
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(6, 37);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(61, 29);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm:";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 628);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox3;
        private RadioButton radioButton2;
        private Panel panel1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnTinhCongLuong;
        private DataGridView dgvHienThi;
        private GroupBox groupBox1;
        private TextBox txtGioiTinh;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cbQuyen;
        private MaskedTextBox txtNgayVaoLam;
        private MaskedTextBox txtNgaySinh;
        private TextBox txtLuong;
        private TextBox txtDienThoai;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnCheckIn;
        private Button btnXemTongCong;
        private Button btnCheckOut;
        private Button btnxem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button FormC;
        private Button btnNhanSu;
        private Button button4;
        private Button btnLogOut;
        private SplitContainer splitContainer1;
        private Label label3;
        private Label lblXinchao;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnThoat;
        private Button button5;
        private Button FormA;
        private Button btnfrmdoimk;
        private GroupBox groupBox3;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnKho;
        private Button btnBaocaothongke;
        private Button btnKhachhang;
        private Label label2;
        private TextBox txtPhuCap;
        private LinkLabel lblHuongDan;
    }
}