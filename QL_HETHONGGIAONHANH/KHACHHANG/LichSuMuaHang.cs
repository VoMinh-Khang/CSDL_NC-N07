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
    public partial class LichSuMuaHang : Form
    {
        string MAKH;
        DataTable tbl_LSMH;
        
        public LichSuMuaHang()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            //string sql = "Sp_KH_LayThongTinDH '" + MAKH + "'";
            //tbl_LSMH = Functions.GetDataToTable(sql);
            //dataGridView1.DataSource = tbl_LSMH;

            // set Font cho tên cột
            dataGridView1.Font = new Font("Time New Roman", 13);
            dataGridView1.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView1.Columns[1].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[2].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[3].HeaderText = "Tên người nhận";
            dataGridView1.Columns[4].HeaderText = "Địa chỉ người nhận";
            dataGridView1.Columns[5].HeaderText = "SĐT người nhận";
            dataGridView1.Columns[6].HeaderText = "Phí vận chuyển";
            dataGridView1.Columns[7].HeaderText = "Hình thức thanh toán";
            dataGridView1.Columns[8].HeaderText = "Ngày muốn giao";
            dataGridView1.Columns[9].HeaderText = "Ngày lập";
            dataGridView1.Columns[10].HeaderText = "Tình trạng";
            dataGridView1.Columns[11].HeaderText = "Tổng tiền";

            // set Font cho dữ liệu hiển thị trong cột
            dataGridView1.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 0;
            dataGridView1.Columns[2].Width = 0;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 200;
            dataGridView1.Columns[6].Width = 200;
            dataGridView1.Columns[7].Width = 0;
            dataGridView1.Columns[8].Width = 200;
            dataGridView1.Columns[9].Width = 200;
            dataGridView1.Columns[10].Width = 200;
            dataGridView1.Columns[11].Width = 200;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu không có dữ liệu
            if (tbl_LSMH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtBox_MaDH.Text = dataGridView1.CurrentRow.Cells["MADON"].Value.ToString();
            txtBox_TongTien.Text = dataGridView1.CurrentRow.Cells["TONGTIEN"].Value.ToString();
            txtBox_TinhTrang.Text = dataGridView1.CurrentRow.Cells["TINHTRANG"].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            if (txtBox_MaDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn đơn hàng nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // ct_DonHang = new CT_DonHang(txtBox_MaDH.Text.Trim().ToString());
            //ct_DonHang.StartPosition = FormStartPosition.CenterScreen;
            //ct_DonHang.Show();
        }
    }
}
