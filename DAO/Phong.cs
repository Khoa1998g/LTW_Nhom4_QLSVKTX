using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.DAO
{
    public class Phong
    {
        public Phong(string SoPhong, int SoLuongSV, string TinhTrang)        
        {
            this.soPhong = SoPhong;
            this.soLuongSV = SoLuongSV;
            this.tinhTrang = TinhTrang;
        }
        public Phong(DataRow row)
        {
            this.soPhong = row[0].ToString();
            this.soLuongSV = (int)row[1];
            this.tinhTrang = row[2].ToString();
        }

        public string soPhong { get; set; }
        public int soLuongSV { get; set; }

        public string tinhTrang { get; set; }
    }
}
