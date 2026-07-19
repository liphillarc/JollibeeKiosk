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
            btnBack = new Button();
            lblNavBrand = new Label();
            lblQuestion = new Label();
            lblSubQ = new Label();
            btnDineIn = new Button();
            btnTakeOut = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(218, 41, 28);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(190, 30, 20);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(17, 20);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(129, 60);
            btnBack.TabIndex = 1;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // lblNavBrand
            // 
            lblNavBrand.BackColor = Color.FromArgb(218, 41, 28);
            lblNavBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNavBrand.ForeColor = Color.White;
            lblNavBrand.Location = new Point(0, 0);
            lblNavBrand.Margin = new Padding(4, 0, 4, 0);
            lblNavBrand.Name = "lblNavBrand";
            lblNavBrand.Size = new Size(1571, 100);
            lblNavBrand.TabIndex = 0;
            lblNavBrand.Text = "           🐝  HAPPYBEE";
            lblNavBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblQuestion.ForeColor = Color.FromArgb(35, 35, 35);
            lblQuestion.Location = new Point(0, 167);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(1571, 100);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "How would you like your order?";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubQ
            // 
            lblSubQ.Font = new Font("Segoe UI", 13F);
            lblSubQ.ForeColor = Color.FromArgb(150, 150, 150);
            lblSubQ.Location = new Point(0, 275);
            lblSubQ.Margin = new Padding(4, 0, 4, 0);
            lblSubQ.Name = "lblSubQ";
            lblSubQ.Size = new Size(1571, 57);
            lblSubQ.TabIndex = 3;
            lblSubQ.Text = "Choose your preferred dining option to get started";
            lblSubQ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDineIn
            // 
            btnDineIn.BackColor = Color.White;
            btnDineIn.BackgroundImage = Properties.Resources.Screenshot_2026_07_14_160113;
            btnDineIn.Cursor = Cursors.Hand;
            btnDineIn.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btnDineIn.FlatAppearance.BorderSize = 2;
            btnDineIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 240);
            btnDineIn.FlatStyle = FlatStyle.Flat;
            btnDineIn.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnDineIn.ForeColor = Color.FromArgb(35, 35, 35);
            btnDineIn.Location = new Point(271, 383);
            btnDineIn.Margin = new Padding(4, 5, 4, 5);
            btnDineIn.Name = "btnDineIn";
            btnDineIn.Size = new Size(443, 517);
            btnDineIn.TabIndex = 4;
            btnDineIn.Text = "🍽️\r\n\r\nDINE IN\r\n\r\nEat here at the restaurant";
            btnDineIn.UseVisualStyleBackColor = false;
            btnDineIn.Click += BtnDineIn_Click;
            // 
            // btnTakeOut
            // 
            btnTakeOut.BackColor = Color.Red;
            btnTakeOut.BackgroundImage = Properties.Resources.Screenshot_2026_07_14_160113;
            btnTakeOut.Cursor = Cursors.Hand;
            btnTakeOut.FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            btnTakeOut.FlatAppearance.BorderSize = 2;
            btnTakeOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 240);
            btnTakeOut.FlatStyle = FlatStyle.Flat;
            btnTakeOut.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnTakeOut.ForeColor = Color.FromArgb(35, 35, 35);
            btnTakeOut.Location = new Point(857, 383);
            btnTakeOut.Margin = new Padding(4, 5, 4, 5);
            btnTakeOut.Name = "btnTakeOut";
            btnTakeOut.Size = new Size(443, 517);
            btnTakeOut.TabIndex = 5;
            btnTakeOut.Text = "\U0001f961\r\n\r\nTAKE OUT\r\n\r\nTake your food to go";
            btnTakeOut.UseVisualStyleBackColor = false;
            btnTakeOut.Click += BtnTakeOut_Click;
            // 
            // FormOrderType
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 248);
            ClientSize = new Size(1571, 1200);
            Controls.Add(btnBack);
            Controls.Add(lblNavBrand);
            Controls.Add(btnTakeOut);
            Controls.Add(btnDineIn);
            Controls.Add(lblSubQ);
            Controls.Add(lblQuestion);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1585, 1228);
            Name = "FormOrderType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🐝 HappiBee Kiosk";
            ResumeLayout(false);
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
