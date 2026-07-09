// Form1.Designer.cs — Screen 1: Welcome
// Edit this screen in Visual Studio: open Form1.cs → press Shift+F7
namespace JollibeeKiosk
{
    partial class Form1
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
            this.lblBeeEmoji   = new System.Windows.Forms.Label();
            this.lblBrand      = new System.Windows.Forms.Label();
            this.lblTagline    = new System.Windows.Forms.Label();
            this.lblSubtitle   = new System.Windows.Forms.Label();
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblBeeEmoji — the big bee icon
            this.lblBeeEmoji.AutoSize  = false;
            this.lblBeeEmoji.Font      = new System.Drawing.Font("Segoe UI Emoji", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBeeEmoji.ForeColor = System.Drawing.Color.White;
            this.lblBeeEmoji.Location  = new System.Drawing.Point(350, 55);
            this.lblBeeEmoji.Name      = "lblBeeEmoji";
            this.lblBeeEmoji.Size      = new System.Drawing.Size(300, 115);
            this.lblBeeEmoji.TabIndex  = 0;
            this.lblBeeEmoji.Text      = "🐝";
            this.lblBeeEmoji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblBrand — "JOLLIBEE" heading
            this.lblBrand.AutoSize  = false;
            this.lblBrand.Font      = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location  = new System.Drawing.Point(100, 175);
            this.lblBrand.Name      = "lblBrand";
            this.lblBrand.Size      = new System.Drawing.Size(800, 85);
            this.lblBrand.TabIndex  = 1;
            this.lblBrand.Text      = "JOLLIBEE";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblTagline — "Bida ang Sarap!"
            this.lblTagline.AutoSize  = false;
            this.lblTagline.Font      = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(253, 184, 19);
            this.lblTagline.Location  = new System.Drawing.Point(200, 265);
            this.lblTagline.Name      = "lblTagline";
            this.lblTagline.Size      = new System.Drawing.Size(600, 38);
            this.lblTagline.TabIndex  = 2;
            this.lblTagline.Text      = "Bida ang Sarap!";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitle — small subtitle text
            this.lblSubtitle.AutoSize  = false;
            this.lblSubtitle.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(255, 195, 175);
            this.lblSubtitle.Location  = new System.Drawing.Point(150, 308);
            this.lblSubtitle.Name      = "lblSubtitle";
            this.lblSubtitle.Size      = new System.Drawing.Size(700, 32);
            this.lblSubtitle.TabIndex  = 3;
            this.lblSubtitle.Text      = "Order your favorites, freshly made just for you.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnStartOrder — the main CTA yellow button
            this.btnStartOrder.BackColor                       = System.Drawing.Color.FromArgb(253, 184, 19);
            this.btnStartOrder.Cursor                          = System.Windows.Forms.Cursors.Hand;
            this.btnStartOrder.FlatStyle                       = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartOrder.FlatAppearance.BorderSize       = 0;
            this.btnStartOrder.Font                            = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartOrder.ForeColor                       = System.Drawing.Color.FromArgb(120, 15, 5);
            this.btnStartOrder.Location                        = new System.Drawing.Point(300, 390);
            this.btnStartOrder.Name                            = "btnStartOrder";
            this.btnStartOrder.Size                            = new System.Drawing.Size(400, 88);
            this.btnStartOrder.TabIndex                        = 4;
            this.btnStartOrder.Text                            = "🛒   TAP TO ORDER";
            this.btnStartOrder.UseVisualStyleBackColor         = false;
            this.btnStartOrder.Click                           += new System.EventHandler(this.BtnStartOrder_Click);

            // Form1 — the form itself
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(218, 41, 28);
            this.ClientSize          = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.btnStartOrder);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblBeeEmoji);
            this.MinimumSize         = new System.Drawing.Size(1016, 759);
            this.Name                = "Form1";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "🐝 Jollibee Kiosk — Welcome";
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Label  lblBeeEmoji;
        private System.Windows.Forms.Label  lblBrand;
        private System.Windows.Forms.Label  lblTagline;
        private System.Windows.Forms.Label  lblSubtitle;
        private System.Windows.Forms.Button btnStartOrder;
    }
}
