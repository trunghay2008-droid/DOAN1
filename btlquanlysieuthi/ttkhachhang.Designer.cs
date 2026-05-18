namespace btlquanlysieuthi
{
    partial class ttkhachhang
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
            dgvKhachHang = new DataGridView();
            grpThongTin = new GroupBox();
            label4 = new Label();
            txtDiaChi = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtTimKiem = new TextBox();
            txtSDT = new TextBox();
            btnLamMoi = new Button();
            label2 = new Label();
            btnXoa = new Button();
            txtTenKH = new TextBox();
            btnSua = new Button();
            label1 = new Label();
            btnThem = new Button();
            txtMaKH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(21, 3);
            dgvKhachHang.Margin = new Padding(3, 4, 3, 4);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(788, 308);
            dgvKhachHang.TabIndex = 8;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(label4);
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(label5);
            grpThongTin.Controls.Add(label3);
            grpThongTin.Controls.Add(txtTimKiem);
            grpThongTin.Controls.Add(txtSDT);
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Controls.Add(label2);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(txtTenKH);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(label1);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(txtMaKH);
            grpThongTin.Font = new Font("Segoe UI", 9F);
            grpThongTin.Location = new Point(21, 319);
            grpThongTin.Margin = new Padding(3, 4, 3, 4);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(3, 4, 3, 4);
            grpThongTin.Size = new Size(788, 264);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông Tin Chi Tiết";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 227);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 7;
            label4.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(156, 220);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(235, 27);
            txtDiaChi.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 35);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm theo tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 177);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 0;
            label3.Text = "Số ĐT:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(156, 28);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(235, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(156, 174);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(235, 27);
            txtSDT.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(609, 187);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(160, 60);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 134);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên KH:";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightCoral;
            btnXoa.Location = new Point(609, 94);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 60);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa khách";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(156, 127);
            txtTenKH.Margin = new Padding(3, 4, 3, 4);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(235, 27);
            txtTenKH.TabIndex = 3;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Khaki;
            btnSua.Location = new Point(434, 187);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(160, 60);
            btnSua.TabIndex = 4;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 81);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã KH:";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.PaleGreen;
            btnThem.Location = new Point(434, 94);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 60);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(156, 74);
            txtMaKH.Margin = new Padding(3, 4, 3, 4);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(235, 27);
            txtMaKH.TabIndex = 5;
            // 
            // ttkhachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 602);
            Controls.Add(grpThongTin);
            Controls.Add(dgvKhachHang);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ttkhachhang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label label1, label2, label3, label5;
        private System.Windows.Forms.TextBox txtMaKH, txtTenKH, txtSDT, txtTimKiem;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLamMoi;
        private TextBox txtDiaChi;
        private Label label4;
    }
}