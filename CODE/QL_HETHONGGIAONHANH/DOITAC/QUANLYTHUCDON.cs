using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_HETHONGGIAONHANH
{
    public partial class QUANLYTHUCDON : Form
    {
        DataTable tbl_THUCDON;
        string MADT;
        public QUANLYTHUCDON(string madoitac)
        {
            InitializeComponent();
            MADT = madoitac;
        }

        


        private void label3_Click(object sender, EventArgs e)
        {

        }
        private int Run_SP_THEMMON()
        {
            SqlCommand cmd = new SqlCommand("USP_THEMMONAN", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu

            cmd.Parameters.Add("@TENMON", SqlDbType.NVarChar, 80);
            cmd.Parameters.Add("@MIEUTAMON", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@GIA", SqlDbType.Float);
            cmd.Parameters.Add("@TINHTRANGMONAN", SqlDbType.NVarChar, 50);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@TENMON"].Value = txt_tenmon.Text;
            cmd.Parameters["@MIEUTAMON"].Value = txtmieuta.Text;
            cmd.Parameters["@GIA"].Value = float.Parse(txtgia.Text);
            cmd.Parameters["@TINHTRANGMONAN"].Value = txttinhtrang.Text;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }
        
        private void QUANLYTHUCDON_Load(object sender, EventArgs e)
        {
           // 
            string sql = " SELECT * FROM MONAN";
            tbl_THUCDON = Functions.GetDataToTable(sql);
            dataGridViewQLTD.DataSource = tbl_THUCDON;
            //set font
            //dataGridViewQLTD.Font = new Font("Time New Roman", 13);
            dataGridViewQLTD.Columns[0].HeaderText = "Tên món";
            dataGridViewQLTD.Columns[1].HeaderText = "Miêu tả món";
            dataGridViewQLTD.Columns[2].HeaderText = "Giá";
            dataGridViewQLTD.Columns[3].HeaderText = "Tình trạng món";
            //set width
            dataGridViewQLTD.Columns[0].Width = 100;
            dataGridViewQLTD.Columns[1].Width = 110;
            dataGridViewQLTD.Columns[2].Width = 110;
            dataGridViewQLTD.Columns[3].Width = 180;
            // cho nguoi dung them du lieu truc tiep
            dataGridViewQLTD.AllowUserToAddRows = false;
            dataGridViewQLTD.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT (*)  FROM MONAN";
            int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
            rows_number++;

            int status = Run_SP_THEMMON();
            if (status == 1)
            {

                MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QUANLYTHUCDON_Load(sender, e);
            }
            if (status == -1)
            {

                MessageBox.Show("Món ăn đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewQLTD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private int Run_SP_XOAMONAN()
        {
            SqlCommand cmd = new SqlCommand("USP_XOAMONAN", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu

            cmd.Parameters.Add("@TENMON", SqlDbType.NVarChar, 80);
            cmd.Parameters.Add("@MIEUTAMON", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@GIA", SqlDbType.Float);
            cmd.Parameters.Add("@TINHTRANGMONAN", SqlDbType.NVarChar, 50);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@TENMON"].Value = txt_tenmon.Text;
            cmd.Parameters["@MIEUTAMON"].Value = txtmieuta.Text;
            cmd.Parameters["@GIA"].Value = txtgia.Text;
            cmd.Parameters["@TINHTRANGMONAN"].Value = txttinhtrang.Text;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT (*)  FROM MONAN";
            int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
            --rows_number;

            int status = Run_SP_XOAMONAN();
            if (status == 1)
            {

                MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QUANLYTHUCDON_Load(sender, e);
            }
        }
        private int Run_SP_CAPNHATMONAN()
        {
            SqlCommand cmd = new SqlCommand("USP_CAPNHATMONAN", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu

            cmd.Parameters.Add("@TENMON", SqlDbType.NVarChar, 80);
            cmd.Parameters.Add("@MIEUTAMON", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@GIA", SqlDbType.Float);
            cmd.Parameters.Add("@TINHTRANGMONAN", SqlDbType.NVarChar, 50);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            //set giá trị
            cmd.Parameters["@TENMON"].Value = txt_tenmon.Text;
            cmd.Parameters["@MIEUTAMON"].Value = txtmieuta.Text;
            cmd.Parameters["@GIA"].Value = txtgia.Text;
            cmd.Parameters["@TINHTRANGMONAN"].Value = txttinhtrang.Text;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT (*)  FROM MONAN";
            int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
            rows_number++;

            int status = Run_SP_CAPNHATMONAN();
            if (status == 1)
            {

                MessageBox.Show("cập nhật món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QUANLYTHUCDON_Load(sender, e);
            }
            if (status == -1)
            {

                MessageBox.Show("không tìm thấy món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
