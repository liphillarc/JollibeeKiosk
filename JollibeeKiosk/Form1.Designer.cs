namespace JollibeeKiosk
{
    partial class Form1
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
            lblNavBrand = new Label();
            lblFooter = new Label();
            lblWelcome = new Label();
            lblTagline = new Label();
            lblDesc = new Label();
            btnStartOrder = new Button();
            lblDineHint = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNavBrand
            // 
            lblNavBrand.BackColor = Color.White;
            lblNavBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNavBrand.ForeColor = Color.FromArgb(218, 41, 28);
            lblNavBrand.Location = new Point(696, 0);
            lblNavBrand.Margin = new Padding(4, 0, 4, 0);
            lblNavBrand.Name = "lblNavBrand";
            lblNavBrand.Size = new Size(181, 100);
            lblNavBrand.TabIndex = 0;
            lblNavBrand.Text = "HappyBee";
            lblNavBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFooter
            // 
            lblFooter.BackColor = Color.White;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(160, 160, 160);
            lblFooter.Location = new Point(0, 1133);
            lblFooter.Margin = new Padding(4, 0, 4, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(1571, 67);
            lblFooter.TabIndex = 1;
            lblFooter.Text = "© 2024 Jollibee Foods Corporation  |  Terms of Service  |  Privacy Policy";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 16F);
            lblWelcome.ForeColor = Color.FromArgb(100, 100, 100);
            lblWelcome.Location = new Point(687, 125);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(199, 60);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome to";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblTagline
            // 
            lblTagline.Font = new Font("Segoe UI", 18F, FontStyle.Italic);
            lblTagline.ForeColor = Color.FromArgb(253, 184, 19);
            lblTagline.Location = new Point(652, 542);
            lblTagline.Margin = new Padding(4, 0, 4, 0);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(267, 67);
            lblTagline.TabIndex = 6;
            lblTagline.Text = "ENJOY EATING!";
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 12F);
            lblDesc.ForeColor = Color.FromArgb(120, 120, 120);
            lblDesc.Location = new Point(529, 660);
            lblDesc.Margin = new Padding(4, 0, 4, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(516, 100);
            lblDesc.TabIndex = 7;
            lblDesc.Text = "Order your favorites freshly made just for you.\nFast, easy, and delicious — every single time.";
            // 
            // btnStartOrder
            // 
            btnStartOrder.BackColor = Color.FromArgb(253, 184, 19);
            btnStartOrder.Cursor = Cursors.Hand;
            btnStartOrder.FlatAppearance.BorderSize = 0;
            btnStartOrder.FlatStyle = FlatStyle.Flat;
            btnStartOrder.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnStartOrder.ForeColor = Color.FromArgb(120, 15, 5);
            btnStartOrder.Location = new Point(486, 807);
            btnStartOrder.Margin = new Padding(4, 5, 4, 5);
            btnStartOrder.Name = "btnStartOrder";
            btnStartOrder.Size = new Size(600, 133);
            btnStartOrder.TabIndex = 9;
            btnStartOrder.Text = "\U0001f6d2   START ORDER";
            btnStartOrder.UseVisualStyleBackColor = false;
            btnStartOrder.Click += BtnStartOrder_Click;
            // 
            // lblDineHint
            // 
            lblDineHint.Font = new Font("Segoe UI", 11F);
            lblDineHint.ForeColor = Color.FromArgb(150, 150, 150);
            lblDineHint.Location = new Point(624, 978);
            lblDineHint.Margin = new Padding(4, 0, 4, 0);
            lblDineHint.Name = "lblDineHint";
            lblDineHint.Size = new Size(324, 50);
            lblDineHint.TabIndex = 8;
            lblDineHint.Text = "🍽️  Dine In   ·   \U0001f961  Take Out";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.download__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(486, 190);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 347);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1571, 1200);
            Controls.Add(pictureBox1);
            Controls.Add(btnStartOrder);
            Controls.Add(lblDineHint);
            Controls.Add(lblDesc);
            Controls.Add(lblTagline);
            Controls.Add(lblWelcome);
            Controls.Add(lblFooter);
            Controls.Add(lblNavBrand);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1585, 1228);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🐝 Jollibee Kiosk";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Label      lblNavBrand;
        private System.Windows.Forms.Label      lblFooter;
        private System.Windows.Forms.Label      lblWelcome;
        private System.Windows.Forms.Label      lblTagline;
        private System.Windows.Forms.Label      lblDesc;
        private System.Windows.Forms.Label      lblDineHint;
        private System.Windows.Forms.Button     btnStartOrder;
        private PictureBox pictureBox1;
    }
}
