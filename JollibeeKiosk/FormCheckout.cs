// ============================================================
//  FormCheckout.cs  —  Screen 4: CART / CHECKOUT
//  Owner: Leader (Member 3)
//
//  HOW THIS SCREEN WORKS:
//    Shows the customer everything in their cart using a ListView.
//    A ListView is a table-like control with columns (Item, Price, Qty, Total).
//    The data comes from KioskSession.CurrentOrder.Items (Member 2's Order class).
//
//  KEY CONCEPT — LISTVIEW:
//    A ListView in View.Details mode looks like a spreadsheet.
//    Each row is a ListViewItem. Sub-columns are SubItems.
//    We add rows in a loop: for each OrderItem → create a ListViewItem row.
//
//  NAVIGATION:
//    BACK              → shows opener (FormMenu), closes this
//    APPLY DISCOUNT →  → opens FormDiscount
// ============================================================
namespace JollibeeKiosk
{
    /// <summary>
    /// Screen 4 — Checkout: shows cart contents, subtotal, and discount button.
    /// </summary>
    public partial class FormCheckout : Form
    {
        private readonly Form _opener;

        public FormCheckout(Form opener)
        {
            _opener = opener;
            InitializeComponent();
        }

        // ── Form Load ────────────────────────────────────────────────────

        /// <summary>
        /// Loads the cart data into the ListView when the form opens.
        /// Reads from KioskSession.CurrentOrder.Items (Order class — Member 2).
        /// </summary>
        private void FormCheckout_Load(object sender, EventArgs e)
        {
            LoadCartIntoListView();
        }

        // ── Screen Loading ────────────────────────────────────────────────

        /// <summary>
        /// Populates lvwCart (the table) with the customer's order items.
        ///
        /// HOW IT WORKS:
        ///   - Loop through KioskSession.CurrentOrder.Items
        ///   - For each OrderItem: create a ListViewItem row with 4 columns:
        ///       Col 0: item name
        ///       Col 1: unit price (₱xx.xx)
        ///       Col 2: quantity
        ///       Col 3: line total (price × qty)
        ///   - Add the row to lvwCart.Items
        /// </summary>
        private void LoadCartIntoListView()
        {
            lvwCart.Items.Clear();   // Remove any old rows first

            foreach (OrderItem oi in KioskSession.CurrentOrder.Items)
            {
                // Column 0 — item name (first parameter of ListViewItem)
                var row = new ListViewItem(oi.Item.Name);

                // Columns 1, 2, 3 — added as SubItems
                row.SubItems.Add($"₱{oi.Item.Price:F2}");
                row.SubItems.Add(oi.Quantity.ToString());
                row.SubItems.Add($"₱{oi.LineTotal:F2}");

                lvwCart.Items.Add(row);
            }

            // Update the subtotal label at the bottom
            decimal subtotal     = KioskSession.CurrentOrder.CalculateSubtotal();
            lblCOSubtotal.Text   = $"Subtotal:   ₱{subtotal:F2}";
        }

        // ── Button Events ────────────────────────────────────────────────

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _opener.Show();
            this.Close();
        }

        private void BtnApplyDiscount_Click(object sender, EventArgs e)
        {
            new FormDiscount(this).Show();
            this.Hide();
        }
    }
}
