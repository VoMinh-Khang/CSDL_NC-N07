
namespace QL_HETHONGGIAONHANH
{
    partial class QUANLYSOLIEU
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateDHHT = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewDHTN = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewPH = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDHTN)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateDHHT);
            this.panel1.Controls.Add(this.dataGridViewDHTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 340);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tổng số lượng đơn hàng trong ngày";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(590, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quản lý đơn hàng theo ngày";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateDHHT
            // 
            this.dateDHHT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDHHT.Location = new System.Drawing.Point(155, 35);
            this.dateDHHT.Name = "dateDHHT";
            this.dateDHHT.Size = new System.Drawing.Size(184, 27);
            this.dateDHHT.TabIndex = 9;
            this.dateDHHT.Value = new System.DateTime(2022, 12, 22, 0, 0, 0, 0);
            this.dateDHHT.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridViewDHTN
            // 
            this.dataGridViewDHTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDHTN.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewDHTN.Name = "dataGridViewDHTN";
            this.dataGridViewDHTN.RowHeadersWidth = 51;
            this.dataGridViewDHTN.RowTemplate.Height = 29;
            this.dataGridViewDHTN.Size = new System.Drawing.Size(776, 154);
            this.dataGridViewDHTN.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn hàng của ngày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewPH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 307);
            this.panel2.TabIndex = 12;
            // 
            // dataGridViewPH
            // 
            this.dataGridViewPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPH.Location = new System.Drawing.Point(13, 23);
            this.dataGridViewPH.Name = "dataGridViewPH";
            this.dataGridViewPH.RowHeadersWidth = 51;
            this.dataGridViewPH.RowTemplate.Height = 29;
            this.dataGridViewPH.Size = new System.Drawing.Size(772, 273);
            this.dataGridViewPH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phản hồi của khách hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 75);
            this.dataGridView1.TabIndex = 16;
            // 
            // QUANLYSOLIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(801, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QUANLYSOLIEU";
            this.Text = "QUANLYSOLIEU";
            this.Load += new System.EventHandler(this.QUANLYSOLIEU_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDHTN)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateDHHT;
        private System.Windows.Forms.DataGridView dataGridViewDHTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewPH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}