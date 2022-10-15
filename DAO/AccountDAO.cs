using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool IsValidMail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            string sMailPattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            return Regex.IsMatch(email.Trim(), sMailPattern);
        }
        public bool IsValidVietNamPhoneNumber(string phoneNum)
        {
            if (string.IsNullOrEmpty(phoneNum))
                return false;
            string sMailPattern = @"^((09(\d){8})|(086(\d){7})|(088(\d){7})|(089(\d){7})|(01(\d){9}))$";
            return Regex.IsMatch(phoneNum.Trim(), sMailPattern);
        }
        public bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;
            string pattern = @"((?=.*[0-9])(?=.*[a-z]).{6,20})";
            return Regex.IsMatch(password.Trim(), pattern);
        }
        public bool IsValidID(string maSV)
        {
            if (string.IsNullOrEmpty(maSV))
                return false;
            string pattern = @"[0-9]{10}";
            return Regex.IsMatch(maSV.Trim(), pattern);
        }
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
