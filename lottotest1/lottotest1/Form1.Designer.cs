
namespace lottotest1
{
    partial class Form1
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

      
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_6 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 456);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(345, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "보너스";
           
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Red;
            this.button_start.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_start.Location = new System.Drawing.Point(489, 23);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(91, 33);
            this.button_start.TabIndex = 19;
            this.button_start.Text = "생성하기";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_6
            // 
            this.label_6.AllowDrop = true;
            this.label_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_6.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_6.Location = new System.Drawing.Point(288, 22);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(51, 33);
            this.label_6.TabIndex = 17;
            this.label_6.Text = "0";
            this.label_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_5
            // 
            this.label_5.AllowDrop = true;
            this.label_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_5.Location = new System.Drawing.Point(235, 22);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(47, 33);
            this.label_5.TabIndex = 16;
            this.label_5.Text = "0";
            this.label_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_4
            // 
            this.label_4.AllowDrop = true;
            this.label_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_4.Location = new System.Drawing.Point(188, 22);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(41, 33);
            this.label_4.TabIndex = 15;
            this.label_4.Text = "0";
            this.label_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_3
            // 
            this.label_3.AllowDrop = true;
            this.label_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_3.Location = new System.Drawing.Point(135, 23);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(47, 33);
            this.label_3.TabIndex = 14;
            this.label_3.Text = "0";
            this.label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_2
            // 
            this.label_2.AllowDrop = true;
            this.label_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_2.Location = new System.Drawing.Point(80, 22);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(49, 33);
            this.label_2.TabIndex = 13;
            this.label_2.Text = "0";
            this.label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // label_1
            // 
            this.label_1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label_1.AllowDrop = true;
            this.label_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_1.Location = new System.Drawing.Point(27, 22);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(47, 33);
            this.label_1.TabIndex = 12;
            this.label_1.Text = "0";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(420, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 33);
            this.label7.TabIndex = 21;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_start;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(618, 456);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_6);
            this.Controls.Add(this.label_5);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.pictureBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_6;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_4;
    }
}

