using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemThuocFinalVersion.Controller.DataAccess
{
    public class DataBaseFunction
    {
        public static SqlConnection Conn;  //Khai báo đối tượng kết nối
        public static string connString;   //Khai báo biến chứa chuỗi kết nối

        public static void Connect()
        {
            //Thiết lập giá trị cho chuỗi kết nối
            connString = @"Data Source=Admin\SQLEXPRESS;Initial Catalog=Quanlitiemthuoc;Integrated Security=True";

            Conn = new SqlConnection();
            Conn.ConnectionString = connString;
            Conn.Open();
        }

        
        public static DataTable GetDataToTable(string sql)
        {
            Connect();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        } 

        public static int GetItemId(string sql) //lay ra id
        {
            Connect();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return Int32.Parse(dt.Rows[0].ItemArray[0].ToString());
            }
            return -1;
        }

        public static string GetItemValue(string sql) //lay gia tri
        {
            Connect();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0].ItemArray[0].ToString();
            }
            return "";
        } 
        //


        public static void ExcuteSQL(string sql) //thuc thi sql delete upodate insert
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
        }

        
    }
}
