using Microsoft.IdentityModel.Tokens;
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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        IUserRepository userRepository = new UserRepository();  

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckbShowPass.Checked;
            txtPasswordCf.UseSystemPasswordChar = !ckbShowPass.Checked;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            User user = userRepository.GetUserByName(username);

            if (user == null)
            {
                var password = txtPassword.Text;
                var passwordCf = txtPasswordCf.Text;
                if (password.Equals(passwordCf) )
                {
                    if (!IsEmpty(txtUserName.Text, txtPassword.Text))
                    {
                        userRepository.InsertUser(new User
                        {
                            Name = txtUserName.Text,
                            Password = txtPassword.Text,
                            DateOfBirth = dateTimeDOB.Value,
                        });
                        frmMoneyManagement frmMoneyManagement = new frmMoneyManagement();
                        this.Hide();
                        frmMoneyManagement.ShowDialog();
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please enter information in the box");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Confirm Password Incorrect");
                }
            }
            else
            {
                    MessageBox.Show("The User Name already exists.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsEmpty(string name, string password)
        {
            if (name.IsNullOrEmpty() || password.IsNullOrEmpty())
                return true;
            return false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
