
namespace CarManager0323
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createTB = new Sunny.UI.UIButton();
            this.dropTB = new Sunny.UI.UIButton();
            this.insertAll = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.insertCar = new Sunny.UI.UISymbolButton();
            this.insertCustomer = new Sunny.UI.UISymbolButton();
            this.insertSeller = new Sunny.UI.UISymbolButton();
            this.insertDeal = new Sunny.UI.UISymbolButton();
            this.appExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createTB
            // 
            this.createTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createTB.Location = new System.Drawing.Point(479, 130);
            this.createTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.createTB.Name = "createTB";
            this.createTB.Size = new System.Drawing.Size(143, 35);
            this.createTB.TabIndex = 0;
            this.createTB.Text = "테이블 생성";
            this.createTB.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // dropTB
            // 
            this.dropTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dropTB.Location = new System.Drawing.Point(479, 202);
            this.dropTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.dropTB.Name = "dropTB";
            this.dropTB.Size = new System.Drawing.Size(143, 35);
            this.dropTB.TabIndex = 1;
            this.dropTB.Text = "테이블 삭제";
            this.dropTB.Click += new System.EventHandler(this.dropTB_Click);
            // 
            // insertAll
            // 
            this.insertAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertAll.Location = new System.Drawing.Point(12, 383);
            this.insertAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertAll.Name = "insertAll";
            this.insertAll.Size = new System.Drawing.Size(160, 35);
            this.insertAll.TabIndex = 2;
            this.insertAll.Text = "데이터 추가 All";
            this.insertAll.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // insertCar
            // 
            this.insertCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertCar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertCar.Location = new System.Drawing.Point(210, 383);
            this.insertCar.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertCar.Name = "insertCar";
            this.insertCar.Size = new System.Drawing.Size(157, 35);
            this.insertCar.TabIndex = 4;
            this.insertCar.Text = "차량 정보 추가";
            this.insertCar.Click += new System.EventHandler(this.insertCar_Click);
            // 
            // insertCustomer
            // 
            this.insertCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertCustomer.Location = new System.Drawing.Point(411, 383);
            this.insertCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertCustomer.Name = "insertCustomer";
            this.insertCustomer.Size = new System.Drawing.Size(157, 35);
            this.insertCustomer.TabIndex = 5;
            this.insertCustomer.Text = "고객 정보 추가";
            this.insertCustomer.Click += new System.EventHandler(this.insertCustomer_Click);
            // 
            // insertSeller
            // 
            this.insertSeller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertSeller.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertSeller.Location = new System.Drawing.Point(12, 460);
            this.insertSeller.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertSeller.Name = "insertSeller";
            this.insertSeller.Size = new System.Drawing.Size(160, 35);
            this.insertSeller.TabIndex = 6;
            this.insertSeller.Text = "판매자 정보 추가";
            this.insertSeller.Click += new System.EventHandler(this.insertSeller_Click);
            // 
            // insertDeal
            // 
            this.insertDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertDeal.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.insertDeal.Location = new System.Drawing.Point(210, 460);
            this.insertDeal.MinimumSize = new System.Drawing.Size(1, 1);
            this.insertDeal.Name = "insertDeal";
            this.insertDeal.Size = new System.Drawing.Size(157, 35);
            this.insertDeal.TabIndex = 7;
            this.insertDeal.Text = "거래 정보 추가";
            this.insertDeal.Click += new System.EventHandler(this.insertDeal_Click);
            // 
            // appExit
            // 
            this.appExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.appExit.Location = new System.Drawing.Point(411, 460);
            this.appExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.appExit.Name = "appExit";
            this.appExit.Size = new System.Drawing.Size(157, 35);
            this.appExit.TabIndex = 8;
            this.appExit.Text = "프로그램 종료";
            this.appExit.Click += new System.EventHandler(this.appExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 516);
            this.Controls.Add(this.appExit);
            this.Controls.Add(this.insertDeal);
            this.Controls.Add(this.insertSeller);
            this.Controls.Add(this.insertCustomer);
            this.Controls.Add(this.insertCar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.insertAll);
            this.Controls.Add(this.dropTB);
            this.Controls.Add(this.createTB);
            this.Name = "MainForm";
            this.Text = "차량 고객 관리 프로그램v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton createTB;
        private Sunny.UI.UIButton dropTB;
        private Sunny.UI.UISymbolButton insertAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton insertCar;
        private Sunny.UI.UISymbolButton insertCustomer;
        private Sunny.UI.UISymbolButton insertSeller;
        private Sunny.UI.UISymbolButton insertDeal;
        private Sunny.UI.UISymbolButton appExit;
    }
}

