
namespace CarManager0323.UI
{
    partial class CustInsForm
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
            this.custCancel = new Sunny.UI.UISymbolButton();
            this.custOK = new Sunny.UI.UISymbolButton();
            this.custTel = new Sunny.UI.UITextBox();
            this.custEmail = new Sunny.UI.UITextBox();
            this.custAddress = new Sunny.UI.UITextBox();
            this.custName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // custCancel
            // 
            this.custCancel.BackColor = System.Drawing.Color.Transparent;
            this.custCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custCancel.FillColor = System.Drawing.Color.Red;
            this.custCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custCancel.IsCircle = true;
            this.custCancel.Location = new System.Drawing.Point(197, 282);
            this.custCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custCancel.Name = "custCancel";
            this.custCancel.RectColor = System.Drawing.Color.Red;
            this.custCancel.Size = new System.Drawing.Size(182, 50);
            this.custCancel.Style = Sunny.UI.UIStyle.Custom;
            this.custCancel.Symbol = 61453;
            this.custCancel.SymbolSize = 30;
            this.custCancel.TabIndex = 27;
            this.custCancel.Click += new System.EventHandler(this.custCancel_Click);
            // 
            // custOK
            // 
            this.custOK.BackColor = System.Drawing.Color.Transparent;
            this.custOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.custOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custOK.IsCircle = true;
            this.custOK.Location = new System.Drawing.Point(25, 282);
            this.custOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.custOK.Name = "custOK";
            this.custOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.custOK.Size = new System.Drawing.Size(182, 50);
            this.custOK.Style = Sunny.UI.UIStyle.Custom;
            this.custOK.SymbolSize = 30;
            this.custOK.TabIndex = 26;
            this.custOK.Click += new System.EventHandler(this.custOK_Click);
            // 
            // custTel
            // 
            this.custTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custTel.FillColor = System.Drawing.Color.White;
            this.custTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custTel.Location = new System.Drawing.Point(170, 174);
            this.custTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custTel.Maximum = 2147483647D;
            this.custTel.Minimum = -2147483648D;
            this.custTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custTel.Name = "custTel";
            this.custTel.Padding = new System.Windows.Forms.Padding(5);
            this.custTel.Size = new System.Drawing.Size(182, 29);
            this.custTel.TabIndex = 1;
            // 
            // custEmail
            // 
            this.custEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custEmail.FillColor = System.Drawing.Color.White;
            this.custEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custEmail.Location = new System.Drawing.Point(170, 209);
            this.custEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custEmail.Maximum = 2147483647D;
            this.custEmail.Minimum = -2147483648D;
            this.custEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.custEmail.Name = "custEmail";
            this.custEmail.Padding = new System.Windows.Forms.Padding(5);
            this.custEmail.Size = new System.Drawing.Size(182, 29);
            this.custEmail.TabIndex = 3;
            // 
            // custAddress
            // 
            this.custAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custAddress.FillColor = System.Drawing.Color.White;
            this.custAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddress.Location = new System.Drawing.Point(170, 135);
            this.custAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custAddress.Maximum = 2147483647D;
            this.custAddress.Minimum = -2147483648D;
            this.custAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddress.Name = "custAddress";
            this.custAddress.Padding = new System.Windows.Forms.Padding(5);
            this.custAddress.Size = new System.Drawing.Size(182, 29);
            this.custAddress.TabIndex = 2;
            // 
            // custName
            // 
            this.custName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custName.FillColor = System.Drawing.Color.White;
            this.custName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custName.Location = new System.Drawing.Point(170, 88);
            this.custName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custName.Maximum = 2147483647D;
            this.custName.Minimum = -2147483648D;
            this.custName.MinimumSize = new System.Drawing.Size(1, 1);
            this.custName.Name = "custName";
            this.custName.Padding = new System.Windows.Forms.Padding(5);
            this.custName.Size = new System.Drawing.Size(182, 29);
            this.custName.TabIndex = 0;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(25, 85);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(142, 32);
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 18;
            this.uiSymbolLabel1.Text = "이 름";
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(25, 170);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(142, 32);
            this.uiSymbolLabel5.Symbol = 61589;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel5.TabIndex = 28;
            this.uiSymbolLabel5.Text = "번 호";
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel6.Location = new System.Drawing.Point(35, 206);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(128, 32);
            this.uiSymbolLabel6.Symbol = 61856;
            this.uiSymbolLabel6.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel6.TabIndex = 29;
            this.uiSymbolLabel6.Text = "이메일";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(25, 132);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(142, 32);
            this.uiSymbolLabel2.Symbol = 57597;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.TabIndex = 30;
            this.uiSymbolLabel2.Text = "주 소";
            // 
            // CustInsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 372);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.custCancel);
            this.Controls.Add(this.custOK);
            this.Controls.Add(this.custTel);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.custAddress);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "CustInsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "고객 정보 추가";
            this.Load += new System.EventHandler(this.CustInsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton custCancel;
        private Sunny.UI.UISymbolButton custOK;
        private Sunny.UI.UITextBox custTel;
        private Sunny.UI.UITextBox custEmail;
        private Sunny.UI.UITextBox custAddress;
        private Sunny.UI.UITextBox custName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
    }
}