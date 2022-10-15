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
using System.Runtime.InteropServices;

namespace QuanLyKTX
{
    public partial class frmSinhVien : Form
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
        public frmSinhVien(string email)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            lblTile.Text = "Trang Chủ";
            this.pnlFormLoad.Controls.Clear();
            frmTrangChu fTrangChu = new frmTrangChu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fTrangChu.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(fTrangChu);
            fTrangChu.Show();
            lblMaSV.Text = AccountDAO.Instance.getInfo(email).Rows[0][3].ToString();
            lblName.Text = AccountDAO.Instance.getInfo(email).Rows[0][5].ToString();

    }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            pnlNative.Height = btnTrangChu.Height;
            pnlNative.Top = btnTrangChu.Top;
            pnlNative.RightToLeft = btnTrangChu.RightToLeft;
            btnTrangChu.BackColor = Color.FromArgb(46, 51, 73);

            lblTile.Text = "Trang Chủ";
            this.pnlFormLoad.Controls.Clear();
            frmTrangChu fTrangChu = new frmTrangChu() { Dock = DockStyle.Fill, TopLevel= false, TopMost = true };
            fTrangChu.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(fTrangChu);
            fTrangChu.Show();
        }

        private void btnThongTinSV_Click(object sender, EventArgs e)
        {
            pnlNative.Height = btnThongTinSV.Height;
            pnlNative.Top = btnThongTinSV.Top;
            pnlNative.RightToLeft = btnThongTinSV.RightToLeft;
            btnThongTinSV.BackColor = Color.FromArgb(46, 51, 73);

            lblTile.Text = "Thông tin sinh viên";
            string id = lblMaSV.Text.Trim();
            this.pnlFormLoad.Controls.Clear();
            frmTTSV fTTSV = new frmTTSV(id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fTTSV.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(fTTSV);
            fTTSV.Show();
        }

        private void btnThongTinLuuTru_Click(object sender, EventArgs e)
        {
            pnlNative.Height = btnThongTinLuuTru.Height;
            pnlNative.Top = btnThongTinLuuTru.Top;
            pnlNative.RightToLeft = btnThongTinLuuTru.RightToLeft;
            btnThongTinLuuTru.BackColor = Color.FromArgb(46, 51, 73);

            lblTile.Text = "Thông tin lưu trú";
            this.pnlFormLoad.Controls.Clear();
            string id = lblMaSV.Text.Trim();
            frmTTLuuTru fTTLuuTru = new frmTTLuuTru(id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fTTLuuTru.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(fTTLuuTru);
            fTTLuuTru.Show();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            pnlNative.Height = btnThongBao.Height;
            pnlNative.Top = btnThongBao.Top;
            pnlNative.RightToLeft = btnThongBao.RightToLeft;
            btnThongBao.BackColor = Color.FromArgb(46, 51, 73);

            lblTile.Text = "Thông báo";
            this.pnlFormLoad.Controls.Clear();
            frmThongBao_Admin fThongBao = new frmThongBao_Admin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            fThongBao.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoad.Controls.Add(fThongBao);
            fThongBao.Show();
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            pnlNative.Height = btnDangXuat.Height;
            pnlNative.Top = btnDangXuat.Top;
            pnlNative.RightToLeft = btnDangXuat.RightToLeft;
            btnDangXuat.BackColor = Color.FromArgb(46, 51, 73);
            this.Close();
        }

        private void btnTrangChu_Leave(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnThongTinSV_Leave(object sender, EventArgs e)
        {
            btnThongTinSV.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnThongTinLuuTru_Leave(object sender, EventArgs e)
        {
            btnThongTinLuuTru.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnThongBao_Leave(object sender, EventArgs e)
        {
            btnThongBao.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnDangXuat_Leave(object sender, EventArgs e)
        {
            btnDangXuat.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void frmSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {   //tạo mess box yes/no khi thoát
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }      
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
