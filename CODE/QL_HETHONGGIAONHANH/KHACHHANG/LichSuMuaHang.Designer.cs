namespace QL_HETHONGGIAONHANH
{
    partial class LichSuMuaHang
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
            this.dsDonHang = new System.Windows.Forms.DataGridView();
            this.btn_XemChiTiet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_MaDH = new System.Windows.Forms.TextBox();
            this.txtBox_TongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_TinhTrang = new System.Windows.Forms.TextBox();
            this.button_XacNhanDon = new System.Windows.Forms.Button();
            this.button_huydon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dsDonHang
            // 
            this.dsDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsDonHang.Location = new System.Drawing.Point(17, 242);
            this.dsDonHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dsDonHang.Name = "dsDonHang";
            this.dsDonHang.RowHeadersWidth = 62;
            this.dsDonHang.RowTemplate.Height = 25;
            this.dsDonHang.Size = new System.Drawing.Size(895, 339);
            this.dsDonHang.TabIndex = 0;
            this.dsDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_XemChiTiet
            // 
            this.btn_XemChiTiet.Location = new System.Drawing.Point(769, 194);
            this.btn_XemChiTiet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_XemChiTiet.Name = "btn_XemChiTiet";
            this.btn_XemChiTiet.Size = new System.Drawing.Size(143, 38);
            this.btn_XemChiTiet.TabIndex = 1;
            this.btn_XemChiTiet.Text = "Xem chi tiết";
            this.btn_XemChiTiet.UseMnemonic = false;
            this.btn_XemChiTiet.UseVisualStyleBackColor = true;
            this.btn_XemChiTiet.Click += new System.EventHandler(this.btn_XemChiTiet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đơn";
            // 
            // txtBox_MaDH
            // 
            this.txtBox_MaDH.Location = new System.Drawing.Point(56, 125);
            this.txtBox_MaDH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_MaDH.Name = "txtBox_MaDH";
            this.txtBox_MaDH.Size = new System.Drawing.Size(141, 31);
            this.txtBox_MaDH.TabIndex = 3;
            // 
            // txtBox_TongTien
            // 
            this.txtBox_TongTien.Location = new System.Drawing.Point(232, 125);
            this.txtBox_TongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_TongTien.Name = "txtBox_TongTien";
            this.txtBox_TongTien.Size = new System.Drawing.Size(141, 31);
            this.txtBox_TongTien.TabIndex = 5;
            this.txtBox_TongTien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng Tiền";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tình Trạng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBox_TinhTrang
            // 
            this.txtBox_TinhTrang.Location = new System.Drawing.Point(405, 125);
            this.txtBox_TinhTrang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBox_TinhTrang.Name = "txtBox_TinhTrang";
            this.txtBox_TinhTrang.Size = new System.Drawing.Size(141, 31);
            this.txtBox_TinhTrang.TabIndex = 7;
            // 
            // button_XacNhanDon
            // 
            this.button_XacNhanDon.Enabled = false;
            this.button_XacNhanDon.Location = new System.Drawing.Point(614, 67);
            this.button_XacNhanDon.Name = "button_XacNhanDon";
            this.button_XacNhanDon.Size = new System.Drawing.Size(147, 89);
            this.button_XacNhanDon.TabIndex = 8;
            this.button_XacNhanDon.Text = "Xác Nhận Đơn Hàng Này";
            this.button_XacNhanDon.UseVisualStyleBackColor = true;
            this.button_XacNhanDon.Click += new System.EventHandler(this.button_XacNhanDon_Click);
            // 
            // button_huydon
            // 
            this.button_huydon.Enabled = false;
            this.button_huydon.Location = new System.Drawing.Point(783, 70);
            this.button_huydon.Name = "button_huydon";
            this.button_huydon.Size = new System.Drawing.Size(105, 89);
            this.button_huydon.TabIndex = 9;
            this.button_huydon.Text = "Hủy Đơn";
            this.button_huydon.UseVisualStyleBackColor = true;
            this.button_huydon.Click += new System.EventHandler(this.button_huydon_Click);
            // 
            // LichSuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 595);
            this.Controls.Add(this.button_huydon);
            this.Controls.Add(this.button_XacNhanDon);
            this.Controls.Add(this.txtBox_TinhTrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_TongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_MaDH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XemChiTiet);
            this.Controls.Add(this.dsDonHang);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LichSuMuaHang";
            this.Text = "LichSuMuaHang";
            this.Load += new System.EventHandler(this.LichSuMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dsDonHang;
        private Button btn_XemChiTiet;
        private Label label1;
        private TextBox txtBox_MaDH;
        private TextBox txtBox_TongTien;
        private Label label2;
        private Label label3;
        private TextBox txtBox_TinhTrang;
        private Button button_XacNhanDon;
        private Button button_huydon;
    }
}