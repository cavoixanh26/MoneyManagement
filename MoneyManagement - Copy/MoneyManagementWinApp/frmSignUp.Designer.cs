namespace MoneyManagementWinApp
{
    partial class frmSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbPasswordConf = new System.Windows.Forms.Label();
            this.lbDoB = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordCf = new System.Windows.Forms.TextBox();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.ckbShowPass = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(66, 63);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(89, 20);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User Name: ";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(82, 108);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(73, 20);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password:";
            // 
            // lbPasswordConf
            // 
            this.lbPasswordConf.AutoSize = true;
            this.lbPasswordConf.Location = new System.Drawing.Point(25, 153);
            this.lbPasswordConf.Name = "lbPasswordConf";
            this.lbPasswordConf.Size = new System.Drawing.Size(130, 20);
            this.lbPasswordConf.TabIndex = 2;
            this.lbPasswordConf.Text = "Password Confirm:";
            // 
            // lbDoB
            // 
            this.lbDoB.AutoSize = true;
            this.lbDoB.Location = new System.Drawing.Point(61, 198);
            this.lbDoB.Name = "lbDoB";
            this.lbDoB.Size = new System.Drawing.Size(94, 20);
            this.lbDoB.TabIndex = 3;
            this.lbDoB.Text = "Date of birth";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(179, 60);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(252, 27);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(179, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPasswordCf
            // 
            this.txtPasswordCf.Location = new System.Drawing.Point(179, 150);
            this.txtPasswordCf.Name = "txtPasswordCf";
            this.txtPasswordCf.Size = new System.Drawing.Size(252, 27);
            this.txtPasswordCf.TabIndex = 6;
            this.txtPasswordCf.UseSystemPasswordChar = true;
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Location = new System.Drawing.Point(179, 193);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(252, 27);
            this.dateTimeDOB.TabIndex = 8;
            // 
            // ckbShowPass
            // 
            this.ckbShowPass.AutoSize = true;
            this.ckbShowPass.Location = new System.Drawing.Point(299, 226);
            this.ckbShowPass.Name = "ckbShowPass";
            this.ckbShowPass.Size = new System.Drawing.Size(132, 24);
            this.ckbShowPass.TabIndex = 9;
            this.ckbShowPass.Text = "Show Password";
            this.ckbShowPass.UseVisualStyleBackColor = true;
            this.ckbShowPass.CheckedChanged += new System.EventHandler(this.ckbShowPass_CheckedChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(179, 256);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(94, 29);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(337, 256);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 327);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.ckbShowPass);
            this.Controls.Add(this.dateTimeDOB);
            this.Controls.Add(this.txtPasswordCf);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lbDoB);
            this.Controls.Add(this.lbPasswordConf);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbUserName;
        private Label lbPassword;
        private Label lbPasswordConf;
        private Label lbDoB;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtPasswordCf;
        private DateTimePicker dateTimeDOB;
        private CheckBox ckbShowPass;
        private Button btnSignUp;
        private Button btnBack;
    }
}