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
    public partial class ThongkeKH_NV : Form
    {
        Thread t;
        DataTable table_KH;
        string ID;
        public ThongkeKH_NV()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dTP_ngaygiaohang_ValueChanged(object sender, EventArgs e)
        {
            dTP_ngaygiaohang.CustomFormat = "yyyy-MM-dd";
        }

        /*private int Run_ThongkeKH()
        {
            SqlCommand cmd = new SqlCommand("USP_NV_THONGKEKHACH_NGAY", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@ngay", SqlDbType.DateTime);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@ngay"].Value = dTP_ngaygiaohang.Value;
            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());
        }*/

        private void btn_thongkeKH_NV_Click(object sender, EventArgs e)
        {
            if (dTP_ngaygiaohang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn ngày  !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "USP_NV_THONGKEKHACH_NGAY'" + dTP_ngaygiaohang.Value + "'";
            table_KH = Functions.GetDataToTable(sql);
            dataGridView_thongkeKH.DataSource = table_KH;

             dataGridView_thongkeKH.Columns[0].HeaderText = "Mã khách hàng";
             dataGridView_thongkeKH.Columns[1].HeaderText = "Tài khoản";
             dataGridView_thongkeKH.Columns[2].HeaderText = "Tên khách hàng";
             dataGridView_thongkeKH.Columns[3].HeaderText = "Số điện thoại";
             dataGridView_thongkeKH.Columns[4].HeaderText = "Địa chỉ";
             dataGridView_thongkeKH.Columns[5].HeaderText = "Email";

             dataGridView_thongkeKH.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // set kích thước cột
             dataGridView_thongkeKH.Columns[0].Width = 100;
             dataGridView_thongkeKH.Columns[1].Width = 200;
             dataGridView_thongkeKH.Columns[2].Width = 200;
             dataGridView_thongkeKH.Columns[3].Width = 100;
             dataGridView_thongkeKH.Columns[4].Width = 200;
             dataGridView_thongkeKH.Columns[5].Width = 200;

            //Không cho người dùng thêm dữ liệu trực tiếp
             dataGridView_thongkeKH.AllowUserToAddRows = false;
             dataGridView_thongkeKH.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThongkeKH_NV_Load(object sender, EventArgs e)
        {
            Functions.Connect(Functions.get_ConnectString());
            string sql = "SELECT * FROM KHACHHANG";
            table_KH = Functions.GetDataToTable(sql);
            dataGridView_thongkeKH.DataSource = table_KH;

            // set Font cho tên cột
            dataGridView_thongkeKH.Font = new Font("Time New Roman", 13);
            dataGridView_thongkeKH.Columns[0].HeaderText = "Mã khách hàng";
            dataGridView_thongkeKH.Columns[1].HeaderText = "Tài khoản";
            dataGridView_thongkeKH.Columns[2].HeaderText = "Tên khách hàng";
            dataGridView_thongkeKH.Columns[3].HeaderText = "Số điện thoại";
            dataGridView_thongkeKH.Columns[4].HeaderText = "Địa chỉ";
            dataGridView_thongkeKH.Columns[5].HeaderText = "Email";

            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_thongkeKH.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_thongkeKH.Columns[0].Width = 200;
            dataGridView_thongkeKH.Columns[1].Width = 200;
            dataGridView_thongkeKH.Columns[2].Width = 200;
            dataGridView_thongkeKH.Columns[3].Width = 200;
            dataGridView_thongkeKH.Columns[4].Width = 200;
            dataGridView_thongkeKH.Columns[5].Width = 200;


            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_thongkeKH.AllowUserToAddRows = false;
            dataGridView_thongkeKH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dataGridView_thongkeKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            textBox_MAKH.Text = dataGridView_thongkeKH.Rows[numrow].Cells[0].Value.ToString();
            textBox_TK.Text = dataGridView_thongkeKH.Rows[numrow].Cells[1].Value.ToString();
            textBox_TENKH.Text = dataGridView_thongkeKH.Rows[numrow].Cells[2].Value.ToString();
            textBox_SDT.Text = dataGridView_thongkeKH.Rows[numrow].Cells[3].Value.ToString();
            textBox_DIACHI.Text = dataGridView_thongkeKH.Rows[numrow].Cells[4].Value.ToString();
            textBox_EMAIL.Text = dataGridView_thongkeKH.Rows[numrow].Cells[5].Value.ToString();

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

        private void btn_huythongkeKH_NV_Click(object sender, EventArgs e)
        {

        }
    }
}

