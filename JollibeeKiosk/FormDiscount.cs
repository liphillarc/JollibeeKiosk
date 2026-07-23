using System;
using System.Windows.Forms;

namespace JollibeeKiosk
{
    public partial class FormDiscount : Form
    {
        private readonly Form _opener;

        public FormDiscount(Form opener)
        {
            _opener = opener;
            InitializeComponent();
        }

        private void FormDiscount_Load(object sender, EventArgs e)
        {
            rbtnNoDiscount.Checked = true;
            RefreshDiscountTotals();
        }

        private void RefreshDiscountTotals()
        {
            DiscountType selected = GetSelectedDiscount();

            decimal subtotal    = KioskSession.CurrentOrder.CalculateSubtotal();
            decimal discountAmt = KioskSession.CurrentOrder.ApplyDiscount(selected);
            decimal total       = subtotal - discountAmt;

            lblDCSubtotal.Text = $"Subtotal:        ₱{subtotal,10:F2}";
            lblDCDiscount.Text = $"Discount ({(selected == DiscountType.None ? "None" : "20%")}):   -₱{discountAmt,9:F2}";
            lblDCTotal.Text    = $"TOTAL:           ₱{total,10:F2}";

            lblDiscountPreview.Text = selected == DiscountType.None
                ? "No discount will be applied."
                : $"20% {selected} discount will be applied to your order.";
        }

        private DiscountType GetSelectedDiscount()
        {
            if (rbtnPWDSenior.Checked) return DiscountType.PWDSenior;
            return DiscountType.None;
        }

        private void DiscountOption_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDiscountTotals();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _opener.Show();
            this.Close();
        }

        private void BtnConfirmOrder_Click(object sender, EventArgs e)
        {
            KioskSession.CurrentOrder.ApplyDiscount(GetSelectedDiscount());
            new FormReceipt(this).Show();
            this.Hide();
        }
}
}


