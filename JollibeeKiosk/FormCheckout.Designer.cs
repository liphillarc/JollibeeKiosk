namespace JollibeeKiosk
{
    partial class FormCheckout
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
            this.btnBack          = new System.Windows.Forms.Button();
            this.lblHeader        = new System.Windows.Forms.Label();
            this.lblSubheader     = new System.Windows.Forms.Label();
            this.lblOrderBadge    = new System.Windows.Forms.Label();
            this.lblReviewTitle   = new System.Windows.Forms.Label();
            this.btnAddMoreItems  = new System.Windows.Forms.Button();

            // Checkout Item Row 1
            this.picCOItem1   = new System.Windows.Forms.PictureBox();
            this.lblCOName1   = new System.Windows.Forms.Label();
            this.lblCOPrice1  = new System.Windows.Forms.Label();
            this.btnCOMinus1  = new System.Windows.Forms.Button();
            this.lblCOQty1    = new System.Windows.Forms.Label();
            this.btnCOPlus1   = new System.Windows.Forms.Button();
            this.lblCOSub1    = new System.Windows.Forms.Label();
            this.btnCODelete1 = new System.Windows.Forms.Button();

            // Checkout Item Row 2
            this.picCOItem2   = new System.Windows.Forms.PictureBox();
            this.lblCOName2   = new System.Windows.Forms.Label();
            this.lblCOPrice2  = new System.Windows.Forms.Label();
            this.btnCOMinus2  = new System.Windows.Forms.Button();
            this.lblCOQty2    = new System.Windows.Forms.Label();
            this.btnCOPlus2   = new System.Windows.Forms.Button();
            this.lblCOSub2    = new System.Windows.Forms.Label();
            this.btnCODelete2 = new System.Windows.Forms.Button();

            // Checkout Item Row 3
            this.picCOItem3   = new System.Windows.Forms.PictureBox();
            this.lblCOName3   = new System.Windows.Forms.Label();
            this.lblCOPrice3  = new System.Windows.Forms.Label();
            this.btnCOMinus3  = new System.Windows.Forms.Button();
            this.lblCOQty3    = new System.Windows.Forms.Label();
            this.btnCOPlus3   = new System.Windows.Forms.Button();
            this.lblCOSub3    = new System.Windows.Forms.Label();
            this.btnCODelete3 = new System.Windows.Forms.Button();

            // Checkout Item Row 4
            this.picCOItem4   = new System.Windows.Forms.PictureBox();
            this.lblCOName4   = new System.Windows.Forms.Label();
            this.lblCOPrice4  = new System.Windows.Forms.Label();
            this.btnCOMinus4  = new System.Windows.Forms.Button();
            this.lblCOQty4    = new System.Windows.Forms.Label();
            this.btnCOPlus4   = new System.Windows.Forms.Button();
            this.lblCOSub4    = new System.Windows.Forms.Label();
            this.btnCODelete4 = new System.Windows.Forms.Button();

            // Checkout Item Row 5
            this.picCOItem5   = new System.Windows.Forms.PictureBox();
            this.lblCOName5   = new System.Windows.Forms.Label();
            this.lblCOPrice5  = new System.Windows.Forms.Label();
            this.btnCOMinus5  = new System.Windows.Forms.Button();
            this.lblCOQty5    = new System.Windows.Forms.Label();
            this.btnCOPlus5   = new System.Windows.Forms.Button();
            this.lblCOSub5    = new System.Windows.Forms.Label();
            this.btnCODelete5 = new System.Windows.Forms.Button();

            // Checkout Item Row 6
            this.picCOItem6   = new System.Windows.Forms.PictureBox();
            this.lblCOName6   = new System.Windows.Forms.Label();
            this.lblCOPrice6  = new System.Windows.Forms.Label();
            this.btnCOMinus6  = new System.Windows.Forms.Button();
            this.lblCOQty6    = new System.Windows.Forms.Label();
            this.btnCOPlus6   = new System.Windows.Forms.Button();
            this.lblCOSub6    = new System.Windows.Forms.Label();
            this.btnCODelete6 = new System.Windows.Forms.Button();

            // Right Card: Discounts & Promos + Totals + Confirm Button
            this.grpDiscounts     = new System.Windows.Forms.GroupBox();
            this.rbtnRegular      = new System.Windows.Forms.RadioButton();
            this.rbtnSenior       = new System.Windows.Forms.RadioButton();
            this.rbtnPWD          = new System.Windows.Forms.RadioButton();

            this.lblCOSubtotalAmt = new System.Windows.Forms.Label();
            this.lblCODiscountAmt = new System.Windows.Forms.Label();
            this.lblCOTotalAmt    = new System.Windows.Forms.Label();
            this.btnConfirmOrder  = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)this.picCOItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picCOItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picCOItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picCOItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picCOItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.picCOItem6).BeginInit();
            this.grpDiscounts.SuspendLayout();
            this.SuspendLayout();

            // ── TOP HEADER BAR (Dock=Top for clean full-screen stretching) ──
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.lblHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location  = new System.Drawing.Point(0, 0);
            this.lblHeader.Name      = "lblHeader";
            this.lblHeader.Size      = new System.Drawing.Size(1280, 60);
            this.lblHeader.TabIndex  = 0;
            this.lblHeader.Text      = "           ✓  CHECKOUT & REVIEW";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnBack.BackColor                 = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnBack.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor                 = System.Drawing.Color.White;
            this.btnBack.Location                  = new System.Drawing.Point(12, 12);
            this.btnBack.Name                      = "btnBack";
            this.btnBack.Size                      = new System.Drawing.Size(90, 36);
            this.btnBack.TabIndex                  = 1;
            this.btnBack.Text                      = "← Go Back";
            this.btnBack.UseVisualStyleBackColor   = false;
            this.btnBack.Click                    += new System.EventHandler(this.BtnBack_Click);

            this.lblOrderBadge.Anchor    = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblOrderBadge.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.lblOrderBadge.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblOrderBadge.ForeColor = System.Drawing.Color.FromArgb(253, 184, 19);
            this.lblOrderBadge.Location  = new System.Drawing.Point(980, 0);
            this.lblOrderBadge.Name      = "lblOrderBadge";
            this.lblOrderBadge.Size      = new System.Drawing.Size(280, 60);
            this.lblOrderBadge.TabIndex  = 2;
            this.lblOrderBadge.Text      = "Dine In Order";
            this.lblOrderBadge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblSubheader.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubheader.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblSubheader.Location  = new System.Drawing.Point(30, 70);
            this.lblSubheader.Name      = "lblSubheader";
            this.lblSubheader.Size      = new System.Drawing.Size(500, 25);
            this.lblSubheader.TabIndex  = 3;
            this.lblSubheader.Text      = "Please review your order items and select any applicable discount.";

            // ── LEFT SECTION HEADER ──────────────────────────────────────
            this.lblReviewTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblReviewTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblReviewTitle.Location  = new System.Drawing.Point(30, 110);
            this.lblReviewTitle.Name      = "lblReviewTitle";
            this.lblReviewTitle.Size      = new System.Drawing.Size(300, 30);
            this.lblReviewTitle.TabIndex  = 4;
            this.lblReviewTitle.Text      = "Review Items";

            this.btnAddMoreItems.Cursor                    = System.Windows.Forms.Cursors.Hand;
            this.btnAddMoreItems.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMoreItems.FlatAppearance.BorderSize = 1;
            this.btnAddMoreItems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnAddMoreItems.Font                      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddMoreItems.ForeColor                 = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnAddMoreItems.Location                  = new System.Drawing.Point(530, 105);
            this.btnAddMoreItems.Name                      = "btnAddMoreItems";
            this.btnAddMoreItems.Size                      = new System.Drawing.Size(180, 36);
            this.btnAddMoreItems.TabIndex                  = 5;
            this.btnAddMoreItems.Text                      = "+ Add more items";
            this.btnAddMoreItems.UseVisualStyleBackColor   = false;
            this.btnAddMoreItems.Click                    += new System.EventHandler(this.BtnAddMoreItems_Click);

            // ════════════════════════════════════════════════════════════
            //  CHECKOUT ITEM ROWS (Static PictureBox + Controls on Left/Center)
            // ════════════════════════════════════════════════════════════

            // ── ROW 1 (Y = 160) ──────────────────────────────────────────
            this.picCOItem1.BackColor   = System.Drawing.Color.FromArgb(255, 248, 240);
            this.picCOItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCOItem1.Location    = new System.Drawing.Point(30, 160);
            this.picCOItem1.Name        = "picCOItem1";
            this.picCOItem1.Size        = new System.Drawing.Size(90, 70);
            this.picCOItem1.SizeMode    = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCOItem1.TabIndex    = 10;
            this.picCOItem1.TabStop     = false;

            this.lblCOName1.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOName1.Location  = new System.Drawing.Point(135, 165);
            this.lblCOName1.Name      = "lblCOName1";
            this.lblCOName1.Size      = new System.Drawing.Size(220, 28);
            this.lblCOName1.Text      = "Item Name 1";

            this.lblCOPrice1.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCOPrice1.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCOPrice1.Location  = new System.Drawing.Point(135, 195);
            this.lblCOPrice1.Name      = "lblCOPrice1";
            this.lblCOPrice1.Size      = new System.Drawing.Size(220, 24);
            this.lblCOPrice1.Text      = "₱0.00";

            this.btnCOMinus1.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOMinus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOMinus1.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOMinus1.Location  = new System.Drawing.Point(370, 175);
            this.btnCOMinus1.Name      = "btnCOMinus1";
            this.btnCOMinus1.Size      = new System.Drawing.Size(34, 34);
            this.btnCOMinus1.Text      = "−";
            this.btnCOMinus1.Click    += new System.EventHandler(this.BtnCOMinus1_Click);

            this.lblCOQty1.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOQty1.Location  = new System.Drawing.Point(404, 175);
            this.lblCOQty1.Name      = "lblCOQty1";
            this.lblCOQty1.Size      = new System.Drawing.Size(46, 34);
            this.lblCOQty1.Text      = "1";
            this.lblCOQty1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnCOPlus1.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOPlus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOPlus1.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOPlus1.Location  = new System.Drawing.Point(450, 175);
            this.btnCOPlus1.Name      = "btnCOPlus1";
            this.btnCOPlus1.Size      = new System.Drawing.Size(34, 34);
            this.btnCOPlus1.Text      = "+";
            this.btnCOPlus1.Click    += new System.EventHandler(this.BtnCOPlus1_Click);

            this.lblCOSub1.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCOSub1.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblCOSub1.Location  = new System.Drawing.Point(510, 175);
            this.lblCOSub1.Name      = "lblCOSub1";
            this.lblCOSub1.Size      = new System.Drawing.Size(130, 34);
            this.lblCOSub1.Text      = "₱0.00";
            this.lblCOSub1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.btnCODelete1.BackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.btnCODelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCODelete1.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCODelete1.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnCODelete1.Location  = new System.Drawing.Point(660, 175);
            this.btnCODelete1.Name      = "btnCODelete1";
            this.btnCODelete1.Size      = new System.Drawing.Size(46, 34);
            this.btnCODelete1.Text      = "🗑";
            this.btnCODelete1.Click    += new System.EventHandler(this.BtnCODelete1_Click);

            // ── ROW 2 (Y = 250) ──────────────────────────────────────────
            this.picCOItem2.BackColor   = System.Drawing.Color.FromArgb(255, 248, 240);
            this.picCOItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCOItem2.Location    = new System.Drawing.Point(30, 250);
            this.picCOItem2.Name        = "picCOItem2";
            this.picCOItem2.Size        = new System.Drawing.Size(90, 70);
            this.picCOItem2.SizeMode    = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCOItem2.TabIndex    = 20;

            this.lblCOName2.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOName2.Location  = new System.Drawing.Point(135, 255);
            this.lblCOName2.Name      = "lblCOName2";
            this.lblCOName2.Size      = new System.Drawing.Size(220, 28);
            this.lblCOName2.Text      = "Item Name 2";

            this.lblCOPrice2.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCOPrice2.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCOPrice2.Location  = new System.Drawing.Point(135, 285);
            this.lblCOPrice2.Name      = "lblCOPrice2";
            this.lblCOPrice2.Size      = new System.Drawing.Size(220, 24);
            this.lblCOPrice2.Text      = "₱0.00";

            this.btnCOMinus2.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOMinus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOMinus2.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOMinus2.Location  = new System.Drawing.Point(370, 265);
            this.btnCOMinus2.Name      = "btnCOMinus2";
            this.btnCOMinus2.Size      = new System.Drawing.Size(34, 34);
            this.btnCOMinus2.Text      = "−";
            this.btnCOMinus2.Click    += new System.EventHandler(this.BtnCOMinus2_Click);

            this.lblCOQty2.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOQty2.Location  = new System.Drawing.Point(404, 265);
            this.lblCOQty2.Name      = "lblCOQty2";
            this.lblCOQty2.Size      = new System.Drawing.Size(46, 34);
            this.lblCOQty2.Text      = "1";
            this.lblCOQty2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnCOPlus2.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOPlus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOPlus2.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOPlus2.Location  = new System.Drawing.Point(450, 265);
            this.btnCOPlus2.Name      = "btnCOPlus2";
            this.btnCOPlus2.Size      = new System.Drawing.Size(34, 34);
            this.btnCOPlus2.Text      = "+";
            this.btnCOPlus2.Click    += new System.EventHandler(this.BtnCOPlus2_Click);

            this.lblCOSub2.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCOSub2.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblCOSub2.Location  = new System.Drawing.Point(510, 265);
            this.lblCOSub2.Name      = "lblCOSub2";
            this.lblCOSub2.Size      = new System.Drawing.Size(130, 34);
            this.lblCOSub2.Text      = "₱0.00";
            this.lblCOSub2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.btnCODelete2.BackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.btnCODelete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCODelete2.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCODelete2.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnCODelete2.Location  = new System.Drawing.Point(660, 265);
            this.btnCODelete2.Name      = "btnCODelete2";
            this.btnCODelete2.Size      = new System.Drawing.Size(46, 34);
            this.btnCODelete2.Text      = "🗑";
            this.btnCODelete2.Click    += new System.EventHandler(this.BtnCODelete2_Click);

            // ── ROW 3 (Y = 340) ──────────────────────────────────────────
            this.picCOItem3.BackColor   = System.Drawing.Color.FromArgb(255, 248, 240);
            this.picCOItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCOItem3.Location    = new System.Drawing.Point(30, 340);
            this.picCOItem3.Name        = "picCOItem3";
            this.picCOItem3.Size        = new System.Drawing.Size(90, 70);
            this.picCOItem3.SizeMode    = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCOItem3.TabIndex    = 30;

            this.lblCOName3.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOName3.Location  = new System.Drawing.Point(135, 345);
            this.lblCOName3.Name      = "lblCOName3";
            this.lblCOName3.Size      = new System.Drawing.Size(220, 28);
            this.lblCOName3.Text      = "Item Name 3";

            this.lblCOPrice3.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCOPrice3.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCOPrice3.Location  = new System.Drawing.Point(135, 375);
            this.lblCOPrice3.Name      = "lblCOPrice3";
            this.lblCOPrice3.Size      = new System.Drawing.Size(220, 24);
            this.lblCOPrice3.Text      = "₱0.00";

            this.btnCOMinus3.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOMinus3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOMinus3.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOMinus3.Location  = new System.Drawing.Point(370, 355);
            this.btnCOMinus3.Name      = "btnCOMinus3";
            this.btnCOMinus3.Size      = new System.Drawing.Size(34, 34);
            this.btnCOMinus3.Text      = "−";
            this.btnCOMinus3.Click    += new System.EventHandler(this.BtnCOMinus3_Click);

            this.lblCOQty3.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOQty3.Location  = new System.Drawing.Point(404, 355);
            this.lblCOQty3.Name      = "lblCOQty3";
            this.lblCOQty3.Size      = new System.Drawing.Size(46, 34);
            this.lblCOQty3.Text      = "1";
            this.lblCOQty3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnCOPlus3.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOPlus3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOPlus3.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOPlus3.Location  = new System.Drawing.Point(450, 355);
            this.btnCOPlus3.Name      = "btnCOPlus3";
            this.btnCOPlus3.Size      = new System.Drawing.Size(34, 34);
            this.btnCOPlus3.Text      = "+";
            this.btnCOPlus3.Click    += new System.EventHandler(this.BtnCOPlus3_Click);

            this.lblCOSub3.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCOSub3.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblCOSub3.Location  = new System.Drawing.Point(510, 355);
            this.lblCOSub3.Name      = "lblCOSub3";
            this.lblCOSub3.Size      = new System.Drawing.Size(130, 34);
            this.lblCOSub3.Text      = "₱0.00";
            this.lblCOSub3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.btnCODelete3.BackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.btnCODelete3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCODelete3.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCODelete3.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnCODelete3.Location  = new System.Drawing.Point(660, 355);
            this.btnCODelete3.Name      = "btnCODelete3";
            this.btnCODelete3.Size      = new System.Drawing.Size(46, 34);
            this.btnCODelete3.Text      = "🗑";
            this.btnCODelete3.Click    += new System.EventHandler(this.BtnCODelete3_Click);

            // ── ROW 4 (Y = 430) ──────────────────────────────────────────
            this.picCOItem4.BackColor   = System.Drawing.Color.FromArgb(255, 248, 240);
            this.picCOItem4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCOItem4.Location    = new System.Drawing.Point(30, 430);
            this.picCOItem4.Name        = "picCOItem4";
            this.picCOItem4.Size        = new System.Drawing.Size(90, 70);
            this.picCOItem4.SizeMode    = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCOItem4.TabIndex    = 40;

            this.lblCOName4.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOName4.Location  = new System.Drawing.Point(135, 435);
            this.lblCOName4.Name      = "lblCOName4";
            this.lblCOName4.Size      = new System.Drawing.Size(220, 28);
            this.lblCOName4.Text      = "Item Name 4";

            this.lblCOPrice4.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCOPrice4.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCOPrice4.Location  = new System.Drawing.Point(135, 465);
            this.lblCOPrice4.Name      = "lblCOPrice4";
            this.lblCOPrice4.Size      = new System.Drawing.Size(220, 24);
            this.lblCOPrice4.Text      = "₱0.00";

            this.btnCOMinus4.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOMinus4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOMinus4.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOMinus4.Location  = new System.Drawing.Point(370, 445);
            this.btnCOMinus4.Name      = "btnCOMinus4";
            this.btnCOMinus4.Size      = new System.Drawing.Size(34, 34);
            this.btnCOMinus4.Text      = "−";
            this.btnCOMinus4.Click    += new System.EventHandler(this.BtnCOMinus4_Click);

            this.lblCOQty4.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOQty4.Location  = new System.Drawing.Point(404, 445);
            this.lblCOQty4.Name      = "lblCOQty4";
            this.lblCOQty4.Size      = new System.Drawing.Size(46, 34);
            this.lblCOQty4.Text      = "1";
            this.lblCOQty4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnCOPlus4.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOPlus4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOPlus4.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOPlus4.Location  = new System.Drawing.Point(450, 445);
            this.btnCOPlus4.Name      = "btnCOPlus4";
            this.btnCOPlus4.Size      = new System.Drawing.Size(34, 34);
            this.btnCOPlus4.Text      = "+";
            this.btnCOPlus4.Click    += new System.EventHandler(this.BtnCOPlus4_Click);

            this.lblCOSub4.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCOSub4.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblCOSub4.Location  = new System.Drawing.Point(510, 445);
            this.lblCOSub4.Name      = "lblCOSub4";
            this.lblCOSub4.Size      = new System.Drawing.Size(130, 34);
            this.lblCOSub4.Text      = "₱0.00";
            this.lblCOSub4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.btnCODelete4.BackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.btnCODelete4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCODelete4.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCODelete4.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnCODelete4.Location  = new System.Drawing.Point(660, 445);
            this.btnCODelete4.Name      = "btnCODelete4";
            this.btnCODelete4.Size      = new System.Drawing.Size(46, 34);
            this.btnCODelete4.Text      = "🗑";
            this.btnCODelete4.Click    += new System.EventHandler(this.BtnCODelete4_Click);

            // ── ROW 5 (Y = 520) ──────────────────────────────────────────
            this.picCOItem5.BackColor   = System.Drawing.Color.FromArgb(255, 248, 240);
            this.picCOItem5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCOItem5.Location    = new System.Drawing.Point(30, 520);
            this.picCOItem5.Name        = "picCOItem5";
            this.picCOItem5.Size        = new System.Drawing.Size(90, 70);
            this.picCOItem5.SizeMode    = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCOItem5.TabIndex    = 50;

            this.lblCOName5.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOName5.Location  = new System.Drawing.Point(135, 525);
            this.lblCOName5.Name      = "lblCOName5";
            this.lblCOName5.Size      = new System.Drawing.Size(220, 28);
            this.lblCOName5.Text      = "Item Name 5";

            this.lblCOPrice5.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCOPrice5.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCOPrice5.Location  = new System.Drawing.Point(135, 555);
            this.lblCOPrice5.Name      = "lblCOPrice5";
            this.lblCOPrice5.Size      = new System.Drawing.Size(220, 24);
            this.lblCOPrice5.Text      = "₱0.00";

            this.btnCOMinus5.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOMinus5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOMinus5.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOMinus5.Location  = new System.Drawing.Point(370, 535);
            this.btnCOMinus5.Name      = "btnCOMinus5";
            this.btnCOMinus5.Size      = new System.Drawing.Size(34, 34);
            this.btnCOMinus5.Text      = "−";
            this.btnCOMinus5.Click    += new System.EventHandler(this.BtnCOMinus5_Click);

            this.lblCOQty5.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOQty5.Location  = new System.Drawing.Point(404, 535);
            this.lblCOQty5.Name      = "lblCOQty5";
            this.lblCOQty5.Size      = new System.Drawing.Size(46, 34);
            this.lblCOQty5.Text      = "1";
            this.lblCOQty5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnCOPlus5.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOPlus5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOPlus5.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOPlus5.Location  = new System.Drawing.Point(450, 535);
            this.btnCOPlus5.Name      = "btnCOPlus5";
            this.btnCOPlus5.Size      = new System.Drawing.Size(34, 34);
            this.btnCOPlus5.Text      = "+";
            this.btnCOPlus5.Click    += new System.EventHandler(this.BtnCOPlus5_Click);

            this.lblCOSub5.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCOSub5.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblCOSub5.Location  = new System.Drawing.Point(510, 535);
            this.lblCOSub5.Name      = "lblCOSub5";
            this.lblCOSub5.Size      = new System.Drawing.Size(130, 34);
            this.lblCOSub5.Text      = "₱0.00";
            this.lblCOSub5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.btnCODelete5.BackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.btnCODelete5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCODelete5.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCODelete5.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnCODelete5.Location  = new System.Drawing.Point(660, 535);
            this.btnCODelete5.Name      = "btnCODelete5";
            this.btnCODelete5.Size      = new System.Drawing.Size(46, 34);
            this.btnCODelete5.Text      = "🗑";
            this.btnCODelete5.Click    += new System.EventHandler(this.BtnCODelete5_Click);

            // ── ROW 6 (Y = 610) ──────────────────────────────────────────
            this.picCOItem6.BackColor   = System.Drawing.Color.FromArgb(255, 248, 240);
            this.picCOItem6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCOItem6.Location    = new System.Drawing.Point(30, 610);
            this.picCOItem6.Name        = "picCOItem6";
            this.picCOItem6.Size        = new System.Drawing.Size(90, 70);
            this.picCOItem6.SizeMode    = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCOItem6.TabIndex    = 60;

            this.lblCOName6.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOName6.Location  = new System.Drawing.Point(135, 615);
            this.lblCOName6.Name      = "lblCOName6";
            this.lblCOName6.Size      = new System.Drawing.Size(220, 28);
            this.lblCOName6.Text      = "Item Name 6";

            this.lblCOPrice6.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCOPrice6.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCOPrice6.Location  = new System.Drawing.Point(135, 645);
            this.lblCOPrice6.Name      = "lblCOPrice6";
            this.lblCOPrice6.Size      = new System.Drawing.Size(220, 24);
            this.lblCOPrice6.Text      = "₱0.00";

            this.btnCOMinus6.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOMinus6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOMinus6.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOMinus6.Location  = new System.Drawing.Point(370, 625);
            this.btnCOMinus6.Name      = "btnCOMinus6";
            this.btnCOMinus6.Size      = new System.Drawing.Size(34, 34);
            this.btnCOMinus6.Text      = "−";
            this.btnCOMinus6.Click    += new System.EventHandler(this.BtnCOMinus6_Click);

            this.lblCOQty6.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCOQty6.Location  = new System.Drawing.Point(404, 625);
            this.lblCOQty6.Name      = "lblCOQty6";
            this.lblCOQty6.Size      = new System.Drawing.Size(46, 34);
            this.lblCOQty6.Text      = "1";
            this.lblCOQty6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnCOPlus6.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnCOPlus6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOPlus6.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCOPlus6.Location  = new System.Drawing.Point(450, 625);
            this.btnCOPlus6.Name      = "btnCOPlus6";
            this.btnCOPlus6.Size      = new System.Drawing.Size(34, 34);
            this.btnCOPlus6.Text      = "+";
            this.btnCOPlus6.Click    += new System.EventHandler(this.BtnCOPlus6_Click);

            this.lblCOSub6.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCOSub6.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblCOSub6.Location  = new System.Drawing.Point(510, 625);
            this.lblCOSub6.Name      = "lblCOSub6";
            this.lblCOSub6.Size      = new System.Drawing.Size(130, 34);
            this.lblCOSub6.Text      = "₱0.00";
            this.lblCOSub6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.btnCODelete6.BackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.btnCODelete6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCODelete6.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCODelete6.ForeColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnCODelete6.Location  = new System.Drawing.Point(660, 625);
            this.btnCODelete6.Name      = "btnCODelete6";
            this.btnCODelete6.Size      = new System.Drawing.Size(46, 34);
            this.btnCODelete6.Text      = "🗑";
            this.btnCODelete6.Click    += new System.EventHandler(this.BtnCODelete6_Click);

            // ════════════════════════════════════════════════════════════
            //  RIGHT CARD: DISCOUNTS & PROMOS + TOTALS + CONFIRM ORDER
            //  (Anchored Top/Right just like Screenshot 3!)
            // ════════════════════════════════════════════════════════════
            this.grpDiscounts.Anchor    = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.grpDiscounts.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpDiscounts.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.grpDiscounts.Location  = new System.Drawing.Point(760, 110);
            this.grpDiscounts.Name      = "grpDiscounts";
            this.grpDiscounts.Size      = new System.Drawing.Size(480, 200);
            this.grpDiscounts.TabIndex  = 100;
            this.grpDiscounts.TabStop   = false;
            this.grpDiscounts.Text      = "🎟  Discounts & Promos";

            this.rbtnRegular.Checked  = true;
            this.rbtnRegular.Font     = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rbtnRegular.Location = new System.Drawing.Point(24, 40);
            this.rbtnRegular.Name     = "rbtnRegular";
            this.rbtnRegular.Size     = new System.Drawing.Size(430, 40);
            this.rbtnRegular.TabIndex = 0;
            this.rbtnRegular.TabStop  = true;
            this.rbtnRegular.Text     = "Regular Price                                                0%";
            this.rbtnRegular.CheckedChanged += new System.EventHandler(this.Discount_CheckedChanged);

            this.rbtnSenior.Font     = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rbtnSenior.Location = new System.Drawing.Point(24, 90);
            this.rbtnSenior.Name     = "rbtnSenior";
            this.rbtnSenior.Size     = new System.Drawing.Size(430, 40);
            this.rbtnSenior.TabIndex = 1;
            this.rbtnSenior.Text     = "Senior Citizen                                            -20%";
            this.rbtnSenior.CheckedChanged += new System.EventHandler(this.Discount_CheckedChanged);

            this.rbtnPWD.Font     = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.rbtnPWD.Location = new System.Drawing.Point(24, 140);
            this.rbtnPWD.Name     = "rbtnPWD";
            this.rbtnPWD.Size     = new System.Drawing.Size(430, 40);
            this.rbtnPWD.TabIndex = 2;
            this.rbtnPWD.Text     = "PWD / Disability                                         -15%";
            this.rbtnPWD.CheckedChanged += new System.EventHandler(this.Discount_CheckedChanged);

            this.grpDiscounts.Controls.Add(this.rbtnRegular);
            this.grpDiscounts.Controls.Add(this.rbtnSenior);
            this.grpDiscounts.Controls.Add(this.rbtnPWD);

            this.lblCOSubtotalAmt.Anchor    = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblCOSubtotalAmt.Font      = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCOSubtotalAmt.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblCOSubtotalAmt.Location  = new System.Drawing.Point(760, 330);
            this.lblCOSubtotalAmt.Name      = "lblCOSubtotalAmt";
            this.lblCOSubtotalAmt.Size      = new System.Drawing.Size(480, 30);
            this.lblCOSubtotalAmt.TabIndex  = 101;
            this.lblCOSubtotalAmt.Text      = "Subtotal:                                                   ₱0.00";

            this.lblCODiscountAmt.Anchor    = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblCODiscountAmt.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCODiscountAmt.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.lblCODiscountAmt.Location  = new System.Drawing.Point(760, 365);
            this.lblCODiscountAmt.Name      = "lblCODiscountAmt";
            this.lblCODiscountAmt.Size      = new System.Drawing.Size(480, 30);
            this.lblCODiscountAmt.TabIndex  = 102;
            this.lblCODiscountAmt.Text      = "Discount:                                                −₱0.00";

            this.lblCOTotalAmt.Anchor    = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblCOTotalAmt.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCOTotalAmt.ForeColor = System.Drawing.Color.FromArgb(253, 184, 19);
            this.lblCOTotalAmt.BackColor = System.Drawing.Color.FromArgb(40, 20, 5);
            this.lblCOTotalAmt.Location  = new System.Drawing.Point(760, 410);
            this.lblCOTotalAmt.Name      = "lblCOTotalAmt";
            this.lblCOTotalAmt.Size      = new System.Drawing.Size(480, 60);
            this.lblCOTotalAmt.TabIndex  = 103;
            this.lblCOTotalAmt.Text      = "TOTAL: ₱0.00";
            this.lblCOTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnConfirmOrder.Anchor    = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnConfirmOrder.BackColor = System.Drawing.Color.FromArgb(218, 41, 28);
            this.btnConfirmOrder.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.FlatAppearance.BorderSize = 0;
            this.btnConfirmOrder.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOrder.Location  = new System.Drawing.Point(760, 490);
            this.btnConfirmOrder.Name      = "btnConfirmOrder";
            this.btnConfirmOrder.Size      = new System.Drawing.Size(480, 70);
            this.btnConfirmOrder.TabIndex  = 104;
            this.btnConfirmOrder.Text      = "CONFIRM ORDER →";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click    += new System.EventHandler(this.BtnConfirmOrder_Click);

            // ── FORM ─────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll          = true;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(1280, 800);

            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.lblCOTotalAmt);
            this.Controls.Add(this.lblCODiscountAmt);
            this.Controls.Add(this.lblCOSubtotalAmt);
            this.Controls.Add(this.grpDiscounts);

            this.Controls.Add(this.btnCODelete6);
            this.Controls.Add(this.lblCOSub6);
            this.Controls.Add(this.btnCOPlus6);
            this.Controls.Add(this.lblCOQty6);
            this.Controls.Add(this.btnCOMinus6);
            this.Controls.Add(this.lblCOPrice6);
            this.Controls.Add(this.lblCOName6);
            this.Controls.Add(this.picCOItem6);

            this.Controls.Add(this.btnCODelete5);
            this.Controls.Add(this.lblCOSub5);
            this.Controls.Add(this.btnCOPlus5);
            this.Controls.Add(this.lblCOQty5);
            this.Controls.Add(this.btnCOMinus5);
            this.Controls.Add(this.lblCOPrice5);
            this.Controls.Add(this.lblCOName5);
            this.Controls.Add(this.picCOItem5);

            this.Controls.Add(this.btnCODelete4);
            this.Controls.Add(this.lblCOSub4);
            this.Controls.Add(this.btnCOPlus4);
            this.Controls.Add(this.lblCOQty4);
            this.Controls.Add(this.btnCOMinus4);
            this.Controls.Add(this.lblCOPrice4);
            this.Controls.Add(this.lblCOName4);
            this.Controls.Add(this.picCOItem4);

            this.Controls.Add(this.btnCODelete3);
            this.Controls.Add(this.lblCOSub3);
            this.Controls.Add(this.btnCOPlus3);
            this.Controls.Add(this.lblCOQty3);
            this.Controls.Add(this.btnCOMinus3);
            this.Controls.Add(this.lblCOPrice3);
            this.Controls.Add(this.lblCOName3);
            this.Controls.Add(this.picCOItem3);

            this.Controls.Add(this.btnCODelete2);
            this.Controls.Add(this.lblCOSub2);
            this.Controls.Add(this.btnCOPlus2);
            this.Controls.Add(this.lblCOQty2);
            this.Controls.Add(this.btnCOMinus2);
            this.Controls.Add(this.lblCOPrice2);
            this.Controls.Add(this.lblCOName2);
            this.Controls.Add(this.picCOItem2);

            this.Controls.Add(this.btnCODelete1);
            this.Controls.Add(this.lblCOSub1);
            this.Controls.Add(this.btnCOPlus1);
            this.Controls.Add(this.lblCOQty1);
            this.Controls.Add(this.btnCOMinus1);
            this.Controls.Add(this.lblCOPrice1);
            this.Controls.Add(this.lblCOName1);
            this.Controls.Add(this.picCOItem1);

            this.Controls.Add(this.btnAddMoreItems);
            this.Controls.Add(this.lblReviewTitle);
            this.Controls.Add(this.lblSubheader);
            this.Controls.Add(this.lblOrderBadge);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHeader);

            this.MinimumSize   = new System.Drawing.Size(1116, 759);
            this.Name          = "FormCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text          = "🐝 HappyBee Kiosk — Checkout Review";
            this.Load         += new System.EventHandler(this.FormCheckout_Load);

            ((System.ComponentModel.ISupportInitialize)this.picCOItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picCOItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picCOItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picCOItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picCOItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.picCOItem6).EndInit();
            this.grpDiscounts.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label  lblHeader;
        private System.Windows.Forms.Label  lblSubheader;
        private System.Windows.Forms.Label  lblOrderBadge;
        private System.Windows.Forms.Label  lblReviewTitle;
        private System.Windows.Forms.Button btnAddMoreItems;

        private System.Windows.Forms.PictureBox picCOItem1;
        private System.Windows.Forms.Label      lblCOName1;
        private System.Windows.Forms.Label      lblCOPrice1;
        private System.Windows.Forms.Button     btnCOMinus1;
        private System.Windows.Forms.Label      lblCOQty1;
        private System.Windows.Forms.Button     btnCOPlus1;
        private System.Windows.Forms.Label      lblCOSub1;
        private System.Windows.Forms.Button     btnCODelete1;

        private System.Windows.Forms.PictureBox picCOItem2;
        private System.Windows.Forms.Label      lblCOName2;
        private System.Windows.Forms.Label      lblCOPrice2;
        private System.Windows.Forms.Button     btnCOMinus2;
        private System.Windows.Forms.Label      lblCOQty2;
        private System.Windows.Forms.Button     btnCOPlus2;
        private System.Windows.Forms.Label      lblCOSub2;
        private System.Windows.Forms.Button     btnCODelete2;

        private System.Windows.Forms.PictureBox picCOItem3;
        private System.Windows.Forms.Label      lblCOName3;
        private System.Windows.Forms.Label      lblCOPrice3;
        private System.Windows.Forms.Button     btnCOMinus3;
        private System.Windows.Forms.Label      lblCOQty3;
        private System.Windows.Forms.Button     btnCOPlus3;
        private System.Windows.Forms.Label      lblCOSub3;
        private System.Windows.Forms.Button     btnCODelete3;

        private System.Windows.Forms.PictureBox picCOItem4;
        private System.Windows.Forms.Label      lblCOName4;
        private System.Windows.Forms.Label      lblCOPrice4;
        private System.Windows.Forms.Button     btnCOMinus4;
        private System.Windows.Forms.Label      lblCOQty4;
        private System.Windows.Forms.Button     btnCOPlus4;
        private System.Windows.Forms.Label      lblCOSub4;
        private System.Windows.Forms.Button     btnCODelete4;

        private System.Windows.Forms.PictureBox picCOItem5;
        private System.Windows.Forms.Label      lblCOName5;
        private System.Windows.Forms.Label      lblCOPrice5;
        private System.Windows.Forms.Button     btnCOMinus5;
        private System.Windows.Forms.Label      lblCOQty5;
        private System.Windows.Forms.Button     btnCOPlus5;
        private System.Windows.Forms.Label      lblCOSub5;
        private System.Windows.Forms.Button     btnCODelete5;

        private System.Windows.Forms.PictureBox picCOItem6;
        private System.Windows.Forms.Label      lblCOName6;
        private System.Windows.Forms.Label      lblCOPrice6;
        private System.Windows.Forms.Button     btnCOMinus6;
        private System.Windows.Forms.Label      lblCOQty6;
        private System.Windows.Forms.Button     btnCOPlus6;
        private System.Windows.Forms.Label      lblCOSub6;
        private System.Windows.Forms.Button     btnCODelete6;

        private System.Windows.Forms.GroupBox    grpDiscounts;
        private System.Windows.Forms.RadioButton rbtnRegular;
        private System.Windows.Forms.RadioButton rbtnSenior;
        private System.Windows.Forms.RadioButton rbtnPWD;

        private System.Windows.Forms.Label  lblCOSubtotalAmt;
        private System.Windows.Forms.Label  lblCODiscountAmt;
        private System.Windows.Forms.Label  lblCOTotalAmt;
        private System.Windows.Forms.Button btnConfirmOrder;
    }
}
