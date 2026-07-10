using System;
using System.Windows.Forms;

namespace JollibeeKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStartOrder_Click(object sender, EventArgs e)
        {
            KioskSession.StartNewOrder();
            new FormOrderType(this).Show();
            this.Hide();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
        }
    }
}
