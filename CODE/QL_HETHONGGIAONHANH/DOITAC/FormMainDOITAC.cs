using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QL_HETHONGGIAONHANH
{
    public partial class FormMainDOITAC : Form
    {
        Thread t;
        string ID;
        string MADT;
        public FormMainDOITAC(string id)
        {
            InitializeComponent();
            ID = id;
            string sql = "SELECT MADT FROM DOITAC WHERE TAIKHOAN = '" + id + "'";
            //string sql = "SELECT TENQUAN FROM DOITAC WHERE TAIKHOAN = '" + id + "'";
            MADT = Functions.GetFieldValues(sql);

        }
        private Form activeform = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // xử lí chuyển màu khi click vào button
        private Button currentButton;
        private void DisableButton()
        {
            foreach (Control previousBtn in PanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(39, 39, 58);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#FFBCB3");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void BtnLHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LAPHOPDONG(MADT));
            ActivateButton(sender);
        }

        private void BtnQLCH_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QUANLYCUAHANG(MADT));
            ActivateButton(sender);
        }

        private void BtnQLTD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QUANLYTHUCDON());
            ActivateButton(sender);
        }

        private void BtnQLDH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QUANLYDONHANG());
            ActivateButton(sender);
        }

        private void BtnQLSL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QUANLYSOLIEU());
            ActivateButton(sender);
        }

        private void FormMainDOITAC_Load(object sender, EventArgs e)
        {

        }
        public void open_FormDangNhap(object obj)
        {
            Application.Run(new DangNhap());
        }
        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormDangNhap);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
