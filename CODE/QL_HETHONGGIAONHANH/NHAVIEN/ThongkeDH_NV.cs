using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace QL_HETHONGGIAONHANH
{
    public partial class ThongkeDH_NV : Form
    {
        Thread t;
        DataTable table_DH;
        string ID;
        public ThongkeDH_NV()
        {
            InitializeComponent();
        }

        private void ThongkeDH_NV_Load(object sender, EventArgs e)
        {
            Functions.Connect(Functions.get_ConnectString());
            string sql = "SELECT * FROM DONHANG";
            table_DH = Functions.GetDataToTable(sql);
            dataGridView_thongkeDH.DataSource = table_DH;

            // set Font cho tên cột
            dataGridView_thongkeDH.Font = new Font("Time New Roman", 13);
            dataGridView_thongkeDH.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView_thongkeDH.Columns[1].HeaderText = "Ngày tạo đơn";
            dataGridView_thongkeDH.Columns[2].HeaderText = "Hình thức thanh toán";
            dataGridView_thongkeDH.Columns[3].HeaderText = "Địa chỉ giao";
            dataGridView_thongkeDH.Columns[4].HeaderText = "Phí sản phẩm";
            dataGridView_thongkeDH.Columns[5].HeaderText = "Phí vận chuyển";
            dataGridView_thongkeDH.Columns[6].HeaderText = "Tổng tiền";
            dataGridView_thongkeDH.Columns[7].HeaderText = "Tình trạng đơn hàng";
            dataGridView_thongkeDH.Columns[8].HeaderText = "Ngày giao đơn";
            dataGridView_thongkeDH.Columns[9].HeaderText = "Mã khách hàng";
            dataGridView_thongkeDH.Columns[10].HeaderText = "Mã tìa xế";




            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_thongkeDH.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_thongkeDH.Columns[0].Width = 100;
            dataGridView_thongkeDH.Columns[1].Width = 100;
            dataGridView_thongkeDH.Columns[2].Width = 100;
            dataGridView_thongkeDH.Columns[3].Width = 100;
            dataGridView_thongkeDH.Columns[4].Width = 100;
            dataGridView_thongkeDH.Columns[5].Width = 100;
            dataGridView_thongkeDH.Columns[6].Width = 100;
            dataGridView_thongkeDH.Columns[7].Width = 100;
            dataGridView_thongkeDH.Columns[8].Width = 100;
            dataGridView_thongkeDH.Columns[9].Width = 100;
            dataGridView_thongkeDH.Columns[10].Width = 100;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_thongkeDH.AllowUserToAddRows = false;
            dataGridView_thongkeDH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void btn_timkiem_ThemDH_Click(object sender, EventArgs e)
        {
            if (textBox_TimKiemMADT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn ngày  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "USP_NV_THONGKEDH'" + textBox_TimKiemMADT.Text.Trim() + "'";
            table_DH = Functions.GetDataToTable(sql);
            dataGridView_thongkeDH.DataSource = table_DH;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_thongkeDH.AllowUserToAddRows = false;
            dataGridView_thongkeDH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dataGridView_thongkeDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            textBox_MADH.Text = dataGridView_thongkeDH.Rows[numrow].Cells[0].Value.ToString();
            dTP_ngaylap.Text = dataGridView_thongkeDH.Rows[numrow].Cells[1].Value.ToString();
            textBox_HTTT.Text = dataGridView_thongkeDH.Rows[numrow].Cells[2].Value.ToString();
            textBox_DIACHIGIAO.Text = dataGridView_thongkeDH.Rows[numrow].Cells[3].Value.ToString();
            textBox_PHISP.Text = dataGridView_thongkeDH.Rows[numrow].Cells[4].Value.ToString();
            textBox_PHIVC.Text = dataGridView_thongkeDH.Rows[numrow].Cells[5].Value.ToString();
            textBox_TONGTIEN.Text = dataGridView_thongkeDH.Rows[numrow].Cells[6].Value.ToString();
            textBox_TINHTRANG.Text = dataGridView_thongkeDH.Rows[numrow].Cells[7].Value.ToString();
            dTP_ngaygiao.Text = dataGridView_thongkeDH.Rows[numrow].Cells[8].Value.ToString();
            textBox_MAKH.Text = dataGridView_thongkeDH.Rows[numrow].Cells[9].Value.ToString();
            textBox_TAIXE.Text = dataGridView_thongkeDH.Rows[numrow].Cells[10].Value.ToString();

        }

        private void btn_huytimkiem_ThemDH_Click(object sender, EventArgs e)
        {
            textBox_TimKiemMADT.Text = "";
            dataGridView_thongkeDH.DataSource = table_DH;
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            if (textBox_TimKiemMADT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn ngày  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "USP_NV_THONGKEDOANHTHU'" + textBox_TimKiemMADT.Text.Trim() + "'";
            table_DH = Functions.GetDataToTable(sql);
            dataGridView_thongkeDH.DataSource = table_DH;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_thongkeDH.AllowUserToAddRows = false;
            dataGridView_thongkeDH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        public void open_FormMain_NV(object obj)
        {
            Application.Run(new FormMain_NV());
        }

        private void btn_quaylai_thongkeKH_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormMain_NV);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

        }

        private void textBox_TimKiemMADT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

