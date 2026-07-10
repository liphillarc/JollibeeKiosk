using System.Drawing;
using JollibeeKiosk.Models;

namespace JollibeeKiosk
{
    public partial class ProductCard : UserControl
    {
        private MenuItem? _item;
        public event EventHandler<MenuItem>? ItemAdded;
        public event EventHandler<MenuItem>? ItemRemoved;

        public ProductCard()
        {
            InitializeComponent();
        }

        public PictureBox ProductImage => picProduct;

        public void SetItem(MenuItem item, int currentQty)
        {
            _item = item;
            lblName.Text = item.Name;
            lblPrice.Text = $"₱{item.Price:F2}";
            lblQty.Text = currentQty.ToString();

            try
            {
                string imgPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, item.ImagePath);
                if (File.Exists(imgPath))
                {
                    picProduct.Image = Image.FromFile(imgPath);
                    picProduct.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch
            {
            }
        }

        public void UpdateQuantity(int qty)
        {
            lblQty.Text = qty.ToString();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (_item != null)
            {
                ItemAdded?.Invoke(this, _item);
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (_item != null)
            {
                ItemRemoved?.Invoke(this, _item);
            }
        }
    }
}
