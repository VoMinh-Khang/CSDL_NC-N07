namespace QL_HETHONGGIAONHANH
{
    partial class GioHangKH
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
            this.btn_muangay = new System.Windows.Forms.Button();
            this.btn_TiepTuc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_muangay
            // 
            this.btn_muangay.Location = new System.Drawing.Point(446, 305);
            this.btn_muangay.Name = "btn_muangay";
            this.btn_muangay.Size = new System.Drawing.Size(75, 23);
            this.btn_muangay.TabIndex = 0;
            this.btn_muangay.Text = "Mua ngay";
            this.btn_muangay.UseVisualStyleBackColor = true;
            // 
            // btn_TiepTuc
            // 
            this.btn_TiepTuc.Location = new System.Drawing.Point(527, 305);
            this.btn_TiepTuc.Name = "btn_TiepTuc";
            this.btn_TiepTuc.Size = new System.Drawing.Size(76, 23);
            this.btn_TiepTuc.TabIndex = 1;
            this.btn_TiepTuc.Text = "Tiếp Tục";
            this.btn_TiepTuc.UseVisualStyleBackColor = true;
            this.btn_TiepTuc.Click += new System.EventHandler(this.btn_TiepTuc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(591, 217);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "GIỎ HÀNG";
            // 
            // GioHangKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_TiepTuc);
            this.Controls.Add(this.btn_muangay);
            this.Name = "GioHangKH";
            this.Text = "GioHangKH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_muangay;
        private Button btn_TiepTuc;
        private DataGridView dataGridView1;
        private Label label1;
    }
}