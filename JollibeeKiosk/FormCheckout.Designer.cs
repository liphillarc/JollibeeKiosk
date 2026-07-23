namespace JollibeeKiosk
{
    partial class FormCheckout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnBack = new System.Windows.Forms.Button();
            lblHeader = new System.Windows.Forms.Label();
            lblSubheader = new System.Windows.Forms.Label();
            lblOrderBadge = new System.Windows.Forms.Label();
            lblReviewTitle = new System.Windows.Forms.Label();
            btnAddMoreItems = new System.Windows.Forms.Button();
            picCOItem1 = new System.Windows.Forms.PictureBox();
            lblCOName1 = new System.Windows.Forms.Label();
            lblCOPrice1 = new System.Windows.Forms.Label();
            btnCOMinus1 = new System.Windows.Forms.Button();
            lblCOQty1 = new System.Windows.Forms.Label();
            btnCOPlus1 = new System.Windows.Forms.Button();
            lblCOSub1 = new System.Windows.Forms.Label();
            btnCODelete1 = new System.Windows.Forms.Button();
            picCOItem2 = new System.Windows.Forms.PictureBox();
            lblCOName2 = new System.Windows.Forms.Label();
            lblCOPrice2 = new System.Windows.Forms.Label();
            btnCOMinus2 = new System.Windows.Forms.Button();
            lblCOQty2 = new System.Windows.Forms.Label();
            btnCOPlus2 = new System.Windows.Forms.Button();
            lblCOSub2 = new System.Windows.Forms.Label();
            btnCODelete2 = new System.Windows.Forms.Button();
            picCOItem3 = new System.Windows.Forms.PictureBox();
            lblCOName3 = new System.Windows.Forms.Label();
            lblCOPrice3 = new System.Windows.Forms.Label();
            btnCOMinus3 = new System.Windows.Forms.Button();
            lblCOQty3 = new System.Windows.Forms.Label();
            btnCOPlus3 = new System.Windows.Forms.Button();
            lblCOSub3 = new System.Windows.Forms.Label();
            btnCODelete3 = new System.Windows.Forms.Button();
            picCOItem4 = new System.Windows.Forms.PictureBox();
            lblCOName4 = new System.Windows.Forms.Label();
            lblCOPrice4 = new System.Windows.Forms.Label();
            btnCOMinus4 = new System.Windows.Forms.Button();
            lblCOQty4 = new System.Windows.Forms.Label();
            btnCOPlus4 = new System.Windows.Forms.Button();
            lblCOSub4 = new System.Windows.Forms.Label();
            btnCODelete4 = new System.Windows.Forms.Button();
            picCOItem5 = new System.Windows.Forms.PictureBox();
            lblCOName5 = new System.Windows.Forms.Label();
            lblCOPrice5 = new System.Windows.Forms.Label();
            btnCOMinus5 = new System.Windows.Forms.Button();
            lblCOQty5 = new System.Windows.Forms.Label();
            btnCOPlus5 = new System.Windows.Forms.Button();
            lblCOSub5 = new System.Windows.Forms.Label();
            btnCODelete5 = new System.Windows.Forms.Button();
            picCOItem6 = new System.Windows.Forms.PictureBox();
            lblCOName6 = new System.Windows.Forms.Label();
            lblCOPrice6 = new System.Windows.Forms.Label();
            btnCOMinus6 = new System.Windows.Forms.Button();
            lblCOQty6 = new System.Windows.Forms.Label();
            btnCOPlus6 = new System.Windows.Forms.Button();
            lblCOSub6 = new System.Windows.Forms.Label();
            btnCODelete6 = new System.Windows.Forms.Button();
            grpDiscounts = new System.Windows.Forms.GroupBox();
            rbtnRegular = new System.Windows.Forms.RadioButton();
            rbtnPWDSenior = new System.Windows.Forms.RadioButton();
            lblCOSubtotalAmt = new Label();
            lblCODiscountAmt = new Label();
            lblCOTotalAmt = new Label();
            btnConfirmOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)picCOItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCOItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCOItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCOItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCOItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCOItem6).BeginInit();
            grpDiscounts.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(218, 41, 28);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 36);
            btnBack.TabIndex = 1;
            btnBack.Text = "← Go Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(218, 41, 28);
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1280, 60);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "                  🛒  CHECKOUT AND REVIEW";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubheader
            // 
            lblSubheader.Font = new Font("Segoe UI", 11F);
            lblSubheader.ForeColor = Color.FromArgb(100, 100, 100);
            lblSubheader.Location = new Point(30, 70);
            lblSubheader.Name = "lblSubheader";
            lblSubheader.Size = new Size(500, 25);
            lblSubheader.TabIndex = 3;
            lblSubheader.Text = "Please review your order items and select any applicable discount.";
            // 
            // lblOrderBadge
            // 
            lblOrderBadge.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblOrderBadge.BackColor = Color.FromArgb(218, 41, 28);
            lblOrderBadge.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblOrderBadge.ForeColor = Color.FromArgb(253, 184, 19);
            lblOrderBadge.Location = new Point(980, 0);
            lblOrderBadge.Name = "lblOrderBadge";
            lblOrderBadge.Size = new Size(280, 60);
            lblOrderBadge.TabIndex = 2;
            lblOrderBadge.Text = "Dine In Order";
            lblOrderBadge.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblReviewTitle
            // 
            lblReviewTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblReviewTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblReviewTitle.Location = new Point(30, 110);
            lblReviewTitle.Name = "lblReviewTitle";
            lblReviewTitle.Size = new Size(300, 30);
            lblReviewTitle.TabIndex = 4;
            lblReviewTitle.Text = "Review Items";
            // 
            // btnAddMoreItems
            // 
            btnAddMoreItems.Cursor = Cursors.Hand;
            btnAddMoreItems.FlatAppearance.BorderColor = Color.FromArgb(218, 41, 28);
            btnAddMoreItems.FlatStyle = FlatStyle.Flat;
            btnAddMoreItems.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddMoreItems.ForeColor = Color.FromArgb(218, 41, 28);
            btnAddMoreItems.Location = new Point(530, 105);
            btnAddMoreItems.Name = "btnAddMoreItems";
            btnAddMoreItems.Size = new Size(180, 36);
            btnAddMoreItems.TabIndex = 5;
            btnAddMoreItems.Text = "+ Add more items";
            btnAddMoreItems.UseVisualStyleBackColor = false;
            btnAddMoreItems.Click += BtnAddMoreItems_Click;
            // 
            // picCOItem1
            // 
            picCOItem1.BackColor = Color.FromArgb(255, 248, 240);
            picCOItem1.BackgroundImageLayout = ImageLayout.Stretch;
            picCOItem1.BorderStyle = BorderStyle.FixedSingle;
            picCOItem1.Location = new Point(30, 160);
            picCOItem1.Name = "picCOItem1";
            picCOItem1.Size = new Size(90, 70);
            picCOItem1.SizeMode = PictureBoxSizeMode.Zoom;
            picCOItem1.TabIndex = 20;
            picCOItem1.TabStop = false;
            // lblCOName1
            lblCOName1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOName1.Location = new Point(135, 165);
            lblCOName1.Name = "lblCOName1";
            lblCOName1.Size = new Size(220, 28);
            lblCOName1.TabIndex = 146;
            lblCOName1.Text = "Item Name 1";
            // lblCOPrice1
            lblCOPrice1.Font = new Font("Segoe UI", 11F);
            lblCOPrice1.ForeColor = Color.FromArgb(120, 120, 120);
            lblCOPrice1.Location = new Point(135, 195);
            lblCOPrice1.Name = "lblCOPrice1";
            lblCOPrice1.Size = new Size(220, 24);
            lblCOPrice1.TabIndex = 145;
            lblCOPrice1.Text = "₱0.00";
            // btnCOMinus1
            btnCOMinus1.BackColor = Color.FromArgb(235, 235, 235);
            btnCOMinus1.FlatStyle = FlatStyle.Flat;
            btnCOMinus1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOMinus1.Location = new Point(370, 175);
            btnCOMinus1.Name = "btnCOMinus1";
            btnCOMinus1.Size = new Size(34, 34);
            btnCOMinus1.TabIndex = 144;
            btnCOMinus1.Text = "-";
            btnCOMinus1.UseVisualStyleBackColor = false;
            btnCOMinus1.Click += BtnCOMinus1_Click;
            // lblCOQty1
            lblCOQty1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOQty1.Location = new Point(404, 175);
            lblCOQty1.Name = "lblCOQty1";
            lblCOQty1.Size = new Size(46, 34);
            lblCOQty1.TabIndex = 143;
            lblCOQty1.Text = "1";
            lblCOQty1.TextAlign = ContentAlignment.MiddleCenter;
            // btnCOPlus1
            btnCOPlus1.BackColor = Color.FromArgb(235, 235, 235);
            btnCOPlus1.FlatStyle = FlatStyle.Flat;
            btnCOPlus1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOPlus1.Location = new Point(450, 175);
            btnCOPlus1.Name = "btnCOPlus1";
            btnCOPlus1.Size = new Size(34, 34);
            btnCOPlus1.TabIndex = 142;
            btnCOPlus1.Text = "+";
            btnCOPlus1.UseVisualStyleBackColor = false;
            btnCOPlus1.Click += BtnCOPlus1_Click;
            // lblCOSub1
            lblCOSub1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCOSub1.ForeColor = Color.FromArgb(30, 30, 30);
            lblCOSub1.Location = new Point(510, 175);
            lblCOSub1.Name = "lblCOSub1";
            lblCOSub1.Size = new Size(130, 34);
            lblCOSub1.TabIndex = 141;
            lblCOSub1.Text = "₱0.00";
            lblCOSub1.TextAlign = ContentAlignment.MiddleRight;
            // btnCODelete1
            btnCODelete1.BackColor = Color.FromArgb(255, 235, 235);
            btnCODelete1.FlatStyle = FlatStyle.Flat;
            btnCODelete1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCODelete1.ForeColor = Color.FromArgb(218, 41, 28);
            btnCODelete1.Location = new Point(660, 175);
            btnCODelete1.Name = "btnCODelete1";
            btnCODelete1.Size = new Size(46, 34);
            btnCODelete1.TabIndex = 140;
            btnCODelete1.Text = "🗑️";
            btnCODelete1.UseVisualStyleBackColor = false;
            btnCODelete1.Click += BtnCODelete1_Click;
            // 
            // picCOItem2
            // 
            picCOItem2.BackColor = Color.FromArgb(255, 248, 240);
            picCOItem2.BackgroundImageLayout = ImageLayout.Stretch;
            picCOItem2.BorderStyle = BorderStyle.FixedSingle;
            picCOItem2.Location = new Point(30, 250);
            picCOItem2.Name = "picCOItem2";
            picCOItem2.Size = new Size(90, 70);
            picCOItem2.SizeMode = PictureBoxSizeMode.Zoom;
            picCOItem2.TabIndex = 30;
            picCOItem2.TabStop = false;
            // lblCOName2
            lblCOName2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOName2.Location = new Point(135, 255);
            lblCOName2.Name = "lblCOName2";
            lblCOName2.Size = new Size(220, 28);
            lblCOName2.TabIndex = 140;
            lblCOName2.Text = "Item Name 2";
            // lblCOPrice2
            lblCOPrice2.Font = new Font("Segoe UI", 11F);
            lblCOPrice2.ForeColor = Color.FromArgb(120, 120, 120);
            lblCOPrice2.Location = new Point(135, 285);
            lblCOPrice2.Name = "lblCOPrice2";
            lblCOPrice2.Size = new Size(220, 24);
            lblCOPrice2.TabIndex = 139;
            lblCOPrice2.Text = "₱0.00";
            // btnCOMinus2
            btnCOMinus2.BackColor = Color.FromArgb(235, 235, 235);
            btnCOMinus2.FlatStyle = FlatStyle.Flat;
            btnCOMinus2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOMinus2.Location = new Point(370, 265);
            btnCOMinus2.Name = "btnCOMinus2";
            btnCOMinus2.Size = new Size(34, 34);
            btnCOMinus2.TabIndex = 138;
            btnCOMinus2.Text = "-";
            btnCOMinus2.UseVisualStyleBackColor = false;
            btnCOMinus2.Click += BtnCOMinus2_Click;
            // lblCOQty2
            lblCOQty2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOQty2.Location = new Point(404, 265);
            lblCOQty2.Name = "lblCOQty2";
            lblCOQty2.Size = new Size(46, 34);
            lblCOQty2.TabIndex = 137;
            lblCOQty2.Text = "1";
            lblCOQty2.TextAlign = ContentAlignment.MiddleCenter;
            // btnCOPlus2
            btnCOPlus2.BackColor = Color.FromArgb(235, 235, 235);
            btnCOPlus2.FlatStyle = FlatStyle.Flat;
            btnCOPlus2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOPlus2.Location = new Point(450, 265);
            btnCOPlus2.Name = "btnCOPlus2";
            btnCOPlus2.Size = new Size(34, 34);
            btnCOPlus2.TabIndex = 136;
            btnCOPlus2.Text = "+";
            btnCOPlus2.UseVisualStyleBackColor = false;
            btnCOPlus2.Click += BtnCOPlus2_Click;
            // lblCOSub2
            lblCOSub2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCOSub2.ForeColor = Color.FromArgb(30, 30, 30);
            lblCOSub2.Location = new Point(510, 265);
            lblCOSub2.Name = "lblCOSub2";
            lblCOSub2.Size = new Size(130, 34);
            lblCOSub2.TabIndex = 135;
            lblCOSub2.Text = "₱0.00";
            lblCOSub2.TextAlign = ContentAlignment.MiddleRight;
            // btnCODelete2
            btnCODelete2.BackColor = Color.FromArgb(255, 235, 235);
            btnCODelete2.FlatStyle = FlatStyle.Flat;
            btnCODelete2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCODelete2.ForeColor = Color.FromArgb(218, 41, 28);
            btnCODelete2.Location = new Point(660, 265);
            btnCODelete2.Name = "btnCODelete2";
            btnCODelete2.Size = new Size(46, 34);
            btnCODelete2.TabIndex = 134;
            btnCODelete2.Text = "🗑️";
            btnCODelete2.UseVisualStyleBackColor = false;
            btnCODelete2.Click += BtnCODelete2_Click;
            // 
            // picCOItem3
            // 
            picCOItem3.BackColor = Color.FromArgb(255, 248, 240);
            picCOItem3.BackgroundImageLayout = ImageLayout.Stretch;
            picCOItem3.BorderStyle = BorderStyle.FixedSingle;
            picCOItem3.Location = new Point(30, 340);
            picCOItem3.Name = "picCOItem3";
            picCOItem3.Size = new Size(90, 70);
            picCOItem3.SizeMode = PictureBoxSizeMode.Zoom;
            picCOItem3.TabIndex = 40;
            picCOItem3.TabStop = false;
            // lblCOName3
            lblCOName3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOName3.Location = new Point(135, 345);
            lblCOName3.Name = "lblCOName3";
            lblCOName3.Size = new Size(220, 28);
            lblCOName3.TabIndex = 134;
            lblCOName3.Text = "Item Name 3";
            // lblCOPrice3
            lblCOPrice3.Font = new Font("Segoe UI", 11F);
            lblCOPrice3.ForeColor = Color.FromArgb(120, 120, 120);
            lblCOPrice3.Location = new Point(135, 375);
            lblCOPrice3.Name = "lblCOPrice3";
            lblCOPrice3.Size = new Size(220, 24);
            lblCOPrice3.TabIndex = 133;
            lblCOPrice3.Text = "₱0.00";
            // btnCOMinus3
            btnCOMinus3.BackColor = Color.FromArgb(235, 235, 235);
            btnCOMinus3.FlatStyle = FlatStyle.Flat;
            btnCOMinus3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOMinus3.Location = new Point(370, 355);
            btnCOMinus3.Name = "btnCOMinus3";
            btnCOMinus3.Size = new Size(34, 34);
            btnCOMinus3.TabIndex = 132;
            btnCOMinus3.Text = "-";
            btnCOMinus3.UseVisualStyleBackColor = false;
            btnCOMinus3.Click += BtnCOMinus3_Click;
            // lblCOQty3
            lblCOQty3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOQty3.Location = new Point(404, 355);
            lblCOQty3.Name = "lblCOQty3";
            lblCOQty3.Size = new Size(46, 34);
            lblCOQty3.TabIndex = 131;
            lblCOQty3.Text = "1";
            lblCOQty3.TextAlign = ContentAlignment.MiddleCenter;
            // btnCOPlus3
            btnCOPlus3.BackColor = Color.FromArgb(235, 235, 235);
            btnCOPlus3.FlatStyle = FlatStyle.Flat;
            btnCOPlus3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOPlus3.Location = new Point(450, 355);
            btnCOPlus3.Name = "btnCOPlus3";
            btnCOPlus3.Size = new Size(34, 34);
            btnCOPlus3.TabIndex = 130;
            btnCOPlus3.Text = "+";
            btnCOPlus3.UseVisualStyleBackColor = false;
            btnCOPlus3.Click += BtnCOPlus3_Click;
            // lblCOSub3
            lblCOSub3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCOSub3.ForeColor = Color.FromArgb(30, 30, 30);
            lblCOSub3.Location = new Point(510, 355);
            lblCOSub3.Name = "lblCOSub3";
            lblCOSub3.Size = new Size(130, 34);
            lblCOSub3.TabIndex = 129;
            lblCOSub3.Text = "₱0.00";
            lblCOSub3.TextAlign = ContentAlignment.MiddleRight;
            // btnCODelete3
            btnCODelete3.BackColor = Color.FromArgb(255, 235, 235);
            btnCODelete3.FlatStyle = FlatStyle.Flat;
            btnCODelete3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCODelete3.ForeColor = Color.FromArgb(218, 41, 28);
            btnCODelete3.Location = new Point(660, 355);
            btnCODelete3.Name = "btnCODelete3";
            btnCODelete3.Size = new Size(46, 34);
            btnCODelete3.TabIndex = 128;
            btnCODelete3.Text = "🗑️";
            btnCODelete3.UseVisualStyleBackColor = false;
            btnCODelete3.Click += BtnCODelete3_Click;
            // 
            // picCOItem4
            // 
            picCOItem4.BackColor = Color.FromArgb(255, 248, 240);
            picCOItem4.BackgroundImageLayout = ImageLayout.Stretch;
            picCOItem4.BorderStyle = BorderStyle.FixedSingle;
            picCOItem4.Location = new Point(30, 430);
            picCOItem4.Name = "picCOItem4";
            picCOItem4.Size = new Size(90, 70);
            picCOItem4.SizeMode = PictureBoxSizeMode.Zoom;
            picCOItem4.TabIndex = 50;
            picCOItem4.TabStop = false;
            // lblCOName4
            lblCOName4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOName4.Location = new Point(135, 435);
            lblCOName4.Name = "lblCOName4";
            lblCOName4.Size = new Size(220, 28);
            lblCOName4.TabIndex = 128;
            lblCOName4.Text = "Item Name 4";
            // lblCOPrice4
            lblCOPrice4.Font = new Font("Segoe UI", 11F);
            lblCOPrice4.ForeColor = Color.FromArgb(120, 120, 120);
            lblCOPrice4.Location = new Point(135, 465);
            lblCOPrice4.Name = "lblCOPrice4";
            lblCOPrice4.Size = new Size(220, 24);
            lblCOPrice4.TabIndex = 127;
            lblCOPrice4.Text = "₱0.00";
            // btnCOMinus4
            btnCOMinus4.BackColor = Color.FromArgb(235, 235, 235);
            btnCOMinus4.FlatStyle = FlatStyle.Flat;
            btnCOMinus4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOMinus4.Location = new Point(370, 445);
            btnCOMinus4.Name = "btnCOMinus4";
            btnCOMinus4.Size = new Size(34, 34);
            btnCOMinus4.TabIndex = 126;
            btnCOMinus4.Text = "-";
            btnCOMinus4.UseVisualStyleBackColor = false;
            btnCOMinus4.Click += BtnCOMinus4_Click;
            // lblCOQty4
            lblCOQty4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOQty4.Location = new Point(404, 445);
            lblCOQty4.Name = "lblCOQty4";
            lblCOQty4.Size = new Size(46, 34);
            lblCOQty4.TabIndex = 125;
            lblCOQty4.Text = "1";
            lblCOQty4.TextAlign = ContentAlignment.MiddleCenter;
            // btnCOPlus4
            btnCOPlus4.BackColor = Color.FromArgb(235, 235, 235);
            btnCOPlus4.FlatStyle = FlatStyle.Flat;
            btnCOPlus4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOPlus4.Location = new Point(450, 445);
            btnCOPlus4.Name = "btnCOPlus4";
            btnCOPlus4.Size = new Size(34, 34);
            btnCOPlus4.TabIndex = 124;
            btnCOPlus4.Text = "+";
            btnCOPlus4.UseVisualStyleBackColor = false;
            btnCOPlus4.Click += BtnCOPlus4_Click;
            // lblCOSub4
            lblCOSub4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCOSub4.ForeColor = Color.FromArgb(30, 30, 30);
            lblCOSub4.Location = new Point(510, 445);
            lblCOSub4.Name = "lblCOSub4";
            lblCOSub4.Size = new Size(130, 34);
            lblCOSub4.TabIndex = 123;
            lblCOSub4.Text = "₱0.00";
            lblCOSub4.TextAlign = ContentAlignment.MiddleRight;
            // btnCODelete4
            btnCODelete4.BackColor = Color.FromArgb(255, 235, 235);
            btnCODelete4.FlatStyle = FlatStyle.Flat;
            btnCODelete4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCODelete4.ForeColor = Color.FromArgb(218, 41, 28);
            btnCODelete4.Location = new Point(660, 445);
            btnCODelete4.Name = "btnCODelete4";
            btnCODelete4.Size = new Size(46, 34);
            btnCODelete4.TabIndex = 122;
            btnCODelete4.Text = "🗑️";
            btnCODelete4.UseVisualStyleBackColor = false;
            btnCODelete4.Click += BtnCODelete4_Click;
            // 
            // picCOItem5
            // 
            picCOItem5.BackColor = Color.FromArgb(255, 248, 240);
            picCOItem5.BackgroundImageLayout = ImageLayout.Stretch;
            picCOItem5.BorderStyle = BorderStyle.FixedSingle;
            picCOItem5.Location = new Point(30, 520);
            picCOItem5.Name = "picCOItem5";
            picCOItem5.Size = new Size(90, 70);
            picCOItem5.SizeMode = PictureBoxSizeMode.Zoom;
            picCOItem5.TabIndex = 60;
            picCOItem5.TabStop = false;
            // lblCOName5
            lblCOName5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOName5.Location = new Point(135, 525);
            lblCOName5.Name = "lblCOName5";
            lblCOName5.Size = new Size(220, 28);
            lblCOName5.TabIndex = 122;
            lblCOName5.Text = "Item Name 5";
            // lblCOPrice5
            lblCOPrice5.Font = new Font("Segoe UI", 11F);
            lblCOPrice5.ForeColor = Color.FromArgb(120, 120, 120);
            lblCOPrice5.Location = new Point(135, 555);
            lblCOPrice5.Name = "lblCOPrice5";
            lblCOPrice5.Size = new Size(220, 24);
            lblCOPrice5.TabIndex = 121;
            lblCOPrice5.Text = "₱0.00";
            // btnCOMinus5
            btnCOMinus5.BackColor = Color.FromArgb(235, 235, 235);
            btnCOMinus5.FlatStyle = FlatStyle.Flat;
            btnCOMinus5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOMinus5.Location = new Point(370, 535);
            btnCOMinus5.Name = "btnCOMinus5";
            btnCOMinus5.Size = new Size(34, 34);
            btnCOMinus5.TabIndex = 120;
            btnCOMinus5.Text = "-";
            btnCOMinus5.UseVisualStyleBackColor = false;
            btnCOMinus5.Click += BtnCOMinus5_Click;
            // lblCOQty5
            lblCOQty5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOQty5.Location = new Point(404, 535);
            lblCOQty5.Name = "lblCOQty5";
            lblCOQty5.Size = new Size(46, 34);
            lblCOQty5.TabIndex = 119;
            lblCOQty5.Text = "1";
            lblCOQty5.TextAlign = ContentAlignment.MiddleCenter;
            // btnCOPlus5
            btnCOPlus5.BackColor = Color.FromArgb(235, 235, 235);
            btnCOPlus5.FlatStyle = FlatStyle.Flat;
            btnCOPlus5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOPlus5.Location = new Point(450, 535);
            btnCOPlus5.Name = "btnCOPlus5";
            btnCOPlus5.Size = new Size(34, 34);
            btnCOPlus5.TabIndex = 118;
            btnCOPlus5.Text = "+";
            btnCOPlus5.UseVisualStyleBackColor = false;
            btnCOPlus5.Click += BtnCOPlus5_Click;
            // lblCOSub5
            lblCOSub5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCOSub5.ForeColor = Color.FromArgb(30, 30, 30);
            lblCOSub5.Location = new Point(510, 535);
            lblCOSub5.Name = "lblCOSub5";
            lblCOSub5.Size = new Size(130, 34);
            lblCOSub5.TabIndex = 117;
            lblCOSub5.Text = "₱0.00";
            lblCOSub5.TextAlign = ContentAlignment.MiddleRight;
            // btnCODelete5
            btnCODelete5.BackColor = Color.FromArgb(255, 235, 235);
            btnCODelete5.FlatStyle = FlatStyle.Flat;
            btnCODelete5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCODelete5.ForeColor = Color.FromArgb(218, 41, 28);
            btnCODelete5.Location = new Point(660, 535);
            btnCODelete5.Name = "btnCODelete5";
            btnCODelete5.Size = new Size(46, 34);
            btnCODelete5.TabIndex = 116;
            btnCODelete5.Text = "🗑️";
            btnCODelete5.UseVisualStyleBackColor = false;
            btnCODelete5.Click += BtnCODelete5_Click;
            // 
            // picCOItem6
            // 
            picCOItem6.BackColor = Color.FromArgb(255, 248, 240);
            picCOItem6.BackgroundImageLayout = ImageLayout.Stretch;
            picCOItem6.BorderStyle = BorderStyle.FixedSingle;
            picCOItem6.Location = new Point(30, 610);
            picCOItem6.Name = "picCOItem6";
            picCOItem6.Size = new Size(90, 70);
            picCOItem6.SizeMode = PictureBoxSizeMode.Zoom;
            picCOItem6.TabIndex = 70;
            picCOItem6.TabStop = false;
            // lblCOName6
            lblCOName6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOName6.Location = new Point(135, 615);
            lblCOName6.Name = "lblCOName6";
            lblCOName6.Size = new Size(220, 28);
            lblCOName6.TabIndex = 116;
            lblCOName6.Text = "Item Name 6";
            // lblCOPrice6
            lblCOPrice6.Font = new Font("Segoe UI", 11F);
            lblCOPrice6.ForeColor = Color.FromArgb(120, 120, 120);
            lblCOPrice6.Location = new Point(135, 645);
            lblCOPrice6.Name = "lblCOPrice6";
            lblCOPrice6.Size = new Size(220, 24);
            lblCOPrice6.TabIndex = 115;
            lblCOPrice6.Text = "₱0.00";
            // btnCOMinus6
            btnCOMinus6.BackColor = Color.FromArgb(235, 235, 235);
            btnCOMinus6.FlatStyle = FlatStyle.Flat;
            btnCOMinus6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOMinus6.Location = new Point(370, 625);
            btnCOMinus6.Name = "btnCOMinus6";
            btnCOMinus6.Size = new Size(34, 34);
            btnCOMinus6.TabIndex = 114;
            btnCOMinus6.Text = "-";
            btnCOMinus6.UseVisualStyleBackColor = false;
            btnCOMinus6.Click += BtnCOMinus6_Click;
            // lblCOQty6
            lblCOQty6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOQty6.Location = new Point(404, 625);
            lblCOQty6.Name = "lblCOQty6";
            lblCOQty6.Size = new Size(46, 34);
            lblCOQty6.TabIndex = 113;
            lblCOQty6.Text = "1";
            lblCOQty6.TextAlign = ContentAlignment.MiddleCenter;
            // btnCOPlus6
            btnCOPlus6.BackColor = Color.FromArgb(235, 235, 235);
            btnCOPlus6.FlatStyle = FlatStyle.Flat;
            btnCOPlus6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOPlus6.Location = new Point(450, 625);
            btnCOPlus6.Name = "btnCOPlus6";
            btnCOPlus6.Size = new Size(34, 34);
            btnCOPlus6.TabIndex = 112;
            btnCOPlus6.Text = "+";
            btnCOPlus6.UseVisualStyleBackColor = false;
            btnCOPlus6.Click += BtnCOPlus6_Click;
            // lblCOSub6
            lblCOSub6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCOSub6.ForeColor = Color.FromArgb(30, 30, 30);
            lblCOSub6.Location = new Point(510, 625);
            lblCOSub6.Name = "lblCOSub6";
            lblCOSub6.Size = new Size(130, 34);
            lblCOSub6.TabIndex = 111;
            lblCOSub6.Text = "₱0.00";
            lblCOSub6.TextAlign = ContentAlignment.MiddleRight;
            // btnCODelete6
            btnCODelete6.BackColor = Color.FromArgb(255, 235, 235);
            btnCODelete6.FlatStyle = FlatStyle.Flat;
            btnCODelete6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCODelete6.ForeColor = Color.FromArgb(218, 41, 28);
            btnCODelete6.Location = new Point(660, 625);
            btnCODelete6.Name = "btnCODelete6";
            btnCODelete6.Size = new Size(46, 34);
            btnCODelete6.TabIndex = 110;
            btnCODelete6.Text = "🗑️";
            btnCODelete6.UseVisualStyleBackColor = false;
            btnCODelete6.Click += BtnCODelete6_Click;
            // 
            // grpDiscounts
            // 
            grpDiscounts.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            grpDiscounts.Controls.Add(rbtnRegular);
            grpDiscounts.Controls.Add(rbtnPWDSenior);
            grpDiscounts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpDiscounts.ForeColor = Color.FromArgb(40, 40, 40);
            grpDiscounts.Location = new Point(760, 110);
            grpDiscounts.Name = "grpDiscounts";
            grpDiscounts.Size = new Size(480, 200);
            grpDiscounts.TabIndex = 100;
            grpDiscounts.TabStop = false;
            grpDiscounts.Text = "🏷️  Discounts & Promos";
            // 
            // rbtnRegular
            // 
            rbtnRegular.Checked = true;
            rbtnRegular.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtnRegular.Location = new Point(24, 40);
            rbtnRegular.Name = "rbtnRegular";
            rbtnRegular.Size = new Size(430, 40);
            rbtnRegular.TabIndex = 0;
            rbtnRegular.TabStop = true;
            rbtnRegular.Text = "Regular Price                                                0%";
            rbtnRegular.CheckedChanged += Discount_CheckedChanged;
            // 
            // rbtnPWDSenior
            // 
            rbtnPWDSenior.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtnPWDSenior.Location = new Point(24, 90);
            rbtnPWDSenior.Name = "rbtnPWDSenior";
            rbtnPWDSenior.Size = new Size(430, 40);
            rbtnPWDSenior.TabIndex = 1;
btnCODelete4.Size = new Size(46, 34);
            btnCODelete4.TabIndex = 122;
            btnCODelete4.Text = "🗑️";
            btnCODelete4.UseVisualStyleBackColor = false;
            btnCODelete4.Click += BtnCODelete4_Click;
            // 
            // picCOItem5
            // 
            picCOItem5.BackColor = Color.FromArgb(255, 248, 240);
            picCOItem5.BackgroundImageLayout = ImageLayout.Stretch;
            picCOItem5.BorderStyle = BorderStyle.FixedSingle;
            picCOItem5.Location = new Point(30, 520);
            picCOItem5.Name = "picCOItem5";
            picCOItem5.Size = new Size(90, 70);
            picCOItem5.SizeMode = PictureBoxSizeMode.Zoom;
            picCOItem5.TabIndex = 60;
            picCOItem5.TabStop = false;
            // lblCOName5
            lblCOName5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOName5.Location = new Point(135, 525);
            lblCOName5.Name = "lblCOName5";
            lblCOName5.Size = new Size(220, 28);
            lblCOName5.TabIndex = 122;
            lblCOName5.Text = "Item Name 5";
            // lblCOPrice5
            lblCOPrice5.Font = new Font("Segoe UI", 11F);
            lblCOPrice5.ForeColor = Color.FromArgb(120, 120, 120);
            lblCOPrice5.Location = new Point(135, 555);
            lblCOPrice5.Name = "lblCOPrice5";
            lblCOPrice5.Size = new Size(220, 24);
            lblCOPrice5.TabIndex = 121;
            lblCOPrice5.Text = "₱0.00";
            // btnCOMinus5
            btnCOMinus5.BackColor = Color.FromArgb(235, 235, 235);
            btnCOMinus5.FlatStyle = FlatStyle.Flat;
            btnCOMinus5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOMinus5.Location = new Point(370, 535);
            btnCOMinus5.Name = "btnCOMinus5";
            btnCOMinus5.Size = new Size(34, 34);
            btnCOMinus5.TabIndex = 120;
            btnCOMinus5.Text = "-";
            btnCOMinus5.UseVisualStyleBackColor = false;
            btnCOMinus5.Click += BtnCOMinus5_Click;
            // lblCOQty5
            lblCOQty5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOQty5.Location = new Point(404, 535);
            lblCOQty5.Name = "lblCOQty5";
            lblCOQty5.Size = new Size(46, 34);
            lblCOQty5.TabIndex = 119;
            lblCOQty5.Text = "1";
            lblCOQty5.TextAlign = ContentAlignment.MiddleCenter;
            // btnCOPlus5
            btnCOPlus5.BackColor = Color.FromArgb(235, 235, 235);
            btnCOPlus5.FlatStyle = FlatStyle.Flat;
            btnCOPlus5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOPlus5.Location = new Point(450, 535);
            btnCOPlus5.Name = "btnCOPlus5";
            btnCOPlus5.Size = new Size(34, 34);
            btnCOPlus5.TabIndex = 118;
            btnCOPlus5.Text = "+";
            btnCOPlus5.UseVisualStyleBackColor = false;
            btnCOPlus5.Click += BtnCOPlus5_Click;
            // lblCOSub5
            lblCOSub5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCOSub5.ForeColor = Color.FromArgb(30, 30, 30);
            lblCOSub5.Location = new Point(510, 535);
            lblCOSub5.Name = "lblCOSub5";
            lblCOSub5.Size = new Size(130, 34);
            lblCOSub5.TabIndex = 117;
            lblCOSub5.Text = "₱0.00";
            lblCOSub5.TextAlign = ContentAlignment.MiddleRight;
            // btnCODelete5
            btnCODelete5.BackColor = Color.FromArgb(255, 235, 235);
            btnCODelete5.FlatStyle = FlatStyle.Flat;
            btnCODelete5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCODelete5.ForeColor = Color.FromArgb(218, 41, 28);
            btnCODelete5.Location = new Point(660, 535);
            btnCODelete5.Name = "btnCODelete5";
            btnCODelete5.Size = new Size(46, 34);
            btnCODelete5.TabIndex = 116;
            btnCODelete5.Text = "🗑️";
            btnCODelete5.UseVisualStyleBackColor = false;
            btnCODelete5.Click += BtnCODelete5_Click;
            // 
            // picCOItem6
            // 
            picCOItem6.BackColor = Color.FromArgb(255, 248, 240);
            picCOItem6.BackgroundImageLayout = ImageLayout.Stretch;
            picCOItem6.BorderStyle = BorderStyle.FixedSingle;
            picCOItem6.Location = new Point(30, 610);
            picCOItem6.Name = "picCOItem6";
            picCOItem6.Size = new Size(90, 70);
            picCOItem6.SizeMode = PictureBoxSizeMode.Zoom;
            picCOItem6.TabIndex = 70;
            picCOItem6.TabStop = false;
            // lblCOName6
            lblCOName6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOName6.Location = new Point(135, 615);
            lblCOName6.Name = "lblCOName6";
            lblCOName6.Size = new Size(220, 28);
            lblCOName6.TabIndex = 116;
            lblCOName6.Text = "Item Name 6";
            // lblCOPrice6
            lblCOPrice6.Font = new Font("Segoe UI", 11F);
            lblCOPrice6.ForeColor = Color.FromArgb(120, 120, 120);
            lblCOPrice6.Location = new Point(135, 645);
            lblCOPrice6.Name = "lblCOPrice6";
            lblCOPrice6.Size = new Size(220, 24);
            lblCOPrice6.TabIndex = 115;
            lblCOPrice6.Text = "₱0.00";
            // btnCOMinus6
            btnCOMinus6.BackColor = Color.FromArgb(235, 235, 235);
            btnCOMinus6.FlatStyle = FlatStyle.Flat;
            btnCOMinus6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOMinus6.Location = new Point(370, 625);
            btnCOMinus6.Name = "btnCOMinus6";
            btnCOMinus6.Size = new Size(34, 34);
            btnCOMinus6.TabIndex = 114;
            btnCOMinus6.Text = "-";
            btnCOMinus6.UseVisualStyleBackColor = false;
            btnCOMinus6.Click += BtnCOMinus6_Click;
            // lblCOQty6
            lblCOQty6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOQty6.Location = new Point(404, 625);
            lblCOQty6.Name = "lblCOQty6";
            lblCOQty6.Size = new Size(46, 34);
            lblCOQty6.TabIndex = 113;
            lblCOQty6.Text = "1";
            lblCOQty6.TextAlign = ContentAlignment.MiddleCenter;
            // btnCOPlus6
            btnCOPlus6.BackColor = Color.FromArgb(235, 235, 235);
            btnCOPlus6.FlatStyle = FlatStyle.Flat;
            btnCOPlus6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCOPlus6.Location = new Point(450, 625);
            btnCOPlus6.Name = "btnCOPlus6";
            btnCOPlus6.Size = new Size(34, 34);
            btnCOPlus6.TabIndex = 112;
            btnCOPlus6.Text = "+";
            btnCOPlus6.UseVisualStyleBackColor = false;
            btnCOPlus6.Click += BtnCOPlus6_Click;
            // lblCOSub6
            lblCOSub6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCOSub6.ForeColor = Color.FromArgb(30, 30, 30);
            lblCOSub6.Location = new Point(510, 625);
            lblCOSub6.Name = "lblCOSub6";
            lblCOSub6.Size = new Size(130, 34);
            lblCOSub6.TabIndex = 111;
            lblCOSub6.Text = "₱0.00";
            lblCOSub6.TextAlign = ContentAlignment.MiddleRight;
            // btnCODelete6
            btnCODelete6.BackColor = Color.FromArgb(255, 235, 235);
            btnCODelete6.FlatStyle = FlatStyle.Flat;
            btnCODelete6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCODelete6.ForeColor = Color.FromArgb(218, 41, 28);
            btnCODelete6.Location = new Point(660, 625);
            btnCODelete6.Name = "btnCODelete6";
            btnCODelete6.Size = new Size(46, 34);
            btnCODelete6.TabIndex = 110;
            btnCODelete6.Text = "🗑️";
            btnCODelete6.UseVisualStyleBackColor = false;
            btnCODelete6.Click += BtnCODelete6_Click;
            // 
            // grpDiscounts
            // 
            grpDiscounts.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            grpDiscounts.Controls.Add(rbtnRegular);
            grpDiscounts.Controls.Add(rbtnPWDSenior);
            grpDiscounts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            grpDiscounts.ForeColor = Color.FromArgb(40, 40, 40);
            grpDiscounts.Location = new Point(760, 110);
            grpDiscounts.Name = "grpDiscounts";
            grpDiscounts.Size = new Size(480, 200);
            grpDiscounts.TabIndex = 100;
            grpDiscounts.TabStop = false;
            grpDiscounts.Text = "🏷️  Discounts & Promos";
            // 
            // rbtnRegular
            // 
            rbtnRegular.Checked = true;
            rbtnRegular.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtnRegular.Location = new Point(24, 40);
            rbtnRegular.Name = "rbtnRegular";
            rbtnRegular.Size = new Size(430, 40);
            rbtnRegular.TabIndex = 0;
            rbtnRegular.TabStop = true;
            rbtnRegular.Text = "Regular Price                                                0%";
            rbtnRegular.CheckedChanged += Discount_CheckedChanged;
            // 
            // rbtnPWDSenior
            // 
            rbtnPWDSenior.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            rbtnPWDSenior.Location = new Point(24, 90);
            rbtnPWDSenior.Name = "rbtnPWDSenior";
            rbtnPWDSenior.Size = new Size(430, 40);
            rbtnPWDSenior.TabIndex = 1;
            rbtnPWDSenior.Text = "PWD / Senior Citizen                                      -20%";
            rbtnPWDSenior.CheckedChanged += Discount_CheckedChanged;
            // 
            // lblCOSubtotalAmt
            // 
            lblCOSubtotalAmt.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblCOSubtotalAmt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCOSubtotalAmt.Location = new Point(760, 350);
            lblCOSubtotalAmt.Name = "lblCOSubtotalAmt";
            lblCOSubtotalAmt.Size = new Size(480, 25);
            lblCOSubtotalAmt.TabIndex = 103;
            lblCOSubtotalAmt.Text = "Subtotal:        ₱0.00";
            // 
            // lblCODiscountAmt
            // 
            lblCODiscountAmt.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblCODiscountAmt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCODiscountAmt.ForeColor = Color.FromArgb(218, 41, 28);
            lblCODiscountAmt.Location = new Point(760, 385);
            lblCODiscountAmt.Name = "lblCODiscountAmt";
            lblCODiscountAmt.Size = new Size(480, 25);
            lblCODiscountAmt.TabIndex = 104;
            lblCODiscountAmt.Text = "Discount (None):   -₱0.00";
            // 
            // lblCOTotalAmt
            // 
            lblCOTotalAmt.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblCOTotalAmt.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCOTotalAmt.Location = new Point(760, 430);
            lblCOTotalAmt.Name = "lblCOTotalAmt";
            lblCOTotalAmt.Size = new Size(480, 35);
            lblCOTotalAmt.TabIndex = 105;
            lblCOTotalAmt.Text = "TOTAL:           ₱0.00";
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnConfirmOrder.BackColor = Color.FromArgb(34, 139, 34);
            btnConfirmOrder.Cursor = Cursors.Hand;
            btnConfirmOrder.FlatStyle = FlatStyle.Flat;
            btnConfirmOrder.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnConfirmOrder.ForeColor = Color.White;
            btnConfirmOrder.Location = new Point(760, 500);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(480, 60);
            btnConfirmOrder.TabIndex = 106;
            btnConfirmOrder.Text = "PROCEED TO RECEIPT →";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += BtnConfirmOrder_Click;
            // 
            // FormCheckout
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1280, 720);
            Controls.Add(btnConfirmOrder);
            Controls.Add(lblCOTotalAmt);
            Controls.Add(lblCODiscountAmt);
            Controls.Add(lblCOSubtotalAmt);
            Controls.Add(grpDiscounts);
            Controls.Add(btnCODelete6);
            Controls.Add(lblCOSub6);
            Controls.Add(btnCOPlus6);
            Controls.Add(lblCOQty6);
            Controls.Add(btnCOMinus6);
            Controls.Add(lblCOPrice6);
            Controls.Add(lblCOName6);
            Controls.Add(picCOItem6);
            Controls.Add(btnCODelete5);
            Controls.Add(lblCOSub5);
            Controls.Add(btnCOPlus5);
            Controls.Add(lblCOQty5);
            Controls.Add(btnCOMinus5);
            Controls.Add(lblCOPrice5);
            Controls.Add(lblCOName5);
            Controls.Add(picCOItem5);
            Controls.Add(btnCODelete4);
            Controls.Add(lblCOSub4);
            Controls.Add(btnCOPlus4);
            Controls.Add(lblCOQty4);
            Controls.Add(btnCOMinus4);
            Controls.Add(lblCOPrice4);
            Controls.Add(lblCOName4);
            Controls.Add(picCOItem4);
            Controls.Add(btnCODelete3);
            Controls.Add(lblCOSub3);
            Controls.Add(btnCOPlus3);
            Controls.Add(lblCOQty3);
            Controls.Add(btnCOMinus3);
            Controls.Add(lblCOPrice3);
            Controls.Add(lblCOName3);
            Controls.Add(picCOItem3);
            Controls.Add(btnCODelete2);
            Controls.Add(lblCOSub2);
            Controls.Add(btnCOPlus2);
            Controls.Add(lblCOQty2);
            Controls.Add(btnCOMinus2);
            Controls.Add(lblCOPrice2);
            Controls.Add(lblCOName2);
            Controls.Add(picCOItem2);
            Controls.Add(btnCODelete1);
            Controls.Add(lblCOSub1);
            Controls.Add(btnCOPlus1);
            Controls.Add(lblCOQty1);
            Controls.Add(btnCOMinus1);
            Controls.Add(lblCOPrice1);
            Controls.Add(lblCOName1);
            Controls.Add(picCOItem1);
            Controls.Add(btnAddMoreItems);
            Controls.Add(lblReviewTitle);
            Controls.Add(lblSubheader);
            Controls.Add(lblOrderBadge);
            Controls.Add(btnBack);
            Controls.Add(lblHeader);
            Name = "FormCheckout";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Checkout";
            Load += FormCheckout_Load;
            ((System.ComponentModel.ISupportInitialize)picCOItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCOItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCOItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCOItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCOItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCOItem6).EndInit();
            grpDiscounts.ResumeLayout(false);

            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubheader;
        private System.Windows.Forms.Label lblOrderBadge;
        private System.Windows.Forms.Label lblReviewTitle;
        private System.Windows.Forms.Button btnAddMoreItems;
        private System.Windows.Forms.PictureBox picCOItem1;
        private System.Windows.Forms.Label lblCOName1;
        private System.Windows.Forms.Label lblCOPrice1;
        private System.Windows.Forms.Button btnCOMinus1;
        private System.Windows.Forms.Label lblCOQty1;
        private System.Windows.Forms.Button btnCOPlus1;
        private System.Windows.Forms.Label lblCOSub1;
        private System.Windows.Forms.Button btnCODelete1;
        private System.Windows.Forms.PictureBox picCOItem2;
        private System.Windows.Forms.Label lblCOName2;
        private System.Windows.Forms.Label lblCOPrice2;
        private System.Windows.Forms.Button btnCOMinus2;
        private System.Windows.Forms.Label lblCOQty2;
        private System.Windows.Forms.Button btnCOPlus2;
        private System.Windows.Forms.Label lblCOSub2;
        private System.Windows.Forms.Button btnCODelete2;
        private System.Windows.Forms.PictureBox picCOItem3;
        private System.Windows.Forms.Label lblCOName3;
        private System.Windows.Forms.Label lblCOPrice3;
        private System.Windows.Forms.Button btnCOMinus3;
        private System.Windows.Forms.Label lblCOQty3;
        private System.Windows.Forms.Button btnCOPlus3;
        private System.Windows.Forms.Label lblCOSub3;
        private System.Windows.Forms.Button btnCODelete3;
        private System.Windows.Forms.PictureBox picCOItem4;
        private System.Windows.Forms.Label lblCOName4;
        private System.Windows.Forms.Label lblCOPrice4;
        private System.Windows.Forms.Button btnCOMinus4;
        private System.Windows.Forms.Label lblCOQty4;
        private System.Windows.Forms.Button btnCOPlus4;
        private System.Windows.Forms.Label lblCOSub4;
        private System.Windows.Forms.Button btnCODelete4;
        private System.Windows.Forms.PictureBox picCOItem5;
        private System.Windows.Forms.Label lblCOName5;
        private System.Windows.Forms.Label lblCOPrice5;
        private System.Windows.Forms.Button btnCOMinus5;
        private System.Windows.Forms.Label lblCOQty5;
        private System.Windows.Forms.Button btnCOPlus5;
        private System.Windows.Forms.Label lblCOSub5;
        private System.Windows.Forms.Button btnCODelete5;
        private System.Windows.Forms.PictureBox picCOItem6;
        private System.Windows.Forms.Label lblCOName6;
        private System.Windows.Forms.Label lblCOPrice6;
        private System.Windows.Forms.Button btnCOMinus6;
        private System.Windows.Forms.Label lblCOQty6;
        private System.Windows.Forms.Button btnCOPlus6;
        private System.Windows.Forms.Label lblCOSub6;
        private System.Windows.Forms.Button btnCODelete6;
        private System.Windows.Forms.GroupBox grpDiscounts;
        private System.Windows.Forms.RadioButton rbtnRegular;
        private System.Windows.Forms.RadioButton rbtnPWDSenior;
        private System.Windows.Forms.Label lblCOSubtotalAmt;
        private System.Windows.Forms.Label lblCODiscountAmt;
        private System.Windows.Forms.Label lblCOTotalAmt;
        private System.Windows.Forms.Button btnConfirmOrder;
    }
}




