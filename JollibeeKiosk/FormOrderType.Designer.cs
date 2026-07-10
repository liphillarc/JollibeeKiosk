namespace JollibeeKiosk
{
    partial class FormOrderType
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
            this.btnBack       = new System.Windows.Forms.Button();
            this.lblNavBrand   = new System.Windows.Forms.Label();
            this.lblQuestion   = new System.Windows.Forms.Label();
            this.lblSubQ       = new System.Windows.Forms.Label();
            this.btnDineIn     = new System.Windows.Forms.Button();
            this.btnTakeOut    = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ── TOP BRAND LABEL (directly on form!) ──────────────────────
            this.lblNavBrand.AutoSize  = false;
            this.lblNavBrand.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.lblNavBrand.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNavBrand.ForeColor = System.Drawing.Color.White;
            this.lblNavBrand.Location  = new System.Drawing.Point(0, 0);
            this.lblNavBrand.Name      = "lblNavBrand";
            this.lblNavBrand.Size      = new System.Drawing.Size(1100, 60);
            this.lblNavBrand.TabIndex  = 0;
            this.lblNavBrand.Text      = "           🐝  JOLLIBEE";
            this.lblNavBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnBack.BackColor                 = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnBack.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(190, 30, 20);
            this.btnBack.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor                 = System.Drawing.Color.White;
            this.btnBack.Location                  = new System.Drawing.Point(12, 12);
            this.btnBack.Name                      = "btnBack";
            this.btnBack.Size                      = new System.Drawing.Size(90, 36);
            this.btnBack.TabIndex                  = 1;
            this.btnBack.Text                      = "← Back";
            this.btnBack.UseVisualStyleBackColor   = false;
            this.btnBack.Click                    += new System.EventHandler(this.BtnBack_Click);

            // ── QUESTION LABELS & BUTTONS (directly on form!) ────────────
            this.lblQuestion.AutoSize  = false;
            this.lblQuestion.Font      = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.lblQuestion.Location  = new System.Drawing.Point(0, 100);
            this.lblQuestion.Name      = "lblQuestion";
            this.lblQuestion.Size      = new System.Drawing.Size(1100, 60);
            this.lblQuestion.TabIndex  = 2;
            this.lblQuestion.Text      = "How would you like your order?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblSubQ.AutoSize  = false;
            this.lblSubQ.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubQ.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150);
            this.lblSubQ.Location  = new System.Drawing.Point(0, 165);
            this.lblSubQ.Name      = "lblSubQ";
            this.lblSubQ.Size      = new System.Drawing.Size(1100, 34);
            this.lblSubQ.TabIndex  = 3;
            this.lblSubQ.Text      = "Choose your preferred dining option to get started";
            this.lblSubQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Dine In card button
            this.btnDineIn.BackColor                   = System.Drawing.Color.White;
            this.btnDineIn.Cursor                      = System.Windows.Forms.Cursors.Hand;
            this.btnDineIn.FlatStyle                   = System.Windows.Forms.FlatStyle.Flat;
            this.btnDineIn.FlatAppearance.BorderColor  = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnDineIn.FlatAppearance.BorderSize   = 2;
            this.btnDineIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 242, 240);
            this.btnDineIn.Font                        = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDineIn.ForeColor                   = System.Drawing.Color.FromArgb(35, 35, 35);
            this.btnDineIn.Location                    = new System.Drawing.Point(190, 230);
            this.btnDineIn.Name                        = "btnDineIn";
            this.btnDineIn.Size                        = new System.Drawing.Size(310, 310);
            this.btnDineIn.TabIndex                    = 4;
            this.btnDineIn.Text                        = "🍽️\r\n\r\nDINE IN\r\n\r\nEat here at the restaurant";
            this.btnDineIn.UseVisualStyleBackColor     = false;
            this.btnDineIn.Click                      += new System.EventHandler(this.BtnDineIn_Click);

            // Take Out card button
            this.btnTakeOut.BackColor                  = System.Drawing.Color.White;
            this.btnTakeOut.Cursor                     = System.Windows.Forms.Cursors.Hand;
            this.btnTakeOut.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnTakeOut.FlatAppearance.BorderSize  = 2;
            this.btnTakeOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 242, 240);
            this.btnTakeOut.Font                       = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakeOut.ForeColor                  = System.Drawing.Color.FromArgb(35, 35, 35);
            this.btnTakeOut.Location                   = new System.Drawing.Point(600, 230);
            this.btnTakeOut.Name                       = "btnTakeOut";
            this.btnTakeOut.Size                       = new System.Drawing.Size(310, 310);
            this.btnTakeOut.TabIndex                   = 5;
            this.btnTakeOut.Text                       = "🥡\r\n\r\nTAKE OUT\r\n\r\nTake your food to go";
            this.btnTakeOut.UseVisualStyleBackColor    = false;
            this.btnTakeOut.Click                     += new System.EventHandler(this.BtnTakeOut_Click);

            // ── FORM ─────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(248, 248, 248);
            this.ClientSize          = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNavBrand);
            this.Controls.Add(this.btnTakeOut);
            this.Controls.Add(this.btnDineIn);
            this.Controls.Add(this.lblSubQ);
            this.Controls.Add(this.lblQuestion);
            this.MinimumSize         = new System.Drawing.Size(1116, 759);
            this.Name                = "FormOrderType";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "🐝 Jollibee Kiosk — Order Type";
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label  lblNavBrand;
        private System.Windows.Forms.Label  lblQuestion;
        private System.Windows.Forms.Label  lblSubQ;
        private System.Windows.Forms.Button btnDineIn;
        private System.Windows.Forms.Button btnTakeOut;
    }
}
