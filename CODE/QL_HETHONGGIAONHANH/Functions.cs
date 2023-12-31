﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_HETHONGGIAONHANH
{
    class Functions
    {
    
        private static string exactly_server_name = @"192.168.32.131";

        //Khai báo đối tượng kết nối  
        public static SqlConnection Con;
        public static void Connect(string ConnectString)
        {
            Con = new SqlConnection();
            Con.ConnectionString = ConnectString;
            //  Con.ConnectionString = "Data Source=DESKTOP-0QKBNDR;Initial Catalog=HYT;Integrated Security=True";
            //Mở kết nối
            Con.Open();

            //Kiểm tra kết nối
            if (Con.State == ConnectionState.Open)
            {
                //MessageBox.Show("Kết nối DB thành công");
            }
            else MessageBox.Show("Không thể kết nối với DB");
        }

        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                //Đóng kết nối
                Con.Close();

                //Giải phóng tài nguyên
                Con.Dispose();
                Con = null;

                //Kiểm tra kết nối
                //MessageBox.Show("Đóng Kết nối DB thành công");
            }
        }
        //public static string get_ConnectString()
        //{
        //    string s = "";
        //    s = @"Data Source=" + exactly_server_name + ";Initial Catalog=QL_HETHONGGIAONHANH;Persist Security Info=True;User ID=sa;Password=Trang6720002";
        //    return s;
        //}
        //lấy ConnectString với mỗi loại user
        public static string get_ConnectString(int type)
        {
            string s = "";
            switch (type)
            {
                // vô danh
                case -2:
                    {
                        s = @"Data Source=" + exactly_server_name + ";Initial Catalog=QL_HETHONGGIAONHANH;Persist Security Info=True;User ID=TK_VODANH;Password=TK_VODANH123";
                        break;
                    }
                // đối tác
                case 1:
                    {
                        s = @"Data Source=" + exactly_server_name + ";Initial Catalog=QL_HETHONGGIAONHANH;Persist Security Info=True;User ID=TK_DOITAC;Password=TK_DOITAC12345";
                        break;
                    }
                //tài xế
                case 2:
                    {
                        s = @"Data Source=" + exactly_server_name + ";Initial Catalog=QL_HETHONGGIAONHANH;Persist Security Info=True;User ID=TK_TAIXE;Password=TK_TAIXE12345";
                        break;
                    }
                //// nhân viên
                case 3:
                    {
                        s = @"Data Source=" + exactly_server_name + ";Initial Catalog = QL_HETHONGGIAONHANH;Persist Security Info=True;User ID=TK_NHANVIEN;Password=TK_NHANVIEN12345";
                        break;
                    }
                // khách hàng
                case 4:
                    {
                        s = @"Data Source=" + exactly_server_name + ";Initial Catalog=QL_HETHONGGIAONHANH;Persist Security Info=True;User ID=TK_KHACHHANG;Password=TK_KHACHHANG12345";
                        break;
                    }
                
            }
            return s;
        }

        public static DataTable GetDataToTable(string sql) //Lấy dữ liệu đổ vào bảng
        {
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = new SqlCommand();

            //Kết nối cơ sở dữ liệu
            dap.SelectCommand.Connection = Functions.Con;
            dap.SelectCommand.CommandText = sql;

            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }

        public static bool CheckKey(string sql) // kiểm tra xem có trùng khóa hay không
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public static void RunSQL(string sql) // chạy câu lệnh sql
        {
            SqlCommand cmd = new SqlCommand();

            //Gán kết nối
            cmd.Connection = Con;

            //Gán lệnh SQL
            cmd.CommandText = sql;

            //Thực hiện câu lệnh SQL
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Giải phóng bộ nhớ
            cmd.Dispose();
            cmd = null;
        }

        public static string GetFieldValues(string sql) // lấy dữ liệu từ câu lệnh sql
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
    }
}
