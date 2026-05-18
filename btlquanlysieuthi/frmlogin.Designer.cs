namespace btlquanlysieuthi
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            button2 = new Button();
            cboQuyen = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btnDangKy = new Button();
            label5 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label4 = new Label();
            lblQuenMatKhau = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(438, 180);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(187, 27);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(436, 221);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(189, 27);
            txtPass.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(75, 8, 138);
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(412, 340);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateBlue;
            button2.ForeColor = Color.White;
            button2.Location = new Point(438, 405);
            button2.Name = "button2";
            button2.Size = new Size(101, 31);
            button2.TabIndex = 3;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cboQuyen
            // 
            cboQuyen.FormattingEnabled = true;
            cboQuyen.Location = new Point(436, 259);
            cboQuyen.Name = "cboQuyen";
            cboQuyen.Size = new Size(144, 28);
            cboQuyen.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 180);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 5;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 225);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 6;
            label2.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 262);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 7;
            label3.Text = "Chức vụ:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 8, 138);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnDangKy);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 491);
            panel1.TabIndex = 8;
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
            label6.Location = new Point(58, 405);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 4;
            label6.Text = "Register your account";
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(75, 8, 138);
            btnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(12, 434);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(254, 45);
            btnDangKy.TabIndex = 3;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(46, 225);
            label5.Name = "label5";
            label5.Size = new Size(198, 28);
            label5.TabIndex = 0;
            label5.Text = "Cửa Hàng Tạp Hóa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(347, 116);
            label4.Name = "label4";
            label4.Size = new Size(278, 25);
            label4.TabIndex = 9;
            label4.Text = "CỔNG THÔNG TIN NHÂN VIÊN";
            // 
            // lblQuenMatKhau
            // 
            lblQuenMatKhau.AutoSize = true;
            lblQuenMatKhau.LinkBehavior = LinkBehavior.NeverUnderline;
            lblQuenMatKhau.LinkColor = Color.Navy;
            lblQuenMatKhau.Location = new Point(436, 317);
            lblQuenMatKhau.Name = "lblQuenMatKhau";
            lblQuenMatKhau.Size = new Size(116, 20);
            lblQuenMatKhau.TabIndex = 10;
            lblQuenMatKhau.TabStop = true;
            lblQuenMatKhau.Text = "Quên mật khẩu?";
            lblQuenMatKhau.LinkClicked += lblQuenMatKhau_LinkClicked;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(688, 491);
            Controls.Add(lblQuenMatKhau);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboQuyen);
            Controls.Add(button2);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmlogin";
            Text = "frmlogin";
            Load += frmlogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Button button2;
        private ComboBox cboQuyen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btnDangKy;
        private LinkLabel lblQuenMatKhau;
    }
}