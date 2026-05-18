namespace btlquanlysieuthi
{
    partial class FormTheoDoiDonHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.pnlTimeline = new System.Windows.Forms.Panel();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.lblStep4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.pnlTimeline.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Height = 60;
            this.lblTitle.Text = "HÀNH TRÌNH ĐƠN HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvDonHang
            this.dgvDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Location = new System.Drawing.Point(20, 70);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.Size = new System.Drawing.Size(740, 200);
            this.dgvDonHang.TabIndex = 0;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);

            // pnlTimeline (Khung chứa các bước giao hàng)
            this.pnlTimeline.BackColor = System.Drawing.Color.White;
            this.pnlTimeline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimeline.Controls.Add(this.lblStep1);
            this.pnlTimeline.Controls.Add(this.lblStep2);
            this.pnlTimeline.Controls.Add(this.lblStep3);
            this.pnlTimeline.Controls.Add(this.lblStep4);
            this.pnlTimeline.Location = new System.Drawing.Point(20, 290);
            this.pnlTimeline.Name = "pnlTimeline";
            this.pnlTimeline.Size = new System.Drawing.Size(740, 120);

            // Cài đặt các Label đại diện cho từng bước (Step)
            // Lưu ý: Tôi dùng ký tự '●' để làm điểm nút
            SetupStep(lblStep1, "Đã đặt hàng", 40);
            SetupStep(lblStep2, "Đã xác nhận", 220);
            SetupStep(lblStep3, "Đang giao", 400);
            SetupStep(lblStep4, "Thành công", 580);

            // Form Setup
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.pnlTimeline);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormTheoDoiDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo dõi quá trình giao hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.pnlTimeline.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // Hàm phụ để thiết kế nhanh các bước
        private void SetupStep(System.Windows.Forms.Label lbl, string text, int x)
        {
            lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.Silver; // Mặc định chưa tới là màu xám
            lbl.Location = new System.Drawing.Point(x, 20);
            lbl.Size = new System.Drawing.Size(120, 80);
            lbl.Text = "●\n" + text;
            lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        }

        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Panel pnlTimeline;
        private System.Windows.Forms.Label lblStep1, lblStep2, lblStep3, lblStep4;
        private System.Windows.Forms.Label lblTitle;
    }
}