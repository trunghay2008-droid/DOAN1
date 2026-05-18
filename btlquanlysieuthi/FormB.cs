using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace btlquanlysieuthi
{
    // Lưu ý: Để dùng làm Card, chúng ta sửa 'Form' thành 'UserControl' 
    public partial class FormB : UserControl
    {
        // Khai báo sự kiện để truyền dữ liệu sang FormC (Đơn hàng)
        public event Action<string, string, decimal, int> OnAddClick;

        private string _productID; // Biến tạm lưu ID sản phẩm
        private int _currentStock; // Biến tạm lưu số lượng tồn kho thực tế của sản phẩm này

        public FormB()
        {
            InitializeComponent();
        }

        // Nhận dữ liệu từ FormA/SQL để hiển thị lên Card
        public void SetData(string id, string name, decimal price, int stock, string imgPath)
        {
            _productID = id;
            _currentStock = stock; // Lưu lại số lượng tồn kho vào biến toàn cục của Card

            lblTenSP.Text = name;
            lblGia.Text = price.ToString("N0") + " VNĐ";
            lblStock.Text = "Số lượng tồn: " + stock.ToString();

            // Xử lý hiển thị ảnh sản phẩm
            if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
            {
                try
                {
                    using (FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                    {
                        picAnh.Image = Image.FromStream(fs);
                    }
                }
                catch { /* Xử lý nếu ảnh lỗi */ }
            }

            if (_currentStock <= 0)
            {
                btnAdd.Enabled = true;       
                btnAdd.Text = "Hết hàng";       // Đổi chữ hiển thị
                btnAdd.BackColor = Color.Gray;  // Đổi nút sang màu xám để nhận biết
            }
            else
            {
                btnAdd.Enabled = true;
                btnAdd.Text = "Mua";
                btnAdd.BackColor = Color.FromArgb(0, 0, 128); // Đổi lại màu xanh mặc định (hoặc màu cũ của bạn)
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra định dạng số lượng nhập vào (phải là số nguyên > 0)
            if (!int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ (số nguyên lớn hơn 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. KIỂM TRA SỐ LƯỢNG TỒN KHO THỰC TẾ
            if (_currentStock <= 0)
            {
                MessageBox.Show("Sản phẩm này đã hết hàng, không thể mua thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (qty > _currentStock)
            {
                MessageBox.Show($"Số lượng trong kho không đủ! Hiện tại sản phẩm này chỉ còn {_currentStock} sản phẩm tồn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 3. XỬ LÝ LÀM SẠCH GIÁ TIỀN (
            try
            {
                string cleanPrice = lblGia.Text
                                    .Replace(" VNĐ", "")
                                    .Replace(",", "")
                                    .Replace(".", "")
                                    .Trim();

                if (decimal.TryParse(cleanPrice, out decimal price))
                {
                    OnAddClick?.Invoke(_productID, lblTenSP.Text, price, qty);
                }
                else
                {
                    MessageBox.Show("Lỗi: Định dạng hiển thị giá tiền trên Card không đúng chuẩn!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống khi xử lý giá sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
