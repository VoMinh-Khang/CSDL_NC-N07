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
        public QUANLYSOLIEU()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void QUANLYSOLIEU_Load(object sender, EventArgs e)
        {
            //Functions.Connect(Functions.get_ConnectString());



            string sql = "SELECT * FROM PHANHOI ";
            tbl_SOLIEU = Functions.GetDataToTable(sql);
            dataGridViewPH.DataSource = tbl_SOLIEU;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateDHHT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn ngày  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "USP_DOITAC_XEMDSDONHANG '" + dateDHHT.Value + "'";
            tbl_SOLIEU = Functions.GetDataToTable(sql);
            dataGridViewDHTN.DataSource = tbl_SOLIEU;

            dataGridViewDHTN.AllowUserToAddRows = false;
            dataGridViewDHTN.EditMode = DataGridViewEditMode.EditProgrammatically;
           

            string query = "SELECT COUNT (MADON) FROM DONHANG WHERE NGAYLAP= '"+ dateDHHT.Value + "' AND TINHTRANG = N'Đã giao'";
            textBox1.Text = Functions.GetFieldValues(query).ToString();
            

        }

    }
}