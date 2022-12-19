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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QL_HETHONGGIAONHANH
{

    
    public partial class KHDangKyTT : Form
    {
        Thread t;
        string MAKHACH;
        string ID;
        string USERNAME, PASS, LOAITK;

        public KHDangKyTT(string username, string password, string loaitk)
        {
            InitializeComponent();
            USERNAME = username;
            PASS = password;
            LOAITK = loaitk;
        }

        public void open_FormDangNhap(object obj)
        {
            Application.Run(new DangNhap());
        }
        //thiếu
        //private int Run_SP_TaoTK_KH()
        //{
        //    SqlCommand cmd = new SqlCommand("USP_TaoTKKhachHang", Functions.Con);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //    // set kiểu dữ liệu
        //    cmd.Parameters.Add("@ID", SqlDbType.VarChar, 15);
        //    cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar, 50);
        //    cmd.Parameters.Add("@PASS", SqlDbType.VarChar, 50);
        //    cmd.Parameters.Add("@LOAITK", SqlDbType.Int);

        //    var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
        //    returnParameter.Direction = ParameterDirection.ReturnValue;

        //    //set giá trị
        //    cmd.Parameters["@ID"].Value = ID;
        //    cmd.Parameters["@USERNAME"].Value = USERNAME;
        //    cmd.Parameters["@PASS"].Value = PASS;
        //    cmd.Parameters["@LOAITK"].Value = LOAITK;
            
        //    cmd.ExecuteNonQuery();

        //    return Int32.Parse(returnParameter.Value.ToString());

        //}
        private void btn_dangky_Click(object sender, EventArgs e)
        {
            try
            {
                //Thiếu
                //string sql = "SELECT COUNT(*) FROM KHACHHANG";
                //int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                //rows_number++;
                //MAKHACH = "KH" + rows_number.ToString();

                //sql = "SELECT COUNT(*) FROM TAIKHOAN";
                //rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                //rows_number++;
                //ID = "ID" + rows_number.ToString();

                //int status = Run_SP_TaoTK_KH();//Thiếu
                int status = 1;
                if (status == 1)
                {
                    MessageBox.Show("Thêm tài khoản thành công! Đăng nhập lại để tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // sau khi dk xong thì quay lại cho người dùng đăng nhập
                    this.Close();
                    t = new Thread(open_FormDangNhap);
                    t.SetApartmentState(ApartmentState.STA);
                    t.Start();

                    return;
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show("Thêm tài khoản thất bại mã lỗi: " + loi.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}