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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QL_HETHONGGIAONHANH
{
    public partial class CT_DONHANG : Form
    {
        string madon;
        DataTable table_CTDH;
        string ttrangdh;
        string tenmon;
        string danhgia;
        string MAKHACH;
        string binhluan;
        public CT_DONHANG(string madh, string ttdh,string mk)
        {
            InitializeComponent();
            madon = madh;
            ttrangdh = ttdh;
            MAKHACH = mk;
        }
        private void Load_Data()
        {
            string sql = "USP_KH_XEMCTDH '" + madon + "'";
            table_CTDH = Functions.GetDataToTable(sql);

            dataGridView_CTDH.DataSource = table_CTDH;

            // set Font cho tên cột
            dataGridView_CTDH.Font = new Font("Time New Roman", 13);
            dataGridView_CTDH.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView_CTDH.Columns[1].HeaderText = "Mã đối tác";

                
            dataGridView_CTDH.Columns[2].HeaderText = "Mã cửa hàng";
            
            dataGridView_CTDH.Columns[3].HeaderText = "Tên món";

            dataGridView_CTDH.Columns[4].HeaderText = "Giá";
            dataGridView_CTDH.Columns[5].HeaderText = "Số lượng";
            dataGridView_CTDH.Columns[6].HeaderText = "Thành tiền";
           

            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_CTDH.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_CTDH.Columns[0].Width = 150;
            dataGridView_CTDH.Columns[1].Width = 150;
            dataGridView_CTDH.Columns[2].Width = 110;
            dataGridView_CTDH.Columns[3].Width = 110;
            dataGridView_CTDH.Columns[4].Width = 100;
            dataGridView_CTDH.Columns[5].Width = 100;
            dataGridView_CTDH.Columns[6].Width = 100;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_CTDH.AllowUserToAddRows = false;
            dataGridView_CTDH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void CT_DONHANG_Load(object sender, EventArgs e)
        {
            Load_Data();
            if (ttrangdh == "Đã giao")
                panel1.SendToBack();
        }
        private int Run_SP_DanhGia()
        {
            binhluan = textBox1.Text.ToString();
            SqlCommand cmd = new SqlCommand("USP_KH_DANHGIAMON", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@tenmon", SqlDbType.NVarChar, 80);
            cmd.Parameters.Add("@makhach", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@danhgia", SqlDbType.Char, 7);
            cmd.Parameters.Add("@binhluan", SqlDbType.NVarChar, 100);


            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            // set giá trị
            cmd.Parameters["@tenmon"].Value = tenmon;
            cmd.Parameters["@makhach"].Value = MAKHACH;
            cmd.Parameters["@danhgia"].Value = danhgia;
            cmd.Parameters["@binhluan"].Value = binhluan;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());
        }
        private void dataGridView_CTDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tenmon = dataGridView_CTDH.CurrentRow.Cells["TENMON"].Value.ToString();
            textBox2.Text = tenmon;

        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            //buttonDislike.Enabled = false;
            danhgia = "Like";
            //buttonDislike.
        }

        private void buttonDislike_Click(object sender, EventArgs e)
        {
            //buttonLike.Enabled = false;
            danhgia = "Dislike";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int status = Run_SP_DanhGia();
                if (status == 1)
                {
                    MessageBox.Show("Đánh giá món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_Data();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Đánh giá mã lỗi: " + err.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
