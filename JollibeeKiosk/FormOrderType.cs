// ============================================================
//  FormOrderType.cs  —  Screen 2: DINE IN / TAKE OUT
//  Owner: Leader (Member 3)
//
//  HOW THIS SCREEN WORKS:
//    The customer chooses whether they will eat inside or take
//    the food home. Their choice is saved in KioskSession so
//    every other form can read it.
//
//  KEY CONCEPT — THE OPENER PATTERN:
//    Every form receives a "Form opener" in its constructor.
//    The opener is the form that opened this one. This allows
//    the Back button to show the correct previous screen.
//
//    Example: Form1 opens FormOrderType → Form1 is the opener.
//             FormOrderType Back button → shows Form1, closes itself.
//
//  NAVIGATION:
//    DINE IN  button → saves DineIn,  hides this, opens FormMenu
//    TAKE OUT button → saves TakeOut, hides this, opens FormMenu
//    BACK     button → shows opener (Form1), closes this
// ============================================================
namespace JollibeeKiosk
{
    /// <summary>
    /// Screen 2 — Lets the customer choose Dine In or Take Out.
    /// </summary>
    public partial class FormOrderType : Form
    {
        // ── Private field ────────────────────────────────────────────────
        /// <summary>
        /// The form that opened this one (Form1 / Welcome screen).
        /// Stored so the Back button can show it again.
        /// </summary>
        private readonly Form _opener;

        // ── Constructor ──────────────────────────────────────────────────
        /// <summary>
        /// Creates the Order Type screen.
        /// </summary>
        /// <param name="opener">
        ///   The form that navigated here (Form1).
        ///   Passed in so we can show it again when the customer presses Back.
        /// </param>
        public FormOrderType(Form opener)
        {
            _opener = opener;          // Save the reference for later (Back button)
            InitializeComponent();     // Build UI from FormOrderType.Designer.cs
        }

        // ── Button Events ────────────────────────────────────────────────

        /// <summary>
        /// Customer chose DINE IN.
        ///   1. Save the choice to the shared order.
        ///   2. Open the Menu screen, passing "this" as the opener.
        ///   3. Hide this form.
        /// </summary>
        private void BtnDineIn_Click(object sender, EventArgs e)
        {
            KioskSession.CurrentOrder.OrderType = OrderType.DineIn;  // 1. Save choice
            new FormMenu(this).Show();                                 // 2. Open Menu
            this.Hide();                                               // 3. Hide this
        }

        /// <summary>
        /// Customer chose TAKE OUT.
        /// Same logic as Dine In but saves TakeOut.
        /// </summary>
        private void BtnTakeOut_Click(object sender, EventArgs e)
        {
            KioskSession.CurrentOrder.OrderType = OrderType.TakeOut;
            new FormMenu(this).Show();
            this.Hide();
        }

        /// <summary>
        /// Customer pressed Back.
        ///   1. Show the opener form (Form1/Welcome).
        ///   2. Close (destroy) this form — no longer needed.
        /// </summary>
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _opener.Show();   // 1. Show the form that opened this one
            this.Close();     // 2. Close and free memory for this form
        }
    }
}
