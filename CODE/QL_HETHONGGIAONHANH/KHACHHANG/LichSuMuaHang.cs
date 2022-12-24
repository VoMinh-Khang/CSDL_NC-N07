using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_HETHONGGIAONHANH
{
    public partial class LichSuMuaHang : Form
    {
        
        string MAKH;
        DataTable tbl_LSMH;
        string madon;
        public LichSuMuaHang(string makh)
        {
            InitializeComponent();
            MAKH = makh;
        }

        private void Load_Data()
        {
            string sql = "USP_KH_THEODOIDH '" + MAKH + "'";
            tbl_LSMH = Functions.GetDataToTable(sql);

            //Nếu không có dữ liệu
            if (tbl_LSMH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dsDonHang.DataSource = tbl_LSMH;
            

            // set Font cho tên cột
            dsDonHang.Font = new Font("Time New Roman", 13);
            dsDonHang.Columns[0].HeaderText = "Mã đơn hàng";
            dsDonHang.Columns[1].HeaderText = "Ngày lập";
            dsDonHang.Columns[2].HeaderText = "Hình thức thanh toán";
            dsDonHang.Columns[3].HeaderText = "Địa chỉ giao";
            dsDonHang.Columns[4].HeaderText = "Phí sản phẩm";
            dsDonHang.Columns[5].HeaderText = "Phí vận chuyển";
            dsDonHang.Columns[6].HeaderText = "Tổng tiền";
            dsDonHang.Columns[7].HeaderText = "Tình trạng";
            dsDonHang.Columns[8].HeaderText = "Ngày giao";
            dsDonHang.Columns[9].HeaderText = "Tài xế";


            // set Font cho dữ liệu hiển thị trong cột
            dsDonHang.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dsDonHang.Columns[0].Width = 100;
            dsDonHang.Columns[1].Width = 200;
            dsDonHang.Columns[2].Width = 100;
            dsDonHang.Columns[3].Width = 200;
            dsDonHang.Columns[4].Width = 100;
            dsDonHang.Columns[5].Width = 100;
            dsDonHang.Columns[6].Width = 100;
            dsDonHang.Columns[7].Width = 200;
            dsDonHang.Columns[8].Width = 200;
            dsDonHang.Columns[9].Width = 200;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dsDonHang.AllowUserToAddRows = false;
            dsDonHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_MaDH.Text = dsDonHang.CurrentRow.Cells["MADON"].Value.ToString();
            txtBox_TongTien.Text = dsDonHang.CurrentRow.Cells["TONGTIEN"].Value.ToString();
            txtBox_TinhTrang.Text = dsDonHang.CurrentRow.Cells["TINHTRANG"].Value.ToString();

            if (txtBox_TinhTrang.Text.ToString().Equals("Chờ xác nhận"))
            {
                button_XacNhanDon.Enabled = true;
                button_huydon.Enabled = true;
            }
            else
            {
                button_XacNhanDon.Enabled = false;
                button_huydon.Enabled = false;
            }
            
            if (txtBox_TinhTrang.Text.ToString() == "Đã hủy")
                btn_XemChiTiet.Enabled = false;
            else
                btn_XemChiTiet.Enabled = true;

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
            CT_DONHANG ct_donhang_nay = new CT_DONHANG(txtBox_MaDH.Text.Trim().ToString());
            ct_donhang_nay.StartPosition = FormStartPosition.CenterScreen;
            ct_donhang_nay.Show();
        }

        private void LichSuMuaHang_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private int Run_USP_XacNhanDon()
        {
            SqlCommand cmd = new SqlCommand("USP_KH_XACNHANDON", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@madon", SqlDbType.VarChar, 15);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters["@madon"].Value = madon;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }
        
        private void button_XacNhanDon_Click(object sender, EventArgs e)
        {

            try
            {
                madon = txtBox_MaDH.Text;
                int status = Run_USP_XacNhanDon();
                if (status == 1)
                {
                    MessageBox.Show("Xác Nhận Đơn Hàng Thành Công! \nĐơn của bạn đang ở trạng thái đã xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_Data();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Xác nhận đơn thất bại mã lỗi: " + err.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
        }
        private int Run_USP_KH_HuyDon()
        {
            SqlCommand cmd = new SqlCommand("USP_KH_HUYDON", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@madon", SqlDbType.VarChar, 15);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters["@madon"].Value = madon;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());
        }
        private void button_huydon_Click(object sender, EventArgs e)
        {
            try
            {
                madon = txtBox_MaDH.Text;
                int status = Run_USP_KH_HuyDon();
                if (status == 1)
                {
                    MessageBox.Show("Hủy Đơn Hàng Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Load_Data();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hủy đơn thất bại mã lỗi: " + err.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}

