// ============================================================
//  FormDiscount.cs  —  Screen 5: DISCOUNT SELECTION
//  Owner: Leader (Member 3)
//  (Member 2 implements ApplyDiscount in Order.cs)
//
//  HOW THIS SCREEN WORKS:
//    Three RadioButtons let the customer pick their discount type.
//    Every time the selection changes, the totals are recalculated
//    LIVE so the customer can see the discount amount before confirming.
//
//  KEY CONCEPT — RADIO BUTTONS:
//    All three RadioButtons (rbtnNoDiscount, rbtnSeniorCitizen, rbtnPWD)
//    share the same CheckedChanged event handler.
//    Whenever any of them changes, RefreshDiscountTotals() is called.
//
//  KEY CONCEPT — LIVE PREVIEW vs CONFIRMING:
//    RefreshDiscountTotals() → PREVIEWS the discount (called on every change).
//    BtnConfirmOrder_Click   → FINALIZES the discount in the Order object.
//
//  NAVIGATION:
//    BACK           → shows opener (FormCheckout), closes this
//    CONFIRM ORDER  → finalizes discount, opens FormReceipt
// ============================================================
namespace JollibeeKiosk
{
    /// <summary>
    /// Screen 5 — PWD / Senior Citizen discount selection.
    /// Shows a live preview of the discount before the customer confirms.
    /// </summary>
    public partial class FormDiscount : Form
    {
        private readonly Form _opener;

        public FormDiscount(Form opener)
        {
            _opener = opener;
            InitializeComponent();
        }

        // ── Form Load ────────────────────────────────────────────────────

        private void FormDiscount_Load(object sender, EventArgs e)
        {
            rbtnNoDiscount.Checked = true;  // Default: no discount selected
            RefreshDiscountTotals();
        }

        // ── Discount Preview Logic ────────────────────────────────────────

        /// <summary>
        /// Updates lblDCSubtotal, lblDCDiscount, lblDCTotal every time
        /// the customer changes the radio button selection.
        ///
        /// Calls KioskSession.CurrentOrder.ApplyDiscount() — Member 2 implements
        /// the actual 15% logic inside Order.cs.
        /// </summary>
        private void RefreshDiscountTotals()
        {
            DiscountType selected = GetSelectedDiscount();

            decimal subtotal    = KioskSession.CurrentOrder.CalculateSubtotal();
            decimal discountAmt = KioskSession.CurrentOrder.ApplyDiscount(selected); // Member 2
            decimal total       = subtotal - discountAmt;

            lblDCSubtotal.Text = $"Subtotal:        ₱{subtotal,10:F2}";
            lblDCDiscount.Text = $"Discount ({(selected == DiscountType.None ? "None" : "15%")}):   -₱{discountAmt,9:F2}";
            lblDCTotal.Text    = $"TOTAL:           ₱{total,10:F2}";

            lblDiscountPreview.Text = selected == DiscountType.None
                ? "No discount will be applied."
                : $"15% {selected} discount will be applied to your order.";
        }

        /// <summary>
        /// Reads which RadioButton is checked and returns the matching DiscountType.
        /// </summary>
        private DiscountType GetSelectedDiscount()
        {
            if (rbtnSeniorCitizen.Checked) return DiscountType.SeniorCitizen;
            if (rbtnPWD.Checked)           return DiscountType.PWD;
            return DiscountType.None;
        }

        // ── Button / Radio Events ─────────────────────────────────────────

        /// <summary>
        /// Shared event handler for all three RadioButtons.
        /// Triggered whenever the customer switches from one option to another.
        /// </summary>
        private void DiscountOption_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDiscountTotals();   // Recalculate and update the labels live
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _opener.Show();
            this.Close();
        }

        private void BtnConfirmOrder_Click(object sender, EventArgs e)
        {
            // FINALIZE: write the chosen discount permanently into the Order object
            KioskSession.CurrentOrder.ApplyDiscount(GetSelectedDiscount());

            new FormReceipt(this).Show();
            this.Hide();
        }
    }
}
