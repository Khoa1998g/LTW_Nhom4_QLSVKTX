﻿using QuanLyKTX.DAO;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (login(email, password)==1)
            {
                FrmAdmin f = new FrmAdmin();
                this.Hide();
                f.ShowDialog();
            }
            else if(login(email, password) == 0)
            {
                frmSinhVien f = new frmSinhVien(email);
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu","Mời nhập lại" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int login(string email, string password) 
        { 
            return AccountDAO.Instance.login(email,password); 
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkbxShowPas.Checked ? '\0' : '*';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void lblVaoDangKi_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}