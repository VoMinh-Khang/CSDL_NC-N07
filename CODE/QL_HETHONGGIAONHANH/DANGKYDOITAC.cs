using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_HETHONGGIAONHANH
{
    public partial class DANGKYDOITAC : Form
    {
        public DANGKYDOITAC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 ||textBox5.Text.Length == 0 || textBox7.Text.Length == 0 || textBox6.Text.Length == 0 || textBox4.Text.Length == 0 || textBox8.Text.Length == 0 || textBox9.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Lỗi");
            }
            else
            {
                MessageBox.Show("Đã ghi nhận thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        return;
        }

        private void DANGKYTHONGTIN_Load(object sender, EventArgs e)
        {

        }
    }
}
