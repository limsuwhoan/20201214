
namespace carmanager0323
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
            this.uiButton1 = new Sunny.UI.UIButton();
            this.dropTB = new Sunny.UI.UIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton4 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton5 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton6 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton7 = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(545, 96);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(124, 46);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "테이블 생성";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // dropTB
            // 
            this.dropTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dropTB.Location = new System.Drawing.Point(545, 184);
            this.dropTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.dropTB.Name = "dropTB";
            this.dropTB.Size = new System.Drawing.Size(124, 46);
            this.dropTB.TabIndex = 1;
            this.dropTB.Text = "DropTB";
            this.dropTB.Click += new System.EventHandler(this.dropTB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(496, 614);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(12, 439);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(193, 39);
            this.uiSymbolButton1.TabIndex = 10;
            this.uiSymbolButton1.Text = "데이터전체 추가";
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton3.Location = new System.Drawing.Point(476, 542);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.Size = new System.Drawing.Size(193, 39);
            this.uiSymbolButton3.TabIndex = 12;
            this.uiSymbolButton3.Text = "프로그램종료";
            // 
            // uiSymbolButton4
            // 
            this.uiSymbolButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton4.Location = new System.Drawing.Point(476, 439);
            this.uiSymbolButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton4.Name = "uiSymbolButton4";
            this.uiSymbolButton4.Size = new System.Drawing.Size(193, 39);
            this.uiSymbolButton4.TabIndex = 13;
            this.uiSymbolButton4.Text = "고객정보추가";
            // 
            // uiSymbolButton5
            // 
            this.uiSymbolButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton5.Location = new System.Drawing.Point(242, 542);
            this.uiSymbolButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton5.Name = "uiSymbolButton5";
            this.uiSymbolButton5.Size = new System.Drawing.Size(193, 39);
            this.uiSymbolButton5.TabIndex = 14;
            this.uiSymbolButton5.Text = "거래 정보 추가";
            // 
            // uiSymbolButton6
            // 
            this.uiSymbolButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton6.Location = new System.Drawing.Point(12, 542);
            this.uiSymbolButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton6.Name = "uiSymbolButton6";
            this.uiSymbolButton6.Size = new System.Drawing.Size(193, 39);
            this.uiSymbolButton6.TabIndex = 15;
            this.uiSymbolButton6.Text = "판매자 정보추가";
            // 
            // uiSymbolButton7
            // 
            this.uiSymbolButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton7.Location = new System.Drawing.Point(242, 439);
            this.uiSymbolButton7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton7.Name = "uiSymbolButton7";
            this.uiSymbolButton7.Size = new System.Drawing.Size(193, 39);
            this.uiSymbolButton7.TabIndex = 16;
            this.uiSymbolButton7.Text = "차량정보추가";
            this.uiSymbolButton7.Click += new System.EventHandler(this.uiSymbolButton7_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 647);
            this.Controls.Add(this.uiSymbolButton7);
            this.Controls.Add(this.uiSymbolButton6);
            this.Controls.Add(this.uiSymbolButton5);
            this.Controls.Add(this.uiSymbolButton4);
            this.Controls.Add(this.uiSymbolButton3);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dropTB);
            this.Controls.Add(this.uiButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "차량 고객 관리 프로그램V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton dropTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UISymbolButton uiSymbolButton4;
        private Sunny.UI.UISymbolButton uiSymbolButton5;
        private Sunny.UI.UISymbolButton uiSymbolButton6;
        private Sunny.UI.UISymbolButton uiSymbolButton7;
    }
}

