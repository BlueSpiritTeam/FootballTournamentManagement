﻿using SourceCode.DAO;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUserName.Text = "admin1";
            txtPassword.Text = "1";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;

            AccountDTO login = new AccountDTO(userName, passWord);
            if (String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Please Enter a username!");
                this.txtUserName.Select();
                this.txtUserName.Focus();
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password!");
                this.txtPassword.Select();
                this.txtPassword.Focus();
            }
            else if (loginCheck(login))
            {
                this.Hide();
                frmGeneral general = new frmGeneral();
                general.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password does not match that user! Please try another password!");
            }
        }

        bool loginCheck(AccountDTO login)
        {
            return AccountDAO.Instance.Login(login);
        }
    }
}
