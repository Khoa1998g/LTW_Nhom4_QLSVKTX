using QuanLyKTX.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class frmTTLuuTru : Form
    {
        public frmTTLuuTru(string maSV)
        {
            InitializeComponent();
            loadHopDong(maSV);
        }
        void loadHopDong(string maSV)
        {
            string maHD = HopDongDAO.Instance.getMaHopDongByMaSV(maSV);
            HopDong hopDong = HopDongDAO.Instance.loadHD(maHD);
            txtMaHD.Text = hopDong.MaHopDong;
            txtMaSV.Text = hopDong.MaSinhVien;
            txtSoPhong.Text = hopDong.SoPhong;
            dtpNL.Text = hopDong.NgayLap;
            dtpNBD.Text = hopDong.NgayBatDau;
            dtpNKT.Text = hopDong.NgayKetThuc;
        }

        private void btnHuyHopDong_Click(object sender, EventArgs e)
        {
        }
    }
}
