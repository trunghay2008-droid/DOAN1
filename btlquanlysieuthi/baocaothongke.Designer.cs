namespace btlquanlysieuthi
{
    partial class baocaothongke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baocaothongke));
            groupBox1 = new GroupBox();
            btnXuatBaoCao = new Button();
            btnKhachHang = new Button();
            btnThongkeLoiNhuan = new Button();
            btnThongkedonhang = new Button();
            btnTop5sp = new Button();
            btnBaocaodoanhthu = new Button();
            groupBox2 = new GroupBox();
            dgvBaocao = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaocao).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXuatBaoCao);
            groupBox1.Controls.Add(btnKhachHang);
            groupBox1.Controls.Add(btnThongkeLoiNhuan);
            groupBox1.Controls.Add(btnThongkedonhang);
            groupBox1.Controls.Add(btnTop5sp);
            groupBox1.Controls.Add(btnBaocaodoanhthu);
            groupBox1.Location = new Point(12, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(816, 225);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục báo cáo";
            // 
            // btnXuatBaoCao
            // 
            btnXuatBaoCao.BackColor = Color.FromArgb(33, 11, 97);
            btnXuatBaoCao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatBaoCao.ForeColor = Color.White;
            btnXuatBaoCao.Location = new Point(559, 127);
            btnXuatBaoCao.Name = "btnXuatBaoCao";
            btnXuatBaoCao.Size = new Size(200, 40);
            btnXuatBaoCao.TabIndex = 6;
            btnXuatBaoCao.Text = "Xuất báo cáo";
            btnXuatBaoCao.UseVisualStyleBackColor = false;
            btnXuatBaoCao.Click += btnXuatBaoCao_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.FromArgb(33, 11, 97);
            btnKhachHang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Location = new Point(279, 127);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(200, 40);
            btnKhachHang.TabIndex = 5;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click_1;
            // 
            // btnThongkeLoiNhuan
            // 
            btnThongkeLoiNhuan.BackColor = Color.FromArgb(33, 11, 97);
            btnThongkeLoiNhuan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongkeLoiNhuan.ForeColor = Color.White;
            btnThongkeLoiNhuan.Location = new Point(279, 40);
            btnThongkeLoiNhuan.Name = "btnThongkeLoiNhuan";
            btnThongkeLoiNhuan.Size = new Size(208, 40);
            btnThongkeLoiNhuan.TabIndex = 3;
            btnThongkeLoiNhuan.Text = "Lợi nhuận";
            btnThongkeLoiNhuan.UseVisualStyleBackColor = false;
            btnThongkeLoiNhuan.Click += btnThongkeLoiNhuan_Click_1;
            // 
            // btnThongkedonhang
            // 
            btnThongkedonhang.BackColor = Color.FromArgb(33, 11, 97);
            btnThongkedonhang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongkedonhang.ForeColor = Color.White;
            btnThongkedonhang.Location = new Point(26, 127);
            btnThongkedonhang.Name = "btnThongkedonhang";
            btnThongkedonhang.Size = new Size(200, 40);
            btnThongkedonhang.TabIndex = 2;
            btnThongkedonhang.Text = "Thống kê đơn hàng";
            btnThongkedonhang.UseVisualStyleBackColor = false;
            btnThongkedonhang.Click += btnThongkedonhang_Click_1;
            // 
            // btnTop5sp
            // 
            btnTop5sp.BackColor = Color.FromArgb(33, 11, 97);
            btnTop5sp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTop5sp.ForeColor = Color.White;
            btnTop5sp.Location = new Point(559, 40);
            btnTop5sp.Name = "btnTop5sp";
            btnTop5sp.Size = new Size(200, 40);
            btnTop5sp.TabIndex = 1;
            btnTop5sp.Text = "Top sản phẩm";
            btnTop5sp.UseVisualStyleBackColor = false;
            btnTop5sp.Click += btnTop5sp_Click_1;
            // 
            // btnBaocaodoanhthu
            // 
            btnBaocaodoanhthu.BackColor = Color.FromArgb(33, 11, 97);
            btnBaocaodoanhthu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaocaodoanhthu.ForeColor = Color.White;
            btnBaocaodoanhthu.Location = new Point(26, 40);
            btnBaocaodoanhthu.Name = "btnBaocaodoanhthu";
            btnBaocaodoanhthu.Size = new Size(200, 40);
            btnBaocaodoanhthu.TabIndex = 0;
            btnBaocaodoanhthu.Text = "Báo cáo doanh thu";
            btnBaocaodoanhthu.UseVisualStyleBackColor = false;
            btnBaocaodoanhthu.Click += btnBaocaodoanhthu_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvBaocao);
            groupBox2.Location = new Point(12, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(816, 343);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả thống kê";
            // 
            // dgvBaocao
            // 
            dgvBaocao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaocao.Dock = DockStyle.Fill;
            dgvBaocao.Location = new Point(3, 23);
            dgvBaocao.Name = "dgvBaocao";
            dgvBaocao.RowHeadersWidth = 51;
            dgvBaocao.Size = new Size(810, 317);
            dgvBaocao.TabIndex = 0;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // baocaothongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(844, 590);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "baocaothongke";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo thống kê";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBaocao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;

        private Button btnTop5sp;
        private Button btnBaocaodoanhthu;
        private Button btnThongkedonhang;
        private Button btnThongkeLoiNhuan;
        private Button btnKhachHang;

        private DataGridView dgvBaocao;
        private Button btnXuatBaoCao;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}