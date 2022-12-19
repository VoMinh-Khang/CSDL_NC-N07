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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_XemChiTiet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_MaDH = new System.Windows.Forms.TextBox();
            this.txtBox_TongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_TinhTrang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(541, 158);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_XemChiTiet
            // 
            this.btn_XemChiTiet.Location = new System.Drawing.Point(416, 77);
            this.btn_XemChiTiet.Name = "btn_XemChiTiet";
            this.btn_XemChiTiet.Size = new System.Drawing.Size(130, 23);
            this.btn_XemChiTiet.TabIndex = 1;
            this.btn_XemChiTiet.Text = "Xem chi tiết";
            this.btn_XemChiTiet.UseMnemonic = false;
            this.btn_XemChiTiet.UseVisualStyleBackColor = true;
            this.btn_XemChiTiet.Click += new System.EventHandler(this.btn_XemChiTiet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đơn";
            // 
            // txtBox_MaDH
            // 
            this.txtBox_MaDH.Location = new System.Drawing.Point(21, 42);
            this.txtBox_MaDH.Name = "txtBox_MaDH";
            this.txtBox_MaDH.Size = new System.Drawing.Size(100, 23);
            this.txtBox_MaDH.TabIndex = 3;
            // 
            // txtBox_TongTien
            // 
            this.txtBox_TongTien.Location = new System.Drawing.Point(144, 42);
            this.txtBox_TongTien.Name = "txtBox_TongTien";
            this.txtBox_TongTien.Size = new System.Drawing.Size(100, 23);
            this.txtBox_TongTien.TabIndex = 5;
            this.txtBox_TongTien.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng Tiền";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tình Trạng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBox_TinhTrang
            // 
            this.txtBox_TinhTrang.Location = new System.Drawing.Point(289, 42);
            this.txtBox_TinhTrang.Name = "txtBox_TinhTrang";
            this.txtBox_TinhTrang.Size = new System.Drawing.Size(100, 23);
            this.txtBox_TinhTrang.TabIndex = 7;
            // 
            // LichSuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 328);
            this.Controls.Add(this.txtBox_TinhTrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_TongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_MaDH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XemChiTiet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LichSuMuaHang";
            this.Text = "LichSuMuaHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_XemChiTiet;
        private Label label1;
        private TextBox txtBox_MaDH;
        private TextBox txtBox_TongTien;
        private Label label2;
        private Label label3;
        private TextBox txtBox_TinhTrang;
    }
}