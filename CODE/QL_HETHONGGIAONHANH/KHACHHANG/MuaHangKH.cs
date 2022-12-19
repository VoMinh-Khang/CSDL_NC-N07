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
    public partial class MuaHangKH : Form
    {
            DataTable tbl_SP;
            DataTable tbl_SP2;
            string MAKH;
            //Form_Loading form_loading = new Form_Loading();
            //InitializeComponent();
        
        public MuaHangKH(string id)
        {
            InitializeComponent();
            string sql = "SELECT MAKH FROM KHACHHANG WHERE ID = '" + id + "'";
            //MAKH = Functions.GetFieldValues(sql);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_TimMon_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_TimMon_TextChanged(object sender, EventArgs e)
        {

        }


        private void dsMonAn_Click(object sender, EventArgs e)
        {
            if (tbl_SP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {

            }
        }

        private void btn_MuaNgay_Click(object sender, EventArgs e)
        {
            //DonHang_KH donHang_KH = new DonHang_KH(
            //    dGV_SP_MH_KH.CurrentRow.Cells["MASP"].Value.ToString(),
            //    dGV_SP_MH_KH.CurrentRow.Cells["TENSP"].Value.ToString(),
            //    txtBox_giamoi_MH_KH.Text.Trim().ToString(),
            //    dGV_SP_MH_KH.CurrentRow.Cells["SOLUONGTON"].Value.ToString(),
            //    MAKH,
            //    dGV_SP_MH_KH.CurrentRow.Cells["HINHANH"].Value.ToString());
            //donHang_KH.StartPosition = FormStartPosition.CenterScreen;
            //donHang_KH.Show();
            DonHangKH dh = new DonHangKH();
            dh.StartPosition = FormStartPosition.CenterScreen;
            dh.Show();
        }

        private void btn_ThemVaoGio_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
