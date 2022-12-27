
namespace QL_HETHONGGIAONHANH
{
    partial class QUANLYDONHANG
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
            this.txt_MADON = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewCNTTDH = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDHDN = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCNTTDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDHDN)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_MADON);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridViewCNTTDH);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 242);
            this.panel1.TabIndex = 2;
            // 
            // txt_MADON
            // 
            this.txt_MADON.Location = new System.Drawing.Point(103, 27);
            this.txt_MADON.Name = "txt_MADON";
            this.txt_MADON.Size = new System.Drawing.Size(114, 27);
            this.txt_MADON.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cập nhật tình trạng đơn hàng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Đã xác nhận sang Đang chuẩn bị";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewCNTTDH
            // 
            this.dataGridViewCNTTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCNTTDH.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewCNTTDH.Name = "dataGridViewCNTTDH";
            this.dataGridViewCNTTDH.RowHeadersWidth = 51;
            this.dataGridViewCNTTDH.RowTemplate.Height = 29;
            this.dataGridViewCNTTDH.Size = new System.Drawing.Size(776, 176);
            this.dataGridViewCNTTDH.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn hàng đã nhận";
            // 
            // dataGridViewDHDN
            // 
            this.dataGridViewDHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDHDN.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewDHDN.Name = "dataGridViewDHDN";
            this.dataGridViewDHDN.RowHeadersWidth = 51;
            this.dataGridViewDHDN.RowTemplate.Height = 29;
            this.dataGridViewDHDN.Size = new System.Drawing.Size(776, 144);
            this.dataGridViewDHDN.TabIndex = 1;
            this.dataGridViewDHDN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDHDN_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewDHDN);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 197);
            this.panel2.TabIndex = 11;
            // 
            // QUANLYDONHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(801, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QUANLYDONHANG";
            this.Text = "QUANLYDONHANG";
            this.Load += new System.EventHandler(this.QUANLYDONHANG_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCNTTDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDHDN)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_MADON;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewCNTTDH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDHDN;
        private System.Windows.Forms.Panel panel2;
    }
}