using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using JollibeeKiosk.Services;

namespace JollibeeKiosk
{
    public partial class FormReceipt : Form
    {
        private readonly Form _opener;

        private Panel? panelConfirmation;
        private Label? lblThankYou;
        private Label? lblPreparing;
        private Label? lblOrderNoText;
        private Label? lblOrderNoValue;
        private Label? lblTakeReceipt;
        private Label? lblCountdown;

        private System.Windows.Forms.Timer? timerCountdown;
        private int _secondsRemaining = 10;
        private string _orderNumber = "#1";

        public FormReceipt(Form opener)
        {
            _opener = opener;
            InitializeComponent();
            
            // Insert order into DB and get the real sequential ID
            long receiptId = DatabaseService.InsertOrder(KioskSession.CurrentOrder);
            
            // Update UI elements from designer if they exist
            if (this.Controls.ContainsKey("lblOrderNoValue"))
            {
                this.Controls["lblOrderNoValue"].Text = $"#{receiptId}";
            }

            // Populate the RichTextBox
            if (rtbReceipt != null)
            {
                rtbReceipt.ReadOnly = false;
                string receiptString = ReceiptService.GenerateReceipt(KioskSession.CurrentOrder);
                receiptString = $"ORDER NUMBER: #{receiptId}\n" + receiptString;
                rtbReceipt.Text = receiptString;
            }
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            timerCountdown?.Stop();
            timerCountdown?.Dispose();

            KioskSession.StartNewOrder();

            var welcome = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            welcome?.Show();

            var formsToClose = Application.OpenForms
                .Cast<Form>()
                .Where(f => f is not Form1)
                .ToList();

            foreach (var f in formsToClose)
                f.Close();
        }
    }
}
