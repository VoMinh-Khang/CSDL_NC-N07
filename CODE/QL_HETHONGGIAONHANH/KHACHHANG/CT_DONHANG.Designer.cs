namespace QL_HETHONGGIAONHANH
{
    partial class CT_DONHANG
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
            this.label_MADON = new System.Windows.Forms.Label();
            this.dataGridView_CTDH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CTDH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(282, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // label_MADON
            // 
            this.label_MADON.AutoSize = true;
            this.label_MADON.Location = new System.Drawing.Point(369, 70);
            this.label_MADON.Name = "label_MADON";
            this.label_MADON.Size = new System.Drawing.Size(0, 25);
            this.label_MADON.TabIndex = 1;
            this.label_MADON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_CTDH
            // 
            this.dataGridView_CTDH.AllowUserToAddRows = false;
            this.dataGridView_CTDH.AllowUserToDeleteRows = false;
            this.dataGridView_CTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CTDH.Location = new System.Drawing.Point(12, 146);
            this.dataGridView_CTDH.Name = "dataGridView_CTDH";
            this.dataGridView_CTDH.ReadOnly = true;
            this.dataGridView_CTDH.RowHeadersWidth = 62;
            this.dataGridView_CTDH.RowTemplate.Height = 33;
            this.dataGridView_CTDH.Size = new System.Drawing.Size(829, 246);
            this.dataGridView_CTDH.TabIndex = 2;
            this.dataGridView_CTDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CTDH_CellContentClick);
            // 
            // CT_DONHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 415);
            this.Controls.Add(this.dataGridView_CTDH);
            this.Controls.Add(this.label_MADON);
            this.Controls.Add(this.label1);
            this.Name = "CT_DONHANG";
            this.Text = "CHI TIẾT ĐƠN HÀNG";
            this.Load += new System.EventHandler(this.CT_DONHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CTDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label_MADON;
        private DataGridView dataGridView_CTDH;
    }
}