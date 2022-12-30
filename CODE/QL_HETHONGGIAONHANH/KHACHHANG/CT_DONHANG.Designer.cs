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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonLike = new System.Windows.Forms.Button();
            this.buttonDislike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CTDH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(369, 32);
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
            this.dataGridView_CTDH.Location = new System.Drawing.Point(52, 98);
            this.dataGridView_CTDH.Name = "dataGridView_CTDH";
            this.dataGridView_CTDH.ReadOnly = true;
            this.dataGridView_CTDH.RowHeadersWidth = 62;
            this.dataGridView_CTDH.RowTemplate.Height = 33;
            this.dataGridView_CTDH.Size = new System.Drawing.Size(885, 273);
            this.dataGridView_CTDH.TabIndex = 2;
            this.dataGridView_CTDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CTDH_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(812, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 97);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gửi đánh giá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 440);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(555, 87);
            this.textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(52, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 150);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(52, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Đánh giá cho món ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBox2.Location = new System.Drawing.Point(254, 393);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 33);
            this.textBox2.TabIndex = 9;
            // 
            // buttonLike
            // 
            this.buttonLike.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLike.BackgroundImage = global::QL_HETHONGGIAONHANH.Properties.Resources.like;
            this.buttonLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLike.ForeColor = System.Drawing.Color.Chocolate;
            this.buttonLike.Location = new System.Drawing.Point(640, 450);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(65, 65);
            this.buttonLike.TabIndex = 5;
            this.buttonLike.UseVisualStyleBackColor = false;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // buttonDislike
            // 
            this.buttonDislike.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDislike.BackgroundImage = global::QL_HETHONGGIAONHANH.Properties.Resources.dislike;
            this.buttonDislike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDislike.Location = new System.Drawing.Point(718, 450);
            this.buttonDislike.Name = "buttonDislike";
            this.buttonDislike.Size = new System.Drawing.Size(65, 65);
            this.buttonDislike.TabIndex = 6;
            this.buttonDislike.UseVisualStyleBackColor = false;
            this.buttonDislike.Click += new System.EventHandler(this.buttonDislike_Click);
            // 
            // CT_DONHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDislike);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_CTDH);
            this.Controls.Add(this.label_MADON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
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
        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox2;
        private Button buttonLike;
        private Button buttonDislike;
    }
}