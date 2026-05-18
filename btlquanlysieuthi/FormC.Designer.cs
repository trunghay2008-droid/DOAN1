namespace btlquanlysieuthi
{
    partial class FormC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormC));
            flpProductList = new FlowLayoutPanel();
            dgvOrder = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            btnThanhToan = new Button();
            btnInHoaDon = new Button();
            lblTotal = new Label();
            cbNhanVien = new ComboBox();
            txtTenKH = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // flpProductList
            // 
            flpProductList.AutoScroll = true;
            flpProductList.BackColor = Color.FromArgb(224, 224, 224);
            flpProductList.Dock = DockStyle.Left;
            flpProductList.Location = new Point(0, 0);
            flpProductList.Name = "flpProductList";
            flpProductList.Size = new Size(265, 576);
            flpProductList.TabIndex = 0;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { id, name, qty, price, total });
            dgvOrder.Location = new Point(267, 0);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(556, 276);
            dgvOrder.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "Mã SP";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "Tên Sản Phẩm";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // qty
            // 
            qty.HeaderText = "Số Lượng";
            qty.MinimumWidth = 6;
            qty.Name = "qty";
            qty.Width = 125;
            // 
            // price
            // 
            price.HeaderText = "Đơn Giá";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 125;
            // 
            // total
            // 
            total.HeaderText = "Thành tiền";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 125;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(33, 11, 97);
            btnThanhToan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(393, 141);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(113, 34);
            btnThanhToan.TabIndex = 3;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.FromArgb(33, 11, 97);
            btnInHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInHoaDon.ForeColor = Color.White;
            btnInHoaDon.Location = new Point(393, 181);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(113, 34);
            btnInHoaDon.TabIndex = 4;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(85, 148);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(69, 20);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "tổng tiền";
            // 
            // cbNhanVien
            // 
            cbNhanVien.FormattingEnabled = true;
            cbNhanVien.Location = new Point(186, 64);
            cbNhanVien.Name = "cbNhanVien";
            cbNhanVien.Size = new Size(151, 28);
            cbNhanVien.TabIndex = 6;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(186, 102);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(125, 27);
            txtTenKH.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 64);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 9;
            label1.Text = "Người Phụ trách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 105);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 10;
            label2.Text = "Người Mua:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbNhanVien);
            groupBox1.Controls.Add(btnInHoaDon);
            groupBox1.Controls.Add(btnThanhToan);
            groupBox1.Controls.Add(txtTenKH);
            groupBox1.Location = new Point(271, 282);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 282);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý đơn hàng";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(33, 11, 97);
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(393, 91);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(113, 34);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(33, 11, 97);
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(393, 51);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(113, 34);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
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
            // FormC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(835, 576);
            Controls.Add(groupBox1);
            Controls.Add(dgvOrder);
            Controls.Add(flpProductList);
            Name = "FormC";
            Text = "FormC";
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpProductList;
        private DataGridView dgvOrder;
        private Button btnThanhToan;
        private Button btnInHoaDon;
        private Label lblTotal;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn total;
        private ComboBox cbNhanVien;
        private TextBox txtTenKH;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnXoa;
        private Button btnSua;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}