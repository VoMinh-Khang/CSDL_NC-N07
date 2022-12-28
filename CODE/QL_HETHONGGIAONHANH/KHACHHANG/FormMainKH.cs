using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QL_HETHONGGIAONHANH
{
    public partial class FormMainKH : Form
    {

        Thread t;
        string ID;

        public FormMainKH(string id)
        {
            InitializeComponent();
            ID = id;
            string sql = "SELECT TENKHACH FROM KHACHHANG WHERE TAIKHOAN = '" + id + "'";
            textBox2.Text = Functions.GetFieldValues(sql);
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
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void open_FormDangNhap(object obj)
        {
            Application.Run(new DangNhap());
        }

        private void btn_dangxuat_KH_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormDangNhap);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void openFormMuaHang(object obj)
        {
            Application.Run(new MuaHangKH(ID));
            
            //Application.Run(new TT_KH_DK(tendn, matkhau, LOAITK));
        }
        private void btn_muahang_KH_Click(object sender, EventArgs e)
        {
            //openChildForm(new MuaHangKH(c));
            //this.Close();
            //activeform.Close();
            //this.Close();
            //Thread T;
            //Thread mh = new Thread(open);
            //MuaHangKH mh = new MuaHangKH(ID);
            //mh.StartPosition = FormStartPosition.CenterScreen;
            //mh.Show();
            ActivateButton(sender);
            this.Close();
            t = new Thread(openFormMuaHang);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void FormMain_KH_Load(object sender, EventArgs e)
        {
            btn_muahang_KH.PerformClick();
        }

        private void btn_giohang_KH_Click(object sender, EventArgs e)
        {
            //openChildForm(new GioHangKH());
            ActivateButton(sender);
        }

        private void btnLichSuMuaHang_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT MAKHACH FROM KHACHHANG WHERE TAIKHOAN = '" + ID + "'";     
            openChildForm(new LichSuMuaHang(Functions.GetFieldValues(sql)));
           
            ActivateButton(sender);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
