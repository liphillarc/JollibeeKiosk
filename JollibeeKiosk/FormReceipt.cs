namespace JollibeeKiosk
{
    public partial class FormReceipt : Form
    {
        private readonly Form _opener;

        public FormReceipt(Form opener)
        {
            _opener = opener;
            InitializeComponent();
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            rtbReceipt.Text = ReceiptService.GenerateReceipt(KioskSession.CurrentOrder);
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
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
