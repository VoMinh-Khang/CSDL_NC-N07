using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string LOAITAIKHOAN;

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
        //public void open_FormDangKyDoiTac(object obj)
        //{
        //    Application.Run(new DANGKYDOITAC());
        //}
        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormDangNhap);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public void open_FormKHDangKyTT(object obj)
        {
            Application.Run(new KHDangKyTT(username,password, LOAITAIKHOAN));
            
        }
      
        
        private int Run_SP_KTTenDangNhap()
        {
            SqlCommand cmd = new SqlCommand("USP_CHECKUSERNAME", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar, 20);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            // set giá trị
            cmd.Parameters["@USERNAME"].Value = username;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());
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
            // Kiểm tra tên đăng nhập           
            if (Run_SP_KTTenDangNhap() == 1)
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text.Trim().Length > 20)
            {
                MessageBox.Show("Mật khẩu không được dài hơn 20 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }

            //thiếu: usp_taotaikhoan


            this.Close();

            // mở form nhập thông tin cá nhân
            if (checkBox_KhachHang.Checked == true)
            {
                checkBox_TaiXe.Checked = false;
                LOAITAIKHOAN = "4";
                t = new Thread(open_FormKHDangKyTT);
            }
            else if (checkBox_TaiXe.Checked == true)
            {
                //t = new Thread(open_FormDangKyDoiTac);
                
            }    
           
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
