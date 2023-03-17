namespace MoneyManagementWinApp
{
    partial class frmDetailManagement
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartDetail = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbTimeChose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnApp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboYearComp = new System.Windows.Forms.ComboBox();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.cboMonthComp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDescribe = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboCateDetail = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lbNameMain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(720, 3);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 29;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(445, 427);
            this.dgvData.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartDetail);
            this.panel1.Controls.Add(this.dgvData);
            this.panel1.Location = new System.Drawing.Point(10, 363);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 433);
            this.panel1.TabIndex = 0;
            // 
            // chartDetail
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDetail.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDetail.Legends.Add(legend1);
            this.chartDetail.Location = new System.Drawing.Point(3, 3);
            this.chartDetail.Name = "chartDetail";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDetail.Series.Add(series1);
            this.chartDetail.Size = new System.Drawing.Size(711, 428);
            this.chartDetail.TabIndex = 1;
            this.chartDetail.Text = "chart1";
            // 
            // lbTimeChose
            // 
            this.lbTimeChose.AutoSize = true;
            this.lbTimeChose.Location = new System.Drawing.Point(147, 5);
            this.lbTimeChose.Name = "lbTimeChose";
            this.lbTimeChose.Size = new System.Drawing.Size(71, 20);
            this.lbTimeChose.TabIndex = 0;
            this.lbTimeChose.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClearAll);
            this.panel3.Controls.Add(this.btnApp);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cboYearComp);
            this.panel3.Controls.Add(this.cboSort);
            this.panel3.Controls.Add(this.cboYear);
            this.panel3.Controls.Add(this.cboCate);
            this.panel3.Controls.Add(this.cboMonthComp);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cboMonth);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lbTimeChose);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(10, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 195);
            this.panel3.TabIndex = 2;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(355, 153);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(94, 29);
            this.btnClearAll.TabIndex = 11;
            this.btnClearAll.Text = "Xóa hết";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnApp
            // 
            this.btnApp.Location = new System.Drawing.Point(224, 153);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(94, 29);
            this.btnApp.TabIndex = 10;
            this.btnApp.Text = "Áp dụng";
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 75);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "so sánh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sắp xếp";
            // 
            // cboYearComp
            // 
            this.cboYearComp.FormattingEnabled = true;
            this.cboYearComp.Location = new System.Drawing.Point(224, 111);
            this.cboYearComp.Name = "cboYearComp";
            this.cboYearComp.Size = new System.Drawing.Size(85, 28);
            this.cboYearComp.TabIndex = 8;
            this.cboYearComp.SelectedIndexChanged += new System.EventHandler(this.cboYearComp_SelectedIndexChanged);
            // 
            // cboSort
            // 
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Items.AddRange(new object[] {
            "asc",
            "desc"});
            this.cboSort.Location = new System.Drawing.Point(423, 109);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(233, 28);
            this.cboSort.TabIndex = 8;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(224, 33);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(85, 28);
            this.cboYear.TabIndex = 7;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // cboCate
            // 
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(423, 70);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(233, 28);
            this.cboCate.TabIndex = 7;
            this.cboCate.SelectedIndexChanged += new System.EventHandler(this.cboCate_SelectedIndexChanged);
            // 
            // cboMonthComp
            // 
            this.cboMonthComp.FormattingEnabled = true;
            this.cboMonthComp.Items.AddRange(new object[] {
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
            this.cboMonthComp.Location = new System.Drawing.Point(78, 111);
            this.cboMonthComp.Name = "cboMonthComp";
            this.cboMonthComp.Size = new System.Drawing.Size(85, 28);
            this.cboMonthComp.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Danh mục";
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
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
            this.cboMonth.Location = new System.Drawing.Point(78, 33);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(85, 28);
            this.cboMonth.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Năm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(341, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(315, 27);
            this.txtSearch.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tháng";
            // 
            // lbDescribe
            // 
            this.lbDescribe.AutoSize = true;
            this.lbDescribe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescribe.Location = new System.Drawing.Point(29, 21);
            this.lbDescribe.Name = "lbDescribe";
            this.lbDescribe.Size = new System.Drawing.Size(93, 23);
            this.lbDescribe.TabIndex = 0;
            this.lbDescribe.Text = "Chú thích: ";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMoney.Location = new System.Drawing.Point(55, 68);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(67, 23);
            this.lbMoney.TabIndex = 1;
            this.lbMoney.Text = "Số tiền:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTime.Location = new System.Drawing.Point(37, 117);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(85, 23);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "Thời gian:";
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(128, 17);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(329, 34);
            this.txtDescribe.TabIndex = 4;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(128, 64);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(329, 27);
            this.txtMoney.TabIndex = 5;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(128, 113);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(329, 27);
            this.txtTime.TabIndex = 6;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(40, 205);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(82, 20);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.Text = "Trạng thái: ";
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Location = new System.Drawing.Point(128, 201);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(70, 24);
            this.ckbStatus.TabIndex = 8;
            this.ckbStatus.Text = "đã trả";
            this.ckbStatus.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboCateDetail);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Controls.Add(this.ckbStatus);
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.txtTime);
            this.panel2.Controls.Add(this.txtMoney);
            this.panel2.Controls.Add(this.txtDescribe);
            this.panel2.Controls.Add(this.lbTime);
            this.panel2.Controls.Add(this.lbMoney);
            this.panel2.Controls.Add(this.lbDescribe);
            this.panel2.Location = new System.Drawing.Point(675, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 312);
            this.panel2.TabIndex = 1;
            // 
            // cboCateDetail
            // 
            this.cboCateDetail.FormattingEnabled = true;
            this.cboCateDetail.Location = new System.Drawing.Point(128, 158);
            this.cboCateDetail.Name = "cboCateDetail";
            this.cboCateDetail.Size = new System.Drawing.Size(329, 28);
            this.cboCateDetail.TabIndex = 15;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(363, 202);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(94, 27);
            this.txtID.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(29, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Danh mục:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(363, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(207, 253);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(40, 253);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(94, 29);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "Thêm";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lbNameMain
            // 
            this.lbNameMain.AutoSize = true;
            this.lbNameMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNameMain.Location = new System.Drawing.Point(254, 72);
            this.lbNameMain.Name = "lbNameMain";
            this.lbNameMain.Size = new System.Drawing.Size(161, 28);
            this.lbNameMain.TabIndex = 7;
            this.lbNameMain.Text = "Thống kê chi tiêu";
            // 
            // frmDetailManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 806);
            this.Controls.Add(this.lbNameMain);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDetailManagement";
            this.Text = "frmDetailManagement";
            this.Load += new System.EventHandler(this.frmDetailManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private DataGridView dgvData;
        private Panel panel1;
        private Label lbTimeChose;
        private Label label2;
        private Panel panel3;
        private Button btnClearAll;
        private Button btnApp;
        private Label label8;
        private ComboBox cboSort;
        private ComboBox cboCate;
        private Label label7;
        private TextBox txtSearch;
        private Label label6;
        private Label label5;
        private ComboBox cboYearComp;
        private ComboBox cboYear;
        private ComboBox cboMonthComp;
        private ComboBox cboMonth;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label lbDescribe;
        private Label lbMoney;
        private Label lbTime;
        private TextBox txtDescribe;
        private TextBox txtMoney;
        private TextBox txtTime;
        private Label lbStatus;
        private CheckBox ckbStatus;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDetail;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAddNew;
        private Label lbNameMain;
        private Label label9;
        private TextBox txtID;
        private ComboBox cboCateDetail;
    }
}