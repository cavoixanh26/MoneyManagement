namespace MoneyManagementWinApp
{
    partial class frmDetailManagement1
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboYearTo = new System.Windows.Forms.ComboBox();
            this.cboMonthTo = new System.Windows.Forms.ComboBox();
            this.cboYearFrom = new System.Windows.Forms.ComboBox();
            this.cboMonthFrom = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.lbSort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDeadline = new System.Windows.Forms.ComboBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.ckbDone = new System.Windows.Forms.CheckBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbRate = new System.Windows.Forms.Label();
            this.lnMoney = new System.Windows.Forms.Label();
            this.lbDeadline = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDescribe = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.cboYearTo);
            this.panel3.Controls.Add(this.cboMonthTo);
            this.panel3.Controls.Add(this.cboYearFrom);
            this.panel3.Controls.Add(this.cboMonthFrom);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.cboStatus);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cboSort);
            this.panel3.Controls.Add(this.lbSort);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cboDeadline);
            this.panel3.Controls.Add(this.lbTo);
            this.panel3.Controls.Add(this.lbFrom);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.lbSearch);
            this.panel3.Controls.Add(this.lbTitle);
            this.panel3.Location = new System.Drawing.Point(12, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 307);
            this.panel3.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(334, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Xóa hết";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboYearTo
            // 
            this.cboYearTo.FormattingEnabled = true;
            this.cboYearTo.Location = new System.Drawing.Point(500, 98);
            this.cboYearTo.Name = "cboYearTo";
            this.cboYearTo.Size = new System.Drawing.Size(76, 28);
            this.cboYearTo.TabIndex = 30;
            // 
            // cboMonthTo
            // 
            this.cboMonthTo.FormattingEnabled = true;
            this.cboMonthTo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboMonthTo.Location = new System.Drawing.Point(406, 98);
            this.cboMonthTo.Name = "cboMonthTo";
            this.cboMonthTo.Size = new System.Drawing.Size(76, 28);
            this.cboMonthTo.TabIndex = 29;
            // 
            // cboYearFrom
            // 
            this.cboYearFrom.FormattingEnabled = true;
            this.cboYearFrom.Location = new System.Drawing.Point(252, 98);
            this.cboYearFrom.Name = "cboYearFrom";
            this.cboYearFrom.Size = new System.Drawing.Size(76, 28);
            this.cboYearFrom.TabIndex = 28;
            // 
            // cboMonthFrom
            // 
            this.cboMonthFrom.FormattingEnabled = true;
            this.cboMonthFrom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboMonthFrom.Location = new System.Drawing.Point(160, 98);
            this.cboMonthFrom.Name = "cboMonthFrom";
            this.cboMonthFrom.Size = new System.Drawing.Size(76, 28);
            this.cboMonthFrom.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(160, 251);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Áp dụng";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Đã trả",
            "Chưa trả"});
            this.cboStatus.Location = new System.Drawing.Point(160, 194);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(168, 28);
            this.cboStatus.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tình trạng";
            // 
            // cboSort
            // 
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Items.AddRange(new object[] {
            "Tang",
            "Giam"});
            this.cboSort.Location = new System.Drawing.Point(406, 150);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(170, 28);
            this.cboSort.TabIndex = 24;
            // 
            // lbSort
            // 
            this.lbSort.AutoSize = true;
            this.lbSort.Location = new System.Drawing.Point(338, 155);
            this.lbSort.Name = "lbSort";
            this.lbSort.Size = new System.Drawing.Size(62, 20);
            this.lbSort.TabIndex = 23;
            this.lbSort.Text = "Sắp xếp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thời gian hạn còn";
            // 
            // cboDeadline
            // 
            this.cboDeadline.FormattingEnabled = true;
            this.cboDeadline.Items.AddRange(new object[] {
            "7",
            "30",
            "60",
            "90"});
            this.cboDeadline.Location = new System.Drawing.Point(160, 147);
            this.cboDeadline.Name = "cboDeadline";
            this.cboDeadline.Size = new System.Drawing.Size(168, 28);
            this.cboDeadline.TabIndex = 21;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(334, 106);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(66, 20);
            this.lbTo.TabIndex = 19;
            this.lbTo.Text = "Ngày trả";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(43, 106);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(87, 20);
            this.lbFrom.TabIndex = 17;
            this.lbFrom.Text = "Ngày mượn";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(160, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(416, 27);
            this.txtSearch.TabIndex = 16;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(60, 55);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(70, 20);
            this.lbSearch.TabIndex = 15;
            this.lbSearch.Text = "Tìm kiếm";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(160, 8);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(203, 28);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "khác khoản vay mượn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.dateTo);
            this.panel2.Controls.Add(this.dateFrom);
            this.panel2.Controls.Add(this.ckbDone);
            this.panel2.Controls.Add(this.txtRate);
            this.panel2.Controls.Add(this.txtMoney);
            this.panel2.Controls.Add(this.txtDescribe);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.lbRate);
            this.panel2.Controls.Add(this.lnMoney);
            this.panel2.Controls.Add(this.lbDeadline);
            this.panel2.Controls.Add(this.lbTime);
            this.panel2.Controls.Add(this.lbDescribe);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Location = new System.Drawing.Point(602, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 307);
            this.panel2.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(252, 195);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(50, 27);
            this.txtID.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(313, 251);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(93, 117);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(327, 27);
            this.dateTo.TabIndex = 13;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(93, 72);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(327, 27);
            this.dateFrom.TabIndex = 12;
            // 
            // ckbDone
            // 
            this.ckbDone.AutoSize = true;
            this.ckbDone.Location = new System.Drawing.Point(323, 197);
            this.ckbDone.Name = "ckbDone";
            this.ckbDone.Size = new System.Drawing.Size(70, 24);
            this.ckbDone.TabIndex = 11;
            this.ckbDone.Text = "đã trả";
            this.ckbDone.UseVisualStyleBackColor = true;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(93, 194);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(123, 27);
            this.txtRate.TabIndex = 10;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(93, 155);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(327, 27);
            this.txtMoney.TabIndex = 9;
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(93, 37);
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(327, 27);
            this.txtDescribe.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 27);
            this.txtName.TabIndex = 7;
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Location = new System.Drawing.Point(10, 197);
            this.lbRate.Name = "lbRate";
            this.lbRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRate.Size = new System.Drawing.Size(77, 20);
            this.lbRate.TabIndex = 5;
            this.lbRate.Text = "phần trăm";
            // 
            // lnMoney
            // 
            this.lnMoney.AutoSize = true;
            this.lnMoney.Location = new System.Drawing.Point(32, 158);
            this.lnMoney.Name = "lnMoney";
            this.lnMoney.Size = new System.Drawing.Size(55, 20);
            this.lnMoney.TabIndex = 4;
            this.lnMoney.Text = "Số tiền";
            // 
            // lbDeadline
            // 
            this.lbDeadline.AutoSize = true;
            this.lbDeadline.Location = new System.Drawing.Point(51, 117);
            this.lbDeadline.Name = "lbDeadline";
            this.lbDeadline.Size = new System.Drawing.Size(36, 20);
            this.lbDeadline.TabIndex = 3;
            this.lbDeadline.Text = "Hạn";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(16, 77);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(71, 20);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Thời gian";
            // 
            // lbDescribe
            // 
            this.lbDescribe.AutoSize = true;
            this.lbDescribe.Location = new System.Drawing.Point(39, 40);
            this.lbDescribe.Name = "lbDescribe";
            this.lbDescribe.Size = new System.Drawing.Size(48, 20);
            this.lbDescribe.TabIndex = 1;
            this.lbDescribe.Text = "Mô tả";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(55, 8);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(32, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvData);
            this.panel1.Location = new System.Drawing.Point(12, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 336);
            this.panel1.TabIndex = 5;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(3, 3);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 29;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1013, 333);
            this.dgvData.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmDetailManagement1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 697);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Name = "frmDetailManagement1";
            this.Text = "frmDetailManagement1";
            this.Load += new System.EventHandler(this.frmDetailManagement1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Button btnSearch;
        private ComboBox cboStatus;
        private Label label2;
        private ComboBox cboSort;
        private Label lbSort;
        private Label label1;
        private ComboBox cboDeadline;
        private Label lbTo;
        private Label lbFrom;
        private TextBox txtSearch;
        private Label lbSearch;
        private Label lbTitle;
        private Panel panel2;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private DateTimePicker dateTo;
        private DateTimePicker dateFrom;
        private CheckBox ckbDone;
        private TextBox txtRate;
        private TextBox txtMoney;
        private TextBox txtDescribe;
        private TextBox txtName;
        private Label lbRate;
        private Label lnMoney;
        private Label lbDeadline;
        private Label lbTime;
        private Label lbDescribe;
        private Label lbName;
        private Panel panel1;
        private DataGridView dgvData;
        private Button btnBack;
        private ComboBox cboYearTo;
        private ComboBox cboMonthTo;
        private ComboBox cboYearFrom;
        private ComboBox cboMonthFrom;
        private TextBox txtID;
        private Button btnClear;
    }
}