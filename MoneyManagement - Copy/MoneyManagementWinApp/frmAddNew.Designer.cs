namespace MoneyManagementWinApp
{
    partial class frmAddNew
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
            this.lbDescribe = new System.Windows.Forms.Label();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lbMoney = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lbCate = new System.Windows.Forms.Label();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDeadline = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDescribe
            // 
            this.lbDescribe.AutoSize = true;
            this.lbDescribe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescribe.Location = new System.Drawing.Point(70, 19);
            this.lbDescribe.Name = "lbDescribe";
            this.lbDescribe.Size = new System.Drawing.Size(40, 23);
            this.lbDescribe.TabIndex = 0;
            this.lbDescribe.Text = "Tên:";
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(123, 15);
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(347, 27);
            this.txtDescribe.TabIndex = 1;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTime.Location = new System.Drawing.Point(22, 121);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(85, 23);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Thời gian:";
            this.lbTime.Click += new System.EventHandler(this.lbTime_Click);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(123, 117);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(347, 27);
            this.dateTime.TabIndex = 3;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMoney.Location = new System.Drawing.Point(43, 215);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(67, 23);
            this.lbMoney.TabIndex = 4;
            this.lbMoney.Text = "Số tiền:";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(123, 211);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(347, 27);
            this.txtMoney.TabIndex = 5;
            // 
            // lbCate
            // 
            this.lbCate.AutoSize = true;
            this.lbCate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCate.Location = new System.Drawing.Point(17, 265);
            this.lbCate.Name = "lbCate";
            this.lbCate.Size = new System.Drawing.Size(93, 23);
            this.lbCate.TabIndex = 6;
            this.lbCate.Text = "Danh mục:";
            // 
            // cboCate
            // 
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(123, 260);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(347, 28);
            this.cboCate.TabIndex = 7;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(22, 15);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(23, 27);
            this.txtUserID.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(123, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(376, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(123, 66);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(347, 27);
            this.txtMoTa.TabIndex = 11;
            this.txtMoTa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mô tả:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateDeadline
            // 
            this.dateDeadline.Location = new System.Drawing.Point(123, 167);
            this.dateDeadline.Name = "dateDeadline";
            this.dateDeadline.Size = new System.Drawing.Size(347, 27);
            this.dateDeadline.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hạn trả:";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(123, 307);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(167, 27);
            this.txtRate.TabIndex = 15;
            this.txtRate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(65, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tỉ lệ:";
            // 
            // frmAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 409);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.dateDeadline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.cboCate);
            this.Controls.Add(this.lbCate);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.lbDescribe);
            this.Name = "frmAddNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNew";
            this.Load += new System.EventHandler(this.frmAddNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbDescribe;
        private TextBox txtDescribe;
        private Label lbTime;
        private DateTimePicker dateTime;
        private Label lbMoney;
        private TextBox txtMoney;
        private Label lbCate;
        private ComboBox cboCate;
        private TextBox txtUserID;
        private Button btnAdd;
        private Button btnCancel;
        private TextBox txtMoTa;
        private Label label1;
        private DateTimePicker dateDeadline;
        private Label label2;
        private TextBox txtRate;
        private Label label3;
    }
}