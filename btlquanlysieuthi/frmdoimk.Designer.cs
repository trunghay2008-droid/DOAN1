namespace btlquanlysieuthi
{
    partial class frmdoimk
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
            txtMatKhauMoi = new TextBox();
            txtXacNhanMK = new TextBox();
            cbQuyen = new ComboBox();
            btnCapNhat = new Button();
            txtMaTK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkHienMatKhau = new CheckBox();
            groupBox1 = new GroupBox();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(196, 100);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(157, 27);
            txtMatKhauMoi.TabIndex = 1;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(196, 133);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(157, 27);
            txtXacNhanMK.TabIndex = 2;
            // 
            // cbQuyen
            // 
            cbQuyen.FormattingEnabled = true;
            cbQuyen.Location = new Point(169, 199);
            cbQuyen.Name = "cbQuyen";
            cbQuyen.Size = new Size(184, 28);
            cbQuyen.TabIndex = 3;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(33, 11, 97);
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(30, 247);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(323, 56);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Đổi Mật Khẩu";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtMaTK
            // 
            txtMaTK.Location = new Point(196, 61);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.Size = new Size(157, 27);
            txtMaTK.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 68);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã Tài Khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 7;
            label2.Text = "Mật khẩu Mới:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 136);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 8;
            label3.Text = "Xác nhận lại mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 202);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 9;
            label4.Text = "Quyền Hạn:";
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(169, 166);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(188, 24);
            chkHienMatKhau.TabIndex = 10;
            chkHienMatKhau.Text = "Hiện Mật Khẩu Hiện Tại";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(chkHienMatKhau);
            groupBox1.Controls.Add(txtMatKhauMoi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtXacNhanMK);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbQuyen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaTK);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(224, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 375);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đổi Mật Khẩu TK:";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(75, 8, 138);
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(62, 318);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(255, 34);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmdoimk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 530);
            Controls.Add(groupBox1);
            Name = "frmdoimk";
            Text = "frmdoimk";
            Load += frmdoimk_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhanMK;
        private ComboBox cbQuyen;
        private Button btnCapNhat;
        private TextBox txtMaTK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkHienMatKhau;
        private GroupBox groupBox1;
        private Button btnThoat;
    }
}