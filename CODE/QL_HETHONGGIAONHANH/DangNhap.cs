using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_HETHONGGIAONHANH
{
    public partial class DangNhap : Form
    {      
        string id;
        int loaitk = -2;
        string username;
        string password;

        Thread t;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void resetvalue_DN()
        {
            txtUsername.Text = "kh1";
            txtPassword.Text = "123456789";
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            //Mở kết nối
            //Functions.Connect(user_type);
            Functions.Connect(Functions.get_ConnectString(loaitk));
            //Functions.Connect(Functions.get_ConnectString());
            resetvalue_DN();
        }

        private void Run_SP_DangNhap()
        {
            SqlCommand cmd = new SqlCommand("USP_Login", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@PASS", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@ID", SqlDbType.Char,5).Direction = ParameterDirection.Output;
            //thiếu: chỗ này đổi
            cmd.Parameters.Add("@LOAITK", SqlDbType.Int).Direction = ParameterDirection.Output;

            // set giá trị
            cmd.Parameters["@USERNAME"].Value = username;
            cmd.Parameters["@PASS"].Value = password;

            cmd.ExecuteNonQuery();

            id = Convert.ToString(cmd.Parameters["@ID"].Value);
            loaitk = Convert.ToInt32(cmd.Parameters["@LOAITK"].Value);
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

        public int Run_SP_KTMatKhau()
        {
            SqlCommand cmd = new SqlCommand("USP_CHECKPASS", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@PASS", SqlDbType.VarChar, 20);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            // set giá trị
            cmd.Parameters["@USERNAME"].Value = username;
            cmd.Parameters["@PASS"].Value = password;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());
        }

        // xử lí mở form tương ứng từng loại acc      
        public void open_FormMain(object obj)
        {
            switch (loaitk)
            {
                case 0:
                    {
                       // Application.Run(new FormMain_QT());
                        break;
                    }
                case 4:
                    {
                        Application.Run(new FormMainKH(id));
                        break;
                    }
                //case 2:
                //    {
                //        Application.Run(new FormMain_NV(id));
                //        break;
                //    }
                //case 3:
                //    {
                //        Application.Run(new FormMain_NS());
                //        break;
                //    }
                //case 4:
                //    {
                //        Application.Run(new FormMain_QL());
                //        break;
                //    }
                
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text.Trim().ToString();
            password = txtPassword.Text.Trim().ToString();

            // nếu chưa có dữ liệu 
            if (username.Length == 0 | password.Length == 0)

            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra tên đăng nhập           
            if (Run_SP_KTTenDangNhap() == 0)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }

            //Kiểm tra mật khẩu ứng với tên đăng nhập
            if (Run_SP_KTMatKhau() == 0)
            {
                MessageBox.Show("Mật khẩu không chính xác !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = "";
                txtPassword.Focus();
                return;
            }

            Run_SP_DangNhap();
            
            // nếu acc này bị khóa
            if (loaitk == -1)
            {
                MessageBox.Show("Tài khoản này đã bị khóa !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ngắt kết nối vô danh
            Functions.Disconnect();

            // kết nối với database tương ứng với loại acc

            Functions.Connect(Functions.get_ConnectString(loaitk));
            // mở giao diện tương ứng từng loại acc                 
            this.Close();
            t = new Thread(open_FormMain);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public void open_FormDangKi(object obj)
        {
            Application.Run(new DangKy());
        }


        private void btn_dangky_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormDangKi);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
