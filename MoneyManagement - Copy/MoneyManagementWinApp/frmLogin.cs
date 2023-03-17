using MoneyManagementLibrary.DataAccess;
using MoneyManagementLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManagementWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        IUserRepository userRepository = new UserRepository();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;    
            User user= userRepository.GetUserByNameAndPass(username, password);

            if (user != null)
            {
                frmMoneyManagement frmMoneyManagement = new frmMoneyManagement
                {
                    UserInfo = user,
                };
                this.Hide();
                frmMoneyManagement.ShowDialog();
                this.Show();
            } else
            {
                var _user = userRepository.GetUserByName(username);
                if (_user != null)
                {
                    MessageBox.Show("Password Incorrect.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("The User Name does not already exists.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar= !ckbShowPass.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
          =>  Close();
         

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp();
            this.Hide();
            frmSignUp.ShowDialog();
            this.Show();
        }
    }
}
