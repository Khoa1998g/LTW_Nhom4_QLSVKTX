using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.DAO
{
    public class SinhVienDAO
    {
        private static SinhVienDAO instance;
        public static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return instance; }
            private set { instance = value; }
        }
        private SinhVienDAO() { }

        public SinhVien loadSV(string ID)
        {
            DataTable data = dataProvider.Instance.ExecuteQuery("select * from sinhvien where masv = '" + ID + "'");
            if (data.Rows.Count > 0)
            {
                SinhVien sinhVien = new SinhVien(data.Rows[0]);
                return sinhVien;
            }
            else
            {
                return null;
            }
        }
    }
}
