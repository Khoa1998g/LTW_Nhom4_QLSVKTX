using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKTX.DAO
{
    public class reportSinhVien
    {
        public reportSinhVien(string mahd, string ht, string sophong, string nbd, string nkt)
        {
            this.maHD = mahd;
            this.hoTen = ht;
            this.SoPhong = sophong;
            this.ngayBatDau = nbd;
            this.ngayKetThuc = nkt;
        }
        public reportSinhVien(DataRow row)
        {
            this.maHD = row[0].ToString();
            this.hoTen = row[1].ToString();
            this.SoPhong = row[2].ToString();
            this.ngayBatDau = row[3].ToString();
            this.ngayKetThuc = row[4].ToString();
        }



        private string maHD;
        private string hoTen;
        private string soPhong;
        private string ngayBatDau;
        private string ngayKetThuc;

        public string MaHD { get => maHD; set => maHD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoPhong { get => soPhong; set => soPhong = value; }
        public string NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public string NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}
