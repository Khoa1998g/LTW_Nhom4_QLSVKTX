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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
                txtPassword.PasswordChar =  checkbxShowPas.Checked ? '\0' : '*';
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblTroVeDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string maSV = txtMaSV.Text;
            try
            {
                if (txtEmail.Text == "" || txtPassword.Text == "" || txtMaSV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Đăng kí thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (register(email, password, maSV) == 0)
                {
                    MessageBox.Show("Mã SV chưa được đăng kí, liên hệ quản lý ktx", "Đăng kí thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đăng kí thành công");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Mã SV chưa được đăng kí, liên hệ quản lý ktx", "Đăng kí thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        int register(string email, string password, string maSV)
        {
            return AccountDAO.Instance.register(email, password, maSV);
        }
    }
}
