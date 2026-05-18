namespace btlquanlysieuthi
{
    partial class frmdangky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangky));
            txtUsername = new TextBox();
            txtTenNV = new TextBox();
            txtPassword = new TextBox();
            txtRePassword = new TextBox();
            cbQuyen = new ComboBox();
            chkHienMatKhau = new CheckBox();
            btnDangKy = new Button();
            panel1 = new Panel();
            btnlogin = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(451, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(161, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(451, 199);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(161, 27);
            txtTenNV.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(451, 241);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(161, 27);
            txtPassword.TabIndex = 2;
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(451, 274);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(161, 27);
            txtRePassword.TabIndex = 3;
            // 
            // cbQuyen
            // 
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Location = new Point(451, 312);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(137, 28);
            cbQuyen.TabIndex = 4;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(594, 318);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(18, 17);
            chkHienMatKhau.TabIndex = 5;
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(75, 8, 138);
            btnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(429, 359);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(173, 43);
            btnDangKy.TabIndex = 6;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 491);
            panel1.TabIndex = 18;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(75, 8, 138);
            btnlogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(12, 438);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(261, 41);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Đăng Nhập";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += this.btnlogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(73, 403);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 4;
            label6.Text = "Login your account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(90, 221);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 0;
            label5.Text = "SIêu Thị Mini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 157);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 19;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 202);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 20;
            label2.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 244);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 21;
            label3.Text = "Mật Khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 274);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 22;
            label4.Text = "Nhập Lại Mật Khẩu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 315);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 23;
            label7.Text = "Chức vụ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(347, 97);
            label8.Name = "label8";
            label8.Size = new Size(278, 25);
            label8.TabIndex = 24;
            label8.Text = "CỔNG THÔNG TIN NHÂN VIÊN";
            // 
            // frmdangky
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(688, 491);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnDangKy);
            Controls.Add(chkHienMatKhau);
            Controls.Add(cbQuyen);
            Controls.Add(txtRePassword);
            Controls.Add(txtPassword);
            Controls.Add(txtTenNV);
            Controls.Add(txtUsername);
            Name = "frmdangky";
            Text = "Đăng ký";
            Load += frmdangky_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtTenNV;
        private TextBox txtPassword;
        private TextBox txtRePassword;
        private ComboBox cbQuyen;
        private CheckBox chkHienMatKhau;
        private Button btnDangKy;
        private Button btnlogin;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
    }
}