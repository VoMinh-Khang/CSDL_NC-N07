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
    public partial class TXTheoDoiThuNhap : Form
    {
        string cmnd_TX;
        DataTable tbl_ThuNhapTX;
        public TXTheoDoiThuNhap(string cmnd_TX)
        {
            InitializeComponent();
            this.cmnd_TX = cmnd_TX;
        }

        private void Load_Data()
        {

            string sql = "USP_TX_THEODOITHUNHAP '" + cmnd_TX + "'";
            tbl_ThuNhapTX = Functions.GetDataToTable(sql);

            if(tbl_ThuNhapTX.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa nhận đơn hàng nào cả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView_TXTheoDoiThuNhap.DataSource = tbl_ThuNhapTX;
            

            //set font
            dataGridView_TXTheoDoiThuNhap.Font = new Font("Time New Roman", 12);
            dataGridView_TXTheoDoiThuNhap.Columns[0].HeaderText = "ID đơn hàng";
            dataGridView_TXTheoDoiThuNhap.Columns[1].HeaderText = "Thu nhập";
            dataGridView_TXTheoDoiThuNhap.Columns[2].HeaderText = "Ngày giao";

           

            //set width
            dataGridView_TXTheoDoiThuNhap.Columns[0].Width = 110;
            dataGridView_TXTheoDoiThuNhap.Columns[1].Width = 110;
            dataGridView_TXTheoDoiThuNhap.Columns[2].Width = 110;

            //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView_TXTheoDoiThuNhap.AllowUserToAddRows = false;
            dataGridView_TXTheoDoiThuNhap.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dataGridView_DSDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TXTheoDoiThuNhap_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void dataGridView_TXTheoDoiThuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
