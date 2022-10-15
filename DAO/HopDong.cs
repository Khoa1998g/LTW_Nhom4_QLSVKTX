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
        public HopDong(string maHD, string maSV, string soP, DateTime? NgayLap, DateTime? NgayBD, DateTime? NgayKT)
        {
            this.maHopDong = maHD;
            this.maSinhVien = maSV;
            this.ngayLap = NgayLap;
            this.ngayBatDau = NgayBD;
            this.ngayKetThuc = NgayKT;
        }
        public HopDong(DataRow row)
        {
            this.maHopDong = row[0].ToString();
            this.maSinhVien = row[1].ToString();
            this.ngayLap = (DateTime?)row[2];
            this.ngayBatDau = (DateTime?)row[3];
            this.ngayKetThuc = (DateTime?)row[4];
        }

        private string maHopDong;
        private string maSinhVien;
        private string soPhong;
        private DateTime? ngayLap;
        private DateTime? ngayBatDau;
        private DateTime? ngayKetThuc;

        public string MaHopDong { get => maHopDong; set => maHopDong = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string SoPhong { get => soPhong; set => soPhong = value; }
        public DateTime? NgayLap { get => ngayLap; set => ngayLap = value; }
        public DateTime? NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime? NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}
