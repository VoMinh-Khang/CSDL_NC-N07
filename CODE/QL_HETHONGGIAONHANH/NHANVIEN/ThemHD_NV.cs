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

namespace QL_HETHONGGIAONHANH1
{
    public partial class ThemHD_NV : Form
    {
        DataTable tbl_SP;
        DataTable tbl_SP2;
        string MANV;
        //Form_Loading form_loading = new Form_Loading();

        public ThemHD_NV(string cmnd)
        {
            InitializeComponent();
            string sql = "SELECT MANV FROM NHANVIEN WHERE ID = '" + cmnd + "'";
            //MANV = Functions.GetFieldValues(sql);
        }

        private void Load_Data()
        {
            //string sql = "SELECT MASOHOPDONG, NGAYLAP, THOIGIANHIEULUC, TAIKHOANNGANHANG, PHIHOAHONG, MADT, MASOTHUE, MANV, TINHTRANGDUYET " +
            //   "FROM HOPDONG";
            //tbl_SP = Functions.GetDataToTable(sql);
            //dGV_HD_ThemHD.DataSource = tbl_SP;

            // set Font cho tên cột
            dGV_HD_ThemHD.Font = new Font("Time New Roman", 13);
            dGV_HD_ThemHD.Columns[0].HeaderText = "Mã số hợp đồng";
            dGV_HD_ThemHD.Columns[1].HeaderText = "Ngày lập";
            dGV_HD_ThemHD.Columns[2].HeaderText = "Thời gian hiệu lực";
            dGV_HD_ThemHD.Columns[3].HeaderText = "Tài khoản ngân hàng";
            dGV_HD_ThemHD.Columns[4].HeaderText = "Phí hoa hồng";
            dGV_HD_ThemHD.Columns[5].HeaderText = "Mã đối tác";
            dGV_HD_ThemHD.Columns[6].HeaderText = "Mã số thuế";
            dGV_HD_ThemHD.Columns[7].HeaderText = "Mã nhân viên";
            dGV_HD_ThemHD.Columns[8].HeaderText = "Tình trạng duyệt";

            // set Font cho dữ liệu hiển thị trong cột
            dGV_HD_ThemHD.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dGV_HD_ThemHD.Columns[0].Width = 0;
            dGV_HD_ThemHD.Columns[1].Width = 200;
            dGV_HD_ThemHD.Columns[2].Width = 200;
            dGV_HD_ThemHD.Columns[3].Width = 200;
            dGV_HD_ThemHD.Columns[4].Width = 200;
            dGV_HD_ThemHD.Columns[5].Width = 200;
            dGV_HD_ThemHD.Columns[6].Width = 0;
            dGV_HD_ThemHD.Columns[7].Width = 200;
            dGV_HD_ThemHD.Columns[8].Width = 200;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dGV_HD_ThemHD.AllowUserToAddRows = false;
            dGV_HD_ThemHD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btn_tieptuc_ThemHD_NV_Click(object sender, EventArgs e)
        {
            if (txtBox_tenHD_ThemHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn hợp đồng nào !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ThongTinTT_NV thongTinTT_NV = new ThongTinTT_NV(
                dGV_HD_ThemHD.CurrentRow.Cells["MASOHOPDONG"].Value.ToString(),
                dGV_HD_ThemHD.CurrentRow.Cells["MADT"].Value.ToString(),
                txtBox_giamoi_ThemDH.Text.Trim().ToString(),
                dGV_HD_ThemHD.CurrentRow.Cells["TINHTRANGDUYET"].Value.ToString(),
                MANV);
            thongTinTT_NV.StartPosition = FormStartPosition.CenterScreen;
            thongTinTT_NV.Show();
        }

        private void dGV_HD_ThemHD_Click(object sender, EventArgs e)
        {
            //Nếu không có dữ liệu
            if (tbl_SP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        //private void ThemHD_NV_Load(object sender, EventArgs e)
        //{
        //    Thread t = new Thread(() =>
        //   {
        //        form_loading.StartPosition = FormStartPosition.CenterParent;
        //        form_loading.ShowDialog();
         //   });

            // show form loading         
        //    t.Start();

        //    Load_Data();

        //    form_loading.Close_Form();
       // }

        private void btn_timkiem_ThemDH_Click(object sender, EventArgs e)
        {
            if (txtBox_timkiem_ThemDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập từ khóa vào ô tìm kiếm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tukhoa = txtBox_timkiem_ThemDH.Text.Trim();
            string sql = "Hđ_NV_TimKiemHD '" + tukhoa + "'";
            tbl_SP2 = Functions.GetDataToTable(sql);
            dGV_HD_ThemHD.DataSource = tbl_SP2;
        }

        private void btn_huytimkiem_ThemHD_Click(object sender, EventArgs e)
        {
            txtBox_timkiem_ThemDH.Text = "";
            dGV_HD_ThemHD.DataSource = tbl_SP;
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
    }
}    

