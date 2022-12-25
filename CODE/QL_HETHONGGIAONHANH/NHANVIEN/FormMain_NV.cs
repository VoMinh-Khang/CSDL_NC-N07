using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HETHONGGIAONHANH
{
    public partial class FormMain_NV : Form
    {
        Thread t;
        //string ID;
        /*string MSHD;
        string NGAYLAP, THOIGIANHIEULUC;
        string PHIHOAHONG;
        string MADT;
        string MASOTHUE;
        string CMND;
        string TINHTRANGDUYET;*/
        public FormMain_NV(/*string id*/)
        {
            InitializeComponent();
            //ID = id;
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

        public void open_xemHD_NV(object obj)
        {
            Application.Run(new XemHD_NV());
        }
        private void btn_xemHD_NV_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_xemHD_NV);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
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

        private void panelChildForm_KH_Paint(object sender, PaintEventArgs e)
        {

        }

        public void open_themHD_NV(object obj)
        {
            Application.Run(new ThemHD_NV());
        }
        private void btn_themHD_NV_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_themHD_NV);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void open_Thongke_KH(object obj)
        {
            Application.Run(new ThongkeKH_NV());
        }
        private void btn_Thongke_KH_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_Thongke_KH);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public void open_Thongke_DH(object obj)
        {
            Application.Run(new ThongkeDH_NV());
        }
        private void btn_ThongKeKh_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_Thongke_DH);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        public void open_DuyetHD_NV(object obj)
        {
            Application.Run(new DuyetHD_NV());
        }

        private void btn_duyet_HD_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_DuyetHD_NV);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }

        public void open_ThongKe_Report_NV(object obj)
        {
            Application.Run(new ThongKeReport_NV());
        }

        private void btn_ThongKe_Report_Click(object sender, EventArgs e)
        {
            {
                this.Close();
                t = new Thread(open_ThongKe_Report_NV);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();

            }
        }
    }
}
