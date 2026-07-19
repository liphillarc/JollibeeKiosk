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
            btnSalesAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNavBrand
            // 
            lblNavBrand.BackColor = Color.Transparent;
            lblNavBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNavBrand.ForeColor = Color.FromArgb(218, 41, 28);
            lblNavBrand.Location = new Point(0, 0);
            lblNavBrand.Name = "lblNavBrand";
            lblNavBrand.Size = new Size(1100, 60);
            lblNavBrand.TabIndex = 0;
            lblNavBrand.Text = "                                                                                  HappyBee";
            lblNavBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFooter
            // 
            lblFooter.BackColor = Color.White;
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.FromArgb(160, 160, 160);
            lblFooter.Location = new Point(0, 680);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(1100, 40);
            lblFooter.TabIndex = 1;
            lblFooter.Text = "© 2024 Jollibee Foods Corporation  |  Terms of Service  |  Privacy Policy";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 16F);
            lblWelcome.ForeColor = Color.FromArgb(100, 100, 100);
            lblWelcome.Location = new Point(481, 75);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(139, 36);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome to";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblTagline
            // 
            lblTagline.Font = new Font("Segoe UI", 18F, FontStyle.Italic);
            lblTagline.ForeColor = Color.FromArgb(253, 184, 19);
            lblTagline.Location = new Point(456, 325);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(187, 40);
            lblTagline.TabIndex = 6;
            lblTagline.Text = "ENJOY EATING!";
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 12F);
            lblDesc.ForeColor = Color.FromArgb(120, 120, 120);
            lblDesc.Location = new Point(370, 396);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(361, 60);
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
            btnStartOrder.Location = new Point(340, 484);
            btnStartOrder.Name = "btnStartOrder";
            btnStartOrder.Size = new Size(420, 80);
            btnStartOrder.TabIndex = 9;
            btnStartOrder.Text = "\U0001f6d2   START ORDER";
            btnStartOrder.UseVisualStyleBackColor = false;
            btnStartOrder.Click += BtnStartOrder_Click;
            // 
            // lblDineHint
            // 
            lblDineHint.Font = new Font("Segoe UI", 11F);
            lblDineHint.ForeColor = Color.FromArgb(150, 150, 150);
            lblDineHint.Location = new Point(437, 587);
            lblDineHint.Name = "lblDineHint";
            lblDineHint.Size = new Size(227, 30);
            lblDineHint.TabIndex = 8;
            lblDineHint.Text = "🍽️  Dine In   ·   \U0001f961  Take Out";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._07c338f3_0268_4cca_93a9_8de88b1a9e0c_76bc42db_6a5f_4533_bb21_c75949c9e70d_1871562_image_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(340, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 208);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnSalesAdmin
            // 
            btnSalesAdmin.BackColor = Color.White;
            btnSalesAdmin.Cursor = Cursors.Hand;
            btnSalesAdmin.FlatStyle = FlatStyle.Flat;
            btnSalesAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalesAdmin.ForeColor = Color.FromArgb(120, 120, 120);
            btnSalesAdmin.Location = new Point(0, 0);
            btnSalesAdmin.Margin = new Padding(2);
            btnSalesAdmin.Name = "btnSalesAdmin";
            btnSalesAdmin.Size = new Size(105, 33);
            btnSalesAdmin.TabIndex = 12;
            btnSalesAdmin.Text = "📊 Sales Database";
            btnSalesAdmin.UseVisualStyleBackColor = false;
            btnSalesAdmin.Click += btnSalesAdmin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1100, 720);
            Controls.Add(btnSalesAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(btnStartOrder);
            Controls.Add(lblDineHint);
            Controls.Add(lblDesc);
            Controls.Add(lblTagline);
            Controls.Add(lblWelcome);
            Controls.Add(lblFooter);
            Controls.Add(lblNavBrand);
            MinimumSize = new Size(1114, 752);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🐝 HappiBee Kiosk";
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
        private Button btnSalesAdmin;
    }
}
