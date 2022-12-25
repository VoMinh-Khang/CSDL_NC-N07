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
    public partial class ThongKeReport_NV : Form
    {
        DataTable table_report;
        Thread t;
        public ThongKeReport_NV()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ThongKeReport_NV_Load(object sender, EventArgs e)
        {
            Functions.Connect(Functions.get_ConnectString());
            string sql = "SELECT * FROM HOPDONG";
            table_report = Functions.GetDataToTable(sql);
            dataGridView_ThongKeReport.DataSource = table_report;

            // set Font cho tên cột
            dataGridView_ThongKeReport.Font = new Font("Time New Roman", 13);
            dataGridView_ThongKeReport.Columns[0].HeaderText = "Mã số hợp đồng";
            dataGridView_ThongKeReport.Columns[1].HeaderText = "Ngày lập";
            dataGridView_ThongKeReport.Columns[2].HeaderText = "Thời gian hiệu lực";
            dataGridView_ThongKeReport.Columns[3].HeaderText = "Tài khoản ngân hàng";


            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_ThongKeReport.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_ThongKeReport.Columns[0].Width = 200;
            dataGridView_ThongKeReport.Columns[1].Width = 200;
            dataGridView_ThongKeReport.Columns[2].Width = 200;
            dataGridView_ThongKeReport.Columns[3].Width = 200;



            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_ThongKeReport.AllowUserToAddRows = false;
            dataGridView_ThongKeReport.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dataGridView_ThongKeReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            textBox_TENMON.Text = dataGridView_ThongKeReport.Rows[numrow].Cells[0].Value.ToString();
            textBox_MAKH.Text = dataGridView_ThongKeReport.Rows[numrow].Cells[1].Value.ToString();
            textBox_DANHGIA.Text = dataGridView_ThongKeReport.Rows[numrow].Cells[2].Value.ToString();
            textBox_BINHLUAN.Text = dataGridView_ThongKeReport.Rows[numrow].Cells[3].Value.ToString();

        }

        private void btn_thongke_Report_Click(object sender, EventArgs e)
        {
            if (textBox_ThongKeReport.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập từ khóa vào ô duyệt hợp đồng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "USP_THONGKE_REPORT'" + textBox_ThongKeReport.Text.Trim() + "'";
            table_report = Functions.GetDataToTable(sql);
            dataGridView_ThongKeReport.DataSource = table_report;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_ThongKeReport.AllowUserToAddRows = false;
            dataGridView_ThongKeReport.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btn_huythongke_Report_Click(object sender, EventArgs e)
        {
            textBox_ThongKeReport.Text = "";
            dataGridView_ThongKeReport.DataSource = table_report;

        }

        public void open_FormMain_NV(object obj)
        {
            Application.Run(new FormMain_NV());
        }

        private void btn_quaylai_XemHD_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormMain_NV);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }
    }
}
