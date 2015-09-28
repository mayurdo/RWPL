using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Base.Software.Helper;
using RWPLLinqDataService;

namespace Base.Software
{
    public partial class Login : Form
    {
        private IServices _services;

        public bool IsSuccessLogin { get; set; }

        public Login()
        {
            InitializeComponent();

            IsSuccessLogin = false;
            _services = new WinServices(typeof(User).Name);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var response = _services.CustomServiceResponse<User>("GetUser", txtExecutiveName.Text, txtPassword.Text);

            if (!response.IsSuccess)
            {
                MessageBox.Show(response.Exception.Message, @"Error Message");
                this.Close();
            }

            if (response.Object == null)
            {
                MessageBox.Show(@"User name and Password not match, Please try again", @"Validation Message");
                return;
            }

            PageHelper.UserDetail = response.Object;
            IsSuccessLogin = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
