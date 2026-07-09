// ============================================================
//  FormMenu.cs  —  Screen 3: FOOD MENU
//  Owner: Leader (Member 3)
//  (Member 1 fills in MenuRepository with real Jollibee data)
//
//  HOW THIS SCREEN WORKS:
//    When the form LOADS, it reads the menu from MenuRepository
//    and builds a "card" for each item inside a FlowLayoutPanel.
//    Each card has the item name, price, and +/– quantity buttons.
//
//  KEY CONCEPT — DYNAMIC UI CREATION:
//    Instead of designing each food card manually in the Designer,
//    we BUILD them in code (CreateMenuItemCard method). This is
//    because the number of items can change — we don't hard-code
//    one button per menu item.
//
//  KEY CONCEPT — _uiQuantities DICTIONARY:
//    A Dictionary<int, int> maps: MenuItem.Id → quantity on screen.
//    This is how the number label on each card stays correct.
//    When + is clicked: quantity++ in the dictionary AND in the Order.
//    When – is clicked: quantity-- in the dictionary AND in the Order.
//
//  NAVIGATION:
//    BACK button → shows opener (FormOrderType), closes this
//    VIEW CART → validates cart is not empty → opens FormCheckout
// ============================================================
using System.Drawing;

namespace JollibeeKiosk
{
    /// <summary>
    /// Screen 3 — Displays the full Jollibee menu with +/– quantity buttons.
    /// Dynamically builds food cards in a FlowLayoutPanel.
    /// </summary>
    public partial class FormMenu : Form
    {
        // ── Fields ───────────────────────────────────────────────────────
        private readonly Form _opener;

        /// <summary>
        /// Tracks how many of each item the customer has added to the cart.
        /// Key = MenuItem.Id, Value = quantity selected on this screen.
        /// </summary>
        private readonly Dictionary<int, int> _uiQuantities = new();

        // ── Constructor ──────────────────────────────────────────────────
        public FormMenu(Form opener)
        {
            _opener = opener;
            InitializeComponent();
        }

        // ── Form Load ────────────────────────────────────────────────────

        /// <summary>
        /// Runs automatically when the form first opens.
        /// Loads menu items from MenuRepository and builds the card grid.
        /// </summary>
        private void FormMenu_Load(object sender, EventArgs e)
        {
            LoadMenuCards();
        }

        // ── Screen Loading ────────────────────────────────────────────────

        /// <summary>
        /// Populates flpMenuItems with one card per menu item.
        /// Calls MenuRepository.GetAll() — Member 1 provides the real data there.
        /// </summary>
        private void LoadMenuCards()
        {
            // Update the header label to show the order type chosen in Screen 2
            lblMenuOrderType.Text = KioskSession.CurrentOrder.OrderType == OrderType.DineIn
                ? "🍽️  Dine In"
                : "🥡  Take Out";

            // Clear any existing cards (in case form is shown again after being hidden)
            flpMenuItems.Controls.Clear();

            // Ask Member 1's MenuRepository for all menu items
            List<MenuItem> allItems = MenuRepository.GetAll();

            // Build one card panel per item and add to the FlowLayoutPanel
            foreach (MenuItem item in allItems)
            {
                Panel card = CreateMenuItemCard(item);
                flpMenuItems.Controls.Add(card);
            }

            RefreshCartFooter();
        }

        // ── Card Builder ─────────────────────────────────────────────────

        /// <summary>
        /// Builds a single food item card as a Panel control.
        /// The card contains: category badge, item name, price, and +/– buttons.
        /// This method is called once per menu item during LoadMenuCards().
        /// </summary>
        private Panel CreateMenuItemCard(MenuItem item)
        {
            const int CardWidth  = 222;
            const int CardHeight = 185;

            // The card itself is just a Panel with a white background
            var card = new Panel
            {
                Size      = new Size(CardWidth, CardHeight),
                BackColor = Color.White,
                Margin    = new Padding(7),
                Tag       = item.Id   // Store the ID so we can identify this card later
            };

            // Draw a light gray border around the card every time it paints
            card.Paint += (_, e) =>
            {
                using var borderPen = new Pen(Color.FromArgb(210, 210, 210), 1);
                e.Graphics.DrawRectangle(borderPen, 0, 0, CardWidth - 1, CardHeight - 1);
            };

            // ── Category Banner (red strip at the top of the card) ───────
            var categoryBanner = new Panel
            {
                Size      = new Size(CardWidth, 22),
                Location  = new Point(0, 0),
                BackColor = Color.FromArgb(218, 41, 28)
            };
            var lblCategory = new Label
            {
                Text      = item.Category,
                Font      = new Font("Segoe UI", 7.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 210, 200),
                AutoSize  = false,
                Size      = new Size(CardWidth, 22),
                TextAlign = ContentAlignment.MiddleCenter
            };
            categoryBanner.Controls.Add(lblCategory);

            // ── Item Name ────────────────────────────────────────────────
            var lblName = new Label
            {
                Text      = item.Name,
                Font      = new Font("Segoe UI", 10f, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 40, 40),
                AutoSize  = false,
                Size      = new Size(CardWidth - 10, 50),
                Location  = new Point(5, 27),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ── Price (red, bold) ─────────────────────────────────────────
            var lblPrice = new Label
            {
                Text      = $"₱{item.Price:F2}",
                Font      = new Font("Segoe UI", 14f, FontStyle.Bold),
                ForeColor = Color.FromArgb(218, 41, 28),
                AutoSize  = false,
                Size      = new Size(CardWidth, 32),
                Location  = new Point(0, 80),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ── Quantity Label — shows how many are in the cart ──────────
            // Read initial value from _uiQuantities (0 if not yet added)
            int currentQty = _uiQuantities.GetValueOrDefault(item.Id, 0);
            var lblQty = new Label
            {
                Name      = $"lblQty_{item.Id}",  // Unique name for later lookup
                Text      = currentQty.ToString(),
                Font      = new Font("Segoe UI", 13f, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 40, 40),
                AutoSize  = false,
                Size      = new Size(52, 42),
                Location  = new Point(85, 125),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ── Minus Button (−) ─────────────────────────────────────────
            var btnMinus = BuildQtyButton("−", new Point(30, 125));
            btnMinus.Click += (_, _) =>
            {
                // Only decrease if quantity is greater than 0
                if (_uiQuantities.GetValueOrDefault(item.Id, 0) <= 0) return;

                _uiQuantities[item.Id]--;                         // Update UI tracker
                KioskSession.CurrentOrder.RemoveItem(item.Id);    // Update Order (Member 2)
                lblQty.Text = _uiQuantities[item.Id].ToString();  // Refresh label
                RefreshCartFooter();
            };

            // ── Plus Button (+) ───────────────────────────────────────────
            var btnPlus = BuildQtyButton("+", new Point(140, 125));
            btnPlus.Click += (_, _) =>
            {
                _uiQuantities.TryAdd(item.Id, 0);                 // Initialize if first time
                _uiQuantities[item.Id]++;                         // Update UI tracker
                KioskSession.CurrentOrder.AddItem(item, 1);       // Update Order (Member 2)
                lblQty.Text = _uiQuantities[item.Id].ToString();  // Refresh label
                RefreshCartFooter();
            };

            // ── Assemble the card ─────────────────────────────────────────
            card.Controls.Add(categoryBanner);
            card.Controls.Add(lblName);
            card.Controls.Add(lblPrice);
            card.Controls.Add(lblQty);
            card.Controls.Add(btnMinus);
            card.Controls.Add(btnPlus);

            return card;
        }

        /// <summary>
        /// Helper: creates a small red +/– button for the food cards.
        /// </summary>
        private static Button BuildQtyButton(string symbol, Point position)
        {
            var btn = new Button
            {
                Text      = symbol,
                Font      = new Font("Segoe UI", 14f, FontStyle.Bold),
                BackColor = Color.FromArgb(218, 41, 28),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size      = new Size(42, 42),
                Location  = position,
                Cursor    = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }

        // ── Footer Refresh ───────────────────────────────────────────────

        /// <summary>
        /// Updates the bottom footer bar with total item count and subtotal.
        /// Called every time a + or – button is clicked.
        /// </summary>
        private void RefreshCartFooter()
        {
            int     totalItems = _uiQuantities.Values.Sum();
            decimal subtotal   = KioskSession.CurrentOrder.CalculateSubtotal(); // Member 2
            lblCartInfo.Text   = $"{totalItems} item(s)   |   ₱{subtotal:F2}";
        }

        // ── Button Events ────────────────────────────────────────────────

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _opener.Show();
            this.Close();
        }

        private void BtnViewCart_Click(object sender, EventArgs e)
        {
            // Input validation — do not allow empty cart
            if (KioskSession.CurrentOrder.Items.Count == 0)
            {
                MessageBox.Show(
                    "Your cart is empty.\nPlease add at least one item before proceeding.",
                    "Empty Cart",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            new FormCheckout(this).Show();
            this.Hide();
        }
    }
}
