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
                else if(isValidMail(txtEmail.Text)== false || isValidPass(txtPassword.Text) == false || isValidID(txtMaSV.Text)== false )
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng", "Đăng kí thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        bool isValidMail(string email)
        {
            return AccountDAO.Instance.IsValidMail(email);
        }
        bool isValidPass(string password)
        {
            return AccountDAO.Instance.IsValidPassword(password);
        }
        bool isValidID(string maSV)
        {
            return AccountDAO.Instance.IsValidID(maSV);
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (isValidMail(txtEmail.Text.Trim()))
                {
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(txtEmail, "Email Không Hợp Lệ!");
                    MessageBox.Show("Email sai định dạng", "Cần nhập lại email");
                }
            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (isValidMail(txtEmail.Text.Trim()))
            {
                errorProvider1.Clear();            
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Email Không Hợp Lệ!");
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 )
            {
                if (isValidPass(txtPassword.Text.Trim())== false)
                {
                    errorProvider2.SetError(txtPassword, "Mật khẩu chưa Hợp Lệ!");
                    MessageBox.Show("Mật khẩu cần có độ dài từ 6-20 kí tự\nCó cả chữ và số", "Cần đặt lại mật khẩu");                    
                }
                else
                {
                    errorProvider2.Clear();
                }
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (isValidPass(txtPassword.Text.Trim()) == false)
            {
                errorProvider2.SetError(txtPassword, "Mật khẩu chưa Hợp Lệ!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

    }
}
