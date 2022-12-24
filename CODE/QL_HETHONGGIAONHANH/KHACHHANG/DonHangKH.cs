using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QL_HETHONGGIAONHANH
{
    public partial class DonHangKH : Form
    {
        string tenmon;
        string gia;
        string ngaymua;
        string ngaygiao;
        string luongmua;
        string phivc;
        string phisp;
        string diachigiao;
        string hinhthuctt;
        string tongcong;
        string thanhtien;
        string madon;
        string MAKHACH;
        string MADT;
        string MACH;
        public DonHangKH(string tenmon,string gia, string makhach, string slton,string macuahang, string madoitac)
        {
            InitializeComponent();
            txtBox_TenMon.Text = tenmon;
            txtBox_GiaMon.Text = gia;
            MAKHACH = makhach;
            MADT = madoitac;
            MACH = macuahang;
            textBox_LuongMua.Text = "1";
            textBox_SoLuongTon.Text = slton;
            phivc = "30";
        }
        private void Load_Data()
        {
            string sql = "SELECT GIA " +
                "FROM MONAN " +
                "WHERE TENMON LIKE N'" + txtBox_TenMon.Text + "'";
            gia = Functions.GetFieldValues(sql);
            //phisp = ((float.Parse(gia.ToString()) * 0.1).ToString());

            float phisp = (float)(0.1 * float.Parse(gia));
            //float phisp = (float)(tungphisp * Int32.Parse(textBox_LuongMua.Text.Trim().ToString())); ;
            
            textBox_PhiSP.Text = phisp.ToString();
            textBox_PhiVC.Text = phivc;
        }
        private void DonHang_KH_Load(object sender, EventArgs e)
        {
            //Load_Data();
            Auto_Tong_Tien();
            
        }
        private void Auto_Tong_Tien()
        {
            string sql = "SELECT GIA " +
                "FROM MONAN " +
                "WHERE TENMON LIKE N'" + txtBox_TenMon.Text + "'";
            gia = Functions.GetFieldValues(sql);

            float phi_tren1sp = (float)(0.1 * float.Parse(gia));
            float phisp = (float)(phi_tren1sp * Int32.Parse(textBox_LuongMua.Text.Trim().ToString()));

            textBox_PhiSP.Text = phisp.ToString();
            textBox_PhiVC.Text = phivc;

            float tongcong = float.Parse(textBox_PhiSP.Text) + float.Parse(textBox_PhiVC.Text)+ float.Parse(txtBox_GiaMon.Text) * Int32.Parse(textBox_LuongMua.Text.Trim().ToString());
            if (tongcong > 0)
                textBox_TongTien.Text = tongcong.ToString("0.0000");
            else
                textBox_TongTien.Text = "";
        }
        private void buttonGiam_Click(object sender, EventArgs e)
        {
            int luongmua = Int32.Parse(textBox_LuongMua.Text.Trim().ToString());
            luongmua -= 1;
            if (luongmua < 1) 
                luongmua = 1;
            textBox_LuongMua.Text = luongmua.ToString();
            Auto_Tong_Tien();
        }

        private void buttonTang_Click(object sender, EventArgs e)
        {
            int soluongton = Int32.Parse(textBox_SoLuongTon.Text.Trim().ToString());
            int luongmua = Int32.Parse(textBox_LuongMua.Text.Trim().ToString());
            luongmua += 1;
            if (luongmua >= soluongton) 
                luongmua = soluongton;
            textBox_LuongMua.Text = luongmua.ToString();
            Auto_Tong_Tien();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            //chỗ này chép script thanh toán
            if ((textBox_DCG.Text.Trim().Length == 0) || string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tenmon = txtBox_TenMon.Text.Trim();
            gia = txtBox_GiaMon.Text.Trim();
            DateTime todayNow = DateTime.Now;
            ngaymua = todayNow.ToString();
            DateTime giaohnay = DateTime.Today;
            ngaygiao = giaohnay.ToString();
            hinhthuctt = comboBox1.Text.Trim();
            tongcong = textBox_TongTien.Text.Trim();
            diachigiao = textBox_DCG.Text.Trim();
            luongmua = textBox_LuongMua.Text.Trim();
            phisp = textBox_PhiSP.Text.ToString().Trim();
            phivc = textBox_PhiVC.Text.Trim();
            thanhtien = (float.Parse(txtBox_GiaMon.Text.ToString()) * Int32.Parse(textBox_LuongMua.Text.Trim().ToString())).ToString();


            //SqlCommand cmd = new SqlCommand("TaoMaDon", Functions.Con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //cmd.Parameters.Add("@madon", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;;

            //// set giá trị
            //cmd.Parameters["@madon"].Value = madon;

            //cmd.ExecuteNonQuery();

            //madon = Convert.ToString(cmd.Parameters["@madon"].Value);

            string missing = "000000000";
            string sql = "SELECT COUNT(*) FROM DONHANG";
            int rows_number = Int32.Parse(Functions.GetFieldValues(sql));
            rows_number++;
            //MAKHACH = "KH" + missing.Substring(0, 10 - 2 - rows_number.ToString().Length) + rows_number.ToString();//Thiếu
            madon = "DH" + missing.Substring(0, 5 - 2 - rows_number.ToString().Length) + rows_number.ToString();

            //string sql = "select top 1 MADON from DONHANG order by NGAYLAP desc";
            //string get_madon = Functions.GetFieldValues(sql);
            //int madonmoi = Int32.Parse(get_madon.Substring(2));
            //madonmoi++;

            //madon = "DH" + missing.Substring(0, 5 - 2 - madonmoi.ToString().Length) + madonmoi.ToString();

            try
            {
                int status1 = Run_SP_Sp_KH_ThemDH();

                int status2 = Run_SP_Sp_KH_ThemCTDH();

                if (status1 == 1 && status2 == 1)
                {
                    MessageBox.Show("Đặt hàng thành công!\nHãy xác nhận đơn hàng để nhận nhanh nhất nhé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm đơn hàng thất bại, mã lỗi: " + ex.Message);
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
            cmd.Parameters.Add("@ngaygiao", SqlDbType.DateTime);
            cmd.Parameters.Add("@hinhthuctt", SqlDbType.NVarChar,50);
            cmd.Parameters.Add("@diachigiaohang", SqlDbType.NVarChar, 300);
            cmd.Parameters.Add("@tongtien", SqlDbType.Float, 19);
            cmd.Parameters.Add("@phisp", SqlDbType.Float, 19);
            cmd.Parameters.Add("@phivc", SqlDbType.Float, 19);
            

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;


            // set giá trị
            cmd.Parameters["@madt"].Value = MADT;
            cmd.Parameters["@mach"].Value = MACH;
            cmd.Parameters["@madon"].Value = madon;
            cmd.Parameters["@makh"].Value = MAKHACH;
            cmd.Parameters["@ngaymua"].Value = ngaymua;
            cmd.Parameters["@ngaygiao"].Value = ngaygiao;
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

            //cmd.Parameters["@THANHTIEN"].Precision = 19;
            //cmd.Parameters["@THANHTIEN"].Scale = 4;
            //thiếu: sửa proc, thành tiền là bằng sản phẩm nhân

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            // set giá trị
            cmd.Parameters["@madt"].Value = MADT;
            cmd.Parameters["@mach"].Value = MACH;
            cmd.Parameters["@madon"].Value = madon;
            cmd.Parameters["@tenmon"].Value = tenmon;
            cmd.Parameters["@soluong"].Value = luongmua;
            cmd.Parameters["@thanhtien"].Value = thanhtien;

            cmd.ExecuteNonQuery();

            return Int32.Parse(returnParameter.Value.ToString());
        }


        private void label6_Click(object sender, EventArgs e)
        {
           

        }

        private void txtBox_TenMon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
