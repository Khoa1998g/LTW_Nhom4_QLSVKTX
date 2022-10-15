using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKTX;

namespace QuanLyKTX.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;
        public static PhongDAO Instance 
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; } 
            private set { instance = value; }
        }
        private PhongDAO() { }
        public static int phongWidth = 300;
        public static int phongHeight = 250;

        public List<Phong> loadListPhong()
        {
            List<Phong> phongs = new List<Phong>();
            DataTable data = dataProvider.Instance.ExecuteQuery("USP_GETPHONG");
            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                phongs.Add(phong);
            }
            return phongs;
        }
        public List<Phong> loadListPhongReport()
        {
            List<Phong> phongs = new List<Phong>();
            DataTable data = dataProvider.Instance.ExecuteQuery("USP_DATA");
            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                phongs.Add(phong);
            }
            return phongs;
        }
    }
}
