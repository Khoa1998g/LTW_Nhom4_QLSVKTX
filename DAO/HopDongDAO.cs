using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.DAO
{
    public class HopDongDAO
    {
        private static HopDongDAO instance;
        public static HopDongDAO Instance
        {
            get { if (instance == null) instance = new HopDongDAO(); return instance; }
            private set { instance = value; }
        }
        private HopDongDAO() { }

        //public string getMaHopDongBySoPhong(string soPhong)
        //{
        //    //return dataProvider.Instance.ExecuteQuery("");
        //}
    }
}
