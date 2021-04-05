
namespace CarManager0323.UI
{
    partial class DealinsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dealList = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gridView = new Sunny.UI.UIDataGridView();
            this.grid_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gird_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewExit = new Sunny.UI.UISymbolButton();
            this.dealviewclose = new Sunny.UI.UISymbolButton();
            this.custdetail = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dealList
            // 
            this.dealList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.deal_model,
            this.deal_price,
            this.deal_seller,
            this.deal_date});
            this.dealList.FullRowSelect = true;
            this.dealList.HideSelection = false;
            this.dealList.Location = new System.Drawing.Point(12, 101);
            this.dealList.Name = "dealList";
            this.dealList.Size = new System.Drawing.Size(622, 203);
            this.dealList.TabIndex = 3;
            this.dealList.UseCompatibleStateImageBehavior = false;
            this.dealList.View = System.Windows.Forms.View.Details;
            this.dealList.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // list_count
            // 
            this.list_count.Text = "번 호";
            // 
            // list_name
            // 
            this.list_name.Text = "이 름";
            this.list_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_name.Width = 80;
            // 
            // deal_model
            // 
            this.deal_model.Text = "구매가격";
            this.deal_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_model.Width = 120;
            // 
            // deal_price
            // 
            this.deal_price.Text = "가격";
            this.deal_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_price.Width = 200;
            // 
            // deal_seller
            // 
            this.deal_seller.Text = "판매자";
            this.deal_seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_seller.Width = 150;
            // 
            // deal_date
            // 
            this.deal_date.Text = "판매날짜";
            this.deal_date.Width = 120;
            // 
            // gridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridView.ColumnHeadersHeight = 32;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_count,
            this.grid_name,
            this.gird_tel,
            this.grid_addr,
            this.grid_email});
            this.gridView.EnableHeadersVisualStyles = false;
            this.gridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gridView.Location = new System.Drawing.Point(12, 319);
            this.gridView.Name = "gridView";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.gridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridView.RowTemplate.Height = 29;
            this.gridView.SelectedIndex = -1;
            this.gridView.ShowGridLine = true;
            this.gridView.Size = new System.Drawing.Size(622, 196);
            this.gridView.TabIndex = 4;
            // 
            // grid_count
            // 
            this.grid_count.HeaderText = "번 호";
            this.grid_count.Name = "grid_count";
            // 
            // grid_name
            // 
            this.grid_name.HeaderText = "이 름";
            this.grid_name.Name = "grid_name";
            // 
            // gird_tel
            // 
            this.gird_tel.HeaderText = "전 화";
            this.gird_tel.Name = "gird_tel";
            // 
            // grid_addr
            // 
            this.grid_addr.HeaderText = "주 소";
            this.grid_addr.Name = "grid_addr";
            // 
            // grid_email
            // 
            this.grid_email.HeaderText = "이메일";
            this.grid_email.Name = "grid_email";
            // 
            // viewExit
            // 
            this.viewExit.BackColor = System.Drawing.Color.Transparent;
            this.viewExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.viewExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewExit.IsCircle = true;
            this.viewExit.Location = new System.Drawing.Point(668, 29);
            this.viewExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewExit.Name = "viewExit";
            this.viewExit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.viewExit.Size = new System.Drawing.Size(76, 60);
            this.viewExit.Style = Sunny.UI.UIStyle.Custom;
            this.viewExit.Symbol = 61457;
            this.viewExit.SymbolSize = 45;
            this.viewExit.TabIndex = 5;
            this.viewExit.Click += new System.EventHandler(this.viewExit_Click);
            // 
            // dealviewclose
            // 
            this.dealviewclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealviewclose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dealviewclose.Location = new System.Drawing.Point(649, 249);
            this.dealviewclose.MinimumSize = new System.Drawing.Size(1, 1);
            this.dealviewclose.Name = "dealviewclose";
            this.dealviewclose.Size = new System.Drawing.Size(128, 48);
            this.dealviewclose.TabIndex = 6;
            this.dealviewclose.Text = "닫기";
            this.dealviewclose.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // custdetail
            // 
            this.custdetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custdetail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custdetail.Location = new System.Drawing.Point(649, 171);
            this.custdetail.MinimumSize = new System.Drawing.Size(1, 1);
            this.custdetail.Name = "custdetail";
            this.custdetail.Size = new System.Drawing.Size(128, 48);
            this.custdetail.TabIndex = 7;
            this.custdetail.Text = "고객상세정보";
            this.custdetail.Click += new System.EventHandler(this.custdetail_Click);
            // 
            // Dealview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.custdetail);
            this.Controls.Add(this.dealviewclose);
            this.Controls.Add(this.dealList);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.viewExit);
            this.Name = "Dealview";
            this.Text = "거래 추가 정보";
            this.Load += new System.EventHandler(this.DealviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dealList;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader deal_model;
        private System.Windows.Forms.ColumnHeader deal_price;
        private System.Windows.Forms.ColumnHeader deal_seller;
        private Sunny.UI.UIDataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gird_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_email;
        private Sunny.UI.UISymbolButton viewExit;
        private Sunny.UI.UISymbolButton dealviewclose;
        private Sunny.UI.UISymbolButton custdetail;
        private System.Windows.Forms.ColumnHeader deal_date;
    }
}