using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JollibeeKiosk.Models;
using JollibeeKiosk.Services;

namespace JollibeeKiosk
{
    public partial class FormMenu : Form
    {
        private readonly Form _opener;

        public FormMenu(Form opener)
        {
            _opener = opener;
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            lblOrderTypeBadge.Text = KioskSession.CurrentOrder.OrderType == OrderType.DineIn
                ? "🍽️  Dine In"
                : "🥡  Take Out";

            SyncQuantitiesFromOrder();
            RefreshCartSummary();
        }

        private void SyncQuantitiesFromOrder()
        {
            lblQty1.Text  = GetItemQty(1).ToString();
            lblQty2.Text  = GetItemQty(2).ToString();
            lblQty3.Text  = GetItemQty(3).ToString();
            lblQty4.Text  = GetItemQty(18).ToString();
            lblQty5.Text  = GetItemQty(4).ToString();
            lblQty6.Text  = GetItemQty(5).ToString();
            lblQty7.Text  = GetItemQty(6).ToString();
            lblQty8.Text  = GetItemQty(8).ToString();
            lblQty9.Text  = GetItemQty(9).ToString();
            lblQty10.Text = GetItemQty(11).ToString();
            lblQty11.Text = GetItemQty(13).ToString();
            lblQty12.Text = GetItemQty(15).ToString();
        }

        private int GetItemQty(int itemId)
        {
            var item = KioskSession.CurrentOrder.Items.FirstOrDefault(x => x.Item.Id == itemId);
            return item?.Quantity ?? 0;
        }

        private void ModifyCart(int itemId, int delta, Label lblQty)
        {
            var menuItem = MenuRepository.GetById(itemId);
            if (menuItem == null) return;

            int currentQty = GetItemQty(itemId);
            if (delta < 0 && currentQty <= 0) return;

            if (delta > 0)
            {
                KioskSession.CurrentOrder.AddItem(menuItem, 1);
            }
            else
            {
                KioskSession.CurrentOrder.RemoveItem(itemId);
            }

            lblQty.Text = GetItemQty(itemId).ToString();
            RefreshCartSummary();
        }

        private void RefreshCartSummary()
        {
            var order = KioskSession.CurrentOrder;
            var sb = new StringBuilder();

            if (order.Items.Count == 0)
            {
                sb.AppendLine("Your cart is currently empty.");
                sb.AppendLine();
                sb.AppendLine("Click the '+' buttons on any product to add it to your order!");
            }
            else
            {
                sb.AppendLine("── CURRENT CART ───────────────");
                sb.AppendLine();
                foreach (var line in order.Items)
                {
                    sb.AppendLine($"{line.Quantity}x  {line.Item.Name}");
                    sb.AppendLine($"     ₱{line.LineTotal:F2}");
                }
                sb.AppendLine();
                sb.AppendLine("───────────────────────────────");
            }

            rtbCartSummary.Text = sb.ToString();
            decimal subtotal = order.CalculateSubtotal();
            lblSubtotalAmt.Text = $"Subtotal:   ₱{subtotal:F2}";
            btnProceedCheckout.Enabled = (order.Items.Count > 0);
        }

        private void BtnPlus1_Click(object sender, EventArgs e)  => ModifyCart(1, 1, lblQty1);
        private void BtnMinus1_Click(object sender, EventArgs e) => ModifyCart(1, -1, lblQty1);

        private void BtnPlus2_Click(object sender, EventArgs e)  => ModifyCart(2, 1, lblQty2);
        private void BtnMinus2_Click(object sender, EventArgs e) => ModifyCart(2, -1, lblQty2);

        private void BtnPlus3_Click(object sender, EventArgs e)  => ModifyCart(3, 1, lblQty3);
        private void BtnMinus3_Click(object sender, EventArgs e) => ModifyCart(3, -1, lblQty3);

        private void BtnPlus4_Click(object sender, EventArgs e)  => ModifyCart(18, 1, lblQty4);
        private void BtnMinus4_Click(object sender, EventArgs e) => ModifyCart(18, -1, lblQty4);

        private void BtnPlus5_Click(object sender, EventArgs e)  => ModifyCart(4, 1, lblQty5);
        private void BtnMinus5_Click(object sender, EventArgs e) => ModifyCart(4, -1, lblQty5);

        private void BtnPlus6_Click(object sender, EventArgs e)  => ModifyCart(5, 1, lblQty6);
        private void BtnMinus6_Click(object sender, EventArgs e) => ModifyCart(5, -1, lblQty6);

        private void BtnPlus7_Click(object sender, EventArgs e)  => ModifyCart(6, 1, lblQty7);
        private void BtnMinus7_Click(object sender, EventArgs e) => ModifyCart(6, -1, lblQty7);

        private void BtnPlus8_Click(object sender, EventArgs e)  => ModifyCart(8, 1, lblQty8);
        private void BtnMinus8_Click(object sender, EventArgs e) => ModifyCart(8, -1, lblQty8);

        private void BtnPlus9_Click(object sender, EventArgs e)  => ModifyCart(9, 1, lblQty9);
        private void BtnMinus9_Click(object sender, EventArgs e) => ModifyCart(9, -1, lblQty9);

        private void BtnPlus10_Click(object sender, EventArgs e)  => ModifyCart(11, 1, lblQty10);
        private void BtnMinus10_Click(object sender, EventArgs e) => ModifyCart(11, -1, lblQty10);

        private void BtnPlus11_Click(object sender, EventArgs e)  => ModifyCart(13, 1, lblQty11);
        private void BtnMinus11_Click(object sender, EventArgs e) => ModifyCart(13, -1, lblQty11);

        private void BtnPlus12_Click(object sender, EventArgs e)  => ModifyCart(15, 1, lblQty12);
        private void BtnMinus12_Click(object sender, EventArgs e) => ModifyCart(15, -1, lblQty12);

        private void BtnProceedCheckout_Click(object sender, EventArgs e)
        {
            if (KioskSession.CurrentOrder.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add at least one item.",
                    "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new FormCheckout(this).Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _opener.Show();
            this.Close();
        }
    }
}
