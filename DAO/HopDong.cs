using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.DAO
{
    public class HopDong
    {
        public HopDong(string maHD, string maSV, string soP, string NgayLap, string NgayBD, string NgayKT)
        {
            this.maHopDong = maHD;
            this.maSinhVien = maSV;
            this.soPhong = soP;
            this.ngayLap = NgayLap;
            this.ngayBatDau = NgayBD;
            this.ngayKetThuc = NgayKT;
        }
        public HopDong(DataRow row)
        {
            this.maHopDong = row[0].ToString().Trim();
            this.maSinhVien = row[1].ToString().Trim();
            this.soPhong = row[2].ToString().Trim();
            this.ngayLap = row[3].ToString().Trim();
            this.ngayBatDau = row[4].ToString().Trim();
            this.ngayKetThuc = row[5].ToString().Trim();
        }

        private string maHopDong;
        private string maSinhVien;
        private string soPhong;
        private string ngayLap;
        private string ngayBatDau;
        private string ngayKetThuc;

        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string SoPhong { get => soPhong; set => soPhong = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public string NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}
