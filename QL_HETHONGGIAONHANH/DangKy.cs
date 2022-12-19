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
    public partial class DangKy : Form
    {
        Thread t;
        string username;
        string password;
        string loaitk;

        public DangKy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void button_showPass_Click_1(object sender, EventArgs e)
        {
            if (button_showPass.Text.Equals("Show"))
            {
                txtPassword.PasswordChar = '\0';
                button_showPass.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                button_showPass.Text = "Show";
            }
        }
        public void open_FormDangNhap(object obj)
        {
            Application.Run(new DangNhap());
        }
        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormDangNhap);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public void open_FormKHDangKyTT(object obj)
        {
            Application.Run(new KHDangKyTT(username,password,loaitk));
            //Application.Run(new TT_KH_DK(tendn, matkhau, LOAITK));
        }
        private void checkBox_KhachHang_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_KhachHang.Checked == true)
            {
                checkBox_TaiXe.Checked = false;
                loaitk = "4";
            }
        }
        private void checkBox_TaiXe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TaiXe.Checked == true)
            {
                checkBox_KhachHang.Checked = false;
                //loaitk = "4";
            }
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            //TH chưa nhập đủ dữ liệu
            if (txtUsername.Text.Trim().Length == 0 |
                txtPassword.Text.Trim().Length == 0 |
                checkBox_KhachHang.Checked == false
                && checkBox_TaiXe.Checked == false)
                
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            username = txtUsername.Text.Trim();
            password = txtPassword.Text.Trim();
            
            
            //kiểm tra tên đăng nhập tồn tại còn THIếu *****
            
            
            this.Close();

            // mở form nhập thông tin cá nhân
            if (checkBox_KhachHang.Checked == true)
            {
                t = new Thread(open_FormKHDangKyTT);
            }
            else if (checkBox_TaiXe.Checked == true)
            {
                t = new Thread(open_FormDangNhap);
                
            }    
           
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
