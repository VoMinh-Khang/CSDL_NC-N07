using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QL_HETHONGGIAONHANH
{
    public partial class ThemHD_NV : Form
    {
        DataTable table_HD;
        Thread t;
        string MSHD;
        string NGAYLAP, THOIGIANHIEULUC;
        string PHIHOAHONG;
        string MADT;
        string MASOTHUE;
        string CMND;
        string TINHTRANGDUYET;

        string ID;

        public ThemHD_NV()
        {
            InitializeComponent();
            /*MSHD = mahd;
            NGAYLAP = ngaylap;
            THOIGIANHIEULUC = ngayhet;
            MADT = madt;
            CMND = cmnd;*/
        }

        private void reset_value()
        {
            textBox_timMAHD.Text = "";
            textBox_TKNH.Text = "";
            textBox_PhiHoaHong.Text = "";
            textBox_MADT.Text = "";
        }

        private void btn_timtk_Click(object sender, EventArgs e)
        {
            if ( textBox_timMAHD.Text.Trim().Length > 0)
            {
                string sql = "SELECT HD.MAHD, HD.MADT, HD.MANV, HD.MASOTHUE, " + "FROM HOPDONG HD, DOITAC DT " + "WHERE HD.MAHD = '" + textBox_timMAHD.Text.Trim() + "' " + "AND HD.MADT = DT.MADT";
                table_HD = Functions.GetDataToTable(sql);

                if (table_HD.Rows.Count == 0)
                {
                    MessageBox.Show("Mã hợp đồng không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                textBox_MAHD.Text =table_HD.Rows[0].Field<String>(0).ToString();
                textBox_TKNH.Text = table_HD.Rows[0].Field<String>(1).ToString();
                textBox_MADT.Text = table_HD.Rows[0].Field<String>(3).ToString();
                textBox_PhiHoaHong.Text = table_HD.Rows[0].Field<String>(2).ToString();
                MSHD = table_HD.Rows[0].Field<String>(4).ToString();
            }
        }


        private void dTP_ngaygiao_Enter(object sender, EventArgs e)
        {
            dTP_ngayhethan.CustomFormat = "yyyy-MM-dd";
        }

        /*private void cBox_KH_cotk_CheckedChanged(object sender, EventArgs e)
        {
            reset_value();
            if (cBox_KH_cotk.Checked)
            {
                textBox_MAHD.Enabled = true;
                textBox_MAHD1.Enabled = false;
                textBox_TKNH.Enabled = false;
                textBox_PhiHoaHong.Enabled = false;
                textBox_MADT.Enabled = false;
            }
            else
            {
                textBox_MAHD.Enabled = false;
                textBox_MAHD1.Enabled = true;
                textBox_TKNH.Enabled = true;
                textBox_PhiHoaHong.Enabled = true;
                textBox_MADT.Enabled = true;
            }
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private int Run_SP_Sp_KH_ThemDH()
        {
            SqlCommand cmd = new SqlCommand("Sp_ThemDH", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@MAHD", SqlDbType.VarChar, 15);
            cmd.Parameters.Add("@MAKH", SqlDbType.VarChar, 15);
            cmd.Parameters.Add("@MANV", SqlDbType.VarChar, 15);
            cmd.Parameters.Add("@TENNGUOINHAN", SqlDbType.NVarChar, 255);
            cmd.Parameters.Add("@DIACHI_NGUOINHAN", SqlDbType.NVarChar, 255);
            cmd.Parameters.Add("@SDT_NGUOINHAN", SqlDbType.NVarChar, 255);
            cmd.Parameters.Add("@PHIVANCHUYEN", SqlDbType.Decimal, 19);
            cmd.Parameters.Add("@HINHTHUCTHANHTOAN", SqlDbType.Int);
            cmd.Parameters.Add("@NGAYMUONGIAO", SqlDbType.Date);
            cmd.Parameters.Add("@NGAYLAP", SqlDbType.Date);
            cmd.Parameters.Add("@TINHTRANG", SqlDbType.Int);
            cmd.Parameters.Add("@TONGTIEN", SqlDbType.Decimal, 19);

            cmd.Parameters["@PHIVANCHUYEN"].Precision = 19;
            cmd.Parameters["@PHIVANCHUYEN"].Scale = 4;
            cmd.Parameters["@TONGTIEN"].Precision = 19;
            cmd.Parameters["@TONGTIEN"].Scale = 4;

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            // set giá trị
            cmd.Parameters["@MAHD"].Value = MSHD;
            cmd.Parameters["@MADT"].Value = MADT;
            cmd.Parameters["@MANV"].Value = CMND;
            cmd.Parameters["@TENNGUOINHAN"].Value = textBox_MASOTHUE.Text;
            cmd.Parameters["@SDT_NGUOINHAN"].Value = textBox_MANV.Text;
            cmd.Parameters["@NGAYMUONGIAO"].Value = dTP_ngaylap.Text;
            cmd.Parameters["@NGAYLAP"].Value = dTP_ngayhethan.Text;
            cmd.Parameters["@TINHTRANG"].Value = 0;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());
        }

        private int Run_SP_Sp_KH_ThemCTDH()
        {
            SqlCommand cmd = new SqlCommand("Sp_ThemCTDH", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@MADH", SqlDbType.VarChar, 15);
            cmd.Parameters.Add("@MASP", SqlDbType.VarChar, 15);
            cmd.Parameters.Add("@SOLUONG", SqlDbType.Int);
            cmd.Parameters.Add("@THANHTIEN", SqlDbType.Decimal);

            cmd.Parameters["@THANHTIEN"].Precision = 19;
            cmd.Parameters["@THANHTIEN"].Scale = 4;

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            // set giá trị
            cmd.Parameters["@MADH"].Value = MSHD;
            cmd.Parameters["@MADT"].Value = MADT;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());
        }

        private int Run_SP_TaoTK_KH()
        {
            SqlCommand cmd = new SqlCommand("Sp_TaoTK_KH", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@ID", SqlDbType.VarChar, 15);
            cmd.Parameters.Add("@TENDN", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@LOAITK", SqlDbType.Int);
            cmd.Parameters.Add("@SDT", SqlDbType.Char, 15);
            cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar, 255);
            cmd.Parameters.Add("@DIACHI", SqlDbType.VarChar, 255);
            cmd.Parameters.Add("@MAKH", SqlDbType.VarChar, 15);
            cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@STK", SqlDbType.VarChar, 30);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            // set giá trị
            cmd.Parameters["@ID"].Value = ID;
            cmd.Parameters["@TENDN"].Value = textBox_PhiHoaHong.Text;
            cmd.Parameters["@MATKHAU"].Value = textBox_PhiHoaHong.Text;
            cmd.Parameters["@LOAITK"].Value = 1;
            cmd.Parameters["@SDT"].Value = textBox_TKNH.Text;
            cmd.Parameters["@EMAIL"].Value = textBox_PhiHoaHong.Text;
            cmd.Parameters["@DIACHI"].Value = textBox_MADT.Text;
            cmd.Parameters["@MADT"].Value = MADT;
            cmd.Parameters["@TENKH"].Value = textBox_MAHD.Text;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void open_FormMain_NV(object obj)
        {
            Application.Run(new FormMain_NV());
        }
        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormMain_NV);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void textBox_timMAHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_MAHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemHD_NV_Load(object sender, EventArgs e)
        {

        }

        private void btn_themdh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM DONHANG";
            int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
            rows_number++;
            MSHD = "HD" + rows_number.ToString();


            /*if (!cBox_KH_cotk.Checked)
            {
                try
                {
                    sql = "SELECT COUNT(*) FROM KHACHHANG";
                    rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                    rows_number++;
                    MADT = "DT" + rows_number.ToString();

                    sql = "SELECT COUNT(*) FROM TAIKHOAN";
                    rows_number = Int32.Parse(Functions.GetFieldValues(sql));
                    rows_number++;
                    ID = "ID" + rows_number.ToString();

                    int status = Run_SP_TaoTK_KH();
                }
                catch (Exception loi)
                {
                    MessageBox.Show("Thêm tài khoản KH thất bại mã lỗi: " + loi.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }*/

            try
            {
                int status1 = Run_SP_Sp_KH_ThemDH();
                int status2 = Run_SP_Sp_KH_ThemCTDH();

                if (status1 == 1 && status2 == 1)
                {
                    MessageBox.Show("Thêm đơn hàng thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception loi)
            {
                MessageBox.Show("Thêm đơn hàng thất bại mã lỗi: " + loi.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}