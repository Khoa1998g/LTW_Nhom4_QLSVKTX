using QuanLyKTX.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class frmTTSV : Form
    {
        public frmTTSV(string maSV)
        {
            InitializeComponent();
            loadPhong(maSV);
            string Id = maSV;
            SinhVien sv = SinhVienDAO.Instance.loadSV(Id);
            string Name = sv.Name;
            string Birth = sv.Birth;
            string Phone = sv.Phone;
            string CMND = sv.CMND;
            string GioiTinh = sv.GioiTinh;
            txtMaSV.Text = Id;
            txtDienThoai.Text = Phone;
            txtCMND.Text = CMND;
            txtGioiTinh.Text = GioiTinh;
            txtHoten.Text = Name;
            dtpNgaySinh.Text = Birth;
        }
        void loadPhong(string maSV)
        {
            List<Phong> phongs = PhongDAO.Instance.loadListPhong();
            string soPhong = PhongDAO.Instance.getPhongByMaHD(HopDongDAO.Instance.getMaHopDongByMaSV(maSV));
            foreach (Phong item in phongs)
            {
                if (item.soPhong == soPhong)
                {
                    btnPhong.Text = item.soPhong + Environment.NewLine + Environment.NewLine + item.tinhTrang;
                    btnPhong.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
                    switch (item.tinhTrang)
                    {
                        case "Tốt":
                            btnPhong.BackColor = Color.FromArgb(4, 30, 54);
                            btnPhong.Image = global::QuanLyKTX.Properties.Resources.apartment;
                            break;
                        default:
                            btnPhong.BackColor = Color.IndianRed;
                            btnPhong.Image = global::QuanLyKTX.Properties.Resources.repair;
                            break;
                    }
                }
            }
        }
    }
}
