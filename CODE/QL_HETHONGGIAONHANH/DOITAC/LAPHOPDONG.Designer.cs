
namespace QL_HETHONGGIAONHANH
{
    partial class LAPHOPDONG
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.THOIGIANHIEULUC = new System.Windows.Forms.DateTimePicker();
            this.NGAYLAP = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewLHD = new System.Windows.Forms.DataGridView();
            this.NGUOIDAIDIEN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TAIKHOANNGANHANG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DCCUAHANG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CUAHANG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MASOHOPDONG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.THOIGIANHIEULUC);
            this.panel1.Controls.Add(this.NGAYLAP);
            this.panel1.Controls.Add(this.dataGridViewLHD);
            this.panel1.Controls.Add(this.NGUOIDAIDIEN);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TAIKHOANNGANHANG);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.DCCUAHANG);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CUAHANG);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MASOHOPDONG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 654);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // THOIGIANHIEULUC
            // 
            this.THOIGIANHIEULUC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.THOIGIANHIEULUC.Location = new System.Drawing.Point(534, 70);
            this.THOIGIANHIEULUC.Name = "THOIGIANHIEULUC";
            this.THOIGIANHIEULUC.Size = new System.Drawing.Size(241, 27);
            this.THOIGIANHIEULUC.TabIndex = 34;
            this.THOIGIANHIEULUC.Value = new System.DateTime(2022, 12, 24, 0, 0, 0, 0);
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NGAYLAP.Location = new System.Drawing.Point(127, 75);
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.Size = new System.Drawing.Size(257, 27);
            this.NGAYLAP.TabIndex = 33;
            this.NGAYLAP.Value = new System.DateTime(2022, 12, 24, 0, 0, 0, 0);
            // 
            // dataGridViewLHD
            // 
            this.dataGridViewLHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLHD.Location = new System.Drawing.Point(12, 301);
            this.dataGridViewLHD.Name = "dataGridViewLHD";
            this.dataGridViewLHD.RowHeadersWidth = 51;
            this.dataGridViewLHD.RowTemplate.Height = 29;
            this.dataGridViewLHD.Size = new System.Drawing.Size(773, 341);
            this.dataGridViewLHD.TabIndex = 23;
            this.dataGridViewLHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLHD_CellContentClick);
            // 
            // NGUOIDAIDIEN
            // 
            this.NGUOIDAIDIEN.Location = new System.Drawing.Point(127, 118);
            this.NGUOIDAIDIEN.Name = "NGUOIDAIDIEN";
            this.NGUOIDAIDIEN.Size = new System.Drawing.Size(257, 27);
            this.NGUOIDAIDIEN.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 21;
            this.button2.Text = "Gửi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Ngày kết thúc ";
            // 
            // TAIKHOANNGANHANG
            // 
            this.TAIKHOANNGANHANG.Location = new System.Drawing.Point(534, 29);
            this.TAIKHOANNGANHANG.Name = "TAIKHOANNGANHANG";
            this.TAIKHOANNGANHANG.Size = new System.Drawing.Size(241, 27);
            this.TAIKHOANNGANHANG.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số tài khoản";
            // 
            // DCCUAHANG
            // 
            this.DCCUAHANG.Location = new System.Drawing.Point(140, 196);
            this.DCCUAHANG.Name = "DCCUAHANG";
            this.DCCUAHANG.Size = new System.Drawing.Size(244, 27);
            this.DCCUAHANG.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Địa chỉ cửa hàng";
            // 
            // CUAHANG
            // 
            this.CUAHANG.Location = new System.Drawing.Point(176, 156);
            this.CUAHANG.Name = "CUAHANG";
            this.CUAHANG.Size = new System.Drawing.Size(208, 27);
            this.CUAHANG.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số chi nhánh cửa hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Người đại diện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập";
            // 
            // MASOHOPDONG
            // 
            this.MASOHOPDONG.Location = new System.Drawing.Point(127, 29);
            this.MASOHOPDONG.Name = "MASOHOPDONG";
            this.MASOHOPDONG.Size = new System.Drawing.Size(257, 27);
            this.MASOHOPDONG.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số hợp đồng";
            // 
            // LAPHOPDONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(801, 655);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "LAPHOPDONG";
            this.Text = "LAPHOPDONG";
            this.Load += new System.EventHandler(this.LAPHOPDONG_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NGUOIDAIDIEN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TAIKHOANNGANHANG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DCCUAHANG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CUAHANG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MASOHOPDONG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker THOIGIANHIEULUC;
        private System.Windows.Forms.DateTimePicker NGAYLAP;
    }
}