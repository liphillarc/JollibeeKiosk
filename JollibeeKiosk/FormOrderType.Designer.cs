// FormOrderType.Designer.cs — Screen 2: Dine In / Take Out
// To edit in Visual Studio Designer: open FormOrderType.cs → Shift+F7
namespace JollibeeKiosk
{
    partial class FormOrderType
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle    = new System.Windows.Forms.Label();
            this.btnDineIn   = new System.Windows.Forms.Button();
            this.btnTakeOut  = new System.Windows.Forms.Button();
            this.btnBack     = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // lblTitle — text inside the red header
            this.lblTitle.AutoSize  = false;
            this.lblTitle.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "How would you like your order?";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelHeader — red strip across the top
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Name     = "panelHeader";
            this.panelHeader.Size     = new System.Drawing.Size(1000, 100);
            this.panelHeader.TabIndex = 0;

            // btnDineIn — large left button
            this.btnDineIn.BackColor                   = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnDineIn.Cursor                      = System.Windows.Forms.Cursors.Hand;
            this.btnDineIn.FlatStyle                   = System.Windows.Forms.FlatStyle.Flat;
            this.btnDineIn.FlatAppearance.BorderColor  = System.Drawing.Color.FromArgb(180, 25, 15);
            this.btnDineIn.FlatAppearance.BorderSize   = 2;
            this.btnDineIn.Font                        = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDineIn.ForeColor                   = System.Drawing.Color.White;
            this.btnDineIn.Location                    = new System.Drawing.Point(100, 185);
            this.btnDineIn.Name                        = "btnDineIn";
            this.btnDineIn.Size                        = new System.Drawing.Size(340, 290);
            this.btnDineIn.TabIndex                    = 1;
            this.btnDineIn.Text                        = "🍽️\r\n\r\nDINE IN";
            this.btnDineIn.UseVisualStyleBackColor     = false;
            this.btnDineIn.Click                       += new System.EventHandler(this.BtnDineIn_Click);

            // btnTakeOut — large right button
            this.btnTakeOut.BackColor                  = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnTakeOut.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnTakeOut.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 25, 15);
            this.btnTakeOut.FlatAppearance.BorderSize  = 2;
            this.btnTakeOut.Font                       = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakeOut.ForeColor                  = System.Drawing.Color.White;
            this.btnTakeOut.Location                   = new System.Drawing.Point(560, 185);
            this.btnTakeOut.Name                       = "btnTakeOut";
            this.btnTakeOut.Size                       = new System.Drawing.Size(340, 290);
            this.btnTakeOut.TabIndex                   = 2;
            this.btnTakeOut.Text                       = "🥡\r\n\r\nTAKE OUT";
            this.btnTakeOut.UseVisualStyleBackColor    = false;
            this.btnTakeOut.Click                      += new System.EventHandler(this.BtnTakeOut_Click);

            // btnBack — small back button bottom-left
            this.btnBack.Cursor            = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle         = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font              = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location          = new System.Drawing.Point(30, 664);
            this.btnBack.Name              = "btnBack";
            this.btnBack.Size              = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex          = 3;
            this.btnBack.Text              = "← Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click             += new System.EventHandler(this.BtnBack_Click);

            // FormOrderType — the form itself
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTakeOut);
            this.Controls.Add(this.btnDineIn);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize         = new System.Drawing.Size(1016, 759);
            this.Name                = "FormOrderType";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "🐝 Jollibee Kiosk — Order Type";
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel  panelHeader;
        private System.Windows.Forms.Label  lblTitle;
        private System.Windows.Forms.Button btnDineIn;
        private System.Windows.Forms.Button btnTakeOut;
        private System.Windows.Forms.Button btnBack;
    }
}
