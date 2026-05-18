namespace btlquanlysieuthi
{
    partial class FormA
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
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtGia = new TextBox();
            txtSoLuong = new TextBox();
            picSP = new PictureBox();
            dgvHienThiSP = new DataGridView();
            cbLoaiSP = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnImport = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnTim = new Button();
            btnXem = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHienThiSP).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(132, 26);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(125, 27);
            txtMaSP.TabIndex = 0;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(132, 67);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(125, 27);
            txtTenSP.TabIndex = 1;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(132, 119);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(125, 27);
            txtGia.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(132, 152);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 3;
            // 
            // picSP
            // 
            picSP.Location = new Point(48, 56);
            picSP.Name = "picSP";
            picSP.Size = new Size(242, 147);
            picSP.SizeMode = PictureBoxSizeMode.Zoom;
            picSP.TabIndex = 5;
            picSP.TabStop = false;
            // 
            // dgvHienThiSP
            // 
            dgvHienThiSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThiSP.Location = new Point(12, 12);
            dgvHienThiSP.Name = "dgvHienThiSP";
            dgvHienThiSP.RowHeadersWidth = 51;
            dgvHienThiSP.Size = new Size(749, 188);
            dgvHienThiSP.TabIndex = 6;
            // 
            // cbLoaiSP
            // 
            cbLoaiSP.FormattingEnabled = true;
            cbLoaiSP.Location = new Point(132, 201);
            cbLoaiSP.Name = "cbLoaiSP";
            cbLoaiSP.Size = new Size(151, 28);
            cbLoaiSP.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(33, 11, 97);
            btnThem.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(6, 235);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 40);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm Sản Phẩm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(33, 11, 97);
            btnSua.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(137, 235);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 40);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa Sản Phẩm";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(33, 11, 97);
            btnXoa.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(267, 235);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 40);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa sản phẩm";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = Color.FromArgb(33, 11, 97);
            btnImport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.ForeColor = Color.White;
            btnImport.Location = new Point(80, 209);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(167, 41);
            btnImport.TabIndex = 11;
            btnImport.Text = "Thêm ảnh minh họa";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 70);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 12;
            label1.Text = "Tên hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 119);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 13;
            label2.Text = "Giá hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 201);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 14;
            label3.Text = "Phân Loại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 159);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 15;
            label4.Text = "Số Lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 33);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 16;
            label5.Text = "MãHH:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(btnXem);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbLoaiSP);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Location = new Point(12, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 349);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý sản phẩm";
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(33, 11, 97);
            btnTim.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(209, 291);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(120, 40);
            btnTim.TabIndex = 18;
            btnTim.Text = "Tìm Sản Phẩm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // btnXem
            // 
            btnXem.BackColor = Color.FromArgb(33, 11, 97);
            btnXem.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXem.ForeColor = Color.White;
            btnXem.Location = new Point(55, 291);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(120, 40);
            btnXem.TabIndex = 17;
            btnXem.Text = "xem sản phẩm";
            btnXem.UseVisualStyleBackColor = false;
            btnXem.Click += btnXem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(picSP);
            groupBox2.Controls.Add(btnImport);
            groupBox2.Location = new Point(427, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 273);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // FormA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(777, 563);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvHienThiSP);
            Name = "FormA";
            Text = "FormA";
            ((System.ComponentModel.ISupportInitialize)picSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHienThiSP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtGia;
        private TextBox txtSoLuong;
        private PictureBox picSP;
        private DataGridView dgvHienThiSP;
        private ComboBox cbLoaiSP;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnImport;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnXem;
        private Button btnTim;
    }
}