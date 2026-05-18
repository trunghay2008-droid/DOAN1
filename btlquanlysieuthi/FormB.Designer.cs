namespace btlquanlysieuthi
{
    partial class FormB
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
            panel1 = new Panel();
            picAnh = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblStock = new Label();
            txtQty = new TextBox();
            btnAdd = new Button();
            lblTenSP = new Label();
            lblGia = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(113, 76);
            panel1.TabIndex = 0;
            // 
            // picAnh
            // 
            picAnh.Location = new Point(3, 3);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(218, 125);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 0;
            picAnh.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(picAnh);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(230, 132);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(23, 225);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(93, 20);
            lblStock.TabIndex = 4;
            lblStock.Text = "số lượng tồn";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(23, 258);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(125, 27);
            txtQty.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(33, 11, 97);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(154, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Mua";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(131, 160);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(46, 20);
            lblTenSP.TabIndex = 8;
            lblTenSP.Text = "name";
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(131, 189);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(36, 20);
            lblGia.TabIndex = 9;
            lblGia.Text = "0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 160);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên Sản Phẩm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 189);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 11;
            label3.Text = "Giá Bán:";
            // 
            // FormB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblGia);
            Controls.Add(lblTenSP);
            Controls.Add(btnAdd);
            Controls.Add(txtQty);
            Controls.Add(lblStock);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "FormB";
            Size = new Size(232, 299);
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox picAnh;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label4;
        private TextBox txtQty;
        private Button btnAdd;
        private Label lblTenSP;
        private Label lblGia;
        private Label label2;
        private Label label3;
        public Label lblStock;
    }
}