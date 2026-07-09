// FormReceipt.Designer.cs — Screen 6: Receipt
// To edit in Visual Studio Designer: open FormReceipt.cs → Shift+F7
namespace JollibeeKiosk
{
    partial class FormReceipt
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
            this.panelRCHeader = new System.Windows.Forms.Panel();
            this.lblRCTitle    = new System.Windows.Forms.Label();
            this.rtbReceipt    = new System.Windows.Forms.RichTextBox();
            this.panelRCFooter = new System.Windows.Forms.Panel();
            this.btnNewOrder   = new System.Windows.Forms.Button();
            this.panelRCHeader.SuspendLayout();
            this.panelRCFooter.SuspendLayout();
            this.SuspendLayout();

            // ── HEADER (green — indicates success) ───────────────────────
            this.lblRCTitle.AutoSize  = false;
            this.lblRCTitle.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblRCTitle.Font      = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRCTitle.ForeColor = System.Drawing.Color.White;
            this.lblRCTitle.Name      = "lblRCTitle";
            this.lblRCTitle.TabIndex  = 0;
            this.lblRCTitle.Text      = "✅  ORDER CONFIRMED!";
            this.lblRCTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelRCHeader.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.panelRCHeader.Controls.Add(this.lblRCTitle);
            this.panelRCHeader.Dock    = System.Windows.Forms.DockStyle.Top;
            this.panelRCHeader.Name    = "panelRCHeader";
            this.panelRCHeader.Size    = new System.Drawing.Size(1000, 85);
            this.panelRCHeader.TabIndex = 0;

            // ── RICHTEXTBOX — the receipt text ────────────────────────────
            // RichTextBox is like a TextBox but supports scrolling and rich formatting.
            // We keep it ReadOnly so the customer cannot accidentally edit it.
            // Courier New is used because it's monospaced — columns align perfectly.
            this.rtbReceipt.BackColor   = System.Drawing.Color.White;
            this.rtbReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbReceipt.Dock        = System.Windows.Forms.DockStyle.Fill;
            this.rtbReceipt.Font        = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbReceipt.Margin      = new System.Windows.Forms.Padding(20);
            this.rtbReceipt.Name        = "rtbReceipt";
            this.rtbReceipt.ReadOnly    = true;
            this.rtbReceipt.ScrollBars  = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbReceipt.TabIndex    = 1;
            this.rtbReceipt.Text        = "";

            // ── FOOTER — "Start New Order" button ────────────────────────
            this.btnNewOrder.BackColor                 = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnNewOrder.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.Dock                      = System.Windows.Forms.DockStyle.Fill;
            this.btnNewOrder.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.FlatAppearance.BorderSize = 0;
            this.btnNewOrder.Font                      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewOrder.ForeColor                 = System.Drawing.Color.White;
            this.btnNewOrder.Name                      = "btnNewOrder";
            this.btnNewOrder.TabIndex                  = 0;
            this.btnNewOrder.Text                      = "🔄  START NEW ORDER";
            this.btnNewOrder.UseVisualStyleBackColor   = false;
            this.btnNewOrder.Click                     += new System.EventHandler(this.BtnNewOrder_Click);

            this.panelRCFooter.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.panelRCFooter.Controls.Add(this.btnNewOrder);
            this.panelRCFooter.Dock     = System.Windows.Forms.DockStyle.Bottom;
            this.panelRCFooter.Name     = "panelRCFooter";
            this.panelRCFooter.Size     = new System.Drawing.Size(1000, 68);
            this.panelRCFooter.TabIndex = 2;

            // FormReceipt
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.rtbReceipt);      // Fill
            this.Controls.Add(this.panelRCFooter);   // Bottom
            this.Controls.Add(this.panelRCHeader);   // Top
            this.MinimumSize         = new System.Drawing.Size(1016, 759);
            this.Name                = "FormReceipt";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "🐝 Jollibee Kiosk — Receipt";
            this.Load                += new System.EventHandler(this.FormReceipt_Load);
            this.panelRCHeader.ResumeLayout(false);
            this.panelRCFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel       panelRCHeader;
        private System.Windows.Forms.Label       lblRCTitle;
        private System.Windows.Forms.RichTextBox rtbReceipt;
        private System.Windows.Forms.Panel       panelRCFooter;
        private System.Windows.Forms.Button      btnNewOrder;
    }
}
