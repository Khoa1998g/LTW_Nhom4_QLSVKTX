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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace QuanLyKTX
{
    public partial class frmQuanLySV : Form
    {
        public frmQuanLySV()
        {
            InitializeComponent();
            loadSinhVienList();
        }
        void loadSinhVienList()
        {
            string query = "select masv as [Mã Sinh Viên], hoten as [Họ Tên], ngaysinh as [Ngày Sinh], cmnd as [CMND], sdt as [Số Điện Thoại], gioitinh as [Giới Tính] from sinhvien";
            dgvSV.DataSource = dataProvider.Instance.ExecuteQuery(query);
            dgvSV.RowTemplate.Height = 50;
            panel1.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Enabled = true;
            txtMaSV.Enabled = false;
            btnHuy.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSV.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtHoten.Text = row.Cells[1].Value.ToString();
                dtpNgaySinh.Text = row.Cells[2].Value.ToString();
                txtCMND.Text = row.Cells[3].Value.ToString();
                txtDienThoai.Text = row.Cells[4].Value.ToString();
                cbGioiTinh.Text = row.Cells[5].Value.ToString();
            }

        }
        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSV_CellContentClick(sender, e);
        }
        private void xoa()
        {
            txtMaSV.Clear();
            txtHoten.Clear();
            txtCMND.Clear();
            txtDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            cbGioiTinh.SelectedIndex = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xoa();
            panel1.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        bool IsValidVietNamPhoneNumber(string phoneNum)
        {
            return AccountDAO.Instance.IsValidVietNamPhoneNumber(phoneNum);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string Id = txtMaSV.Text;
            string Name = txtHoten.Text;
            string Birth = dtpNgaySinh.Value.ToShortDateString();
            string Phone = txtDienThoai.Text;
            string CMND = txtCMND.Text;
            string GioiTinh = cbGioiTinh.Text;
            string query = "SET DATEFORMAT dmy; insert into sinhvien values('" + Id + "',N'" + Name + "'," + Birth + ",'" + GioiTinh + "','" + CMND + "','" + Phone + "')";
            int i = dataProvider.Instance.ExecuteNonQuery(query);
            try
            {
                if (i == 1)
                {
                    MessageBox.Show("Lưu Thành Công");
                    loadSinhVienList();
                    dgvSV.Refresh();
                    return;
                }
                else
                {
                    MessageBox.Show("Nhấn OK để thoát", "Kết nối thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kết nối thất bại",ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaSV.Text;
            string query = "delete from sinhvien where masv = '" + id + "'";
            int i = dataProvider.Instance.ExecuteNonQuery(query);
            if (i == 1)
            {
                MessageBox.Show("Xoá Thành Công");
                loadSinhVienList();
                dgvSV.Refresh();
                return;
            }
            else
            {
                MessageBox.Show("Nhấn OK để thoát", "Kết nối thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            xoa();
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            string Id = txtMaSV.Text;
            string Name = txtHoten.Text;
            string Birth = dtpNgaySinh.Value.ToShortDateString();
            string Phone = txtDienThoai.Text;
            string CMND = txtCMND.Text;
            string GioiTinh = cbGioiTinh.Text;

            string query = " SET DATEFORMAT dmy; update sinhvien " +
                " set hoten = N'"+Name+"', ngaysinh = '"+Birth+"', gioitinh = '"+GioiTinh+"', cmnd = '"+CMND+"', sdt = '"+Phone+"'" +
                " where masv = '"+Id+"'";
            int i = dataProvider.Instance.ExecuteNonQuery(query);
            if (i == 1)
            {
                MessageBox.Show("Sửa Thành Công");
                loadSinhVienList();
                dgvSV.Refresh();
                return;
            }
            else
            {
                MessageBox.Show("Nhấn OK để thoát", "Kết nối thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = " Tìm tên sinh viên...";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string query = "select masv as [Mã Sinh Viên], hoten as [Họ Tên], ngaysinh as [Ngày Sinh], cmnd as [CMND], sdt as [Số Điện Thoại], gioitinh as [Giới Tính] " +
                    " from sinhvien where hoten LIKE N'%"+txtSearch.Text+"%'";
                dgvSV.DataSource = dataProvider.Instance.ExecuteQuery(query);
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 9)
            {
                if (IsValidVietNamPhoneNumber(txtDienThoai.Text.Trim()))
                {
                    erSDT.Clear();
                }
                else
                {
                    erSDT.SetError(txtDienThoai, "SĐT Không Hợp Lệ!");
                }
            }
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (IsValidVietNamPhoneNumber(txtDienThoai.Text.Trim()))
            {
                erSDT.Clear();
            }
            else
            {
                erSDT.SetError(txtDienThoai, "SĐT Không Hợp Lệ!");
            }
        }
    }
}
