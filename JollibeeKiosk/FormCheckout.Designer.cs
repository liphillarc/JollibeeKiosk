// FormCheckout.Designer.cs — Screen 4: Cart / Checkout
// To edit in Visual Studio Designer: open FormCheckout.cs → Shift+F7
namespace JollibeeKiosk
{
    partial class FormCheckout
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
            this.panelCOHeader    = new System.Windows.Forms.Panel();
            this.lblCOTitle       = new System.Windows.Forms.Label();
            this.lvwCart          = new System.Windows.Forms.ListView();
            this.colItemName      = new System.Windows.Forms.ColumnHeader();
            this.colItemPrice     = new System.Windows.Forms.ColumnHeader();
            this.colItemQty       = new System.Windows.Forms.ColumnHeader();
            this.colItemTotal     = new System.Windows.Forms.ColumnHeader();
            this.panelCOFooter    = new System.Windows.Forms.Panel();
            this.lblCOSubtotal    = new System.Windows.Forms.Label();
            this.btnBack          = new System.Windows.Forms.Button();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.panelCOHeader.SuspendLayout();
            this.panelCOFooter.SuspendLayout();
            this.SuspendLayout();

            // ── HEADER ───────────────────────────────────────────────────
            this.lblCOTitle.AutoSize  = false;
            this.lblCOTitle.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblCOTitle.Font      = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCOTitle.ForeColor = System.Drawing.Color.White;
            this.lblCOTitle.Name      = "lblCOTitle";
            this.lblCOTitle.TabIndex  = 0;
            this.lblCOTitle.Text      = "🛒  YOUR ORDER";
            this.lblCOTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelCOHeader.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.panelCOHeader.Controls.Add(this.lblCOTitle);
            this.panelCOHeader.Dock    = System.Windows.Forms.DockStyle.Top;
            this.panelCOHeader.Name    = "panelCOHeader";
            this.panelCOHeader.Size    = new System.Drawing.Size(1000, 85);
            this.panelCOHeader.TabIndex = 0;

            // ── LISTVIEW (the cart table) ─────────────────────────────────
            // Columns are defined here; rows are added at runtime in FormCheckout.cs
            this.lvwCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colItemName,
                this.colItemPrice,
                this.colItemQty,
                this.colItemTotal
            });
            this.colItemName.Text   = "Item";
            this.colItemName.Width  = 440;
            this.colItemPrice.Text  = "Unit Price";
            this.colItemPrice.Width = 150;
            this.colItemQty.Text    = "Qty";
            this.colItemQty.Width   = 70;
            this.colItemTotal.Text  = "Total";
            this.colItemTotal.Width = 160;
            this.lvwCart.Dock                          = System.Windows.Forms.DockStyle.Fill;
            this.lvwCart.Font                          = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwCart.FullRowSelect                 = true;
            this.lvwCart.GridLines                     = true;
            this.lvwCart.Name                          = "lvwCart";
            this.lvwCart.TabIndex                      = 1;
            this.lvwCart.UseCompatibleStateImageBehavior = false;
            this.lvwCart.View                          = System.Windows.Forms.View.Details;

            // ── FOOTER ───────────────────────────────────────────────────
            this.lblCOSubtotal.AutoSize  = false;
            this.lblCOSubtotal.Font      = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCOSubtotal.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.lblCOSubtotal.Location  = new System.Drawing.Point(20, 18);
            this.lblCOSubtotal.Name      = "lblCOSubtotal";
            this.lblCOSubtotal.Size      = new System.Drawing.Size(430, 46);
            this.lblCOSubtotal.TabIndex  = 0;
            this.lblCOSubtotal.Text      = "Subtotal:   ₱0.00";
            this.lblCOSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnBack.Cursor            = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle         = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font              = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location          = new System.Drawing.Point(640, 20);
            this.btnBack.Name              = "btnBack";
            this.btnBack.Size              = new System.Drawing.Size(130, 44);
            this.btnBack.TabIndex          = 1;
            this.btnBack.Text              = "← Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click             += new System.EventHandler(this.BtnBack_Click);

            this.btnApplyDiscount.BackColor                 = System.Drawing.Color.FromArgb(253, 184, 19);
            this.btnApplyDiscount.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnApplyDiscount.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyDiscount.FlatAppearance.BorderSize = 0;
            this.btnApplyDiscount.Font                      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApplyDiscount.ForeColor                 = System.Drawing.Color.FromArgb(120, 15, 5);
            this.btnApplyDiscount.Location                  = new System.Drawing.Point(780, 18);
            this.btnApplyDiscount.Name                      = "btnApplyDiscount";
            this.btnApplyDiscount.Size                      = new System.Drawing.Size(202, 46);
            this.btnApplyDiscount.TabIndex                  = 2;
            this.btnApplyDiscount.Text                      = "APPLY DISCOUNT →";
            this.btnApplyDiscount.UseVisualStyleBackColor   = false;
            this.btnApplyDiscount.Click                     += new System.EventHandler(this.BtnApplyDiscount_Click);

            this.panelCOFooter.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.panelCOFooter.Controls.Add(this.lblCOSubtotal);
            this.panelCOFooter.Controls.Add(this.btnBack);
            this.panelCOFooter.Controls.Add(this.btnApplyDiscount);
            this.panelCOFooter.Dock     = System.Windows.Forms.DockStyle.Bottom;
            this.panelCOFooter.Name     = "panelCOFooter";
            this.panelCOFooter.Size     = new System.Drawing.Size(1000, 85);
            this.panelCOFooter.TabIndex = 2;

            // FormCheckout
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.lvwCart);          // Fill
            this.Controls.Add(this.panelCOFooter);    // Bottom
            this.Controls.Add(this.panelCOHeader);    // Top
            this.MinimumSize         = new System.Drawing.Size(1016, 759);
            this.Name                = "FormCheckout";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "🐝 Jollibee Kiosk — Checkout";
            this.Load                += new System.EventHandler(this.FormCheckout_Load);
            this.panelCOHeader.ResumeLayout(false);
            this.panelCOFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel        panelCOHeader;
        private System.Windows.Forms.Label        lblCOTitle;
        private System.Windows.Forms.ListView     lvwCart;
        private System.Windows.Forms.ColumnHeader colItemName;
        private System.Windows.Forms.ColumnHeader colItemPrice;
        private System.Windows.Forms.ColumnHeader colItemQty;
        private System.Windows.Forms.ColumnHeader colItemTotal;
        private System.Windows.Forms.Panel        panelCOFooter;
        private System.Windows.Forms.Label        lblCOSubtotal;
        private System.Windows.Forms.Button       btnBack;
        private System.Windows.Forms.Button       btnApplyDiscount;
    }
}
