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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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
        private int Run_SP_TaoTK_KH()
        {
            SqlCommand cmd = new SqlCommand("USP_TAOTK_KHACHHANG", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@loaitk", SqlDbType.Int);
            cmd.Parameters.Add("@sdt", SqlDbType.Char, 10);
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 30);
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 300);
            cmd.Parameters.Add("@makhach", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@tenkhach", SqlDbType.NVarChar, 30);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@id"].Value = ID;
            cmd.Parameters["@username"].Value = USERNAME;
            cmd.Parameters["@pass"].Value = PASS;
            cmd.Parameters["@loaitk"].Value = LOAITK;

            cmd.Parameters["@sdt"].Value = textBox_SDT.Text;
            cmd.Parameters["@email"].Value = textBox_Email.Text;
            cmd.Parameters["@diachi"].Value = textBox_DiaChi.Text;
            cmd.Parameters["@makhach"].Value = MAKHACH;
            cmd.Parameters["@tenkhach"].Value = textBox_HoTen.Text;
            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }
        private void btn_hoantat_Click(object sender, EventArgs e)
        {
            try
            {
                //Thiếu ĐANG SAI
                //string sql = "SELECT COUNT(*) FROM KHACHHANG";
                //int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                //rows_number++;
                //MAKHACH = "KH" + rows_number.ToString();

                //sql = "SELECT COUNT(*) FROM TAIKHOAN";
                //rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                //rows_number++;
                //ID = "ID" + rows_number.ToString();
                //SqlCommand cmd = new SqlCommand("TAOID_TAIKHOAN", Functions.Con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.Add("@ID", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output; 

                //// set giá trị
                //cmd.Parameters["@ID"].Value = ID;
                //cmd.ExecuteNonQuery();
                //ID = Convert.ToString(cmd.Parameters["@ID"].Value);

                //SqlCommand cmd2 = new SqlCommand("TAOMAKH", Functions.Con);
                //cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd2.Parameters.Add("@makhach", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output; 

                //// set giá trị
                //cmd2.Parameters["@makhach"].Value = MAKHACH;
                //cmd2.ExecuteNonQuery();
                //MAKHACH = Convert.ToString(cmd2.Parameters["@makhach"].Value);
                string missing = "000000000";
                string sql = "SELECT COUNT(*) FROM KHACHHANG";
                int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                rows_number++;
                //MAKHACH = "KH" + missing.Substring(0, 10 - 2 - rows_number.ToString().Length) + rows_number.ToString();//Thiếu
                MAKHACH = "KH" + missing.Substring(0, 5 - 2 - rows_number.ToString().Length) + rows_number.ToString();

                sql = "SELECT COUNT(*) FROM TAIKHOAN";
                rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                rows_number++;
                //ID = "TK" + missing.Substring(0, 10 - 2 - rows_number.ToString().Length) + rows_number.ToString();//Thiếu

                ID = "TK" + missing.Substring(0, 5 - 2 - rows_number.ToString().Length) + rows_number.ToString();
                int status = Run_SP_TaoTK_KH();//Thiếu
                
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