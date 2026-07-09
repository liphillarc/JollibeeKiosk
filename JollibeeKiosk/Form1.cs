// ============================================================
//  Form1.cs  —  Screen 1: WELCOME
//  Owner: Leader (Member 3)
//
//  HOW THIS SCREEN WORKS:
//    This is the very first screen the customer sees when they
//    walk up to the kiosk. It shows the Jollibee branding and a
//    big "TAP TO ORDER" button.
//
//  NAVIGATION:
//    TAP TO ORDER → hides this form → opens FormOrderType
// ============================================================
namespace JollibeeKiosk
{
    /// <summary>
    /// Screen 1 — Welcome / Splash Screen.
    /// Shows Jollibee branding and the "Tap to Order" button.
    /// </summary>
    public partial class Form1 : Form
    {
        // ── Constructor ──────────────────────────────────────────────────
        public Form1()
        {
            // InitializeComponent() reads Form1.Designer.cs and builds
            // all the buttons and labels defined there.
            InitializeComponent();
        }

        // ── Button Events ────────────────────────────────────────────────

        /// <summary>
        /// Called when the customer taps "TAP TO ORDER".
        ///
        /// WHAT EACH LINE DOES:
        ///   1. KioskSession.StartNewOrder() → clears any old order data
        ///   2. new FormOrderType(this).Show() → opens the Order Type screen,
        ///      passing "this" (Form1) so FormOrderType knows who to show when
        ///      the customer presses Back.
        ///   3. this.Hide() → hides Form1 (does NOT close it — we need it
        ///      alive so "Start New Order" on the receipt can show it again).
        /// </summary>
        private void BtnStartOrder_Click(object sender, EventArgs e)
        {
            KioskSession.StartNewOrder();          // 1. Fresh order
            new FormOrderType(this).Show();        // 2. Open next screen
            this.Hide();                           // 3. Hide (not close) this screen
        }
    }
}
