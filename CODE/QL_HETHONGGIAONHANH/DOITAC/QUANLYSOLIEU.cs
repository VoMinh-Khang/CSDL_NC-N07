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
    public partial class QUANLYSOLIEU : Form
    {
        DataTable tbl_SOLIEU;
        DataTable tbl_DONHANG;
        string MADT;
        public QUANLYSOLIEU(string madoitac)
        {
            InitializeComponent();
            MADT = madoitac;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void QUANLYSOLIEU_Load(object sender, EventArgs e)
        {
            //
            string S = "SELECT DISTINCT DH.* FROM DONHANG DH JOIN CT_DONHANG CT_DH ON CT_DH.MADON = DH.MADON AND CT_DH.MADT = '" + MADT + "'";
            tbl_DONHANG = Functions.GetDataToTable(S);
            dataGridViewDHTN.DataSource = tbl_DONHANG;


            string sql = "SELECT * FROM PHANHOI ";
            tbl_SOLIEU = Functions.GetDataToTable(sql);
            dataGridViewPH.DataSource = tbl_SOLIEU;
        }
        //private int Run_SP_TONGDOANHTHU()
        //{
        //    SqlCommand cmd = new SqlCommand("USP_DOITAC_DOANHTHU_NGAY", Functions.Con);
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //    // set kiểu dữ liệu

        //    cmd.Parameters.Add("@NGAYLAP", SqlDbType.DateTime);
        //    cmd.Parameters.Add("@MADT", SqlDbType.VarChar, 10);
        //    var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
        //    returnParameter.Direction = ParameterDirection.ReturnValue;

        //    //set giá trị
        //    cmd.Parameters["@NGAYLAP"].Value = dateDHHT.Text;
        //    cmd.Parameters["@MADT"].Value = MADT;
        //    cmd.ExecuteNonQuery();

        //    return Int32.Parse(returnParameter.Value.ToString());

        //}
        private void button1_Click(object sender, EventArgs e)
        {
            if (dateDHHT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn ngày  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //xem đơn hàng theo ngày
            string sql = "SELECT DISTINCT DH.* FROM DONHANG DH JOIN CT_DONHANG CT_DH ON CT_DH.MADON = DH.MADON AND CT_DH.MADT = '" + MADT + "'WHERE DH.NGAYLAP= '" + dateDHHT.Value + "'";
            tbl_SOLIEU = Functions.GetDataToTable(sql);
            dataGridViewDHTN.DataSource = tbl_SOLIEU;

            dataGridViewDHTN.AllowUserToAddRows = false;
            dataGridViewDHTN.EditMode = DataGridViewEditMode.EditProgrammatically;
           
            // xem số lượng đơn trong ngày 
            string query = "SELECT COUNT  (distinct DH.MADON) FROM DONHANG DH JOIN CT_DONHANG CT_DH ON CT_DH.MADON = DH.MADON AND CT_DH.MADT ='" + @MADT + "'WHERE DH.NGAYLAP='" + dateDHHT.Value + "'";
            textBox1.Text = Functions.GetFieldValues(query).ToString();

            // xem doanh thu trong ngày
            //try
            //{
            //    //int status = Run_SP_TONGDOANHTHU();
            //    if (status == 1)
            //    {
            string S = "SELECT SUM (DH.TONGTIEN) FROM DONHANG DH JOIN CT_DONHANG CT ON CT.MADT='" + MADT + "'WHERE TINHTRANG = N'Đã giao' AND CT.MADON=DH.MADON AND DH.NGAYLAP='" + dateDHHT.Value + "'";
            textBox2.Text = Functions.GetFieldValues(S).ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Mã lỗi: " + ex.Message);
            //}

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}