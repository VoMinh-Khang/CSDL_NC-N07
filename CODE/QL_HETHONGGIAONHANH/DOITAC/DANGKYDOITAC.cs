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
    public partial class DANGKYDOITAC : Form
    {
        Thread t;
        string MADT;
        string ID;
        string USERNAME,PASS,LOAITK;
        public DANGKYDOITAC(string username, string password, string loaitk)
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
        private int Run_SP_TaoTK_DT()
        {
            SqlCommand cmd = new SqlCommand("USP_DKDOITAC", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@id", SqlDbType.Char, 5);
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20);
            cmd.Parameters.Add("@loaitk", SqlDbType.Int);

            cmd.Parameters.Add("@masothue", SqlDbType.VarChar,10);
            cmd.Parameters.Add("@madt", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@tenquan", SqlDbType.NVarChar,50);
            cmd.Parameters.Add("@nguoidaidien", SqlDbType.NVarChar,50);
            cmd.Parameters.Add("@thanhpho", SqlDbType.NVarChar,50);
            cmd.Parameters.Add("@quan", SqlDbType.NVarChar,50);
            cmd.Parameters.Add("@soluongcuahang", SqlDbType.Char,10);
            cmd.Parameters.Add("@soluongdhdukien", SqlDbType.Char,10);
            cmd.Parameters.Add("@loaiamthuc", SqlDbType.NVarChar,50);
            cmd.Parameters.Add("@diachikinhdoanh", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@dienthoai", SqlDbType.Char, 10);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@id"].Value = ID;
            cmd.Parameters["@username"].Value = USERNAME;
            cmd.Parameters["@pass"].Value = PASS;
            cmd.Parameters["@loaitk"].Value = LOAITK;

            cmd.Parameters["@masothue"].Value = Masothue.Text;
            cmd.Parameters["@email"].Value = Email.Text;
            cmd.Parameters["@tenquan"].Value = Tenquan.Text;
            cmd.Parameters["@madt"].Value = MADT;
            cmd.Parameters["@nguoidaidien"].Value = NguoiDaiDien.Text;
            cmd.Parameters["@thanhpho"].Value = ThanhPho.Text;
            cmd.Parameters["@quan"].Value = Quan.Text;
            cmd.Parameters["@soluongcuahang"].Value = Cuahang.Text;
            cmd.Parameters["@soluongdhdukien"].Value = SLDHDK.Text;
            cmd.Parameters["@loaiamthuc"].Value = LoaiAmthuc.Text;
            cmd.Parameters["@diachikinhdoanh"].Value = Diachi.Text;
            cmd.Parameters["@dienthoai"].Value = dienthoai.Text;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string missing = "000000000";
                string sql = "SELECT COUNT (*)  FROM DOITAC";
                int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                rows_number++;
                ///CHỖ NÀY THIẾU SỬA SAU TRONG DB
                MADT = "DT" + missing.Substring(0, 5 - 2 - rows_number.ToString().Length) + rows_number.ToString();

                sql = "SELECT COUNT(*) FROM TAIKHOAN";
                rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                rows_number++;
                //ID = "TK" + missing.Substring(0, 10 - 2 - rows_number.ToString().Length) + rows_number.ToString();//Thiếu

                ID = "TK" + missing.Substring(0, 5 - 2 - rows_number.ToString().Length) + rows_number.ToString();
               

                int status = Run_SP_TaoTK_DT();

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

        private void DANGKYTHONGTIN_Load(object sender, EventArgs e)
        {

        }
    }
}
