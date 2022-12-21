﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HETHONGGIAONHANH1
{
    public partial class FormMain_NV : Form
    {
        Thread t;
        string ID;
        public FormMain_NV(string cmnd)
        {
            InitializeComponent();
            ID = cmnd;
        }

        private void FormMain_NV_Load(object sender, EventArgs e)
        {

        }

        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm_KH.Controls.Add(childForm);
            panelChildForm_KH.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // xử lí chuyển màu khi click vào button
        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#4169E1");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(39, 39, 58);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }
        // xử lí đăng xuất + đăng nhập lại
        public void open_FormDangNhap(object obj)
        {
            Application.Run(new DangNhap());
        }


        private void btn_themdh_NV_Click(object sender, EventArgs e)
        {
            openChildForm(new ThemHD_NV(ID));
            ActivateButton(sender);
        }

        private void btn_FormMain_NV_Load(object sender, EventArgs e)
        {
            btn_themdh_NV.PerformClick();
        }

        private void btn_dangxuat_KH_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormDangNhap);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }

        private void btn_thoat_KH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}