namespace btlquanlysieuthi
{
    partial class qlytaikhoan
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
            groupBox1 = new GroupBox();
            btnXoaTK = new Button();
            btnThemTk = new Button();
            dgvHienthiTK = new DataGridView();
            groupBox2 = new GroupBox();
            txtMaKH = new TextBox();
            txtXacnhanMK = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnupdateTK = new Button();
            cbQuyenhan = new ComboBox();
            txtMatkhau = new TextBox();
            txtMaNV = new TextBox();
            txtTenTK = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHienthiTK).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaTK);
            groupBox1.Controls.Add(btnThemTk);
            groupBox1.Controls.Add(dgvHienthiTK);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 536);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách tài khoản";
            // 
            // btnXoaTK
            // 
            btnXoaTK.BackColor = Color.FromArgb(33, 11, 97);
            btnXoaTK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTK.ForeColor = Color.White;
            btnXoaTK.Location = new Point(267, 477);
            btnXoaTK.Name = "btnXoaTK";
            btnXoaTK.Size = new Size(168, 42);
            btnXoaTK.TabIndex = 2;
            btnXoaTK.Text = "Xóa TK";
            btnXoaTK.UseVisualStyleBackColor = false;
            btnXoaTK.Click += btnXoaTK_Click;
            // 
            // btnThemTk
            // 
            btnThemTk.BackColor = Color.FromArgb(33, 11, 97);
            btnThemTk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemTk.ForeColor = Color.White;
            btnThemTk.Location = new Point(25, 482);
            btnThemTk.Name = "btnThemTk";
            btnThemTk.Size = new Size(168, 42);
            btnThemTk.TabIndex = 1;
            btnThemTk.Text = "Thêm TK";
            btnThemTk.UseVisualStyleBackColor = false;
            btnThemTk.Click += btnThemTk_Click;
            // 
            // dgvHienthiTK
            // 
            dgvHienthiTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienthiTK.Location = new Point(6, 44);
            dgvHienthiTK.Name = "dgvHienthiTK";
            dgvHienthiTK.RowHeadersWidth = 51;
            dgvHienthiTK.Size = new Size(454, 398);
            dgvHienthiTK.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMaKH);
            groupBox2.Controls.Add(txtXacnhanMK);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnupdateTK);
            groupBox2.Controls.Add(cbQuyenhan);
            groupBox2.Controls.Add(txtMatkhau);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(txtTenTK);
            groupBox2.Location = new Point(496, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(321, 536);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin tài khoản chi tiết";
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(22, 158);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(219, 27);
            txtMaKH.TabIndex = 16;
            // 
            // txtXacnhanMK
            // 
            txtXacnhanMK.Location = new Point(24, 284);
            txtXacnhanMK.Name = "txtXacnhanMK";
            txtXacnhanMK.Size = new Size(220, 27);
            txtXacnhanMK.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 323);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 14;
            label5.Text = "Quyền hạn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 261);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 13;
            label4.Text = "xác nhận lại mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 196);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 12;
            label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 104);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 11;
            label2.Text = "Mã Người dùng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 44);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 10;
            label1.Text = "Tên Tài khoản";
            // 
            // btnupdateTK
            // 
            btnupdateTK.BackColor = Color.FromArgb(33, 11, 97);
            btnupdateTK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdateTK.ForeColor = Color.White;
            btnupdateTK.Location = new Point(9, 451);
            btnupdateTK.Name = "btnupdateTK";
            btnupdateTK.Size = new Size(306, 47);
            btnupdateTK.TabIndex = 9;
            btnupdateTK.Text = "Cập nhật tài khoản";
            btnupdateTK.UseVisualStyleBackColor = false;
            btnupdateTK.Click += btnupdateTK_Click;
            // 
            // cbQuyenhan
            // 
            cbQuyenhan.FormattingEnabled = true;
            cbQuyenhan.Location = new Point(25, 346);
            cbQuyenhan.Name = "cbQuyenhan";
            cbQuyenhan.Size = new Size(257, 28);
            cbQuyenhan.TabIndex = 6;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(25, 219);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(219, 27);
            txtMatkhau.TabIndex = 5;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(22, 127);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(219, 27);
            txtMaNV.TabIndex = 4;
            // 
            // txtTenTK
            // 
            txtTenTK.Location = new Point(25, 67);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(193, 27);
            txtTenTK.TabIndex = 3;
            // 
            // qlytaikhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(838, 569);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "qlytaikhoan";
            Text = "qlytaikhoan";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHienthiTK).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvHienthiTK;
        private Button btnXoaTK;
        private Button btnThemTk;
        private ComboBox cbQuyenhan;
        private TextBox txtMatkhau;
        private TextBox txtMaNV;
        private TextBox txtTenTK;
        private Button btnupdateTK;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtXacnhanMK;
        private TextBox txtMaKH;
    }
}