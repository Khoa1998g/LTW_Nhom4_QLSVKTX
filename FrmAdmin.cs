using QuanLyKTX.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKTX
{
    public partial class FrmAdmin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        public FrmAdmin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            pnlNative.Height = btnQuanLySV.Height;
            pnlNative.Top = btnQuanLySV.Top;
            pnlNative.RightToLeft = btnQuanLySV.RightToLeft;

            lblTile.Text = "Quản Lý Sinh Viên";
            this.pnlFormLoad.Controls.Clear();
            frmQuanLySV fQuanLySV = new frmQuanLySV() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fQuanLySV.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(fQuanLySV);
            fQuanLySV.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            pnlNative.Height = btnDangXuat.Height;
            pnlNative.Top = btnDangXuat.Top;
            pnlNative.RightToLeft = btnDangXuat.RightToLeft;
            btnDangXuat.BackColor = Color.FromArgb(46, 51, 73);
            this.Close();
        }

        private void btnQuanLySV_Click(object sender, EventArgs e)
        {
            pnlNative.Height = btnQuanLySV.Height;
            pnlNative.Top = btnQuanLySV.Top;
            pnlNative.RightToLeft = btnQuanLySV.RightToLeft;
            btnQuanLySV.BackColor = Color.FromArgb(46, 51, 73);

            lblTile.Text = "Quản Lý Sinh Viên";
            this.pnlFormLoad.Controls.Clear();
            frmQuanLySV fQuanLySV = new frmQuanLySV() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fQuanLySV.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(fQuanLySV);
            fQuanLySV.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            pnlNative.Height = btnThongKe.Height;
            pnlNative.Top = btnThongKe.Top;
            pnlNative.RightToLeft = btnThongKe.RightToLeft;
            btnThongKe.BackColor = Color.FromArgb(46, 51, 73);

            lblTile.Text = "Thống Kê";
            this.pnlFormLoad.Controls.Clear();
            frmThongKe fThongKe = new frmThongKe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fThongKe.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(fThongKe);
            fThongKe.Show();
        }

        private void btnQuanLyHD_Click(object sender, EventArgs e)
        {
            pnlNative.Height = btnQuanLyPhong.Height;
            pnlNative.Top = btnQuanLyPhong.Top;
            pnlNative.RightToLeft = btnQuanLyPhong.RightToLeft;
            btnQuanLyPhong.BackColor = Color.FromArgb(46, 51, 73);

            lblTile.Text = "Quản Lý Phòng";
            this.pnlFormLoad.Controls.Clear();
            frmQuanLyPhong fHopDong = new frmQuanLyPhong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fHopDong.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(fHopDong);
            fHopDong.Show();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            pnlNative.Height = btnThongBao.Height;
            pnlNative.Top = btnThongBao.Top;
            pnlNative.RightToLeft = btnThongBao.RightToLeft;
            btnThongBao.BackColor = Color.FromArgb(46, 51, 73);

            lblTile.Text = "Thông Báo";
            this.pnlFormLoad.Controls.Clear();
            frmThongBao_Admin fTBA = new frmThongBao_Admin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fTBA.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(fTBA);
            fTBA.Show();
        }

        private void btnQuanLySV_Leave(object sender, EventArgs e)
        {
            btnQuanLySV.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnThongKe_Leave(object sender, EventArgs e)
        {
            btnThongKe.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnQuanLyHD_Leave(object sender, EventArgs e)
        {
            btnQuanLyPhong.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnThongBao_Leave(object sender, EventArgs e)
        {
            btnThongBao.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
