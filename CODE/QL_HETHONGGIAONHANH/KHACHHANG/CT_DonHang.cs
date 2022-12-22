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
    public partial class CT_DONHANG : Form
    {
        string madon;
        DataTable table_CTDH;
        public CT_DONHANG(string madh)
        {
            InitializeComponent();
            madon = madh;
        }
        private void Load_Data()
        {
            string sql = "USP_KH_XEMCTDH '" + madon + "'";
            table_CTDH = Functions.GetDataToTable(sql);
            dataGridView_CTDH.DataSource = table_CTDH;

            // set Font cho tên cột
            dataGridView_CTDH.Font = new Font("Time New Roman", 13);
            dataGridView_CTDH.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView_CTDH.Columns[1].HeaderText = "Tên món";
            dataGridView_CTDH.Columns[2].HeaderText = "Giá";
            dataGridView_CTDH.Columns[3].HeaderText = "Số lượng";
            dataGridView_CTDH.Columns[4].HeaderText = "Thành tiền";
           

            // set Font cho dữ liệu hiển thị trong cột
            dataGridView_CTDH.DefaultCellStyle.Font = new Font("Time New Roman", 12);

            // set kích thước cột
            dataGridView_CTDH.Columns[0].Width = 195;
            dataGridView_CTDH.Columns[1].Width = 200;
            dataGridView_CTDH.Columns[2].Width = 110;
            dataGridView_CTDH.Columns[3].Width = 110;
            dataGridView_CTDH.Columns[4].Width = 150;
           

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_CTDH.AllowUserToAddRows = false;
            dataGridView_CTDH.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        private void CT_DONHANG_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
