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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QL_HETHONGGIAONHANH
{
    public partial class QUANLYDONHANG : Form
    {
        DataTable tbl_DONHANG;
        //string MADH;
        string MADT;
        string madon;
        public QUANLYDONHANG(string madt)
        {
            InitializeComponent();
            string sql = "SELECT MADON FROM HOPDONG WHERE MADON = '" + txt_MADON.Text + " '";
            MADT = madt;
        }

        private void QUANLYDONHANG_Load(object sender, EventArgs e)
        {
            //
            //string sql = "Select * " + " FROM DONHANG" ;
            string sql = "SELECT DISTINCT DH.* FROM DONHANG DH JOIN CT_DONHANG CT_DH ON CT_DH.MADON = DH.MADON AND CT_DH.MADT = '" + MADT +"'";
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
            string query = "SELECT DISTINCT DH.* FROM DONHANG DH JOIN CT_DONHANG CT_DH ON CT_DH.MADON = DH.MADON AND CT_DH.MADT ='" + MADT + "'" + string.Format("WHERE TINHTRANG = N'Đang chuẩn bị'");
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
            cmd.Parameters.Add("@MADT", SqlDbType.VarChar,10);
            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@MADON"].Value = txt_MADON.Text;
            cmd.Parameters["@MADT"].Value = MADT;
            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int status = Run_SP_DTCAPNHATDH();
                if (status == 1)
                {

                    MessageBox.Show("Cập nhật đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QUANLYDONHANG_Load(sender, e);
                }
                if (status == -2)
                {

                    MessageBox.Show("Không tồn tại tình trạng đơn hàng nào để xác nhận là đang chuẩn bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   //QUANLYDONHANG_Load(sender, e);
                }
                if (status == -1)
                {

                    MessageBox.Show("Không tồn tại đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //QUANLYDONHANG_Load(sender, e);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật đơn hàng thất bại, mã lỗi: " + ex.Message);
            }

        }
    }
}
