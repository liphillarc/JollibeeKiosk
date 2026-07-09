// FormMenu.Designer.cs — Screen 3: Food Menu
// To edit in Visual Studio Designer: open FormMenu.cs → Shift+F7
// NOTE: The food item cards are NOT in the designer — they are built
//       dynamically in FormMenu.cs → CreateMenuItemCard().
//       Only the header, FlowLayoutPanel, and footer are here.
namespace JollibeeKiosk
{
    partial class FormMenu
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
            this.panelMenuHeader  = new System.Windows.Forms.Panel();
            this.lblMenuTitle     = new System.Windows.Forms.Label();
            this.lblMenuOrderType = new System.Windows.Forms.Label();
            this.flpMenuItems     = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenuFooter  = new System.Windows.Forms.Panel();
            this.lblCartInfo      = new System.Windows.Forms.Label();
            this.btnMenuBack      = new System.Windows.Forms.Button();
            this.btnViewCart      = new System.Windows.Forms.Button();
            this.panelMenuHeader.SuspendLayout();
            this.panelMenuFooter.SuspendLayout();
            this.SuspendLayout();

            // ── HEADER PANEL ─────────────────────────────────────────────
            // lblMenuTitle — "SELECT YOUR MEAL"
            this.lblMenuTitle.AutoSize  = false;
            this.lblMenuTitle.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.White;
            this.lblMenuTitle.Location  = new System.Drawing.Point(30, 10);
            this.lblMenuTitle.Name      = "lblMenuTitle";
            this.lblMenuTitle.Size      = new System.Drawing.Size(500, 42);
            this.lblMenuTitle.TabIndex  = 0;
            this.lblMenuTitle.Text      = "SELECT YOUR MEAL";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // lblMenuOrderType — shows "Dine In" or "Take Out" (set at runtime)
            this.lblMenuOrderType.AutoSize  = false;
            this.lblMenuOrderType.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenuOrderType.ForeColor = System.Drawing.Color.FromArgb(253, 184, 19);
            this.lblMenuOrderType.Location  = new System.Drawing.Point(30, 52);
            this.lblMenuOrderType.Name      = "lblMenuOrderType";
            this.lblMenuOrderType.Size      = new System.Drawing.Size(300, 25);
            this.lblMenuOrderType.TabIndex  = 1;
            this.lblMenuOrderType.Text      = "Dine In";

            // panelMenuHeader — red strip at top
            this.panelMenuHeader.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.panelMenuHeader.Controls.Add(this.lblMenuTitle);
            this.panelMenuHeader.Controls.Add(this.lblMenuOrderType);
            this.panelMenuHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHeader.Name     = "panelMenuHeader";
            this.panelMenuHeader.Size     = new System.Drawing.Size(1000, 85);
            this.panelMenuHeader.TabIndex = 0;

            // ── FLOW LAYOUT PANEL (middle — food cards go here) ──────────
            // flpMenuItems — dynamically filled by FormMenu.cs → LoadMenuCards()
            this.flpMenuItems.AutoScroll = true;
            this.flpMenuItems.BackColor  = System.Drawing.Color.FromArgb(245, 245, 245);
            this.flpMenuItems.Dock       = System.Windows.Forms.DockStyle.Fill;
            this.flpMenuItems.Name       = "flpMenuItems";
            this.flpMenuItems.Padding    = new System.Windows.Forms.Padding(10);
            this.flpMenuItems.TabIndex   = 1;

            // ── FOOTER PANEL ─────────────────────────────────────────────
            // lblCartInfo — shows "3 item(s) | ₱177.00" (updated at runtime)
            this.lblCartInfo.AutoSize  = false;
            this.lblCartInfo.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCartInfo.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.lblCartInfo.Location  = new System.Drawing.Point(20, 22);
            this.lblCartInfo.Name      = "lblCartInfo";
            this.lblCartInfo.Size      = new System.Drawing.Size(440, 38);
            this.lblCartInfo.TabIndex  = 0;
            this.lblCartInfo.Text      = "0 item(s)   |   ₱0.00";
            this.lblCartInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // btnMenuBack
            this.btnMenuBack.Cursor            = System.Windows.Forms.Cursors.Hand;
            this.btnMenuBack.FlatStyle         = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBack.Font              = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenuBack.Location          = new System.Drawing.Point(700, 18);
            this.btnMenuBack.Name              = "btnMenuBack";
            this.btnMenuBack.Size              = new System.Drawing.Size(120, 44);
            this.btnMenuBack.TabIndex          = 1;
            this.btnMenuBack.Text              = "← Back";
            this.btnMenuBack.UseVisualStyleBackColor = true;
            this.btnMenuBack.Click             += new System.EventHandler(this.BtnBack_Click);

            // btnViewCart — red "VIEW CART →" button
            this.btnViewCart.BackColor                 = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnViewCart.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnViewCart.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCart.FlatAppearance.BorderSize = 0;
            this.btnViewCart.Font                      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewCart.ForeColor                 = System.Drawing.Color.White;
            this.btnViewCart.Location                  = new System.Drawing.Point(832, 18);
            this.btnViewCart.Name                      = "btnViewCart";
            this.btnViewCart.Size                      = new System.Drawing.Size(150, 44);
            this.btnViewCart.TabIndex                  = 2;
            this.btnViewCart.Text                      = "VIEW CART →";
            this.btnViewCart.UseVisualStyleBackColor   = false;
            this.btnViewCart.Click                     += new System.EventHandler(this.BtnViewCart_Click);

            // panelMenuFooter — gray strip at the bottom
            this.panelMenuFooter.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            this.panelMenuFooter.Controls.Add(this.lblCartInfo);
            this.panelMenuFooter.Controls.Add(this.btnMenuBack);
            this.panelMenuFooter.Controls.Add(this.btnViewCart);
            this.panelMenuFooter.Dock     = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenuFooter.Name     = "panelMenuFooter";
            this.panelMenuFooter.Size     = new System.Drawing.Size(1000, 80);
            this.panelMenuFooter.TabIndex = 2;

            // FormMenu — the form itself
            // Controls added Fill first, then Bottom, then Top for correct docking
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize          = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.flpMenuItems);     // Fill (middle)
            this.Controls.Add(this.panelMenuFooter);  // Bottom
            this.Controls.Add(this.panelMenuHeader);  // Top
            this.MinimumSize         = new System.Drawing.Size(1016, 759);
            this.Name                = "FormMenu";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "🐝 Jollibee Kiosk — Menu";
            this.Load                += new System.EventHandler(this.FormMenu_Load);
            this.panelMenuHeader.ResumeLayout(false);
            this.panelMenuFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel          panelMenuHeader;
        private System.Windows.Forms.Label          lblMenuTitle;
        private System.Windows.Forms.Label          lblMenuOrderType;
        private System.Windows.Forms.FlowLayoutPanel flpMenuItems;
        private System.Windows.Forms.Panel          panelMenuFooter;
        private System.Windows.Forms.Label          lblCartInfo;
        private System.Windows.Forms.Button         btnMenuBack;
        private System.Windows.Forms.Button         btnViewCart;
    }
}
