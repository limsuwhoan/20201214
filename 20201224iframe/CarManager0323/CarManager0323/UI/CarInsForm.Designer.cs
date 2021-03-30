
namespace CarManager0323.UI
{
    partial class CarInsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.carCancel = new Sunny.UI.UISymbolButton();
            this.carOK = new Sunny.UI.UISymbolButton();
            this.carPrice = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.carCompany = new Sunny.UI.UITextBox();
            this.carColor = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.carModel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.carYear = new Sunny.UI.UITextBox();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // carCancel
            // 
            this.carCancel.BackColor = System.Drawing.Color.Transparent;
            this.carCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carCancel.FillColor = System.Drawing.Color.Red;
            this.carCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carCancel.IsCircle = true;
            this.carCancel.Location = new System.Drawing.Point(319, 388);
            this.carCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.carCancel.Name = "carCancel";
            this.carCancel.RectColor = System.Drawing.Color.Red;
            this.carCancel.Size = new System.Drawing.Size(50, 50);
            this.carCancel.Style = Sunny.UI.UIStyle.Custom;
            this.carCancel.Symbol = 61453;
            this.carCancel.SymbolSize = 30;
            this.carCancel.TabIndex = 15;
            this.carCancel.Click += new System.EventHandler(this.carCancel_Click);
            // 
            // carOK
            // 
            this.carOK.BackColor = System.Drawing.Color.Transparent;
            this.carOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.carOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carOK.IsCircle = true;
            this.carOK.Location = new System.Drawing.Point(229, 388);
            this.carOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.carOK.Name = "carOK";
            this.carOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.carOK.Size = new System.Drawing.Size(50, 50);
            this.carOK.Style = Sunny.UI.UIStyle.Custom;
            this.carOK.SymbolSize = 30;
            this.carOK.TabIndex = 14;
            this.carOK.Click += new System.EventHandler(this.carOK_Click);
            // 
            // carPrice
            // 
            this.carPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carPrice.FillColor = System.Drawing.Color.White;
            this.carPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carPrice.Location = new System.Drawing.Point(187, 144);
            this.carPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carPrice.Maximum = 2147483647D;
            this.carPrice.Minimum = -2147483648D;
            this.carPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.carPrice.Name = "carPrice";
            this.carPrice.Padding = new System.Windows.Forms.Padding(5);
            this.carPrice.Size = new System.Drawing.Size(182, 29);
            this.carPrice.TabIndex = 11;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(12, 144);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(182, 29);
            this.uiSymbolLabel3.Symbol = 57506;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel3.TabIndex = 8;
            this.uiSymbolLabel3.Text = "가 격";
            // 
            // carCompany
            // 
            this.carCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carCompany.FillColor = System.Drawing.Color.White;
            this.carCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carCompany.Location = new System.Drawing.Point(187, 304);
            this.carCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carCompany.Maximum = 2147483647D;
            this.carCompany.Minimum = -2147483648D;
            this.carCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.carCompany.Name = "carCompany";
            this.carCompany.Padding = new System.Windows.Forms.Padding(5);
            this.carCompany.Size = new System.Drawing.Size(182, 29);
            this.carCompany.TabIndex = 12;
            // 
            // carColor
            // 
            this.carColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carColor.FillColor = System.Drawing.Color.White;
            this.carColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carColor.Location = new System.Drawing.Point(187, 197);
            this.carColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carColor.Maximum = 2147483647D;
            this.carColor.Minimum = -2147483648D;
            this.carColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.carColor.Name = "carColor";
            this.carColor.Padding = new System.Windows.Forms.Padding(5);
            this.carColor.Size = new System.Drawing.Size(182, 29);
            this.carColor.TabIndex = 13;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(12, 304);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(182, 29);
            this.uiSymbolLabel4.Symbol = 57597;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel4.TabIndex = 9;
            this.uiSymbolLabel4.Text = "제조사";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(12, 197);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(182, 29);
            this.uiSymbolLabel2.Symbol = 106;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.TabIndex = 10;
            this.uiSymbolLabel2.Text = "색 상";
            // 
            // carModel
            // 
            this.carModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carModel.FillColor = System.Drawing.Color.White;
            this.carModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carModel.Location = new System.Drawing.Point(187, 93);
            this.carModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carModel.Maximum = 2147483647D;
            this.carModel.Minimum = -2147483648D;
            this.carModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.carModel.Name = "carModel";
            this.carModel.Padding = new System.Windows.Forms.Padding(5);
            this.carModel.Size = new System.Drawing.Size(182, 29);
            this.carModel.TabIndex = 7;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 93);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(182, 29);
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 6;
            this.uiSymbolLabel1.Text = "모 델";
            // 
            // carYear
            // 
            this.carYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carYear.FillColor = System.Drawing.Color.White;
            this.carYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carYear.Location = new System.Drawing.Point(187, 248);
            this.carYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carYear.Maximum = 2147483647D;
            this.carYear.Minimum = -2147483648D;
            this.carYear.MinimumSize = new System.Drawing.Size(1, 1);
            this.carYear.Name = "carYear";
            this.carYear.Padding = new System.Windows.Forms.Padding(5);
            this.carYear.Size = new System.Drawing.Size(182, 29);
            this.carYear.TabIndex = 17;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(12, 248);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(182, 29);
            this.uiSymbolLabel5.Symbol = 61649;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel5.TabIndex = 16;
            this.uiSymbolLabel5.Text = "연 식";
            this.uiSymbolLabel5.Click += new System.EventHandler(this.uiSymbolLabel5_Click);
            // 
            // CarInsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.carYear);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.carCancel);
            this.Controls.Add(this.carOK);
            this.Controls.Add(this.carPrice);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.carCompany);
            this.Controls.Add(this.carColor);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "CarInsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "차량 정보 추가";
            this.Load += new System.EventHandler(this.CarInsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton carCancel;
        private Sunny.UI.UISymbolButton carOK;
        private Sunny.UI.UITextBox carPrice;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox carCompany;
        private Sunny.UI.UITextBox carColor;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox carModel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox carYear;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
    }
}