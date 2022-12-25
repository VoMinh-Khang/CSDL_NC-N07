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

namespace QL_HETHONGGIAONHANH.TAIXE
{
    public partial class TXDangKyTT : Form
    {
        Thread t;
        string TAIKHOAN;
        string USERNAME, PASS, LOAITK;
        public TXDangKyTT(string username, string pass, string loaitk)
        {
            InitializeComponent();
            USERNAME = username;
            PASS = pass;
            LOAITK = loaitk;
        }
 
        public void open_FormDangNhap(object obj)
        {
            Application.Run(new DangNhap());
        }

        private void TXDangKyTT_Load(object sender, EventArgs e)
        {

        }
        public int Run_SP_TaoTK_TX()
        {
            SqlCommand cmd = new SqlCommand("UPS_TX_TAOTK", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@CMND", SqlDbType.VarChar, 12);
            
            cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar, 30);
            cmd.Parameters.Add("@DIENTHOAI", SqlDbType.Char, 10);
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 30);
            cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@BIENSOXE", SqlDbType.VarChar, 5);
            cmd.Parameters.Add("@TAIKHOANNGANHANG", SqlDbType.Char, 15);
            cmd.Parameters.Add("@PHITHUECHAN", SqlDbType.Float);
            cmd.Parameters.Add("@ID_KHUVUC", SqlDbType.Char, 10);

            cmd.Parameters.Add("@ID", SqlDbType.VarChar, 5);
            cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@LOAITK", SqlDbType.Int);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@ID"].Value = TAIKHOAN;
            cmd.Parameters["@USERNAME"].Value = USERNAME;
            cmd.Parameters["@pass"].Value = PASS;
            cmd.Parameters["@LOAITK"].Value = LOAITK;


            cmd.Parameters["@HOTEN"].Value = textBox_HoTen.Text;
            cmd.Parameters["@DIENTHOAI"].Value = textBox_SDT.Text;
            cmd.Parameters["@CMND"].Value = textBox_CMND.Text;
            cmd.Parameters["@EMAIL"].Value = textBox_Email.Text;
            cmd.Parameters["@BIENSOXE"].Value = textBox_BienSoXe.Text;
            cmd.Parameters["@TAIKHOANNGANHANG"].Value = textBox_STKNganHang.Text;
            cmd.Parameters["@PHITHUECHAN"].Value = textBox_PhiTheChan.Text;
            cmd.Parameters["@ID_KHUVUC"].Value = textBox_KhuVuc.Text;
            cmd.Parameters["@DIACHI"].Value = textBox_DiaChi.Text;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_hoantat_Click(object sender, EventArgs e)
        {
            try
            {
                //string sql = "SELECT COUNT(*) FROM TAIXE";
                //int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                //rows_number++;
                //CMND = "KH" + rows_number.ToString();

                string sql = "SELECT COUNT(*) FROM TAIKHOAN";
                int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                rows_number++;
                TAIKHOAN = "TK" + rows_number.ToString();

                int status = Run_SP_TaoTK_TX();//Thiếu

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

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_SDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
       
    }
}
