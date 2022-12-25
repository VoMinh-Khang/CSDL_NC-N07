namespace QL_HETHONGGIAONHANH.TAIXE
{
    partial class TXTheoDoiThuNhap
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_TXTheoDoiThuNhap = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TXTheoDoiThuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(139, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(139, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 28);
            this.label3.TabIndex = 31;
            // 
            // dataGridView_TXTheoDoiThuNhap
            // 
            this.dataGridView_TXTheoDoiThuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TXTheoDoiThuNhap.Location = new System.Drawing.Point(34, 149);
            this.dataGridView_TXTheoDoiThuNhap.Name = "dataGridView_TXTheoDoiThuNhap";
            this.dataGridView_TXTheoDoiThuNhap.RowHeadersWidth = 51;
            this.dataGridView_TXTheoDoiThuNhap.RowTemplate.Height = 29;
            this.dataGridView_TXTheoDoiThuNhap.Size = new System.Drawing.Size(1042, 226);
            this.dataGridView_TXTheoDoiThuNhap.TabIndex = 27;
            this.dataGridView_TXTheoDoiThuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TXTheoDoiThuNhap_CellClick);
            this.dataGridView_TXTheoDoiThuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DSDH_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(423, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "THU NHẬP CỦA TÀI XẾ";
            // 
            // TXTheoDoiThuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_TXTheoDoiThuNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TXTheoDoiThuNhap";
            this.Text = "TXTheoDoiThuNhap";
            this.Load += new System.EventHandler(this.TXTheoDoiThuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TXTheoDoiThuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label3;
        private DataGridView dataGridView_TXTheoDoiThuNhap;
        private Label label2;
        private Label label1;
    }
}