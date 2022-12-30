using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace QL_HETHONGGIAONHANH
{
    public partial class GioHangKH : Form
    {
        string tenmon;
        double gia;
        string ngaymua;
        int luongmua;
        double phivc;
        string phisp;
        string diachigiao;
        string hinhthuctt;
        double thanhtien;
        double tongcong;
        string madon;
        string MAKHACH;
        string madoitac;
        string mach;
        double sum;
        public GioHangKH(string MAKH)
        {
            MAKHACH = MAKH;
            InitializeComponent();
            dataGridView1.Font = new Font("Segoe UI", 10);
            dataGridView1.Columns[0].HeaderText = "Mã đối tác";
            dataGridView1.Columns[1].HeaderText = "Mã cửa hàng";
            dataGridView1.Columns[2].HeaderText = "Tên món";
            dataGridView1.Columns[3].HeaderText = "Giá món";
            dataGridView1.Columns[4].HeaderText = "Số lượng mua";

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 105;
            dataGridView1.Columns[4].Width = 105;
            textBox_PhiVC.Text = "30";
            sum = 0;
        }

        private void btn_TiepTuc_Click(object sender, EventArgs e)
        {

        }

        internal void AddNewChoice(string madt, string mach, string tenmon, string gia, int soluong)
        {
            //for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            //{
            //    if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == tenmon)
            //    {
            //        dataGridView1.Rows[i].Cells[4].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value) + 1;
            //    }
            //    else
            //    {
            //        DataGridViewRow newRow = new DataGridViewRow();
            //        newRow.CreateCells(dataGridView1);
            //        newRow.Cells[0].Value = madt;
            //        newRow.Cells[1].Value = mach;
            //        newRow.Cells[2].Value = tenmon;
            //        newRow.Cells[3].Value = gia;
            //        newRow.Cells[4].Value = soluong;
            //        dataGridView1.Rows.Add(newRow);
            //    }

            //}

            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView1);
            newRow.Cells[0].Value = madt;
            newRow.Cells[1].Value = mach;
            newRow.Cells[2].Value = tenmon;
            newRow.Cells[3].Value = gia;
            newRow.Cells[4].Value = soluong;
            dataGridView1.Rows.Add(newRow);
            
            TinhTong();

        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TinhTong();
        }
        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TinhTong();
        }

        private void TinhTong()
        {
            sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                textBox_PhiSP.Text = (sum * 0.1).ToString();
                tongcong = Double.Parse(textBox_PhiVC.Text.ToString()) + sum + sum * 0.1;
                textBox_TongTien.Text = tongcong.ToString();
            }
        }
        private int Run_SP_Sp_KH_ThemDH()
        {
            SqlCommand cmd = new SqlCommand("USP_KH_DATHANG", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@madt", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@mach", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@madon", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@ngaymua", SqlDbType.DateTime);
            cmd.Parameters.Add("@hinhthuctt", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@diachigiaohang", SqlDbType.NVarChar, 300);
            cmd.Parameters.Add("@tongtien", SqlDbType.Float);
            cmd.Parameters.Add("@phisp", SqlDbType.Float);
            cmd.Parameters.Add("@phivc", SqlDbType.Float);


            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;


            // set giá trị
            cmd.Parameters["@madt"].Value = madoitac;
            cmd.Parameters["@mach"].Value = mach;
            cmd.Parameters["@madon"].Value = madon;
            cmd.Parameters["@makh"].Value = MAKHACH;
            cmd.Parameters["@ngaymua"].Value = ngaymua;
            cmd.Parameters["@hinhthuctt"].Value = hinhthuctt;
            cmd.Parameters["@diachigiaohang"].Value = diachigiao;
            cmd.Parameters["@tongtien"].Value = tongcong;
            cmd.Parameters["@phisp"].Value = phisp;
            cmd.Parameters["@phivc"].Value = phivc;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());
        }
        private int Run_SP_Sp_KH_ThemCTDH()
        {
            SqlCommand cmd = new SqlCommand("USP_KH_DATHANG_CTDH", Functions.Con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // set kiểu dữ liệu
            cmd.Parameters.Add("@madon", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@madt", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@mach", SqlDbType.VarChar, 10);
            cmd.Parameters.Add("@tenmon", SqlDbType.NVarChar, 80);
            cmd.Parameters.Add("@soluong", SqlDbType.Int);
            cmd.Parameters.Add("@thanhtien", SqlDbType.Float);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            // set giá trị
            cmd.Parameters["@madt"].Value = madoitac;
            cmd.Parameters["@mach"].Value = mach;
            cmd.Parameters["@madon"].Value = madon;
            cmd.Parameters["@tenmon"].Value = tenmon;
            cmd.Parameters["@soluong"].Value = luongmua;
            cmd.Parameters["@thanhtien"].Value = thanhtien;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());
        }
        private void btn_muangay_Click(object sender, EventArgs e)
        {
            if (textBox_DCG.Text.Trim().Length == 0 |
                textBox_PhiSP.Text.Trim().Length == 0 |
                textBox_TongTien.Text.Trim().Length == 0)

            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime todayNow = DateTime.Now;
            ngaymua = todayNow.ToString();
            hinhthuctt = comboBox1.Text.Trim();
            diachigiao = textBox_DCG.Text.Trim();
            phisp = textBox_PhiSP.Text.ToString().Trim();
            phivc = Double.Parse(textBox_PhiVC.Text.ToString().Trim());
            madoitac = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
            mach = Convert.ToString(dataGridView1.Rows[0].Cells[1].Value);


            string missing = "000000000";
            string sql = "SELECT COUNT(*) FROM DONHANG";
            int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
            rows_number++;
            madon = "DH" + missing.Substring(0, 5 - 2 - rows_number.ToString().Length) + rows_number.ToString();
            Run_SP_Sp_KH_ThemDH();
            

            string res = "";
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                madoitac = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                mach = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                tenmon = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                gia = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                luongmua = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                thanhtien = (gia * luongmua);
                try
                {
                    int status2 = Run_SP_Sp_KH_ThemCTDH();

                    if (status2 == 1)
                    {
                        res += "1";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đặt hàng thất bại, mã lỗi: " + ex.Message);
                }
            }

            if (res.Contains("1"))
            {
                MessageBox.Show("Đặt các món ăn trong giỏ thành công!\nHãy xác nhận đơn hàng để nhận nhanh nhất nhé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void GioHangKH_Load(object sender, EventArgs e)
        {
            TinhTong();
        }
    }      
}
