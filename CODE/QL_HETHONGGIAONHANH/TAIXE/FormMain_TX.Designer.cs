namespace QL_HETHONGGIAONHANH
{
    partial class FormMain_TX
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_DangXuat_TX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_TenTX = new System.Windows.Forms.TextBox();
            this.btn_TheoDoiThuNhap = new System.Windows.Forms.Button();
            this.btn_DSDH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm_TX = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelMenu.Controls.Add(this.btn_Thoat);
            this.panelMenu.Controls.Add(this.btn_DangXuat_TX);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.textBox_TenTX);
            this.panelMenu.Controls.Add(this.btn_TheoDoiThuNhap);
            this.panelMenu.Controls.Add(this.btn_DSDH);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 500);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_DangXuat_TX
            // 
            this.btn_DangXuat_TX.BackColor = System.Drawing.Color.Transparent;
            this.btn_DangXuat_TX.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_DangXuat_TX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DangXuat_TX.Location = new System.Drawing.Point(-3, 341);
            this.btn_DangXuat_TX.Name = "btn_DangXuat_TX";
            this.btn_DangXuat_TX.Size = new System.Drawing.Size(150, 60);
            this.btn_DangXuat_TX.TabIndex = 4;
            this.btn_DangXuat_TX.Text = "Đăng xuất";
            this.btn_DangXuat_TX.UseVisualStyleBackColor = false;
            this.btn_DangXuat_TX.Click += new System.EventHandler(this.btn_DangXuat_TX_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Location = new System.Drawing.Point(4, 184);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 4);
            this.panel2.TabIndex = 2;
            // 
            // textBox_TenTX
            // 
            this.textBox_TenTX.Enabled = false;
            this.textBox_TenTX.Location = new System.Drawing.Point(6, 98);
            this.textBox_TenTX.Multiline = true;
            this.textBox_TenTX.Name = "textBox_TenTX";
            this.textBox_TenTX.Size = new System.Drawing.Size(141, 81);
            this.textBox_TenTX.TabIndex = 0;
            this.textBox_TenTX.TextChanged += new System.EventHandler(this.textBox_TenTX_TextChanged);
            // 
            // btn_TheoDoiThuNhap
            // 
            this.btn_TheoDoiThuNhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_TheoDoiThuNhap.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_TheoDoiThuNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TheoDoiThuNhap.Location = new System.Drawing.Point(-3, 275);
            this.btn_TheoDoiThuNhap.Name = "btn_TheoDoiThuNhap";
            this.btn_TheoDoiThuNhap.Size = new System.Drawing.Size(150, 60);
            this.btn_TheoDoiThuNhap.TabIndex = 3;
            this.btn_TheoDoiThuNhap.Text = "Theo dõi thu nhập";
            this.btn_TheoDoiThuNhap.UseVisualStyleBackColor = false;
            this.btn_TheoDoiThuNhap.Click += new System.EventHandler(this.btn_TheoDoiThuNhap_Click);
            // 
            // btn_DSDH
            // 
            this.btn_DSDH.BackColor = System.Drawing.Color.Transparent;
            this.btn_DSDH.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_DSDH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DSDH.Location = new System.Drawing.Point(-3, 209);
            this.btn_DSDH.Name = "btn_DSDH";
            this.btn_DSDH.Size = new System.Drawing.Size(153, 60);
            this.btn_DSDH.TabIndex = 2;
            this.btn_DSDH.Text = "Danh sách đơn hàng";
            this.btn_DSDH.UseVisualStyleBackColor = false;
            this.btn_DSDH.Click += new System.EventHandler(this.btn_DSDonHang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(32, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelChildForm_TX
            // 
            this.panelChildForm_TX.Location = new System.Drawing.Point(156, 3);
            this.panelChildForm_TX.Name = "panelChildForm_TX";
            this.panelChildForm_TX.Size = new System.Drawing.Size(1176, 497);
            this.panelChildForm_TX.TabIndex = 2;
            this.panelChildForm_TX.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_TX_Paint);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.Location = new System.Drawing.Point(0, 407);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(150, 60);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // FormMain_TX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 500);
            this.Controls.Add(this.panelChildForm_TX);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain_TX";
            this.Text = "FormMain_TX";
            this.Load += new System.EventHandler(this.FormMain_TX_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_DSDH;
        private Button btn_TheoDoiThuNhap;
        private Panel panelChildForm_TX;
        private TextBox textBox_TenTX;
        private Panel panel2;
        private Button btn_DangXuat_TX;
        private Button btn_Thoat;
    }
}