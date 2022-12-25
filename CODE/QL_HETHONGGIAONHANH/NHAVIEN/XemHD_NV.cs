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
    public partial class XemHD_NV : Form
    {
        DataTable table_HD;
        Thread t;
        string ID;
        public XemHD_NV()
        {
            InitializeComponent();
        }

        private void btn_tieptuc_XemHD_NV_Click(object sender, EventArgs e)
        {
            if (textBox_MAHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn hợp đồng nào !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                /*textBox_MAHD.Text = table_HD.CurrentRow.Cells["MAHD"].Value.ToString();
                textBox_MaCH.Text = dsCuaHang.CurrentRow.Cells["MACUAHANG"].Value.ToString();
                txtBox_TenMon.Text = thucdon.CurrentRow.Cells["TENMON"].Value.ToString();
                textBox_MieuTa.Text = thucdon.CurrentRow.Cells["MIEUTAMON"].Value.ToString();
                txtBox_GiaMon.Text = thucdon.CurrentRow.Cells["GIA"].Value.ToString();
                textBox_TinhTrang.Text = thucdon.CurrentRow.Cells["TINHTRANGMONAN"].Value.ToString();
                textBox_LuongTon.Text = thucdon.CurrentRow.Cells["SOLUONGTON"].Value.ToString();*/
            }    
            //    ThemHD_NV thongTinTT_NV = new ThemHD_NV(
            //    dataGridViewHD.CurrentRow.Cells["MASOHOPDONG"].Value.ToString(),
            //    dataGridViewHD.CurrentRow.Cells["MADT"].Value.ToString(),
            //    txtBox_giamoi_ThemDH.Text.Trim().ToString(),
            //    dataGridViewHD.CurrentRow.Cells["TINHTRANGDUYET"].Value.ToString(),
            //    MANV);
            //thongTinTT_NV.StartPosition = FormStartPosition.CenterScreen;
            //thongTinTT_NV.Show();
        }

        /*private void dataGridViewHD_Click(object sender, EventArgs e)
        {
            //Nếu không có dữ liệu
            if (NHANVIEN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }*/

        private void btn_timkiem_ThemDH_Click(object sender, EventArgs e)
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
            dataGridViewHD.DataSource = table_HD;
        }

        private void btn_huytimkiem_ThemHD_Click(object sender, EventArgs e)
        {
            textBox_TimKiemMAHD.Text = "";
            dataGridViewHD.DataSource = table_HD;
        }

        private void InitializeComponents()
        {
            this.SuspendLayout();
            // 
            // ThemHD_NV
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ThemHD_NV";
            this.Load += new System.EventHandler(this.ThemHD_NV_Load_1);
            this.ResumeLayout(false);

        }

        private void ThemHD_NV_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_timkiem_ThemDH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu không có dữ liệu
            //if (NHANVIEN.Rows.Count == 0)
            //{
                //MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //return;
            //}
        }

        private void txtBox_tenHD_ThemHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void XemHD_NV_Load_1(object sender, EventArgs e)
        {
            Functions.Connect(Functions.get_ConnectString());
            string sql = "SELECT * FROM HOPDONG";
            table_HD = Functions.GetDataToTable(sql);
            dataGridViewHD.DataSource = table_HD;

            // set Font cho tên cột
            dataGridViewHD.Font = new Font("Time New Roman", 13);
            dataGridViewHD.Columns[0].HeaderText = "Mã số hợp đồng";
            dataGridViewHD.Columns[1].HeaderText = "Ngày lập";
            dataGridViewHD.Columns[2].HeaderText = "Thời gian hiệu lực";
            dataGridViewHD.Columns[3].HeaderText = "Tài khoản ngân hàng";
            dataGridViewHD.Columns[4].HeaderText = "Phí hoa hồng";
            dataGridViewHD.Columns[5].HeaderText = "Mã đối tác";
            dataGridViewHD.Columns[6].HeaderText = "Mã số thuế";
            dataGridViewHD.Columns[7].HeaderText = "Mã nhân viên";
            dataGridViewHD.Columns[8].HeaderText = "Tình trạng duyệt";

            // set Font cho dữ liệu hiển thị trong cột
            dataGridViewHD.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridViewHD.Columns[0].Width = 200;
            dataGridViewHD.Columns[1].Width = 200;
            dataGridViewHD.Columns[2].Width = 200;
            dataGridViewHD.Columns[3].Width = 200;
            dataGridViewHD.Columns[4].Width = 200;
            dataGridViewHD.Columns[5].Width = 200;
            dataGridViewHD.Columns[6].Width = 200;
            dataGridViewHD.Columns[7].Width = 200;
            dataGridViewHD.Columns[8].Width = 200;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridViewHD.AllowUserToAddRows = false;
            dataGridViewHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridViewHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            textBox_MAHD.Text = dataGridViewHD.Rows[numrow].Cells[0].Value.ToString();
            textBox_NgayLap.Text = dataGridViewHD.Rows[numrow].Cells[1].Value.ToString();
            textBox_NgayHet.Text = dataGridViewHD.Rows[numrow].Cells[2].Value.ToString();
            textBox_TKNH.Text = dataGridViewHD.Rows[numrow].Cells[3].Value.ToString();
            textBox_PhiHoaHong.Text = dataGridViewHD.Rows[numrow].Cells[4].Value.ToString();
            textBox_MADT.Text = dataGridViewHD.Rows[numrow].Cells[5].Value.ToString();
            textBox_MASOTHUE.Text = dataGridViewHD.Rows[numrow].Cells[6].Value.ToString();
            textBox_MANV.Text = dataGridViewHD.Rows[numrow].Cells[7].Value.ToString();
            textBox_TinhTrangDuyet.Text = dataGridViewHD.Rows[numrow].Cells[8].Value.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

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

