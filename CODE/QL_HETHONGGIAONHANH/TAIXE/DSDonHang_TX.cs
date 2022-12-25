using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HETHONGGIAONHANH
{
    public partial class DSDonHang_TX : Form
    {
        string cmnd_TX;
        DataTable tbl_DSDH;
        public DSDonHang_TX(string cmnd_TX)
        {
            InitializeComponent();
            this.cmnd_TX = cmnd_TX;
        }

       

        private void dataGridView_DSDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Load_Data()
        {
            string sql = "USP_TX_XEMDSDONHANG '" + cmnd_TX + "'";
            tbl_DSDH = Functions.GetDataToTable(sql);
            dataGridView_DSDH.DataSource = tbl_DSDH;

            //set font
            dataGridView_DSDH.Font = new Font("Time New Roman", 12);
            dataGridView_DSDH.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView_DSDH.Columns[1].HeaderText = "Ngày lập";
            dataGridView_DSDH.Columns[2].HeaderText = "Hình thức thanh toán";
            dataGridView_DSDH.Columns[3].HeaderText = "Địa chỉ giao hàng";
            dataGridView_DSDH.Columns[4].HeaderText = "Phí sản phẩm";
            dataGridView_DSDH.Columns[5].HeaderText = "Phí vận chuyển";
            dataGridView_DSDH.Columns[6].HeaderText = "Tổng tiền";
            dataGridView_DSDH.Columns[7].HeaderText = "Tình trạng";
            dataGridView_DSDH.Columns[8].HeaderText = "Ngày giao";
            dataGridView_DSDH.Columns[9].HeaderText = "Mã khách hàng";
            dataGridView_DSDH.Columns[10].HeaderText = "CMND Tài xế";

            //set width
            dataGridView_DSDH.Columns[0].Width = 100;
            dataGridView_DSDH.Columns[1].Width = 110;
            dataGridView_DSDH.Columns[2].Width = 110;
            dataGridView_DSDH.Columns[3].Width = 180;
            dataGridView_DSDH.Columns[4].Width = 110;
            dataGridView_DSDH.Columns[5].Width = 100;
            dataGridView_DSDH.Columns[6].Width = 100;
            dataGridView_DSDH.Columns[7].Width = 100;
            dataGridView_DSDH.Columns[8].Width = 100;
            dataGridView_DSDH.Columns[9].Width = 20;
            dataGridView_DSDH.Columns[10].Width = 100;



            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_DSDH.AllowUserToAddRows = false;
            dataGridView_DSDH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void DSDonHang_TX_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_DSDH_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_DSDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow;
            numRow = e.RowIndex;
            textBox1.Text = dataGridView_DSDH.Rows[numRow].Cells[0].Value.ToString();
            textBox2.Text = dataGridView_DSDH.Rows[numRow].Cells[7].Value.ToString();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox_MaDonHang(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}