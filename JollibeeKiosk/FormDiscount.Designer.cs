// FormDiscount.Designer.cs — Screen 5: Discount Selection
// To edit in Visual Studio Designer: open FormDiscount.cs → Shift+F7
namespace JollibeeKiosk
{
    partial class FormDiscount
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelDCHeader     = new System.Windows.Forms.Panel();
            this.lblDCTitle        = new System.Windows.Forms.Label();
            this.panelDCBody       = new System.Windows.Forms.Panel();
            this.grpDiscountType   = new System.Windows.Forms.GroupBox();
            this.rbtnNoDiscount    = new System.Windows.Forms.RadioButton();
            this.rbtnSeniorCitizen = new System.Windows.Forms.RadioButton();
            this.rbtnPWD           = new System.Windows.Forms.RadioButton();
            this.lblDiscountPreview= new System.Windows.Forms.Label();
            this.lblDCSubtotal     = new System.Windows.Forms.Label();
            this.lblDCDiscount     = new System.Windows.Forms.Label();
            this.lblDCTotal        = new System.Windows.Forms.Label();
            this.panelDCFooter     = new System.Windows.Forms.Panel();
            this.btnBack           = new System.Windows.Forms.Button();
            this.btnConfirmOrder   = new System.Windows.Forms.Button();
            this.panelDCHeader.SuspendLayout();
            this.panelDCBody.SuspendLayout();
            this.grpDiscountType.SuspendLayout();
            this.panelDCFooter.SuspendLayout();
            this.SuspendLayout();

            // ── HEADER ───────────────────────────────────────────────────
            this.lblDCTitle.AutoSize  = false;
            this.lblDCTitle.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblDCTitle.Font      = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDCTitle.ForeColor = System.Drawing.Color.White;
            this.lblDCTitle.Name      = "lblDCTitle";
            this.lblDCTitle.TabIndex  = 0;
            this.lblDCTitle.Text      = "🎟️  APPLY DISCOUNT";
            this.lblDCTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelDCHeader.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.panelDCHeader.Controls.Add(this.lblDCTitle);
            this.panelDCHeader.Dock    = System.Windows.Forms.DockStyle.Top;
            this.panelDCHeader.Name    = "panelDCHeader";
            this.panelDCHeader.Size    = new System.Drawing.Size(1000, 85);
            this.panelDCHeader.TabIndex = 0;

            // ── RADIO BUTTONS (inside GroupBox) ──────────────────────────
            this.rbtnNoDiscount.AutoSize = false;
            this.rbtnNoDiscount.Checked  = true;
            this.rbtnNoDiscount.Font     = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnNoDiscount.Location = new System.Drawing.Point(25, 35);
            this.rbtnNoDiscount.Name     = "rbtnNoDiscount";
            this.rbtnNoDiscount.Size     = new System.Drawing.Size(520, 46);
            this.rbtnNoDiscount.TabIndex = 0;
            this.rbtnNoDiscount.TabStop  = true;
            this.rbtnNoDiscount.Text     = "No Discount — Regular Price";
            this.rbtnNoDiscount.UseVisualStyleBackColor = true;
            this.rbtnNoDiscount.CheckedChanged += new System.EventHandler(this.DiscountOption_CheckedChanged);

            this.rbtnSeniorCitizen.AutoSize = false;
            this.rbtnSeniorCitizen.Font     = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnSeniorCitizen.Location = new System.Drawing.Point(25, 96);
            this.rbtnSeniorCitizen.Name     = "rbtnSeniorCitizen";
            this.rbtnSeniorCitizen.Size     = new System.Drawing.Size(520, 46);
            this.rbtnSeniorCitizen.TabIndex = 1;
            this.rbtnSeniorCitizen.Text     = "👴  Senior Citizen  (15% discount)";
            this.rbtnSeniorCitizen.UseVisualStyleBackColor = true;
            this.rbtnSeniorCitizen.CheckedChanged += new System.EventHandler(this.DiscountOption_CheckedChanged);

            this.rbtnPWD.AutoSize = false;
            this.rbtnPWD.Font     = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnPWD.Location = new System.Drawing.Point(25, 157);
            this.rbtnPWD.Name     = "rbtnPWD";
            this.rbtnPWD.Size     = new System.Drawing.Size(520, 46);
            this.rbtnPWD.TabIndex = 2;
            this.rbtnPWD.Text     = "♿  PWD / Person with Disability  (15% discount)";
            this.rbtnPWD.UseVisualStyleBackColor = true;
            this.rbtnPWD.CheckedChanged += new System.EventHandler(this.DiscountOption_CheckedChanged);

            this.grpDiscountType.Controls.Add(this.rbtnNoDiscount);
            this.grpDiscountType.Controls.Add(this.rbtnSeniorCitizen);
            this.grpDiscountType.Controls.Add(this.rbtnPWD);
            this.grpDiscountType.Font     = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDiscountType.ForeColor= System.Drawing.Color.FromArgb(218, 41, 28);
            this.grpDiscountType.Location = new System.Drawing.Point(50, 30);
            this.grpDiscountType.Name     = "grpDiscountType";
            this.grpDiscountType.Size     = new System.Drawing.Size(600, 225);
            this.grpDiscountType.TabIndex = 0;
            this.grpDiscountType.TabStop  = false;
            this.grpDiscountType.Text     = "Select Discount Type";

            // lblDiscountPreview — italic note about the selected discount
            this.lblDiscountPreview.AutoSize  = false;
            this.lblDiscountPreview.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDiscountPreview.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblDiscountPreview.Location  = new System.Drawing.Point(50, 268);
            this.lblDiscountPreview.Name      = "lblDiscountPreview";
            this.lblDiscountPreview.Size      = new System.Drawing.Size(700, 32);
            this.lblDiscountPreview.TabIndex  = 1;
            this.lblDiscountPreview.Text      = "No discount will be applied.";

            // lblDCSubtotal
            this.lblDCSubtotal.AutoSize  = false;
            this.lblDCSubtotal.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDCSubtotal.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblDCSubtotal.Location  = new System.Drawing.Point(50, 315);
            this.lblDCSubtotal.Name      = "lblDCSubtotal";
            this.lblDCSubtotal.Size      = new System.Drawing.Size(600, 38);
            this.lblDCSubtotal.TabIndex  = 2;
            this.lblDCSubtotal.Text      = "Subtotal:        ₱0.00";

            // lblDCDiscount
            this.lblDCDiscount.AutoSize  = false;
            this.lblDCDiscount.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDCDiscount.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.lblDCDiscount.Location  = new System.Drawing.Point(50, 358);
            this.lblDCDiscount.Name      = "lblDCDiscount";
            this.lblDCDiscount.Size      = new System.Drawing.Size(600, 38);
            this.lblDCDiscount.TabIndex  = 3;
            this.lblDCDiscount.Text      = "Discount (None):   -₱0.00";

            // lblDCTotal — large red total
            this.lblDCTotal.AutoSize  = false;
            this.lblDCTotal.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDCTotal.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.lblDCTotal.Location  = new System.Drawing.Point(50, 408);
            this.lblDCTotal.Name      = "lblDCTotal";
            this.lblDCTotal.Size      = new System.Drawing.Size(600, 55);
            this.lblDCTotal.TabIndex  = 4;
            this.lblDCTotal.Text      = "TOTAL:           ₱0.00";

            // panelDCBody — white area containing all the discount controls
            this.panelDCBody.BackColor = System.Drawing.Color.White;
            this.panelDCBody.Controls.Add(this.grpDiscountType);
            this.panelDCBody.Controls.Add(this.lblDiscountPreview);
            this.panelDCBody.Controls.Add(this.lblDCSubtotal);
            this.panelDCBody.Controls.Add(this.lblDCDiscount);
            this.panelDCBody.Controls.Add(this.lblDCTotal);
            this.panelDCBody.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.panelDCBody.Name     = "panelDCBody";
            this.panelDCBody.TabIndex = 1;

            // ── FOOTER ───────────────────────────────────────────────────
            this.btnBack.Cursor            = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle         = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font              = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location          = new System.Drawing.Point(630, 20);
            this.btnBack.Name              = "btnBack";
            this.btnBack.Size              = new System.Drawing.Size(130, 44);
            this.btnBack.TabIndex          = 0;
            this.btnBack.Text              = "← Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click             += new System.EventHandler(this.BtnBack_Click);

            this.btnConfirmOrder.BackColor                 = System.Drawing.Color.FromArgb(34, 139, 34);
            this.btnConfirmOrder.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmOrder.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.FlatAppearance.BorderSize = 0;
            this.btnConfirmOrder.Font                      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmOrder.ForeColor                 = System.Drawing.Color.White;
            this.btnConfirmOrder.Location                  = new System.Drawing.Point(770, 17);
            this.btnConfirmOrder.Name                      = "btnConfirmOrder";
            this.btnConfirmOrder.Size                      = new System.Drawing.Size(212, 50);
            this.btnConfirmOrder.TabIndex                  = 1;
            this.btnConfirmOrder.Text                      = "✅  CONFIRM ORDER";
            this.btnConfirmOrder.UseVisualStyleBackColor   = false;
            this.btnConfirmOrder.Click                     += new System.EventHandler(this.BtnConfirmOrder_Click);

            this.panelDCFooter.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.panelDCFooter.Controls.Add(this.btnBack);
            this.panelDCFooter.Controls.Add(this.btnConfirmOrder);
            this.panelDCFooter.Dock     = System.Windows.Forms.DockStyle.Bottom;
            this.panelDCFooter.Name     = "panelDCFooter";
            this.panelDCFooter.Size     = new System.Drawing.Size(1000, 85);
            this.panelDCFooter.TabIndex = 2;

            // FormDiscount
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.panelDCBody);     // Fill
            this.Controls.Add(this.panelDCFooter);   // Bottom
            this.Controls.Add(this.panelDCHeader);   // Top
            this.MinimumSize         = new System.Drawing.Size(1016, 759);
            this.Name                = "FormDiscount";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "🐝 Jollibee Kiosk — Discount";
            this.Load                += new System.EventHandler(this.FormDiscount_Load);
            this.panelDCHeader.ResumeLayout(false);
            this.panelDCBody.ResumeLayout(false);
            this.grpDiscountType.ResumeLayout(false);
            this.panelDCFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel       panelDCHeader;
        private System.Windows.Forms.Label       lblDCTitle;
        private System.Windows.Forms.Panel       panelDCBody;
        private System.Windows.Forms.GroupBox    grpDiscountType;
        private System.Windows.Forms.RadioButton rbtnNoDiscount;
        private System.Windows.Forms.RadioButton rbtnSeniorCitizen;
        private System.Windows.Forms.RadioButton rbtnPWD;
        private System.Windows.Forms.Label       lblDiscountPreview;
        private System.Windows.Forms.Label       lblDCSubtotal;
        private System.Windows.Forms.Label       lblDCDiscount;
        private System.Windows.Forms.Label       lblDCTotal;
        private System.Windows.Forms.Panel       panelDCFooter;
        private System.Windows.Forms.Button      btnBack;
        private System.Windows.Forms.Button      btnConfirmOrder;
    }
}
