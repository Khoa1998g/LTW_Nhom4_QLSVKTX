using System;
using System.Collections.Generic;
using System.Data;
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

        public string getMaHopDongByMaSV(string maSV)  //Thành công trả về mã HĐ, thất bại trả về ""
        {
            DataTable data = dataProvider.Instance.ExecuteQuery("select * from hopdong where masv = '"+maSV+"'");
            if(data.Rows.Count > 0)
            {
                HopDong hopDong = new HopDong(data.Rows[0]);
                return hopDong.MaHopDong;
            }
            return "";
        }
        public HopDong loadHD(string ID)
        {
            DataTable data = dataProvider.Instance.ExecuteQuery("select * from hopdong where mahopdong = '" + ID + "'");
            if (data.Rows.Count > 0)
            {
                HopDong hopDong = new HopDong(data.Rows[0]);
                return hopDong;
            }
            else
            {
                return null;
            }
        }
    }
}
