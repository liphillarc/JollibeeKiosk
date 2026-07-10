using System;
using System.Drawing;
using System.Windows.Forms;
using JollibeeKiosk.Models;

namespace JollibeeKiosk
{
    public partial class FormCheckout : Form
    {
        private readonly Form _opener;

        private PictureBox[] _picItems   = Array.Empty<PictureBox>();
        private Label[]      _lblNames   = Array.Empty<Label>();
        private Label[]      _lblPrices  = Array.Empty<Label>();
        private Button[]     _btnMinuses = Array.Empty<Button>();
        private Label[]      _lblQtys    = Array.Empty<Label>();
        private Button[]     _btnPluses  = Array.Empty<Button>();
        private Label[]      _lblSubs    = Array.Empty<Label>();
        private Button[]     _btnDeletes = Array.Empty<Button>();

        public FormCheckout(Form opener)
        {
            _opener = opener;
            InitializeComponent();
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            lblOrderBadge.Text = KioskSession.CurrentOrder.OrderType == OrderType.DineIn
                ? "🍽️  Dine In Order"
                : "🥡  Take Out Order";

            _picItems   = new[] { picCOItem1, picCOItem2, picCOItem3, picCOItem4, picCOItem5, picCOItem6 };
            _lblNames   = new[] { lblCOName1, lblCOName2, lblCOName3, lblCOName4, lblCOName5, lblCOName6 };
            _lblPrices  = new[] { lblCOPrice1, lblCOPrice2, lblCOPrice3, lblCOPrice4, lblCOPrice5, lblCOPrice6 };
            _btnMinuses = new[] { btnCOMinus1, btnCOMinus2, btnCOMinus3, btnCOMinus4, btnCOMinus5, btnCOMinus6 };
            _lblQtys    = new[] { lblCOQty1, lblCOQty2, lblCOQty3, lblCOQty4, lblCOQty5, lblCOQty6 };
            _btnPluses  = new[] { btnCOPlus1, btnCOPlus2, btnCOPlus3, btnCOPlus4, btnCOPlus5, btnCOPlus6 };
            _lblSubs    = new[] { lblCOSub1, lblCOSub2, lblCOSub3, lblCOSub4, lblCOSub5, lblCOSub6 };
            _btnDeletes = new[] { btnCODelete1, btnCODelete2, btnCODelete3, btnCODelete4, btnCODelete5, btnCODelete6 };

            DisplayCheckoutItems();
        }

        private void DisplayCheckoutItems()
        {
            var order = KioskSession.CurrentOrder;
            lblReviewTitle.Text = $"Review Items ({order.Items.Count})";

            for (int i = 0; i < 6; i++)
            {
                if (i < order.Items.Count)
                {
                    var oi = order.Items[i];
                    _lblNames[i].Text  = oi.Item.Name;
                    _lblPrices[i].Text = $"₱{oi.Item.Price:F2}";
                    _lblQtys[i].Text   = oi.Quantity.ToString();
                    _lblSubs[i].Text   = $"₱{oi.LineTotal:F2}";

                    _picItems[i].Visible   = true;
                    _lblNames[i].Visible   = true;
                    _lblPrices[i].Visible  = true;
                    _btnMinuses[i].Visible = true;
                    _lblQtys[i].Visible    = true;
                    _btnPluses[i].Visible  = true;
                    _lblSubs[i].Visible    = true;
                    _btnDeletes[i].Visible = true;
                }
                else
                {
                    _picItems[i].Visible   = false;
                    _lblNames[i].Visible   = false;
                    _lblPrices[i].Visible  = false;
                    _btnMinuses[i].Visible = false;
                    _lblQtys[i].Visible    = false;
                    _btnPluses[i].Visible  = false;
                    _lblSubs[i].Visible    = false;
                    _btnDeletes[i].Visible = false;
                }
            }

            RecalculateTotals();
        }

        private void RecalculateTotals()
        {
            var order = KioskSession.CurrentOrder;

            DiscountType selectedType = DiscountType.None;
            if (rbtnSenior.Checked) selectedType = DiscountType.SeniorCitizen;
            if (rbtnPWD.Checked)    selectedType = DiscountType.PWD;

            order.ApplyDiscount(selectedType);

            decimal subtotal = order.CalculateSubtotal();
            decimal discount = order.DiscountAmount;
            decimal total    = order.GetTotal();

            lblCOSubtotalAmt.Text = $"Subtotal:                                                   ₱{subtotal:F2}";
            lblCODiscountAmt.Text = $"Discount ({selectedType}):                                 −₱{discount:F2}";
            lblCOTotalAmt.Text    = $"TOTAL: ₱{total:F2}";

            btnConfirmOrder.Enabled = (order.Items.Count > 0);
        }

        private void Discount_CheckedChanged(object sender, EventArgs e)
        {
            RecalculateTotals();
        }

        private void ModifyRowQty(int index, int delta)
        {
            var order = KioskSession.CurrentOrder;
            if (index >= order.Items.Count) return;

            var item = order.Items[index].Item;
            if (delta > 0)
                order.AddItem(item, 1);
            else
                order.RemoveItem(item.Id);

            DisplayCheckoutItems();
        }

        private void DeleteRowItem(int index)
        {
            var order = KioskSession.CurrentOrder;
            if (index >= order.Items.Count) return;

            order.DeleteItem(order.Items[index].Item.Id);
            DisplayCheckoutItems();
        }

        private void BtnCOPlus1_Click(object sender, EventArgs e)   => ModifyRowQty(0, 1);
        private void BtnCOMinus1_Click(object sender, EventArgs e)  => ModifyRowQty(0, -1);
        private void BtnCODelete1_Click(object sender, EventArgs e) => DeleteRowItem(0);

        private void BtnCOPlus2_Click(object sender, EventArgs e)   => ModifyRowQty(1, 1);
        private void BtnCOMinus2_Click(object sender, EventArgs e)  => ModifyRowQty(1, -1);
        private void BtnCODelete2_Click(object sender, EventArgs e) => DeleteRowItem(1);

        private void BtnCOPlus3_Click(object sender, EventArgs e)   => ModifyRowQty(2, 1);
        private void BtnCOMinus3_Click(object sender, EventArgs e)  => ModifyRowQty(2, -1);
        private void BtnCODelete3_Click(object sender, EventArgs e) => DeleteRowItem(2);

        private void BtnCOPlus4_Click(object sender, EventArgs e)   => ModifyRowQty(3, 1);
        private void BtnCOMinus4_Click(object sender, EventArgs e)  => ModifyRowQty(3, -1);
        private void BtnCODelete4_Click(object sender, EventArgs e) => DeleteRowItem(3);

        private void BtnCOPlus5_Click(object sender, EventArgs e)   => ModifyRowQty(4, 1);
        private void BtnCOMinus5_Click(object sender, EventArgs e)  => ModifyRowQty(4, -1);
        private void BtnCODelete5_Click(object sender, EventArgs e) => DeleteRowItem(4);

        private void BtnCOPlus6_Click(object sender, EventArgs e)   => ModifyRowQty(5, 1);
        private void BtnCOMinus6_Click(object sender, EventArgs e)  => ModifyRowQty(5, -1);
        private void BtnCODelete6_Click(object sender, EventArgs e) => DeleteRowItem(5);

        private void BtnAddMoreItems_Click(object sender, EventArgs e)
        {
            _opener.Show();
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _opener.Show();
            this.Close();
        }

        private void BtnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (KioskSession.CurrentOrder.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            new FormReceipt(this).Show();
            this.Hide();
        }
    }
}
