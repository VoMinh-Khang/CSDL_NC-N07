using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace QL_HETHONGGIAONHANH
{
    public partial class QUANLYCUAHANG : Form
    {
        DataTable tbl_CUAHANG;
        string MADT;
        public QUANLYCUAHANG(string madoitac)
        {
            InitializeComponent();
            MADT = madoitac;
        }
        private int Run_SP_CAPNHATCUAHANG()
        {
            SqlCommand cmd = new SqlCommand("USP_CAPNHATCUAHANG", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu

            cmd.Parameters.Add("@MACUAHANG", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@MADT", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@TENCUAHANG", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@THOIGIANHOATDONG", SqlDbType.DateTime);
            cmd.Parameters.Add("@TINHTRANGCUAHANG", SqlDbType.NVarChar, 50);
            //cmd.Parameters.Add("@ID_KHUVUC", SqlDbType.Char,10);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@MACUAHANG"].Value = MACUAHANG.Text;
            cmd.Parameters["@MADT"].Value = MADT;
            cmd.Parameters["@TENCUAHANG"].Value = TENCUAHANG.Text;
            cmd.Parameters["@DIACHI"].Value = DIACHI.Text;
            cmd.Parameters["@THOIGIANHOATDONG"].Value = TGHD.Text;
            cmd.Parameters["@TINHTRANGCUAHANG"].Value = TTCUAHANG.Text;
            //cmd.Parameters["@ID_KHUVUC"].Value = ID_KHUVUC.Text;
            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT (*)  FROM CUAHANG";
            int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
            rows_number++;
            try
            {
                int status = Run_SP_CAPNHATCUAHANG();
                if (status == 1)
                {

                    MessageBox.Show("Cập nhật cửa hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QUANLYCUAHANG_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật cửa hàng thất bại, mã lỗi: " + ex.Message);
            }
        }

        private void QUANLYCUAHANG_Load(object sender, EventArgs e)
        {
            //
            string sql = "Select * FROM CUAHANG WHERE MADT ='"+MADT+"'" ;
            tbl_CUAHANG = Functions.GetDataToTable(sql);
            dataGridViewQLCH.DataSource = tbl_CUAHANG;

            dataGridViewQLCH.AllowUserToAddRows = false;
            dataGridViewQLCH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private int Run_SP_THEMCUAHANG()
        {
            SqlCommand cmd = new SqlCommand("USP_THEMCUAHANG", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu

            cmd.Parameters.Add("@MACUAHANG", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@MADT", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@TENCUAHANG", SqlDbType.NVarChar,50);
            cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@THOIGIANHOATDONG", SqlDbType.DateTime);
            cmd.Parameters.Add("@TINHTRANGCUAHANG", SqlDbType.NVarChar, 50);
            //cmd.Parameters.Add("@ID_KHUVUC", SqlDbType.Char, 10);
            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@MACUAHANG"].Value = MACUAHANG.Text;
            cmd.Parameters["@MADT"].Value = MADT;
            cmd.Parameters["@TENCUAHANG"].Value = TENCUAHANG.Text;
            cmd.Parameters["@DIACHI"].Value = DIACHI.Text;
            cmd.Parameters["@THOIGIANHOATDONG"].Value = TGHD.Text;
            cmd.Parameters["@TINHTRANGCUAHANG"].Value = TTCUAHANG.Text;
            //cmd.Parameters["@ID_KHUVUC"].Value = ID_KHUVUC.Text;
            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }
        private void buttonThemCH_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT (*)  FROM CUAHANG";
            int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
            rows_number++;
            try
            {
                int status = Run_SP_THEMCUAHANG(); 
                if (status == 1)
                {
                    MessageBox.Show("Thêm cửa hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QUANLYCUAHANG_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm cửa hàng thất bại, mã lỗi: " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonXoaCH_Click(object sender, EventArgs e)
        {
        }
    }
}
