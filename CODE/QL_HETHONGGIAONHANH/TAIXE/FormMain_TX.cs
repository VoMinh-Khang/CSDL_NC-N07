using QL_HETHONGGIAONHANH.TAIXE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HETHONGGIAONHANH
{
    public partial class FormMain_TX : Form
    {
        Thread t;
        string ID;
       // string CMND;

        public FormMain_TX(string id)
        {
            InitializeComponent();
            ID = id;
            string sql = "SELECT HOTEN FROM TAIXE WHERE TAIKHOAN = '" + id + "'";
            textBox_TenTX.Text = Functions.GetFieldValues(sql);   
        }

        //Mở 1 form con
        private Form activeform = null;

        private void openChildForm(Form childForm)
        {
            if(activeform != null)
            {
                activeform.Close();
            }
            activeform= childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm_TX.Controls.Add(childForm);
            panelChildForm_TX.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Xử lí chuyển màu khi click vào button
        private Button currentButton;

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#3f75a2");
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

        private void FormMain_TX_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //public void open_DSDonHang(object obj)
        //{
        //    Application.Run(new DSDonHang_TX());
        //}
        private void btn_DSDonHang_Click(object sender, EventArgs e)
        {
            string sql = "SELECT TAIKHOAN FROM TAIXE WHERE TAIKHOAN = '" + ID + "'";
            openChildForm(new DSDonHang_TX(Functions.GetFieldValues(sql)));
            ActivateButton(sender);
        }
        private void panelChildForm_TX_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_TheoDoiThuNhap_Click(object sender, EventArgs e)
        {
            string sql = "SELECT TAIKHOAN FROM TAIXE WHERE TAIKHOAN = '" + ID + "'";
            openChildForm(new TXTheoDoiThuNhap(Functions.GetFieldValues(sql)));
            ActivateButton(sender);
        }

        private void textBox_TenTX_TextChanged(object sender, EventArgs e)
        {

        }

        public void open_FormDangNhap(object obj)
        {
            Application.Run(new DangNhap());
        }
        private void btn_DangXuat_TX_Click(object sender, EventArgs e)
        {

            this.Close();
            t = new Thread(open_FormDangNhap);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
