namespace btlquanlysieuthi
{
    partial class lichsugdkh
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
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lblTongTienText = new System.Windows.Forms.Label();
            this.lblTongTienValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLichSu.Location = new System.Drawing.Point(0, 110);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersVisible = false;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(900, 390);
            this.dgvLichSu.TabIndex = 0;

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 50);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 13);
            this.lblTitle.Text = "LỊCH SỬ GIAO DỊCH";

            // Bộ lọc ngày tháng
            this.label1.Text = "Từ ngày:"; this.label1.Location = new System.Drawing.Point(15, 70);
            this.dtpTuNgay.Location = new System.Drawing.Point(75, 67); this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.label2.Text = "Đến ngày:"; this.label2.Location = new System.Drawing.Point(200, 70);
            this.dtpDenNgay.Location = new System.Drawing.Point(270, 67); this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Nút lọc
            this.btnLoc.Text = "Lọc dữ liệu";
            this.btnLoc.Location = new System.Drawing.Point(400, 65);
            this.btnLoc.Size = new System.Drawing.Size(100, 30);
            this.btnLoc.BackColor = System.Drawing.Color.LightGray;

            // Tổng tiền
            this.lblTongTienText.Text = "Tổng chi tiêu:";
            this.lblTongTienText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTienText.Location = new System.Drawing.Point(650, 70);

            this.lblTongTienValue.Text = "0 VNĐ";
            this.lblTongTienValue.ForeColor = System.Drawing.Color.Red;
            this.lblTongTienValue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTienValue.Location = new System.Drawing.Point(760, 68);

            // Form Setup
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lblTongTienValue);
            this.Controls.Add(this.lblTongTienText);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvLichSu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Sử Giao Dịch Khách Hàng";

            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Khai báo các control bên dưới
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lblTongTienText;
        private System.Windows.Forms.Label lblTongTienValue;
    }
}