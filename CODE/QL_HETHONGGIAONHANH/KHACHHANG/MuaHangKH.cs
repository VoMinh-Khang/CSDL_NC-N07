using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QL_HETHONGGIAONHANH
{

    public partial class MuaHangKH : Form
    {
        public GioHangKH gh;
        Thread t;
        //DataTable table_MonAn;
        DataTable table_TimMonAn;
        DataTable table_DSDoiTac;
        DataTable table_CuaHang;
        DataTable table_ThucDon;
        string MAKHACH;
        string ID;
        //InitializeComponent();

        public MuaHangKH(string id)
        {
            InitializeComponent();
            ID = id;

            string sql = "SELECT MAKHACH FROM KHACHHANG WHERE TAIKHOAN = '" + id + "'";
            MAKHACH = Functions.GetFieldValues(sql);
            gh = new GioHangKH(MAKHACH);
        }

        private void MuaHangKH_Load(object sender, EventArgs e)
        {
            Load_Data_DSDoiTac();
        }

        private void btn_TimMon_Click(object sender, EventArgs e)
        {
            if (txtBox_TimMon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập từ khóa vào ô tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string keyword = txtBox_TimMon.Text.Trim();
            string sql = "USP_KH_TIMMONAN N'" + keyword + "'";
            table_TimMonAn = Functions.GetDataToTable(sql);
            dsMonAn.DataSource = table_TimMonAn;
            dsMonAn.Font = new Font("Time New Roman", 13);
            dsMonAn.Columns[0].HeaderText = "Mã đối tác";

            dsMonAn.Columns[1].HeaderText = "Mã cửa hàng";

            dsMonAn.Columns[2].HeaderText = "Tên món";

            dsMonAn.Columns[3].HeaderText = "Gía";
            dsMonAn.Columns[4].HeaderText = "Số lượng tồn";
            dsMonAn.Columns[5].HeaderText = "Miêu tả món";
            dsMonAn.Columns[6].HeaderText = "Tình trạng";

            // set Font cho dữ liệu hiển thị trong cột
            dsMonAn.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // set kích thước cột
            dsMonAn.Columns[0].Width = 150;
            dsMonAn.Columns[1].Width = 150;
            dsMonAn.Columns[2].Width = 200;
            dsMonAn.Columns[3].Width = 115;
            dsMonAn.Columns[4].Width = 100;
            dsMonAn.Columns[5].Width = 180;
            dsMonAn.Columns[6].Width = 150;
            //Không cho người dùng thêm dữ liệu trực tiếp
            dsMonAn.AllowUserToAddRows = false;
            dsMonAn.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void Load_Data_DSDoiTac()
        {
            string sql = "USP_KH_XEMDSDOITAC";

            table_DSDoiTac = Functions.GetDataToTable(sql);
            dsDoiTac.DataSource = table_DSDoiTac;
            // set Font cho tên cột
            dsDoiTac.Font = new Font("Time New Roman", 13);
            dsDoiTac.Columns[0].HeaderText = "Mã đối tác";
            dsDoiTac.Columns[1].HeaderText = "Tên quán";
            dsDoiTac.Columns[2].HeaderText = "Thành phố";
            dsDoiTac.Columns[3].HeaderText = "Quận";
            dsDoiTac.Columns[4].HeaderText = "Loại Ẩm Thực";
            dsDoiTac.Columns[5].HeaderText = "Điện Thoại";
            dsDoiTac.Columns[6].HeaderText = "Email";
            dsDoiTac.Columns[7].HeaderText = "Số lượng cửa hàng";
            dsDoiTac.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            // set kích thước cột
            dsDoiTac.Columns[0].Width = 100;
            dsDoiTac.Columns[1].Width = 200;
            dsDoiTac.Columns[2].Width = 200;
            dsDoiTac.Columns[3].Width = 100;
            dsDoiTac.Columns[4].Width = 200;
            dsDoiTac.Columns[5].Width = 200;
            dsDoiTac.Columns[6].Width = 200;
            dsDoiTac.Columns[7].Width = 150;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dsDoiTac.AllowUserToAddRows = false;
            dsDoiTac.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dsDoiTac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //load ds cua hang cua doi tac
            string MADT = dsDoiTac.CurrentRow.Cells["MADT"].Value.ToString(); ;
            string sql = "USP_KH_XEMDSCUAHANGCUADT '" + MADT + "'";
            table_CuaHang = Functions.GetDataToTable(sql);


            //Nếu không có dữ liệu
            if (table_CuaHang.Rows.Count == 0)
            {
                MessageBox.Show("Đối tác này chưa có cửa hàng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                dsCuaHang.DataSource = table_CuaHang;
                dsCuaHang.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dsCuaHang.Columns[0].HeaderText = "Mã đối tác";
                dsCuaHang.Columns[1].HeaderText = "Mã cửa hàng";
                dsCuaHang.Columns[2].HeaderText = "Tên Cửa Hàng";
                dsCuaHang.Columns[3].HeaderText = "Địa chỉ";
                dsCuaHang.Columns[4].HeaderText = "Thời gian hoạt động";
                dsCuaHang.Columns[5].HeaderText = "Tình Trạng Cửa Hàng";

                // set kích thước cột
                dsCuaHang.Columns[0].Width = 150;
                dsCuaHang.Columns[1].Width = 150;
                dsCuaHang.Columns[2].Width = 200;
                dsCuaHang.Columns[3].Width = 200;
                dsCuaHang.Columns[4].Width = 200;
                dsCuaHang.Columns[5].Width = 200;
                
                //Không cho người dùng thêm dữ liệu trực tiếp
                dsCuaHang.AllowUserToAddRows = false;
                dsCuaHang.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }

        private void dsCuaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //load THUCDON CUA CUAHANG CUA DOI TAC
            string MADT = dsCuaHang.CurrentRow.Cells["MADT"].Value.ToString();
            string MACH = dsCuaHang.CurrentRow.Cells["MACUAHANG"].Value.ToString();
            string sql = "USP_KH_XEMTHUCDON '" + MADT + "','" + MACH + "'";

            table_ThucDon = Functions.GetDataToTable(sql);


            //Nếu không có dữ liệu
            if (table_ThucDon.Rows.Count == 0)
            {
                string sqlch = "Select TENCUAHANG FROM CUAHANG WHERE MACUAHANG = '" + MACH + "'";
                MessageBox.Show("Cửa hàng " + Functions.GetFieldValues(sqlch) + " này chưa có thực đơn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                thucdon.DataSource = table_ThucDon;
                thucdon.Columns[0].HeaderText = "Tên món";
                thucdon.Columns[1].HeaderText = "Gía";
                thucdon.Columns[2].HeaderText = "Số lượng tồn";
                thucdon.Columns[3].HeaderText = "Miêu Tả";
                thucdon.Columns[4].HeaderText = "Tình Trạng Món";

                thucdon.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                // set kích thước cột
                thucdon.Columns[0].Width = 200;
                thucdon.Columns[1].Width = 100;
                thucdon.Columns[2].Width = 150;
                thucdon.Columns[3].Width = 200;
                thucdon.Columns[4].Width = 200;

                //Không cho người dùng thêm dữ liệu trực tiếp
                thucdon.AllowUserToAddRows = false;
                thucdon.EditMode = DataGridViewEditMode.EditProgrammatically;
            }

        }


        private void thucdon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (table_ThucDon.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                textBox_MaDT.Text = dsCuaHang.CurrentRow.Cells["MADT"].Value.ToString();
                textBox_MaCH.Text = dsCuaHang.CurrentRow.Cells["MACUAHANG"].Value.ToString();
                txtBox_TenMon.Text = thucdon.CurrentRow.Cells["TENMON"].Value.ToString();
                textBox_MieuTa.Text = thucdon.CurrentRow.Cells["MIEUTAMON"].Value.ToString();
                txtBox_GiaMon.Text = thucdon.CurrentRow.Cells["GIA"].Value.ToString();
                textBox_TinhTrang.Text = thucdon.CurrentRow.Cells["TINHTRANGMONAN"].Value.ToString();
                textBox_LuongTon.Text = thucdon.CurrentRow.Cells["SOLUONGTON"].Value.ToString();

            }
        }


        private void btn_MuaNgay_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox_LuongTon.Text.ToString()) == 0)
            {
                MessageBox.Show("Quán đã hết món này!\nBạn hãy chọn món khác nhé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DonHangKH dh = new DonHangKH(txtBox_TenMon.Text.ToString(), txtBox_GiaMon.Text.ToString(), MAKHACH, textBox_LuongTon.Text.ToString(), textBox_MaCH.Text.ToString(), textBox_MaDT.Text.ToString());
                dh.StartPosition = FormStartPosition.CenterScreen;
                dh.Show();
            }
        }
        public void open_FormMainkh(object obj)
        {
            Application.Run(new FormMainKH(ID));
        }
        private void btn_ThemVaoGio_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox_LuongTon.Text.ToString()) == 0)
            {
                MessageBox.Show("Quán đã hết món này!\nBạn hãy chọn món khác nhé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                gh.AddNewChoice(textBox_MaDT.Text, textBox_MaCH.Text, txtBox_TenMon.Text, txtBox_GiaMon.Text, 1);
                gh.Show();
                textBox1.Text = "Đã thêm giỏ!";
            }
            
        }

        private void btn_XemDSDT_Click(object sender, EventArgs e)
        {

        }



        private void txtBox_TimMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void dsMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (table_TimMonAn.Rows.Count == 0)
            {
                MessageBox.Show("Quán hết món này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                textBox_MaCH.Text = dsMonAn.CurrentRow.Cells["MACUAHANG"].Value.ToString();
                textBox_MaDT.Text = dsMonAn.CurrentRow.Cells["MADT"].Value.ToString();
                txtBox_TenMon.Text = dsMonAn.CurrentRow.Cells["TENMON"].Value.ToString();
                textBox_MieuTa.Text = dsMonAn.CurrentRow.Cells["MIEUTAMON"].Value.ToString();
                txtBox_GiaMon.Text = dsMonAn.CurrentRow.Cells["GIA"].Value.ToString();
                textBox_TinhTrang.Text = dsMonAn.CurrentRow.Cells["TINHTRANGMONAN"].Value.ToString();
                textBox_LuongTon.Text = dsMonAn.CurrentRow.Cells["SOLUONGTON"].Value.ToString();
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            txtBox_TimMon.Text = "";
            dsMonAn.DataSource = table_TimMonAn;
        }

        private void button_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormMainkh);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}