﻿namespace QL_HETHONGGIAONHANH
{
    partial class FormMainKH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dangxuat_KH = new System.Windows.Forms.Button();
            this.btn_thoat_KH = new System.Windows.Forms.Button();
            this.btn_muahang_KH = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLichSuMuaHang = new System.Windows.Forms.Button();
            this.panelChildForm_KH = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xin chào \r\nKhách hàng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(6, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 5);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_dangxuat_KH
            // 
            this.btn_dangxuat_KH.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dangxuat_KH.Location = new System.Drawing.Point(16, 482);
            this.btn_dangxuat_KH.Name = "btn_dangxuat_KH";
            this.btn_dangxuat_KH.Size = new System.Drawing.Size(153, 60);
            this.btn_dangxuat_KH.TabIndex = 2;
            this.btn_dangxuat_KH.Text = "Đăng xuất";
            this.btn_dangxuat_KH.UseVisualStyleBackColor = true;
            this.btn_dangxuat_KH.Click += new System.EventHandler(this.btn_dangxuat_KH_Click);
            // 
            // btn_thoat_KH
            // 
            this.btn_thoat_KH.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thoat_KH.Location = new System.Drawing.Point(16, 576);
            this.btn_thoat_KH.Name = "btn_thoat_KH";
            this.btn_thoat_KH.Size = new System.Drawing.Size(153, 55);
            this.btn_thoat_KH.TabIndex = 3;
            this.btn_thoat_KH.Text = "Thoát";
            this.btn_thoat_KH.UseVisualStyleBackColor = true;
            this.btn_thoat_KH.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_muahang_KH
            // 
            this.btn_muahang_KH.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_muahang_KH.Location = new System.Drawing.Point(20, 243);
            this.btn_muahang_KH.Name = "btn_muahang_KH";
            this.btn_muahang_KH.Size = new System.Drawing.Size(150, 66);
            this.btn_muahang_KH.TabIndex = 4;
            this.btn_muahang_KH.Text = "Mua hàng";
            this.btn_muahang_KH.UseVisualStyleBackColor = true;
            this.btn_muahang_KH.Click += new System.EventHandler(this.btn_muahang_KH_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelMenu.Controls.Add(this.textBox2);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnLichSuMuaHang);
            this.panelMenu.Controls.Add(this.btn_muahang_KH);
            this.panelMenu.Controls.Add(this.btn_thoat_KH);
            this.panelMenu.Controls.Add(this.btn_dangxuat_KH);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(186, 681);
            this.panelMenu.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(8, 99);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(166, 85);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnLichSuMuaHang
            // 
            this.btnLichSuMuaHang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLichSuMuaHang.Location = new System.Drawing.Point(20, 345);
            this.btnLichSuMuaHang.Name = "btnLichSuMuaHang";
            this.btnLichSuMuaHang.Size = new System.Drawing.Size(150, 93);
            this.btnLichSuMuaHang.TabIndex = 6;
            this.btnLichSuMuaHang.Text = "Lịch sử mua hàng";
            this.btnLichSuMuaHang.UseVisualStyleBackColor = true;
            this.btnLichSuMuaHang.Click += new System.EventHandler(this.btnLichSuMuaHang_Click_1);
            // 
            // panelChildForm_KH
            // 
            this.panelChildForm_KH.Location = new System.Drawing.Point(186, 0);
            this.panelChildForm_KH.Name = "panelChildForm_KH";
            this.panelChildForm_KH.Size = new System.Drawing.Size(929, 681);
            this.panelChildForm_KH.TabIndex = 5;
            // 
            // FormMainKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 681);
            this.Controls.Add(this.panelChildForm_KH);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH HÀNG";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button btn_dangxuat_KH;
        private Button btn_thoat_KH;
        private Button btn_muahang_KH;
        private Panel panelMenu;
        private Button btnLichSuMuaHang;
        private Panel panelChildForm_KH;
        private TextBox textBox2;
    }
}