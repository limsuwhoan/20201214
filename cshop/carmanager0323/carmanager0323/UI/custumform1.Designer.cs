
namespace carmanager0323.UI
{
    partial class custumform1
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.addCancel = new Sunny.UI.UISymbolButton();
            this.addOK = new Sunny.UI.UISymbolButton();
            this.calprice = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.addEmail = new Sunny.UI.UITextBox();
            this.addAddress = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.calmodel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(353, 367);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.Size = new System.Drawing.Size(225, 29);
            this.uiTextBox1.TabIndex = 29;
            this.uiTextBox1.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(157, 361);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(190, 35);
            this.uiSymbolLabel5.Symbol = 61946;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel5.TabIndex = 28;
            this.uiSymbolLabel5.Text = "연식";
            // 
            // addCancel
            // 
            this.addCancel.BackColor = System.Drawing.Color.Transparent;
            this.addCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancel.FillColor = System.Drawing.Color.Red;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancel.IsCircle = true;
            this.addCancel.Location = new System.Drawing.Point(406, 425);
            this.addCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancel.Name = "addCancel";
            this.addCancel.RectColor = System.Drawing.Color.Red;
            this.addCancel.Size = new System.Drawing.Size(50, 50);
            this.addCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCancel.Symbol = 61453;
            this.addCancel.SymbolSize = 30;
            this.addCancel.TabIndex = 27;
            // 
            // addOK
            // 
            this.addOK.BackColor = System.Drawing.Color.Transparent;
            this.addOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOK.IsCircle = true;
            this.addOK.Location = new System.Drawing.Point(238, 425);
            this.addOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOK.Name = "addOK";
            this.addOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addOK.Size = new System.Drawing.Size(50, 50);
            this.addOK.Style = Sunny.UI.UIStyle.Custom;
            this.addOK.SymbolSize = 30;
            this.addOK.TabIndex = 26;
            // 
            // calprice
            // 
            this.calprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calprice.FillColor = System.Drawing.Color.White;
            this.calprice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.calprice.Location = new System.Drawing.Point(353, 175);
            this.calprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calprice.Maximum = 2147483647D;
            this.calprice.Minimum = -2147483648D;
            this.calprice.MinimumSize = new System.Drawing.Size(1, 1);
            this.calprice.Name = "calprice";
            this.calprice.Padding = new System.Windows.Forms.Padding(5);
            this.calprice.Size = new System.Drawing.Size(225, 29);
            this.calprice.TabIndex = 23;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(166, 169);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel3.Symbol = 57488;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel3.TabIndex = 20;
            this.uiSymbolLabel3.Text = "가격";
            // 
            // addEmail
            // 
            this.addEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmail.FillColor = System.Drawing.Color.White;
            this.addEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addEmail.Location = new System.Drawing.Point(353, 303);
            this.addEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmail.Maximum = 2147483647D;
            this.addEmail.Minimum = -2147483648D;
            this.addEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.addEmail.Name = "addEmail";
            this.addEmail.Padding = new System.Windows.Forms.Padding(5);
            this.addEmail.Size = new System.Drawing.Size(225, 29);
            this.addEmail.TabIndex = 24;
            // 
            // addAddress
            // 
            this.addAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addAddress.FillColor = System.Drawing.Color.White;
            this.addAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addAddress.Location = new System.Drawing.Point(353, 239);
            this.addAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addAddress.Maximum = 2147483647D;
            this.addAddress.Minimum = -2147483648D;
            this.addAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.addAddress.Name = "addAddress";
            this.addAddress.Padding = new System.Windows.Forms.Padding(5);
            this.addAddress.Size = new System.Drawing.Size(225, 29);
            this.addAddress.TabIndex = 25;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(177, 297);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel4.Symbol = 61946;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel4.TabIndex = 21;
            this.uiSymbolLabel4.Text = "제조사";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(166, 233);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel2.Symbol = 61649;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.TabIndex = 22;
            this.uiSymbolLabel2.Text = "색상";
            // 
            // calmodel
            // 
            this.calmodel.CanEmpty = true;
            this.calmodel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.calmodel.FillColor = System.Drawing.Color.White;
            this.calmodel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.calmodel.Location = new System.Drawing.Point(353, 111);
            this.calmodel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calmodel.Maximum = 2147483647D;
            this.calmodel.Minimum = -2147483648D;
            this.calmodel.MinimumSize = new System.Drawing.Size(1, 1);
            this.calmodel.Name = "calmodel";
            this.calmodel.Padding = new System.Windows.Forms.Padding(5);
            this.calmodel.Size = new System.Drawing.Size(225, 29);
            this.calmodel.TabIndex = 19;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(166, 105);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 18;
            this.uiSymbolLabel1.Text = "모델";
            // 
            // custumform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 541);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.addOK);
            this.Controls.Add(this.calprice);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.addEmail);
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.calmodel);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "custumform1";
            this.Text = "판매자 정보 추가";
            this.Load += new System.EventHandler(this.custumform1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolButton addCancel;
        private Sunny.UI.UISymbolButton addOK;
        private Sunny.UI.UITextBox calprice;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox addEmail;
        private Sunny.UI.UITextBox addAddress;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox calmodel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}
