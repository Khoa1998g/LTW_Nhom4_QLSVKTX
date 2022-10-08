using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public int login(string email, string password)
        {
            string query = "USP_LOGIN @email , @passWord";
            DataTable result = dataProvider.Instance.ExecuteQuery(query, new object[] {email, password});
            if (result.Rows.Count > 0)
            {
                string s = result.Rows[0][2].ToString();
                if (s.Trim() == "admin")
                {
                    return 1;
                }
                else
                    return 0;
            }
            else
                return -1;
        }
        public int register(string email, string password, string maSV)
        {
            string query = "USP_REGISTER @email , @passWord , @maSV";
            int data = dataProvider.Instance.ExecuteNonQuery(query, new object[] { email, password, maSV });
            return data;
        }
        public DataTable getInfo(string email)
        {
            DataTable data = new DataTable();
            string query = "select * from taikhoan a, sinhvien b where a.masv = b.masv and a.email = '"+email+"'";
            data = dataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
