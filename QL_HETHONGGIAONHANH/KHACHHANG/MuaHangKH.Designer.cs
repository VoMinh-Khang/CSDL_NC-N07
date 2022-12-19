namespace QL_HETHONGGIAONHANH
{
    partial class MuaHangKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtBox_TimMon = new System.Windows.Forms.TextBox();
            this.btn_TimMon = new System.Windows.Forms.Button();
            this.dsMonAn = new System.Windows.Forms.DataGridView();
            this.btn_MuaNgay = new System.Windows.Forms.Button();
            this.btn_ThemVaoGio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_TenMon = new System.Windows.Forms.TextBox();
            this.txtBox_GiaMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_XemDSDT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm món ăn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 80);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 15);
            this.linkLabel1.TabIndex = 2;
            // 
            // txtBox_TimMon
            // 
            this.txtBox_TimMon.Location = new System.Drawing.Point(44, 76);
            this.txtBox_TimMon.Name = "txtBox_TimMon";
            this.txtBox_TimMon.Size = new System.Drawing.Size(136, 23);
            this.txtBox_TimMon.TabIndex = 3;
            this.txtBox_TimMon.TextChanged += new System.EventHandler(this.txtBox_TimMon_TextChanged);
            // 
            // btn_TimMon
            // 
            this.btn_TimMon.Location = new System.Drawing.Point(44, 105);
            this.btn_TimMon.Name = "btn_TimMon";
            this.btn_TimMon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_TimMon.Size = new System.Drawing.Size(75, 23);
            this.btn_TimMon.TabIndex = 4;
            this.btn_TimMon.Text = "Tìm kiếm";
            this.btn_TimMon.UseVisualStyleBackColor = true;
            this.btn_TimMon.Click += new System.EventHandler(this.btn_TimMon_Click);
            // 
            // dsMonAn
            // 
            this.dsMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsMonAn.Location = new System.Drawing.Point(9, 211);
            this.dsMonAn.Name = "dsMonAn";
            this.dsMonAn.RowTemplate.Height = 25;
            this.dsMonAn.Size = new System.Drawing.Size(673, 139);
            this.dsMonAn.TabIndex = 5;
            // 
            // btn_MuaNgay
            // 
            this.btn_MuaNgay.Location = new System.Drawing.Point(498, 177);
            this.btn_MuaNgay.Name = "btn_MuaNgay";
            this.btn_MuaNgay.Size = new System.Drawing.Size(75, 23);
            this.btn_MuaNgay.TabIndex = 6;
            this.btn_MuaNgay.Text = "Mua Ngay";
            this.btn_MuaNgay.UseVisualStyleBackColor = true;
            this.btn_MuaNgay.Click += new System.EventHandler(this.btn_MuaNgay_Click);
            // 
            // btn_ThemVaoGio
            // 
            this.btn_ThemVaoGio.Location = new System.Drawing.Point(579, 177);
            this.btn_ThemVaoGio.Name = "btn_ThemVaoGio";
            this.btn_ThemVaoGio.Size = new System.Drawing.Size(103, 23);
            this.btn_ThemVaoGio.TabIndex = 7;
            this.btn_ThemVaoGio.Text = "Thêm Vào Giỏ";
            this.btn_ThemVaoGio.UseVisualStyleBackColor = true;
            this.btn_ThemVaoGio.Click += new System.EventHandler(this.btn_ThemVaoGio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên món ăn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBox_TenMon
            // 
            this.txtBox_TenMon.Location = new System.Drawing.Point(235, 27);
            this.txtBox_TenMon.Name = "txtBox_TenMon";
            this.txtBox_TenMon.Size = new System.Drawing.Size(136, 23);
            this.txtBox_TenMon.TabIndex = 9;
            // 
            // txtBox_GiaMon
            // 
            this.txtBox_GiaMon.Location = new System.Drawing.Point(232, 76);
            this.txtBox_GiaMon.Name = "txtBox_GiaMon";
            this.txtBox_GiaMon.Size = new System.Drawing.Size(136, 23);
            this.txtBox_GiaMon.TabIndex = 11;
            this.txtBox_GiaMon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gía món ăn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 23);
            this.textBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Miêu tả";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(398, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 23);
            this.textBox2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tình trạng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_XemDSDT
            // 
            this.btn_XemDSDT.Location = new System.Drawing.Point(354, 177);
            this.btn_XemDSDT.Name = "btn_XemDSDT";
            this.btn_XemDSDT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_XemDSDT.Size = new System.Drawing.Size(138, 28);
            this.btn_XemDSDT.TabIndex = 16;
            this.btn_XemDSDT.Text = "Xem tất cả các quán";
            this.btn_XemDSDT.UseVisualStyleBackColor = true;
            // 
            // MuaHangKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 352);
            this.Controls.Add(this.btn_XemDSDT);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_GiaMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_TenMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ThemVaoGio);
            this.Controls.Add(this.btn_MuaNgay);
            this.Controls.Add(this.dsMonAn);
            this.Controls.Add(this.btn_TimMon);
            this.Controls.Add(this.txtBox_TimMon);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "MuaHangKH";
            this.Text = "MuaHangKH";
            ((System.ComponentModel.ISupportInitialize)(this.dsMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox txtBox_TimMon;
        private Button btn_TimMon;
        private DataGridView dsMonAn;
        private Button btn_MuaNgay;
        private Button btn_ThemVaoGio;
        private Label label2;
        private TextBox txtBox_TenMon;
        private TextBox txtBox_GiaMon;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Button btn_XemDSDT;
    }
}