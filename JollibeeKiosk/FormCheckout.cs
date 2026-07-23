using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using JollibeeKiosk.Models;

namespace JollibeeKiosk
{
    public partial class FormCheckout : Form
    {
        private readonly Form _opener;

        private PictureBox[] _picItems = Array.Empty<PictureBox>();
        private Label[] _lblNames = Array.Empty<Label>();
        private Label[] _lblPrices = Array.Empty<Label>();
        private Button[] _btnMinuses = Array.Empty<Button>();
        private Label[] _lblQtys = Array.Empty<Label>();
        private Button[] _btnPluses = Array.Empty<Button>();
        private Label[] _lblSubs = Array.Empty<Label>();
        private Button[] _btnDeletes = Array.Empty<Button>();

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

            _picItems = new[] { picCOItem1, picCOItem2, picCOItem3, picCOItem4, picCOItem5, picCOItem6 };
            _lblNames = new[] { lblCOName1, lblCOName2, lblCOName3, lblCOName4, lblCOName5, lblCOName6 };
            _lblPrices = new[] { lblCOPrice1, lblCOPrice2, lblCOPrice3, lblCOPrice4, lblCOPrice5, lblCOPrice6 };
            _btnMinuses = new[] { btnCOMinus1, btnCOMinus2, btnCOMinus3, btnCOMinus4, btnCOMinus5, btnCOMinus6 };
            _lblQtys = new[] { lblCOQty1, lblCOQty2, lblCOQty3, lblCOQty4, lblCOQty5, lblCOQty6 };
            _btnPluses = new[] { btnCOPlus1, btnCOPlus2, btnCOPlus3, btnCOPlus4, btnCOPlus5, btnCOPlus6 };
            _lblSubs = new[] { lblCOSub1, lblCOSub2, lblCOSub3, lblCOSub4, lblCOSub5, lblCOSub6 };
            _btnDeletes = new[] { btnCODelete1, btnCODelete2, btnCODelete3, btnCODelete4, btnCODelete5, btnCODelete6 };

            // Create a runtime scroll panel so the form doesn't scroll the totals
            _pnlScroll = new Panel
            {
                Location = new Point(20, 140),
                Size = new Size(730, 520),
                AutoScroll = true,
                BorderStyle = BorderStyle.None
            };
            this.Controls.Add(_pnlScroll);

            for (int i = 0; i < 6; i++)
            {
                _pnlScroll.Controls.Add(_picItems[i]);
                _pnlScroll.Controls.Add(_lblNames[i]);
                _pnlScroll.Controls.Add(_lblPrices[i]);
                _pnlScroll.Controls.Add(_btnMinuses[i]);
                _pnlScroll.Controls.Add(_lblQtys[i]);
                _pnlScroll.Controls.Add(_btnPluses[i]);
                _pnlScroll.Controls.Add(_lblSubs[i]);
                _pnlScroll.Controls.Add(_btnDeletes[i]);

                _picItems[i].Top -= 140;
                _lblNames[i].Top -= 140;
                _lblPrices[i].Top -= 140;
                _btnMinuses[i].Top -= 140;
                _lblQtys[i].Top -= 140;
                _btnPluses[i].Top -= 140;
                _lblSubs[i].Top -= 140;
                _btnDeletes[i].Top -= 140;

                _picItems[i].Left -= 10;
                _lblNames[i].Left -= 10;
                _lblPrices[i].Left -= 10;
                _btnMinuses[i].Left -= 10;
                _lblQtys[i].Left -= 10;
                _btnPluses[i].Left -= 10;
                _lblSubs[i].Left -= 10;
                _btnDeletes[i].Left -= 10;
                
                _picItems[i].SizeMode = PictureBoxSizeMode.StretchImage;
            }

            DisplayCheckoutItems();
        }

        private Panel _pnlScroll;

        private void EnsureCapacity(int count)
        {
            if (_picItems.Length >= count) return;

            int oldLen = _picItems.Length;
            Array.Resize(ref _picItems, count);
            Array.Resize(ref _lblNames, count);
            Array.Resize(ref _lblPrices, count);
            Array.Resize(ref _btnMinuses, count);
            Array.Resize(ref _lblQtys, count);
            Array.Resize(ref _btnPluses, count);
            Array.Resize(ref _lblSubs, count);
            Array.Resize(ref _btnDeletes, count);

            for (int i = oldLen; i < count; i++)
            {
                int yOffset = _picItems[0].Top + (90 * i);

                _picItems[i] = new PictureBox { Location = new Point(_picItems[0].Left, yOffset), Size = _picItems[0].Size, BackColor = _picItems[0].BackColor, BorderStyle = _picItems[0].BorderStyle, SizeMode = PictureBoxSizeMode.StretchImage };
                
                _lblNames[i] = new Label { Location = new Point(_lblNames[0].Left, yOffset + (_lblNames[0].Top - _picItems[0].Top)), Size = _lblNames[0].Size, Font = _lblNames[0].Font, ForeColor = _lblNames[0].ForeColor, AutoSize = _lblNames[0].AutoSize };
                
                _lblPrices[i] = new Label { Location = new Point(_lblPrices[0].Left, yOffset + (_lblPrices[0].Top - _picItems[0].Top)), Size = _lblPrices[0].Size, Font = _lblPrices[0].Font, ForeColor = _lblPrices[0].ForeColor, AutoSize = _lblPrices[0].AutoSize };
                
                _lblQtys[i] = new Label { Location = new Point(_lblQtys[0].Left, yOffset + (_lblQtys[0].Top - _picItems[0].Top)), Size = _lblQtys[0].Size, Font = _lblQtys[0].Font, ForeColor = _lblQtys[0].ForeColor, TextAlign = _lblQtys[0].TextAlign };
                
                _lblSubs[i] = new Label { Location = new Point(_lblSubs[0].Left, yOffset + (_lblSubs[0].Top - _picItems[0].Top)), Size = _lblSubs[0].Size, Font = _lblSubs[0].Font, ForeColor = _lblSubs[0].ForeColor, AutoSize = _lblSubs[0].AutoSize, TextAlign = _lblSubs[0].TextAlign };

                _btnMinuses[i] = new Button { Location = new Point(_btnMinuses[0].Left, yOffset + (_btnMinuses[0].Top - _picItems[0].Top)), Size = _btnMinuses[0].Size, Font = _btnMinuses[0].Font, BackColor = _btnMinuses[0].BackColor, ForeColor = _btnMinuses[0].ForeColor, FlatStyle = _btnMinuses[0].FlatStyle, Text = "−", Cursor = Cursors.Hand };
                _btnMinuses[i].FlatAppearance.BorderSize = 1;
                _btnMinuses[i].FlatAppearance.BorderColor = Color.LightGray;

                _btnPluses[i] = new Button { Location = new Point(_btnPluses[0].Left, yOffset + (_btnPluses[0].Top - _picItems[0].Top)), Size = _btnPluses[0].Size, Font = _btnPluses[0].Font, BackColor = _btnPluses[0].BackColor, ForeColor = _btnPluses[0].ForeColor, FlatStyle = _btnPluses[0].FlatStyle, Text = "+", Cursor = Cursors.Hand };
                _btnPluses[i].FlatAppearance.BorderSize = 1;
                _btnPluses[i].FlatAppearance.BorderColor = Color.LightGray;

                _btnDeletes[i] = new Button { Location = new Point(_btnDeletes[0].Left, yOffset + (_btnDeletes[0].Top - _picItems[0].Top)), Size = _btnDeletes[0].Size, Font = _btnDeletes[0].Font, BackColor = _btnDeletes[0].BackColor, ForeColor = _btnDeletes[0].ForeColor, FlatStyle = _btnDeletes[0].FlatStyle, Text = "🗑️", Cursor = Cursors.Hand };
                _btnDeletes[i].FlatAppearance.BorderSize = 1;
                _btnDeletes[i].FlatAppearance.BorderColor = Color.LightGray;

                int capturedIndex = i;
                _btnMinuses[i].Click += (s, e) => ModifyRowQty(capturedIndex, -1);
                _btnPluses[i].Click += (s, e) => ModifyRowQty(capturedIndex, 1);
                _btnDeletes[i].Click += (s, e) => DeleteRowItem(capturedIndex);

                _pnlScroll.Controls.Add(_picItems[i]);
                _pnlScroll.Controls.Add(_lblNames[i]);
                _pnlScroll.Controls.Add(_lblPrices[i]);
                _pnlScroll.Controls.Add(_btnMinuses[i]);
                _pnlScroll.Controls.Add(_lblQtys[i]);
                _pnlScroll.Controls.Add(_btnPluses[i]);
                _pnlScroll.Controls.Add(_lblSubs[i]);
                _pnlScroll.Controls.Add(_btnDeletes[i]);
            }
        }

        private void DisplayCheckoutItems()
        {
            var order = KioskSession.CurrentOrder;
            lblReviewTitle.Text = $"Review Items ({order.Items.Count})";

            EnsureCapacity(order.Items.Count);

            for (int i = 0; i < _picItems.Length; i++)
            {
                if (i < order.Items.Count)
                {
                    var oi = order.Items[i];
                    _lblNames[i].Text = oi.Item.Name;
                    _lblPrices[i].Text = $"₱{oi.Item.Price:F2}";
                    _lblPrices[i].Visible = true;
                    _lblQtys[i].Text = oi.Quantity.ToString();
                    _lblSubs[i].Text = $"₱{oi.LineTotal:F2}";

                    try
                    {
                        var img = GetImageForItem(oi.Item.Id);
                        if (img != null)
                        {
                            _picItems[i].Image = img;
                        }
                    }
                    catch { }

                    _picItems[i].Visible = true;
                    _lblNames[i].Visible = true;
                    _lblPrices[i].Visible = true;
                    _btnMinuses[i].Visible = true;
                    _lblQtys[i].Visible = true;
                    _btnPluses[i].Visible = true;
                    _lblSubs[i].Visible = true;
                    _btnDeletes[i].Visible = true;
                }
                else
                {
                    _picItems[i].Visible = false;
                    _lblNames[i].Visible = false;
                    _lblPrices[i].Visible = false;
                    _btnMinuses[i].Visible = false;
                    _lblQtys[i].Visible = false;
                    _btnPluses[i].Visible = false;
                    _lblSubs[i].Visible = false;
                    _btnDeletes[i].Visible = false;
                }
            }

            RecalculateTotals();
        }

        private void RecalculateTotals()
        {
            var order = KioskSession.CurrentOrder;

            DiscountType selectedType = DiscountType.None;
            if (rbtnPWDSenior.Checked) selectedType = DiscountType.PWDSenior;

            order.ApplyDiscount(selectedType);

            decimal subtotal = order.CalculateSubtotal();
            decimal discount = order.DiscountAmount;
            decimal total = order.GetTotal();

            lblCOSubtotalAmt.Text = $"Subtotal:                                                   ₱{subtotal:F2}";
            lblCODiscountAmt.Text = $"Discount ({selectedType}):                                 -₱{discount:F2}";
            lblCOTotalAmt.Text = $"TOTAL: ₱{total:F2}";

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

        private void BtnCOPlus1_Click(object sender, EventArgs e) => ModifyRowQty(0, 1);
        private void BtnCOMinus1_Click(object sender, EventArgs e) => ModifyRowQty(0, -1);
        private void BtnCODelete1_Click(object sender, EventArgs e) => DeleteRowItem(0);

        private void BtnCOPlus2_Click(object sender, EventArgs e) => ModifyRowQty(1, 1);
        private void BtnCOMinus2_Click(object sender, EventArgs e) => ModifyRowQty(1, -1);
        private void BtnCODelete2_Click(object sender, EventArgs e) => DeleteRowItem(1);

        private void BtnCOPlus3_Click(object sender, EventArgs e) => ModifyRowQty(2, 1);
        private void BtnCOMinus3_Click(object sender, EventArgs e) => ModifyRowQty(2, -1);
        private void BtnCODelete3_Click(object sender, EventArgs e) => DeleteRowItem(2);

        private void BtnCOPlus4_Click(object sender, EventArgs e) => ModifyRowQty(3, 1);
        private void BtnCOMinus4_Click(object sender, EventArgs e) => ModifyRowQty(3, -1);
        private void BtnCODelete4_Click(object sender, EventArgs e) => DeleteRowItem(3);

        private void BtnCOPlus5_Click(object sender, EventArgs e) => ModifyRowQty(4, 1);
        private void BtnCOMinus5_Click(object sender, EventArgs e) => ModifyRowQty(4, -1);
        private void BtnCODelete5_Click(object sender, EventArgs e) => DeleteRowItem(4);

        private void BtnCOPlus6_Click(object sender, EventArgs e) => ModifyRowQty(5, 1);
        private void BtnCOMinus6_Click(object sender, EventArgs e) => ModifyRowQty(5, -1);
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

        private Image? GetImageForItem(int itemId)
        {
            return itemId switch
            {
                1 => Properties.Resources.images__2_,
                2 => Properties.Resources._2_PCS__CHICKEN_MEAL,
                3 => Properties.Resources.Gemini_Generated_Image_brmlarbrmlarbrml,
                18 => Properties.Resources.SIZZLING_BURGER_STEAK,
                4 => Properties.Resources._19356_spaghetti_italian_VAT_Beauty_4x3_af05b7565e014c16b1c5f86d45a18738,
                5 => Properties.Resources.images__1_,
                6 => Properties.Resources._25473_the_perfect_basic_burger_DDMFS_4x3_56eaba3833fd4a26a82755bcd0be0c54,
                8 => Properties.Resources.images,
                9 => Properties.Resources.images__3_,
                11 => Properties.Resources.peach_mango_pie,
                13 => Properties.Resources.Gemini_Generated_Image_8fqos98fqos98fqo,
                15 => Properties.Resources.Gemini_Generated_Image_fj4lthfj4lthfj4l,
                _ => null
            };
        }

        private void picCOItem1_Click(object sender, EventArgs e)
        {

        }
}
}


