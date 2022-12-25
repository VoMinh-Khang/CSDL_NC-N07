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
    public partial class QUANLYDONHANG : Form
    {
        DataTable tbl_DONHANG;
        public QUANLYDONHANG()
        {
            InitializeComponent();
        }

        private void QUANLYDONHANG_Load(object sender, EventArgs e)
        {
            //Functions.Connect(Functions.get_ConnectString());
            string sql = "Select * " + " FROM DONHANG" ;
            tbl_DONHANG = Functions.GetDataToTable(sql);
            dataGridViewCNTTDH.DataSource = tbl_DONHANG;
            //set font
            //dataGridViewCNTTDH.Font = new Font("Time New Roman", 13);
            dataGridViewCNTTDH.Columns[0].HeaderText = "Mã đơn";
            
            //set width
            dataGridViewCNTTDH.Columns[0].Width = 100;
            dataGridViewCNTTDH.Columns[3].Width = 350;
            dataGridViewCNTTDH.Columns[7].Width = 200;
            //ko cho nguoi dung them du lieu truc tiep
            dataGridViewCNTTDH.AllowUserToAddRows = false;
            dataGridViewCNTTDH.EditMode = DataGridViewEditMode.EditProgrammatically;
            
            //doi tac xem don hang da nhan
            string query = string.Format("Select *  FROM DONHANG WHERE TINHTRANG =N'Đang chuẩn bị'");
            tbl_DONHANG = Functions.GetDataToTable(query);
            dataGridViewDHDN.DataSource = tbl_DONHANG;

            
        }

        private void dataGridViewDHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        private int Run_SP_DTCAPNHATDH()
        {
            SqlCommand cmd = new SqlCommand("USP_DOITACAPNHATDONHANG", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu

            cmd.Parameters.Add("@MADON", SqlDbType.NVarChar, 80);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@MADON"].Value = txt_MADON.Text;
            //cmd.Parameters["@MIEUTAMON"].Value = txtmieuta.Text;
            //cmd.Parameters["@GIA"].Value = txtgia.Text;
            //cmd.Parameters["@TINHTRANGMONAN"].Value = txttinhtrang.Text;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT (*)  FROM DONHANG";
            int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
            rows_number++;
            try
            {
                int status = Run_SP_DTCAPNHATDH();
                if (status == 1)
                {

                    MessageBox.Show("Thêm cập nhật đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QUANLYDONHANG_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật đơn hàng thất bại, mã lỗi: " + ex.Message);
            }

        }
    }
}
