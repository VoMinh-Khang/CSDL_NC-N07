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
    public partial class LAPHOPDONG : Form
    {
        //Thread t;
        DataTable tbl_HOPDONG;
        //string MASOHOPDONG;
        string MADT;
        //string MaSoThue;
        //string MANV;
        public LAPHOPDONG(string madoitac)
        {
            
            InitializeComponent();
            string sql = "SELECT MASOHOPDONG FROM HOPDONG WHERE MASOHOPDONG = '"+ MASOHOPDONG.Text+" '";
            //MASOHOPDONG = Functions.GetFieldValues(sql);
            MADT = madoitac;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private int Run_USP_DT_DKHOPDONG()
        {
            SqlCommand cmd = new SqlCommand("USP_DT_DKHOPDONG", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu

            cmd.Parameters.Add("@MASOHOPDONG", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@NGAYLAP", SqlDbType.DateTime);
            cmd.Parameters.Add("@THOIGIANHIEULUC", SqlDbType.DateTime);
            cmd.Parameters.Add("@TAIKHOANNGANHANG", SqlDbType.VarChar,20);
           // cmd.Parameters.Add("@PHIHOAHONG", SqlDbType.Float);
            cmd.Parameters.Add("@MADT", SqlDbType.VarChar, 10);
            //cmd.Parameters.Add("@MANV", SqlDbType.NVarChar, 50);
            //cmd.Parameters.Add("@TINHTRANGDUYET", SqlDbType.Int);
            
            
            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@MASOHOPDONG"].Value = MASOHOPDONG.Text;
            cmd.Parameters["@NGAYLAP"].Value = NGAYLAP.Text;
            cmd.Parameters["@THOIGIANHIEULUC"].Value = THOIGIANHIEULUC.Text;
            cmd.Parameters["@TAIKHOANNGANHANG"].Value = TAIKHOANNGANHANG.Text;
            //cmd.Parameters["@PHIHOAHONG"].Value = float.Parse(PHH.Text);
            cmd.Parameters["@MADT"].Value = MADT;
            //cmd.Parameters["@MANV"].Value = NULL;
            //cmd.Parameters["@TINHTRANGDUYET"].Value = Int32.Parse(TINHTRANGDUYET.Text);

          
            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            string sql = "SELECT COUNT(*) FROM HOPDONG";
            int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
            rows_number++;
            try
            {
                int status = Run_USP_DT_DKHOPDONG();
                if (status == 1)
                {

                    MessageBox.Show("Thêm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LAPHOPDONG_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm đơn hàng thất bại, mã lỗi: " + ex.Message);
            }


        }
        
        private void LAPHOPDONG_Load(object sender, EventArgs e)
        {
            //
            string sql = "Select * " + " FROM HOPDONG WHERE MADT = '" + MADT +"'";
            tbl_HOPDONG = Functions.GetDataToTable(sql);
            dataGridViewLHD.DataSource = tbl_HOPDONG;
            //set font
            //dataGridViewLHD.Font = new Font("Time New Roman", 13);
            /*dataGridViewLHD.Columns[0].HeaderText = "Mã số hợp đồng";
            dataGridViewLHD.Columns[1].HeaderText = "Ngày lập";
            dataGridViewLHD.Columns[2].HeaderText = "Ngày kết thúc";
            dataGridViewLHD.Columns[3].HeaderText = "Số tài khoản";
            dataGridViewLHD.Columns[4].HeaderText = "Mã số thuế";
            dataGridViewLHD.Columns[8].HeaderText = "Tình trạng duyệt";
            //set width
            dataGridViewLHD.Columns[0].Width = 100;
            dataGridViewLHD.Columns[1].Width = 110;
            dataGridViewLHD.Columns[2].Width = 110;
            dataGridViewLHD.Columns[3].Width = 180;
            dataGridViewLHD.Columns[4].Width = 110;
            dataGridViewLHD.Columns[8].Width = 100;*/
            // cho nguoi dung them du lieu truc tiep
            dataGridViewLHD.AllowUserToAddRows = false;
            dataGridViewLHD.EditMode = DataGridViewEditMode.EditProgrammatically;
            
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewLHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
