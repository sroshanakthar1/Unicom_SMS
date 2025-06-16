﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_2025_06_02.Controllers;
using WinFormsApp_2025_06_02.Models;
using WinFormsApp_2025_06_02.Views;

namespace WinFormsApp_2025_06_02
{
    public partial class LoginForm : Form
    {
        private readonly UserController _userController;
        public LoginForm()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OnLogin(object sender, EventArgs e)
        {

            string username = userNameTxt.Text.Trim();
            string password = passwordTxt.Text;

            // Hardcoded credentials
            string validUsername = "admin";
            string validPassword = "12345";

            if (username == validUsername && password == validPassword)
            {
                // Success — open MainForm
                UserView userView = new UserView();
                userView.Show();
                this.Hide();
            }
            else
            {
                Credentials credentials = new Credentials();
                credentials.Username = username;
                credentials.Password = password;
                var result = _userController.Login(credentials);
                if (result)
                {
                    UserView userView = new UserView();
                    userView.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Optionally clear fields
                    userNameTxt.Clear();
                    userNameTxt.Focus();
                }
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
