using App.Common;
using App.Services;
using App.Views.HomeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Views.LoginView
{
    public partial class frmLogin : Form
    {
        private UserService _userService; 
        public frmLogin()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        #endregion

        #region Methods
        private void Login()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string password = Encryptor.MD5Hash(txtPassword.Text);
                var user = _userService.Login(txtUsername.Text, password);

                if (user != null)
                {
                    frmHome frmHome = new frmHome();
                    this.Hide();
                    frmHome.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Đăng nhập thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

        }
        #endregion

    }
}
