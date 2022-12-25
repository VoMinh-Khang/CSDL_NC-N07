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

    public partial class DuyetHD_NV : Form
    {
        Thread t;
        DataTable table_HD;
        public DuyetHD_NV()
        {
            InitializeComponent();
        }

        private void DuyetHD_NV_Load(object sender, EventArgs e)
        {
            Functions.Connect(Functions.get_ConnectString());
            string sql = "SELECT * FROM HOPDONG";
            table_HD = Functions.GetDataToTable(sql);
            dataGridView_DuyetHD.DataSource = table_HD;

            // set Font cho tên cột
            dataGridView_DuyetHD.Font = new Font("Time New Roman", 13);
            dataGridView_DuyetHD.Columns[0].HeaderText = "Mã số hợp đồng";
            dataGridView_DuyetHD.Columns[1].HeaderText = "Ngày lập";
            dataGridView_DuyetHD.Columns[2].HeaderText = "Thời gian hiệu lực";
            dataGridView_DuyetHD.Columns[3].HeaderText = "Tài khoản ngân hàng";
            dataGridView_DuyetHD.Columns[4].HeaderText = "Phí hoa hồng";
            dataGridView_DuyetHD.Columns[5].HeaderText = "Mã đối tác";
            dataGridView_DuyetHD.Columns[6].HeaderText = "Mã số thuế";
            dataGridView_DuyetHD.Columns[7].HeaderText = "Mã nhân viên";
            dataGridView_DuyetHD.Columns[8].HeaderText = "Tình trạng duyệt";

            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_DuyetHD.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_DuyetHD.Columns[0].Width = 200;
            dataGridView_DuyetHD.Columns[1].Width = 200;
            dataGridView_DuyetHD.Columns[2].Width = 200;
            dataGridView_DuyetHD.Columns[3].Width = 200;
            dataGridView_DuyetHD.Columns[4].Width = 200;
            dataGridView_DuyetHD.Columns[5].Width = 200;
            dataGridView_DuyetHD.Columns[6].Width = 200;
            dataGridView_DuyetHD.Columns[7].Width = 200;
            dataGridView_DuyetHD.Columns[8].Width = 200;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_DuyetHD.AllowUserToAddRows = false;
            dataGridView_DuyetHD.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btn_timkiem_DuyetDH_Click(object sender, EventArgs e)
        {
            if (textBox_TimKiemMAHD.Text.Trim().Length == 0 && textBox_TimKiemMADT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập từ khóa vào ô tìm kiếm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string keyword1 = textBox_TimKiemMAHD.Text.Trim();
            string keyword2 = textBox_TimKiemMADT.Text.Trim();
            string sql = "Select * From HOPDONG Where MASOHOPDONG like '%" + keyword1 + "%' And MADT like '%" + keyword2 + "%'";
            table_HD = Functions.GetDataToTable(sql);
            dataGridView_DuyetHD.DataSource = table_HD;

        }

        private void dataGridView_DuyetHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            textBox_MAHD.Text = dataGridView_DuyetHD.Rows[numrow].Cells[0].Value.ToString();
            textBox_NgayLap.Text = dataGridView_DuyetHD.Rows[numrow].Cells[1].Value.ToString();
            textBox_NgayHet.Text = dataGridView_DuyetHD.Rows[numrow].Cells[2].Value.ToString();
            textBox_TKNH.Text = dataGridView_DuyetHD.Rows[numrow].Cells[3].Value.ToString();
            textBox_PhiHoaHong.Text = dataGridView_DuyetHD.Rows[numrow].Cells[4].Value.ToString();
            textBox_MADT.Text = dataGridView_DuyetHD.Rows[numrow].Cells[5].Value.ToString();
            textBox_MASOTHUE.Text = dataGridView_DuyetHD.Rows[numrow].Cells[6].Value.ToString();
            textBox_MANV.Text = dataGridView_DuyetHD.Rows[numrow].Cells[7].Value.ToString();
            textBox_TinhTrangDuyet.Text = dataGridView_DuyetHD.Rows[numrow].Cells[8].Value.ToString();

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

        private void btn_huytimkiem_DuyetDH_Click(object sender, EventArgs e)
        {
            textBox_TimKiemMAHD.Text = "";
            dataGridView_DuyetHD.DataSource = table_HD;

        }

        private void textBox_TimKiemMAHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DuyetDH_Click(object sender, EventArgs e)
        {
            if (textBox_TinhTrangDuyet.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập từ khóa vào ô duyệt hợp đồng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "USP_NV_DUYETHOPDONG'" + textBox_TimKiemMADT.Text.Trim() + "'";
            table_HD = Functions.GetDataToTable(sql);
            dataGridView_DuyetHD.DataSource = table_HD;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_DuyetHD.AllowUserToAddRows = false;
            dataGridView_DuyetHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void textBox_TinhTrangDuyet_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

