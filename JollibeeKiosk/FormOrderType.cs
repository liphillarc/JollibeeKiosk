namespace JollibeeKiosk
{
    public partial class FormOrderType : Form
    {
        private readonly Form _opener;

        public FormOrderType(Form opener)
        {
            _opener = opener;
            InitializeComponent();
        }

        private void BtnDineIn_Click(object sender, EventArgs e)
        {
            KioskSession.CurrentOrder.OrderType = OrderType.DineIn;
            new FormMenu(this).Show();
            this.Hide();
        }

        private void BtnTakeOut_Click(object sender, EventArgs e)
        {
            KioskSession.CurrentOrder.OrderType = OrderType.TakeOut;
            new FormMenu(this).Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _opener.Show();
            this.Close();
        }
}
}


