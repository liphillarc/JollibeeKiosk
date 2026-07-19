namespace JollibeeKiosk
{
    partial class FormDiscount
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
            btnBack = new Button();
            lblBrandLogo = new Label();
            lblStep = new Label();
            grpDiscountType = new GroupBox();
            rbtnNoDiscount = new RadioButton();
            rbtnSeniorCitizen = new RadioButton();
            rbtnPWD = new RadioButton();
            lblDiscountPreview = new Label();
            lblDCSubtotal = new Label();
            lblDCDiscount = new Label();
            lblDivLine = new Label();
            lblDCTotal = new Label();
            btnConfirmOrder = new Button();
            grpDiscountType.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(218, 41, 28);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 36);
            btnBack.TabIndex = 1;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // lblBrandLogo
            // 
            lblBrandLogo.BackColor = Color.FromArgb(218, 41, 28);
            lblBrandLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBrandLogo.ForeColor = Color.White;
            lblBrandLogo.Location = new Point(0, 0);
            lblBrandLogo.Name = "lblBrandLogo";
            lblBrandLogo.Size = new Size(1100, 60);
            lblBrandLogo.TabIndex = 0;
            lblBrandLogo.Text = "           🐝  HAPPYBEE DISCOUNTS";
            lblBrandLogo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStep
            // 
            lblStep.BackColor = Color.FromArgb(218, 41, 28);
            lblStep.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblStep.ForeColor = Color.FromArgb(253, 184, 19);
            lblStep.Location = new Point(600, 0);
            lblStep.Name = "lblStep";
            lblStep.Size = new Size(480, 60);
            lblStep.TabIndex = 2;
            lblStep.Text = "Step 2 of 2:  Discounts & Promos";
            lblStep.TextAlign = ContentAlignment.MiddleRight;
            // 
            // grpDiscountType
            // 
            grpDiscountType.Controls.Add(rbtnNoDiscount);
            grpDiscountType.Controls.Add(rbtnSeniorCitizen);
            grpDiscountType.Controls.Add(rbtnPWD);
            grpDiscountType.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpDiscountType.ForeColor = Color.FromArgb(218, 41, 28);
            grpDiscountType.Location = new Point(40, 90);
            grpDiscountType.Name = "grpDiscountType";
            grpDiscountType.Size = new Size(600, 240);
            grpDiscountType.TabIndex = 3;
            grpDiscountType.TabStop = false;
            grpDiscountType.Text = "Select Discount Type";
            // 
            // rbtnNoDiscount
            // 
            rbtnNoDiscount.Checked = true;
            rbtnNoDiscount.Font = new Font("Segoe UI", 13F);
            rbtnNoDiscount.Location = new Point(20, 35);
            rbtnNoDiscount.Name = "rbtnNoDiscount";
            rbtnNoDiscount.Size = new Size(550, 46);
            rbtnNoDiscount.TabIndex = 0;
            rbtnNoDiscount.TabStop = true;
            rbtnNoDiscount.Text = "No Discount — Regular Price";
            rbtnNoDiscount.UseVisualStyleBackColor = true;
            rbtnNoDiscount.CheckedChanged += DiscountOption_CheckedChanged;
            // 
            // rbtnSeniorCitizen
            // 
            rbtnSeniorCitizen.Font = new Font("Segoe UI", 13F);
            rbtnSeniorCitizen.Location = new Point(20, 100);
            rbtnSeniorCitizen.Name = "rbtnSeniorCitizen";
            rbtnSeniorCitizen.Size = new Size(550, 46);
            rbtnSeniorCitizen.TabIndex = 1;
            rbtnSeniorCitizen.Text = "\U0001f9d3  Senior Citizen  (20% discount — RA 9994)";
            rbtnSeniorCitizen.UseVisualStyleBackColor = true;
            rbtnSeniorCitizen.CheckedChanged += DiscountOption_CheckedChanged;
            // 
            // rbtnPWD
            // 
            rbtnPWD.Font = new Font("Segoe UI", 13F);
            rbtnPWD.Location = new Point(20, 165);
            rbtnPWD.Name = "rbtnPWD";
            rbtnPWD.Size = new Size(550, 46);
            rbtnPWD.TabIndex = 2;
            rbtnPWD.Text = "♿  PWD / Person with Disability  (15% discount)";
            rbtnPWD.UseVisualStyleBackColor = true;
            rbtnPWD.CheckedChanged += DiscountOption_CheckedChanged;
            // 
            // lblDiscountPreview
            // 
            lblDiscountPreview.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblDiscountPreview.ForeColor = Color.FromArgb(130, 130, 130);
            lblDiscountPreview.Location = new Point(680, 100);
            lblDiscountPreview.Name = "lblDiscountPreview";
            lblDiscountPreview.Size = new Size(380, 34);
            lblDiscountPreview.TabIndex = 4;
            lblDiscountPreview.Text = "No discount will be applied.";
            // 
            // lblDCSubtotal
            // 
            lblDCSubtotal.Font = new Font("Segoe UI", 14F);
            lblDCSubtotal.ForeColor = Color.FromArgb(80, 80, 80);
            lblDCSubtotal.Location = new Point(680, 145);
            lblDCSubtotal.Name = "lblDCSubtotal";
            lblDCSubtotal.Size = new Size(380, 38);
            lblDCSubtotal.TabIndex = 5;
            lblDCSubtotal.Text = "Subtotal:   ₱0.00";
            // 
            // lblDCDiscount
            // 
            lblDCDiscount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDCDiscount.ForeColor = Color.FromArgb(34, 139, 34);
            lblDCDiscount.Location = new Point(680, 190);
            lblDCDiscount.Name = "lblDCDiscount";
            lblDCDiscount.Size = new Size(380, 38);
            lblDCDiscount.TabIndex = 6;
            lblDCDiscount.Text = "Discount:   −₱0.00";
            // 
            // lblDivLine
            // 
            lblDivLine.BorderStyle = BorderStyle.Fixed3D;
            lblDivLine.Location = new Point(680, 235);
            lblDivLine.Name = "lblDivLine";
            lblDivLine.Size = new Size(380, 2);
            lblDivLine.TabIndex = 7;
            // 
            // lblDCTotal
            // 
            lblDCTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblDCTotal.ForeColor = Color.FromArgb(218, 41, 28);
            lblDCTotal.Location = new Point(680, 250);
            lblDCTotal.Name = "lblDCTotal";
            lblDCTotal.Size = new Size(380, 60);
            lblDCTotal.TabIndex = 8;
            lblDCTotal.Text = "TOTAL:   ₱0.00";
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.BackColor = Color.FromArgb(34, 139, 34);
            btnConfirmOrder.Cursor = Cursors.Hand;
            btnConfirmOrder.FlatAppearance.BorderSize = 0;
            btnConfirmOrder.FlatStyle = FlatStyle.Flat;
            btnConfirmOrder.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnConfirmOrder.ForeColor = Color.White;
            btnConfirmOrder.Location = new Point(680, 330);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(380, 70);
            btnConfirmOrder.TabIndex = 9;
            btnConfirmOrder.Text = "✅   CONFIRM ORDER";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += BtnConfirmOrder_Click;
            // 
            // FormDiscount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 720);
            Controls.Add(btnConfirmOrder);
            Controls.Add(lblDCTotal);
            Controls.Add(lblDivLine);
            Controls.Add(lblDCDiscount);
            Controls.Add(lblDCSubtotal);
            Controls.Add(lblDiscountPreview);
            Controls.Add(grpDiscountType);
            Controls.Add(lblStep);
            Controls.Add(btnBack);
            Controls.Add(lblBrandLogo);
            MinimumSize = new Size(1116, 759);
            Name = "FormDiscount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🐝 HappiBee Kiosk";
            Load += FormDiscount_Load;
            grpDiscountType.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Button      btnBack;
        private System.Windows.Forms.Label       lblBrandLogo;
        private System.Windows.Forms.Label       lblStep;
        private System.Windows.Forms.GroupBox    grpDiscountType;
        private System.Windows.Forms.RadioButton rbtnNoDiscount;
        private System.Windows.Forms.RadioButton rbtnSeniorCitizen;
        private System.Windows.Forms.RadioButton rbtnPWD;
        private System.Windows.Forms.Label       lblDiscountPreview;
        private System.Windows.Forms.Label       lblDCSubtotal;
        private System.Windows.Forms.Label       lblDCDiscount;
        private System.Windows.Forms.Label       lblDivLine;
        private System.Windows.Forms.Label       lblDCTotal;
        private System.Windows.Forms.Button      btnConfirmOrder;
    }
}
