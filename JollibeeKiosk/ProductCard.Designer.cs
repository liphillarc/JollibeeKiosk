namespace JollibeeKiosk
{
    partial class ProductCard
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblName    = new System.Windows.Forms.Label();
            this.lblPrice   = new System.Windows.Forms.Label();
            this.btnMinus   = new System.Windows.Forms.Button();
            this.lblQty     = new System.Windows.Forms.Label();
            this.btnPlus    = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.picProduct).BeginInit();
            this.SuspendLayout();

            // ── PICTURE BOX (directly editable right here!) ────────────────
            this.picProduct.BackColor = System.Drawing.Color.FromArgb(253, 248, 245);
            this.picProduct.Location  = new System.Drawing.Point(8, 8);
            this.picProduct.Name      = "picProduct";
            this.picProduct.Size      = new System.Drawing.Size(164, 130);
            this.picProduct.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex  = 0;
            this.picProduct.TabStop   = false;

            // ── NAME LABEL ─────────────────────────────────────────────────
            this.lblName.Font      = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.lblName.Location  = new System.Drawing.Point(8, 144);
            this.lblName.Name      = "lblName";
            this.lblName.Size      = new System.Drawing.Size(164, 42);
            this.lblName.TabIndex  = 1;
            this.lblName.Text      = "Chickenjoy (2 pcs)";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // ── PRICE LABEL ────────────────────────────────────────────────
            this.lblPrice.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.lblPrice.Location  = new System.Drawing.Point(8, 188);
            this.lblPrice.Name      = "lblPrice";
            this.lblPrice.Size      = new System.Drawing.Size(164, 28);
            this.lblPrice.TabIndex  = 2;
            this.lblPrice.Text      = "₱179.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── MINUS BUTTON ───────────────────────────────────────────────
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnMinus.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinus.ForeColor = System.Drawing.Color.White;
            this.btnMinus.Location  = new System.Drawing.Point(14, 224);
            this.btnMinus.Name      = "btnMinus";
            this.btnMinus.Size      = new System.Drawing.Size(40, 36);
            this.btnMinus.TabIndex  = 3;
            this.btnMinus.Text      = "−";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click    += new System.EventHandler(this.BtnMinus_Click);

            // ── QUANTITY LABEL ─────────────────────────────────────────────
            this.lblQty.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.lblQty.Location  = new System.Drawing.Point(58, 224);
            this.lblQty.Name      = "lblQty";
            this.lblQty.Size      = new System.Drawing.Size(64, 36);
            this.lblQty.TabIndex  = 4;
            this.lblQty.Text      = "0";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── PLUS BUTTON ────────────────────────────────────────────────
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnPlus.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location  = new System.Drawing.Point(126, 224);
            this.btnPlus.Name      = "btnPlus";
            this.btnPlus.Size      = new System.Drawing.Size(40, 36);
            this.btnPlus.TabIndex  = 5;
            this.btnPlus.Text      = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click    += new System.EventHandler(this.BtnPlus_Click);

            // ── PRODUCT CARD USER CONTROL ──────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picProduct);
            this.Margin              = new System.Windows.Forms.Padding(10);
            this.Name                = "ProductCard";
            this.Size                = new System.Drawing.Size(180, 270);
            ((System.ComponentModel.ISupportInitialize)this.picProduct).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label      lblName;
        private System.Windows.Forms.Label      lblPrice;
        private System.Windows.Forms.Button     btnMinus;
        private System.Windows.Forms.Label      lblQty;
        private System.Windows.Forms.Button     btnPlus;
    }
}
