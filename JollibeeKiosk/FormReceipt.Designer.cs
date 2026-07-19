namespace JollibeeKiosk
{
    partial class FormReceipt
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblBrandLogo = new Label();
            lblSuccessIcon = new Label();
            lblSuccessMsg = new Label();
            lblSuccessSub = new Label();
            lblReceiptHeader = new Label();
            rtbReceipt = new RichTextBox();
            btnNewOrder = new Button();
            SuspendLayout();
            // 
            // lblBrandLogo
            // 
            lblBrandLogo.BackColor = Color.FromArgb(218, 41, 28);
            lblBrandLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrandLogo.ForeColor = Color.White;
            lblBrandLogo.Location = new Point(0, 0);
            lblBrandLogo.Margin = new Padding(4, 0, 4, 0);
            lblBrandLogo.Name = "lblBrandLogo";
            lblBrandLogo.Size = new Size(1571, 100);
            lblBrandLogo.TabIndex = 0;
            lblBrandLogo.Text = "           🐝  HAPPYBEE RECEIPT";
            lblBrandLogo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuccessIcon
            // 
            lblSuccessIcon.Font = new Font("Segoe UI Emoji", 32F);
            lblSuccessIcon.Location = new Point(0, 117);
            lblSuccessIcon.Margin = new Padding(4, 0, 4, 0);
            lblSuccessIcon.Name = "lblSuccessIcon";
            lblSuccessIcon.Size = new Size(1571, 90);
            lblSuccessIcon.TabIndex = 1;
            lblSuccessIcon.Text = "✅";
            lblSuccessIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSuccessMsg
            // 
            lblSuccessMsg.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblSuccessMsg.ForeColor = Color.FromArgb(34, 139, 34);
            lblSuccessMsg.Location = new Point(0, 208);
            lblSuccessMsg.Margin = new Padding(4, 0, 4, 0);
            lblSuccessMsg.Name = "lblSuccessMsg";
            lblSuccessMsg.Size = new Size(1571, 73);
            lblSuccessMsg.TabIndex = 2;
            lblSuccessMsg.Text = "Order Confirmed!";
            lblSuccessMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSuccessSub
            // 
            lblSuccessSub.Font = new Font("Segoe UI", 11F);
            lblSuccessSub.ForeColor = Color.FromArgb(100, 100, 100);
            lblSuccessSub.Location = new Point(0, 283);
            lblSuccessSub.Margin = new Padding(4, 0, 4, 0);
            lblSuccessSub.Name = "lblSuccessSub";
            lblSuccessSub.Size = new Size(1571, 43);
            lblSuccessSub.TabIndex = 3;
            lblSuccessSub.Text = "Please take your receipt below. Your order number will be called when ready.";
            lblSuccessSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReceiptHeader
            // 
            lblReceiptHeader.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblReceiptHeader.ForeColor = Color.FromArgb(35, 35, 35);
            lblReceiptHeader.Location = new Point(664, 345);
            lblReceiptHeader.Margin = new Padding(4, 0, 4, 0);
            lblReceiptHeader.Name = "lblReceiptHeader";
            lblReceiptHeader.Size = new Size(243, 67);
            lblReceiptHeader.TabIndex = 4;
            lblReceiptHeader.Text = "📄  Order Receipt";
            lblReceiptHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rtbReceipt
            // 
            rtbReceipt.BackColor = Color.White;
            rtbReceipt.BorderStyle = BorderStyle.FixedSingle;
            rtbReceipt.Font = new Font("Courier New", 11F);
            rtbReceipt.Location = new Point(447, 417);
            rtbReceipt.Margin = new Padding(4, 5, 4, 5);
            rtbReceipt.Name = "rtbReceipt";
            rtbReceipt.ReadOnly = true;
            rtbReceipt.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbReceipt.Size = new Size(676, 631);
            rtbReceipt.TabIndex = 5;
            rtbReceipt.Text = "";
            // 
            // btnNewOrder
            // 
            btnNewOrder.BackColor = Color.FromArgb(218, 41, 28);
            btnNewOrder.Cursor = Cursors.Hand;
            btnNewOrder.FlatAppearance.BorderSize = 0;
            btnNewOrder.FlatStyle = FlatStyle.Flat;
            btnNewOrder.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnNewOrder.ForeColor = Color.White;
            btnNewOrder.Location = new Point(86, 1067);
            btnNewOrder.Margin = new Padding(4, 5, 4, 5);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(1400, 100);
            btnNewOrder.TabIndex = 6;
            btnNewOrder.Text = "🔄   START NEW ORDER";
            btnNewOrder.UseVisualStyleBackColor = false;
            btnNewOrder.Click += BtnNewOrder_Click;
            // 
            // FormReceipt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1571, 1200);
            Controls.Add(btnNewOrder);
            Controls.Add(rtbReceipt);
            Controls.Add(lblReceiptHeader);
            Controls.Add(lblSuccessSub);
            Controls.Add(lblSuccessMsg);
            Controls.Add(lblSuccessIcon);
            Controls.Add(lblBrandLogo);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1585, 1228);
            Name = "FormReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🐝 HappiBee Kiosk";
            Load += FormReceipt_Load;
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Label       lblBrandLogo;
        private System.Windows.Forms.Label       lblSuccessIcon;
        private System.Windows.Forms.Label       lblSuccessMsg;
        private System.Windows.Forms.Label       lblSuccessSub;
        private System.Windows.Forms.Label       lblReceiptHeader;
        private System.Windows.Forms.RichTextBox rtbReceipt;
        private System.Windows.Forms.Button      btnNewOrder;
    }
}
