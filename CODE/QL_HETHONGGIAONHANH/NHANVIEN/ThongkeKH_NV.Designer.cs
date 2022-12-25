
namespace QL_HETHONGGIAONHANH
{
    partial class ThongkeKH_NV
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
            this.dTP_ngaygiaohang = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_huythongkeKH_NV = new System.Windows.Forms.Button();
            this.btn_thongkeKH_NV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MAKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TENKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_DIACHI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_EMAIL = new System.Windows.Forms.TextBox();
            this.dataGridView_thongkeKH = new System.Windows.Forms.DataGridView();
            this.btn_quaylai_thongkeKH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongkeKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dTP_ngaygiaohang
            // 
            this.dTP_ngaygiaohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTP_ngaygiaohang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_ngaygiaohang.Location = new System.Drawing.Point(24, 119);
            this.dTP_ngaygiaohang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dTP_ngaygiaohang.MinimumSize = new System.Drawing.Size(4, 33);
            this.dTP_ngaygiaohang.Name = "dTP_ngaygiaohang";
            this.dTP_ngaygiaohang.Size = new System.Drawing.Size(216, 33);
            this.dTP_ngaygiaohang.TabIndex = 98;
            this.dTP_ngaygiaohang.Value = new System.DateTime(2022, 12, 24, 0, 0, 0, 0);
            this.dTP_ngaygiaohang.ValueChanged += new System.EventHandler(this.dTP_ngaygiaohang_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.MediumBlue;
            this.label20.Location = new System.Drawing.Point(24, 101);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 15);
            this.label20.TabIndex = 97;
            this.label20.Text = "Ngày giao hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(347, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 99;
            this.label1.Text = "Thống kê số lượng khách hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_huythongkeKH_NV
            // 
            this.btn_huythongkeKH_NV.Location = new System.Drawing.Point(142, 171);
            this.btn_huythongkeKH_NV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_huythongkeKH_NV.Name = "btn_huythongkeKH_NV";
            this.btn_huythongkeKH_NV.Size = new System.Drawing.Size(98, 33);
            this.btn_huythongkeKH_NV.TabIndex = 101;
            this.btn_huythongkeKH_NV.Text = "Hủy";
            this.btn_huythongkeKH_NV.UseVisualStyleBackColor = true;
            this.btn_huythongkeKH_NV.Click += new System.EventHandler(this.btn_huythongkeKH_NV_Click);
            // 
            // btn_thongkeKH_NV
            // 
            this.btn_thongkeKH_NV.Location = new System.Drawing.Point(24, 171);
            this.btn_thongkeKH_NV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_thongkeKH_NV.Name = "btn_thongkeKH_NV";
            this.btn_thongkeKH_NV.Size = new System.Drawing.Size(98, 33);
            this.btn_thongkeKH_NV.TabIndex = 103;
            this.btn_thongkeKH_NV.Text = "Thống kê";
            this.btn_thongkeKH_NV.UseVisualStyleBackColor = true;
            this.btn_thongkeKH_NV.Click += new System.EventHandler(this.btn_thongkeKH_NV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(336, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 108;
            this.label2.Text = "Mã khách hàng";
            // 
            // textBox_MAKH
            // 
            this.textBox_MAKH.Location = new System.Drawing.Point(336, 128);
            this.textBox_MAKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MAKH.Multiline = true;
            this.textBox_MAKH.Name = "textBox_MAKH";
            this.textBox_MAKH.Size = new System.Drawing.Size(216, 33);
            this.textBox_MAKH.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(336, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 110;
            this.label3.Text = "Tài khoản";
            // 
            // textBox_TK
            // 
            this.textBox_TK.Location = new System.Drawing.Point(336, 197);
            this.textBox_TK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_TK.Multiline = true;
            this.textBox_TK.Name = "textBox_TK";
            this.textBox_TK.Size = new System.Drawing.Size(216, 33);
            this.textBox_TK.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(336, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 112;
            this.label4.Text = "Tên khách hàng";
            // 
            // textBox_TENKH
            // 
            this.textBox_TENKH.Location = new System.Drawing.Point(336, 270);
            this.textBox_TENKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_TENKH.Multiline = true;
            this.textBox_TENKH.Name = "textBox_TENKH";
            this.textBox_TENKH.Size = new System.Drawing.Size(216, 33);
            this.textBox_TENKH.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(671, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 114;
            this.label5.Text = "Số điện thoại";
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.Location = new System.Drawing.Point(671, 128);
            this.textBox_SDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_SDT.Multiline = true;
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.Size = new System.Drawing.Size(216, 33);
            this.textBox_SDT.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(671, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 116;
            this.label6.Text = "Địa chỉ";
            // 
            // textBox_DIACHI
            // 
            this.textBox_DIACHI.Location = new System.Drawing.Point(671, 197);
            this.textBox_DIACHI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_DIACHI.Multiline = true;
            this.textBox_DIACHI.Name = "textBox_DIACHI";
            this.textBox_DIACHI.Size = new System.Drawing.Size(216, 33);
            this.textBox_DIACHI.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(671, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 118;
            this.label7.Text = "Email";
            // 
            // textBox_EMAIL
            // 
            this.textBox_EMAIL.Location = new System.Drawing.Point(671, 270);
            this.textBox_EMAIL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_EMAIL.Multiline = true;
            this.textBox_EMAIL.Name = "textBox_EMAIL";
            this.textBox_EMAIL.Size = new System.Drawing.Size(216, 33);
            this.textBox_EMAIL.TabIndex = 117;
            // 
            // dataGridView_thongkeKH
            // 
            this.dataGridView_thongkeKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_thongkeKH.Location = new System.Drawing.Point(12, 316);
            this.dataGridView_thongkeKH.Name = "dataGridView_thongkeKH";
            this.dataGridView_thongkeKH.RowTemplate.Height = 25;
            this.dataGridView_thongkeKH.Size = new System.Drawing.Size(941, 128);
            this.dataGridView_thongkeKH.TabIndex = 119;
            this.dataGridView_thongkeKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_thongkeKH_CellClick);
            // 
            // btn_quaylai_thongkeKH
            // 
            this.btn_quaylai_thongkeKH.Location = new System.Drawing.Point(49, 227);
            this.btn_quaylai_thongkeKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_quaylai_thongkeKH.Name = "btn_quaylai_thongkeKH";
            this.btn_quaylai_thongkeKH.Size = new System.Drawing.Size(152, 53);
            this.btn_quaylai_thongkeKH.TabIndex = 120;
            this.btn_quaylai_thongkeKH.Text = "Quay lại";
            this.btn_quaylai_thongkeKH.UseVisualStyleBackColor = true;
            this.btn_quaylai_thongkeKH.Click += new System.EventHandler(this.btn_quaylai_thongkeKH_Click);
            // 
            // ThongkeKH_NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.btn_quaylai_thongkeKH);
            this.Controls.Add(this.dataGridView_thongkeKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_EMAIL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_DIACHI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_SDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_TENKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_TK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MAKH);
            this.Controls.Add(this.btn_thongkeKH_NV);
            this.Controls.Add(this.btn_huythongkeKH_NV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTP_ngaygiaohang);
            this.Controls.Add(this.label20);
            this.Name = "ThongkeKH_NV";
            this.Text = "ThongkeKH_NV";
            this.Load += new System.EventHandler(this.ThongkeKH_NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongkeKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTP_ngaygiaohang;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_huythongkeKH_NV;
        private System.Windows.Forms.Button btn_thongkeKH_NV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MAKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TENKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_DIACHI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_EMAIL;
        private System.Windows.Forms.DataGridView dataGridView_thongkeKH;
        private System.Windows.Forms.Button btn_quaylai_thongkeKH;
    }
}