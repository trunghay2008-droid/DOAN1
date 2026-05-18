namespace btlquanlysieuthi
{
    partial class frmqlkho
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
            txtGiaNhap = new TextBox();
            txtTenSP = new TextBox();
            txtTenNCC = new TextBox();
            txtMaSP = new TextBox();
            txtSoLuong = new TextBox();
            cbLoaiSP = new ComboBox();
            btnNhapHang = new Button();
            dgvKho = new DataGridView();
            lblLoiNhuan = new Label();
            btnXemphieunhap = new Button();
            btnXemHoaDon = new Button();
            btnXoa = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnXoaHoaDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(92, 195);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(135, 27);
            txtGiaNhap.TabIndex = 3;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(92, 145);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(135, 27);
            txtTenSP.TabIndex = 4;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(92, 53);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(135, 27);
            txtTenNCC.TabIndex = 5;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(92, 97);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(135, 27);
            txtMaSP.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(92, 240);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(133, 27);
            txtSoLuong.TabIndex = 7;
            // 
            // cbLoaiSP
            // 
            cbLoaiSP.FormattingEnabled = true;
            cbLoaiSP.Location = new Point(92, 298);
            cbLoaiSP.Name = "cbLoaiSP";
            cbLoaiSP.Size = new Size(151, 28);
            cbLoaiSP.TabIndex = 8;
            // 
            // btnNhapHang
            // 
            btnNhapHang.BackColor = Color.FromArgb(33, 11, 97);
            btnNhapHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNhapHang.ForeColor = Color.White;
            btnNhapHang.Location = new Point(45, 357);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(182, 38);
            btnNhapHang.TabIndex = 9;
            btnNhapHang.Text = "Nhập Hàng";
            btnNhapHang.UseVisualStyleBackColor = false;
            btnNhapHang.Click += btnNhapHang_Click;
            // 
            // dgvKho
            // 
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKho.Location = new Point(285, 38);
            dgvKho.Name = "dgvKho";
            dgvKho.RowHeadersWidth = 51;
            dgvKho.Size = new Size(517, 309);
            dgvKho.TabIndex = 10;
            dgvKho.CellContentClick += dgvKho_CellContentClick;
            // 
            // lblLoiNhuan
            // 
            lblLoiNhuan.AutoSize = true;
            lblLoiNhuan.Location = new Point(310, 378);
            lblLoiNhuan.Name = "lblLoiNhuan";
            lblLoiNhuan.Size = new Size(117, 20);
            lblLoiNhuan.TabIndex = 11;
            lblLoiNhuan.Text = "Tổng Lợi Nhuận:";
            // 
            // btnXemphieunhap
            // 
            btnXemphieunhap.BackColor = Color.FromArgb(33, 11, 97);
            btnXemphieunhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXemphieunhap.ForeColor = Color.White;
            btnXemphieunhap.Location = new Point(46, 416);
            btnXemphieunhap.Name = "btnXemphieunhap";
            btnXemphieunhap.Size = new Size(181, 38);
            btnXemphieunhap.TabIndex = 12;
            btnXemphieunhap.Text = "Xem Phiếu Nhập";
            btnXemphieunhap.UseVisualStyleBackColor = false;
            btnXemphieunhap.Click += btnXemphieunhap_Click;
            // 
            // btnXemHoaDon
            // 
            btnXemHoaDon.BackColor = Color.FromArgb(33, 11, 97);
            btnXemHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXemHoaDon.ForeColor = Color.White;
            btnXemHoaDon.Location = new Point(354, 437);
            btnXemHoaDon.Name = "btnXemHoaDon";
            btnXemHoaDon.Size = new Size(150, 38);
            btnXemHoaDon.TabIndex = 13;
            btnXemHoaDon.Text = "Xem Biên Lai";
            btnXemHoaDon.UseVisualStyleBackColor = false;
            btnXemHoaDon.Click += btnXemHoaDon_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(33, 11, 97);
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(45, 470);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(182, 38);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnXemphieunhap);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtGiaNhap);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(txtTenNCC);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(cbLoaiSP);
            groupBox1.Controls.Add(btnNhapHang);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 526);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phiếu Nhập Hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 56);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 15;
            label6.Text = "Tên NCC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 306);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 14;
            label5.Text = "Phân Loại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 243);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 13;
            label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 198);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 12;
            label3.Text = "Giá Nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 148);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 11;
            label2.Text = "Tên SP:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 104);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 10;
            label1.Text = "Mã SP:";
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.BackColor = Color.FromArgb(33, 11, 97);
            btnXoaHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaHoaDon.ForeColor = Color.White;
            btnXoaHoaDon.Location = new Point(587, 437);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(150, 38);
            btnXoaHoaDon.TabIndex = 16;
            btnXoaHoaDon.Text = "Xóa Biên Lai";
            btnXoaHoaDon.UseVisualStyleBackColor = false;
            btnXoaHoaDon.Click += btnXoaHoaDon_Click_1;
            // 
            // frmqlkho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(814, 559);
            Controls.Add(btnXoaHoaDon);
            Controls.Add(groupBox1);
            Controls.Add(btnXemHoaDon);
            Controls.Add(lblLoiNhuan);
            Controls.Add(dgvKho);
            Name = "frmqlkho";
            Text = "frmqlkho";
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtGiaNhap;
        private TextBox txtTenSP;
        private TextBox txtTenNCC;
        private TextBox txtMaSP;
        private TextBox txtSoLuong;
        private ComboBox cbLoaiSP;
        private Button btnNhapHang;
        private DataGridView dgvKho;
        private Label lblLoiNhuan;
        private Button btnXemphieunhap;
        private Button btnXemHoaDon;
        private Button btnXoa;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnXoaHoaDon;
    }
}