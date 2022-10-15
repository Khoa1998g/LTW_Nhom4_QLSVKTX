using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.DAO
{
    public class reportSinhVienDAO
    {
        private static reportSinhVienDAO instance;
        public static reportSinhVienDAO Instance
        {
            get { if (instance == null) instance = new reportSinhVienDAO(); return instance; }
            private set { instance = value; }
        }
        private reportSinhVienDAO() { }

        public List<reportSinhVien> loadListReport()
        {
            List<reportSinhVien> SinhViens = new List<reportSinhVien>();
            DataTable data = dataProvider.Instance.ExecuteQuery("select  c.mahopdong, b.hoten, a.sophong,  c.ngaybatdau, c.ngayketthuc" +
                " from phong a, sinhvien b, hopdong c" +
                " where a.sophong = c.sophong and b.masv = c.masv ");
            foreach (DataRow item in data.Rows)
            {
                reportSinhVien sv = new reportSinhVien(item);
                SinhViens.Add(sv);
            }
            return SinhViens;
        }
    }
}
