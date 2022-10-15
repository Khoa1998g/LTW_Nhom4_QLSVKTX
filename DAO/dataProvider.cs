using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.DAO
{
    public class dataProvider
    {
        private static dataProvider instance;
        public static dataProvider Instance 
        {
            get { if (instance == null) instance = new dataProvider(); return dataProvider.instance; }
            private set => dataProvider.instance = value; 
        }
        private dataProvider() { }

        private string connectionSTR = "Data Source=KHOA19\\KHOA1982;Initial Catalog=QLKTX;Integrated Security=True";

        

        public DataTable ExecuteQuery(string query, object[] parameter = null) //trả về 1 table sql
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR)) //kết nối tới sever sql          
            {
                connection.Open(); //mở connection
                SqlCommand command = new SqlCommand(query, connection); //Câu truy vấn được thực thi
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }                             
                SqlDataAdapter adapter = new SqlDataAdapter(command); //Trung gian lấy dữ liệu
                adapter.Fill(data);
                connection.Close(); //đóng connection
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null) //trả về số dòng được thực thi
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR)) //kết nối tới sever sql          
            {
                connection.Open(); //mở connection
                SqlCommand command = new SqlCommand(query, connection); //Câu truy vấn được thực thi
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close(); //đóng connection
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR)) //kết nối tới sever sql          
            {
                connection.Open(); //mở connection
                SqlCommand command = new SqlCommand(query, connection); //Câu truy vấn được thực thi
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close(); //đóng connection
            }
            return data;
        }
    }
}
