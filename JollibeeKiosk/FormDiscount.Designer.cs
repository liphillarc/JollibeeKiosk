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
            btnBack = new System.Windows.Forms.Button();
            lblBrandLogo = new System.Windows.Forms.Label();
            lblStep = new System.Windows.Forms.Label();
            grpDiscountType = new System.Windows.Forms.GroupBox();
            rbtnNoDiscount = new System.Windows.Forms.RadioButton();
            rbtnPWDSenior = new System.Windows.Forms.RadioButton();
            lblDiscountPreview = new System.Windows.Forms.Label();
            lblDCSubtotal = new System.Windows.Forms.Label();
            lblDCDiscount = new System.Windows.Forms.Label();
            lblDivLine = new System.Windows.Forms.Label();
            lblDCTotal = new System.Windows.Forms.Label();
            btnConfirmOrder = new System.Windows.Forms.Button();
            grpDiscountType.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(90, 36);
            btnBack.TabIndex = 1;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // lblBrandLogo
            // 
            lblBrandLogo.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            lblBrandLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblBrandLogo.ForeColor = System.Drawing.Color.White;
            lblBrandLogo.Location = new System.Drawing.Point(0, 0);
            lblBrandLogo.Name = "lblBrandLogo";
            lblBrandLogo.Size = new System.Drawing.Size(1100, 60);
            lblBrandLogo.TabIndex = 0;
            lblBrandLogo.Text = "           🏷️  HAPPYBEE DISCOUNTS";
            lblBrandLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStep
            // 
            lblStep.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            lblStep.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblStep.ForeColor = System.Drawing.Color.FromArgb(253, 184, 19);
            lblStep.Location = new System.Drawing.Point(600, 0);
            lblStep.Name = "lblStep";
            lblStep.Size = new System.Drawing.Size(480, 60);
            lblStep.TabIndex = 2;
            lblStep.Text = "Step 2 of 2:  Discounts And Promos";
            lblStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpDiscountType
            // 
            grpDiscountType.Controls.Add(rbtnNoDiscount);
            grpDiscountType.Controls.Add(rbtnPWDSenior);
            grpDiscountType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            grpDiscountType.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            grpDiscountType.Location = new System.Drawing.Point(40, 90);
            grpDiscountType.Name = "grpDiscountType";
            grpDiscountType.Size = new System.Drawing.Size(600, 240);
            grpDiscountType.TabIndex = 3;
            grpDiscountType.TabStop = false;
            grpDiscountType.Text = "Select Discount Type";
            // 
            // rbtnNoDiscount
            // 
            rbtnNoDiscount.Checked = true;
            rbtnNoDiscount.Font = new System.Drawing.Font("Segoe UI", 13F);
            rbtnNoDiscount.Location = new System.Drawing.Point(20, 35);
            rbtnNoDiscount.Name = "rbtnNoDiscount";
            rbtnNoDiscount.Size = new System.Drawing.Size(550, 46);
            rbtnNoDiscount.TabIndex = 0;
            rbtnNoDiscount.TabStop = true;
            rbtnNoDiscount.Text = "No Discount — Regular Price";
            rbtnNoDiscount.UseVisualStyleBackColor = true;
            rbtnNoDiscount.CheckedChanged += DiscountOption_CheckedChanged;
            // 
            // rbtnPWDSenior
            // 
            rbtnPWDSenior.Font = new System.Drawing.Font("Segoe UI", 13F);
            rbtnPWDSenior.Location = new System.Drawing.Point(20, 100);
            rbtnPWDSenior.Name = "rbtnPWDSenior";
            rbtnPWDSenior.Size = new System.Drawing.Size(550, 46);
            rbtnPWDSenior.TabIndex = 1;
            rbtnPWDSenior.Text = "\U0001f9d3  PWD / Senior Citizen  (20% discount)";
            rbtnPWDSenior.UseVisualStyleBackColor = true;
            rbtnPWDSenior.CheckedChanged += DiscountOption_CheckedChanged;
            // 
            // lblDiscountPreview
            // 
            lblDiscountPreview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            lblDiscountPreview.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130);
            lblDiscountPreview.Location = new System.Drawing.Point(680, 100);
            lblDiscountPreview.Name = "lblDiscountPreview";
            lblDiscountPreview.Size = new System.Drawing.Size(380, 34);
            lblDiscountPreview.TabIndex = 4;
            lblDiscountPreview.Text = "No discount will be applied.";
            lblDiscountPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDCSubtotal
            // 
            lblDCSubtotal.Font = new System.Drawing.Font("Consolas", 16F);
            lblDCSubtotal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            lblDCSubtotal.Location = new System.Drawing.Point(680, 150);
            lblDCSubtotal.Name = "lblDCSubtotal";
            lblDCSubtotal.Size = new System.Drawing.Size(380, 30);
            lblDCSubtotal.TabIndex = 5;
            lblDCSubtotal.Text = "Subtotal:        ₱0.00";
            // 
            // lblDCDiscount
            // 
            lblDCDiscount.Font = new System.Drawing.Font("Consolas", 16F);
            lblDCDiscount.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            lblDCDiscount.Location = new System.Drawing.Point(680, 190);
            lblDCDiscount.Name = "lblDCDiscount";
            lblDCDiscount.Size = new System.Drawing.Size(380, 30);
            lblDCDiscount.TabIndex = 6;
            lblDCDiscount.Text = "Discount (None):   -₱0.00";
            // 
            // lblDivLine
            // 
            lblDivLine.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
            lblDivLine.Location = new System.Drawing.Point(680, 230);
            lblDivLine.Name = "lblDivLine";
            lblDivLine.Size = new System.Drawing.Size(380, 2);
            lblDivLine.TabIndex = 7;
            // 
            // lblDCTotal
            // 
            lblDCTotal.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            lblDCTotal.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblDCTotal.Location = new System.Drawing.Point(680, 245);
            lblDCTotal.Name = "lblDCTotal";
            lblDCTotal.Size = new System.Drawing.Size(380, 40);
            lblDCTotal.TabIndex = 8;
            lblDCTotal.Text = "TOTAL:           ₱0.00";
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            btnConfirmOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            btnConfirmOrder.FlatAppearance.BorderSize = 0;
            btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmOrder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnConfirmOrder.ForeColor = System.Drawing.Color.White;
            btnConfirmOrder.Location = new System.Drawing.Point(740, 310);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new System.Drawing.Size(260, 60);
            btnConfirmOrder.TabIndex = 9;
            btnConfirmOrder.Text = "Confirm Order & Pay";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += BtnConfirmOrder_Click;
            // 
            // FormDiscount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            ClientSize = new System.Drawing.Size(1100, 720);
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
            MinimumSize = new System.Drawing.Size(1116, 759);
            Name = "FormDiscount";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "🐝 HappyBee Kiosk";
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
        private System.Windows.Forms.RadioButton rbtnPWDSenior;
        private System.Windows.Forms.Label       lblDiscountPreview;
        private System.Windows.Forms.Label       lblDCSubtotal;
        private System.Windows.Forms.Label       lblDCDiscount;
        private System.Windows.Forms.Label       lblDivLine;
        private System.Windows.Forms.Label       lblDCTotal;
        private System.Windows.Forms.Button      btnConfirmOrder;
    }
}




