// ============================================================
//  FormReceipt.cs  —  Screen 6: RECEIPT
//  Owner: Leader (Member 3)
//  (Member 2 formats the receipt text in ReceiptService.cs)
//
//  HOW THIS SCREEN WORKS:
//    Calls ReceiptService.GenerateReceipt(order) to get a
//    formatted receipt string, then puts it in a RichTextBox
//    so the customer can read it on screen.
//
//    RichTextBox is ideal for receipts because:
//      - It scrolls automatically if the text is long.
//      - It uses monospaced font (Courier New) for alignment.
//      - It is read-only (customer can't type in it).
//
//  KEY CONCEPT — "START NEW ORDER":
//    When the customer clicks "Start New Order", we need to:
//      1. Reset KioskSession for the next customer.
//      2. Find Form1 (which was hidden, not closed) and show it again.
//      3. Close ALL other forms in the chain (this form + all hidden forms).
//
//    Application.OpenForms — a list of ALL currently open/hidden forms.
//    We loop through it to find and close all non-Form1 forms.
// ============================================================
namespace JollibeeKiosk
{
    /// <summary>
    /// Screen 6 — Receipt: displays the formatted order receipt.
    /// </summary>
    public partial class FormReceipt : Form
    {
        private readonly Form _opener;

        public FormReceipt(Form opener)
        {
            _opener = opener;
            InitializeComponent();
        }

        // ── Form Load ────────────────────────────────────────────────────

        /// <summary>
        /// Generates the receipt text when the form opens.
        /// Calls Member 2's ReceiptService.GenerateReceipt().
        /// </summary>
        private void FormReceipt_Load(object sender, EventArgs e)
        {
            rtbReceipt.Text = ReceiptService.GenerateReceipt(KioskSession.CurrentOrder);
        }

        // ── Button Events ────────────────────────────────────────────────

        /// <summary>
        /// "START NEW ORDER" — resets everything and goes back to welcome screen.
        ///
        /// HOW IT WORKS:
        ///   1. StartNewOrder() clears the KioskSession.CurrentOrder.
        ///   2. Find Form1 in Application.OpenForms (it was hidden, not closed).
        ///   3. Show Form1.
        ///   4. Close ALL other forms (FormOrderType, FormMenu, FormCheckout,
        ///      FormDiscount, and this FormReceipt).
        ///   This leaves only Form1 open and visible — clean slate.
        /// </summary>
        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            KioskSession.StartNewOrder();   // 1. Reset the order for next customer

            // 2. Find Form1 in the list of all open forms
            //    Application.OpenForms contains ALL forms that were shown
            //    but NOT yet closed (hidden forms are still here).
            var welcome = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            welcome?.Show();                // 3. Show the welcome screen again

            // 4. Build a list of all forms that are NOT Form1
            //    We must call ToList() first to avoid "collection modified" errors
            //    when closing forms inside the foreach loop.
            var formsToClose = Application.OpenForms
                .Cast<Form>()
                .Where(f => f is not Form1)
                .ToList();

            foreach (var f in formsToClose)
                f.Close();   // Close each one — FormOrderType, FormMenu, etc.
        }
    }
}
