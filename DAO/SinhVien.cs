using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX
{
    public class SinhVien
    {
        public SinhVien(string masv, string hoten, string ngaysinh, string gioitinh, string cm, string sdt)
        {
            this.Id = masv;
            this.Name = hoten;
            this.Birth = ngaysinh;
            this.GioiTinh = gioitinh;
            this.CMND = cm;
            this.Phone = sdt;
        }
        public SinhVien(DataRow row)
        {
            this.Id = row[0].ToString().Trim();
            this.Name = row[1].ToString().Trim();
            this.Birth = row[2].ToString().Trim();
            this.GioiTinh = row[3].ToString().Trim();
            this.CMND = row[4].ToString().Trim();
            this.Phone = row[5].ToString().Trim();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Birth { get; set; }
        public string Phone { get; set; }
        public string CMND { get; set; }
        public string GioiTinh { get; set; }
    }
}
