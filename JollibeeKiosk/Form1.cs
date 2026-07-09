// ============================================================
//  Form1.cs
//  ╔══════════════════════════════════════════════════════╗
//  ║  OWNER: Leader (Member 3) — System Integrator        ║
//  ╚══════════════════════════════════════════════════════╝
//
//  This file drives the 6-screen kiosk state machine and
//  wires together the work of Member 1 and Member 2.
//
//  SCREEN FLOW:
//    Welcome → OrderType → Menu → Checkout → Discount → Receipt
//
//  INTEGRATION POINTS:
//    • MenuRepository.GetAll()  ← Member 1 fills with real data
//    • Order.AddItem / RemoveItem / CalculateSubtotal / ApplyDiscount
//                               ← Member 2 implements the logic
//    • ReceiptService.GenerateReceipt() ← Member 2 formats the receipt
// ============================================================
using System.Drawing;

namespace JollibeeKiosk
{
    public partial class Form1 : Form
    {
        // ── State ────────────────────────────────────────────────────────
        private Order       _currentOrder    = new Order();
        private KioskState  _currentState    = KioskState.Welcome;

        /// <summary>
        /// Tracks the UI quantity shown on each menu card (keyed by MenuItem.Id).
        /// Stays in sync with Order.Items via AddItem / RemoveItem calls.
        /// </summary>
        private readonly Dictionary<int, int> _uiQuantities = new();

        // ── Constructor ──────────────────────────────────────────────────
        public Form1()
        {
            InitializeComponent();
            InitializeKiosk();
        }

        // ── Initialization ───────────────────────────────────────────────
        private void InitializeKiosk()
        {
            _currentOrder = new Order();
            NavigateTo(KioskState.Welcome);
        }

        // ================================================================
        //  NAVIGATION — State Machine (Leader's core responsibility)
        // ================================================================

        /// <summary>
        /// Hides all screen panels and shows only the target screen.
        /// Add any screen-specific setup calls inside the switch.
        /// </summary>
        private void NavigateTo(KioskState state)
        {
            // Hide every screen panel
            panelWelcome.Visible    = false;
            panelOrderType.Visible  = false;
            panelMenu.Visible       = false;
            panelCheckout.Visible   = false;
            panelDiscount.Visible   = false;
            panelReceipt.Visible    = false;

            _currentState = state;

            switch (state)
            {
                case KioskState.Welcome:
                    panelWelcome.Visible = true;
                    break;

                case KioskState.OrderType:
                    panelOrderType.Visible = true;
                    break;

                case KioskState.Menu:
                    LoadMenuPanel();
                    panelMenu.Visible = true;
                    break;

                case KioskState.Checkout:
                    LoadCheckoutPanel();
                    panelCheckout.Visible = true;
                    break;

                case KioskState.Discount:
                    LoadDiscountPanel();
                    panelDiscount.Visible = true;
                    break;

                case KioskState.Receipt:
                    LoadReceiptPanel();
                    panelReceipt.Visible = true;
                    break;
            }
        }

        // ================================================================
        //  SCREEN LOADERS
        // ================================================================

        // ── Screen 3: Menu ───────────────────────────────────────────────

        /// <summary>
        /// Populates the menu screen with a card for every item from
        /// MenuRepository.GetAll(). Member 1 fills in the real data there.
        /// </summary>
        private void LoadMenuPanel()
        {
            lblMenuOrderType.Text = _currentOrder.OrderType == OrderType.DineIn
                ? "🍽️  Dine In"
                : "🥡  Take Out";

            flpMenuItems.Controls.Clear();

            List<MenuItem> menuItems = MenuRepository.GetAll();

            foreach (MenuItem item in menuItems)
            {
                Panel card = CreateMenuItemCard(item);
                flpMenuItems.Controls.Add(card);
            }

            RefreshCartFooter();
        }

        /// <summary>
        /// Builds a single food card panel for the FlowLayoutPanel.
        /// The card shows the item name, price, category, and +/– quantity buttons.
        /// </summary>
        private Panel CreateMenuItemCard(MenuItem item)
        {
            const int W = 222;
            const int H = 185;

            var card = new Panel
            {
                Size      = new Size(W, H),
                BackColor = Color.White,
                Margin    = new Padding(7),
                Tag       = item.Id
            };

            // Draw a subtle border around the card on every paint
            card.Paint += (_, e) =>
            {
                using var pen = new Pen(Color.FromArgb(210, 210, 210), 1);
                e.Graphics.DrawRectangle(pen, 0, 0, W - 1, H - 1);
            };

            // ── Category badge (top band) ────────────────────────────────
            var pnlTop = new Panel
            {
                Size      = new Size(W, 22),
                Location  = new Point(0, 0),
                BackColor = Color.FromArgb(218, 41, 28)
            };
            var lblCat = new Label
            {
                Text      = item.Category,
                Font      = new Font("Segoe UI", 7.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 210, 200),
                AutoSize  = false,
                Size      = new Size(W, 22),
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlTop.Controls.Add(lblCat);

            // ── Item name ────────────────────────────────────────────────
            var lblName = new Label
            {
                Text      = item.Name,
                Font      = new Font("Segoe UI", 10f, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 40, 40),
                AutoSize  = false,
                Size      = new Size(W - 10, 50),
                Location  = new Point(5, 27),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ── Price ────────────────────────────────────────────────────
            var lblPrice = new Label
            {
                Text      = $"₱{item.Price:F2}",
                Font      = new Font("Segoe UI", 14f, FontStyle.Bold),
                ForeColor = Color.FromArgb(218, 41, 28),
                AutoSize  = false,
                Size      = new Size(W, 32),
                Location  = new Point(0, 80),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ── Quantity label ───────────────────────────────────────────
            int currentQty = _uiQuantities.GetValueOrDefault(item.Id, 0);
            var lblQty = new Label
            {
                Name      = $"lblQty_{item.Id}",
                Text      = currentQty.ToString(),
                Font      = new Font("Segoe UI", 13f, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 40, 40),
                AutoSize  = false,
                Size      = new Size(52, 42),
                Location  = new Point(85, 125),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ── Minus button ─────────────────────────────────────────────
            var btnMinus = CreateQtyButton("−", new Point(30, 125), item.Id);
            btnMinus.Click += (_, _) =>
            {
                if (_uiQuantities.GetValueOrDefault(item.Id, 0) <= 0) return;
                _uiQuantities[item.Id]--;
                _currentOrder.RemoveItem(item.Id);   // Member 2 implements
                lblQty.Text = _uiQuantities[item.Id].ToString();
                RefreshCartFooter();
            };

            // ── Plus button ──────────────────────────────────────────────
            var btnPlus = CreateQtyButton("+", new Point(140, 125), item.Id);
            btnPlus.Click += (_, _) =>
            {
                _uiQuantities.TryAdd(item.Id, 0);
                _uiQuantities[item.Id]++;
                _currentOrder.AddItem(item, 1);      // Member 2 implements
                lblQty.Text = _uiQuantities[item.Id].ToString();
                RefreshCartFooter();
            };

            card.Controls.Add(pnlTop);
            card.Controls.Add(lblName);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblQty);
            card.Controls.Add(btnMinus);
            card.Controls.Add(btnPlus);

            return card;
        }

        /// <summary>Creates a small red +/– quantity button.</summary>
        private static Button CreateQtyButton(string text, Point location, int tagId)
        {
            var btn = new Button
            {
                Text      = text,
                Font      = new Font("Segoe UI", 14f, FontStyle.Bold),
                BackColor = Color.FromArgb(218, 41, 28),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size      = new Size(42, 42),
                Location  = location,
                Cursor    = Cursors.Hand,
                Tag       = tagId
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        /// <summary>Updates the cart item count and subtotal in the menu footer.</summary>
        private void RefreshCartFooter()
        {
            int totalItems = _uiQuantities.Values.Sum();
            decimal subtotal = _currentOrder.CalculateSubtotal(); // Member 2
            lblCartInfo.Text = $"{totalItems} item(s)   |   ₱{subtotal:F2}";
        }

        // ── Screen 4: Checkout ───────────────────────────────────────────

        /// <summary>
        /// Populates the cart ListView from Order.Items.
        /// Uses Member 2's Order class for the data.
        /// </summary>
        private void LoadCheckoutPanel()
        {
            lvwCart.Items.Clear();

            foreach (OrderItem oi in _currentOrder.Items)
            {
                var row = new ListViewItem(oi.Item.Name);
                row.SubItems.Add($"₱{oi.Item.Price:F2}");
                row.SubItems.Add(oi.Quantity.ToString());
                row.SubItems.Add($"₱{oi.LineTotal:F2}");
                lvwCart.Items.Add(row);
            }

            decimal subtotal = _currentOrder.CalculateSubtotal();
            lblCOSubtotal.Text = $"Subtotal:   ₱{subtotal:F2}";
        }

        // ── Screen 5: Discount ───────────────────────────────────────────

        private void LoadDiscountPanel()
        {
            rbtnNoDiscount.Checked = true;
            RefreshDiscountTotals();
        }

        /// <summary>
        /// Re-calculates and displays the subtotal, discount, and total
        /// whenever the customer changes the discount radio button.
        /// Calls Order.ApplyDiscount() — Member 2 implements the 15% logic.
        /// </summary>
        private void RefreshDiscountTotals()
        {
            DiscountType selected = GetSelectedDiscount();

            decimal subtotal     = _currentOrder.CalculateSubtotal();
            decimal discountAmt  = _currentOrder.ApplyDiscount(selected); // Member 2
            decimal total        = subtotal - discountAmt;

            lblDCSubtotal.Text = $"Subtotal:        ₱{subtotal,10:F2}";
            lblDCDiscount.Text = $"Discount ({(selected == DiscountType.None ? "None" : "15%")}):   -₱{discountAmt,9:F2}";
            lblDCTotal.Text    = $"TOTAL:           ₱{total,10:F2}";

            lblDiscountPreview.Text = selected == DiscountType.None
                ? "No discount will be applied."
                : $"15% {selected} discount will be applied to your order.";
        }

        private DiscountType GetSelectedDiscount()
        {
            if (rbtnSeniorCitizen.Checked) return DiscountType.SeniorCitizen;
            if (rbtnPWD.Checked)           return DiscountType.PWD;
            return DiscountType.None;
        }

        // ── Screen 6: Receipt ────────────────────────────────────────────

        /// <summary>
        /// Generates and displays the receipt.
        /// Calls ReceiptService.GenerateReceipt() — Member 2 formats this.
        /// </summary>
        private void LoadReceiptPanel()
        {
            rtbReceipt.Text = ReceiptService.GenerateReceipt(_currentOrder);
        }

        // ================================================================
        //  BUTTON EVENT HANDLERS  (Leader wires all screens together)
        // ================================================================

        // ── Screen 1: Welcome ─────────────────────────────────────────────
        private void BtnStartOrder_Click(object sender, EventArgs e)
        {
            // Reset for a fresh order
            _currentOrder = new Order();
            _uiQuantities.Clear();
            NavigateTo(KioskState.OrderType);
        }

        // ── Screen 2: Order Type ──────────────────────────────────────────
        private void BtnDineIn_Click(object sender, EventArgs e)
        {
            _currentOrder.OrderType = OrderType.DineIn;
            NavigateTo(KioskState.Menu);
        }

        private void BtnTakeOut_Click(object sender, EventArgs e)
        {
            _currentOrder.OrderType = OrderType.TakeOut;
            NavigateTo(KioskState.Menu);
        }

        private void BtnOTBack_Click(object sender, EventArgs e) =>
            NavigateTo(KioskState.Welcome);

        // ── Screen 3: Menu ────────────────────────────────────────────────
        private void BtnMenuBack_Click(object sender, EventArgs e) =>
            NavigateTo(KioskState.OrderType);

        private void BtnViewCart_Click(object sender, EventArgs e)
        {
            // Input validation: cart must not be empty
            if (_currentOrder.Items.Count == 0)
            {
                MessageBox.Show(
                    "Your cart is empty.\nPlease add at least one item before proceeding.",
                    "Empty Cart",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            NavigateTo(KioskState.Checkout);
        }

        // ── Screen 4: Checkout ────────────────────────────────────────────
        private void BtnCOBack_Click(object sender, EventArgs e) =>
            NavigateTo(KioskState.Menu);

        private void BtnApplyDiscount_Click(object sender, EventArgs e) =>
            NavigateTo(KioskState.Discount);

        // ── Screen 5: Discount ────────────────────────────────────────────
        private void DiscountOption_CheckedChanged(object sender, EventArgs e) =>
            RefreshDiscountTotals();

        private void BtnDCBack_Click(object sender, EventArgs e) =>
            NavigateTo(KioskState.Checkout);

        private void BtnConfirmOrder_Click(object sender, EventArgs e)
        {
            // Finalise the selected discount in the Order object
            _currentOrder.ApplyDiscount(GetSelectedDiscount());
            NavigateTo(KioskState.Receipt);
        }

        // ── Screen 6: Receipt ─────────────────────────────────────────────
        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            _currentOrder = new Order();
            _uiQuantities.Clear();
            NavigateTo(KioskState.Welcome);
        }
    }
}
