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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MoneyManagementWinApp
{
    public partial class frmDetailManagement1 : Form
    {
        public frmDetailManagement1()
        {
            InitializeComponent();
        }
        BindingSource source;
        IDataRepository dataRepository = new DataRepository();
        IUserRepository userRepository = new UserRepository();
        public IDatasRepository<Loan> LoanRepository = new DatasRepository<Loan>();
        public IDatasRepository<Borrow> BorrowRepository = new DatasRepository<Borrow>();
        public int Type { get; set; }
        bool update = false;
        private void frmDetailManagement1_Load(object sender, EventArgs e)
        {
            cboYearFrom.DataSource = null;
            cboYearFrom.DataSource = userRepository.GetYears(1);
            cboYearFrom.SelectedIndex = -1;
            cboYearTo.DataSource = null;
            cboYearTo.DataSource = userRepository.GetYears(1);
            cboYearTo.SelectedIndex = -1;
            cboSort.SelectedIndex = -1;
            cboYearFrom.SelectedIndex = -1;
            cboYearFrom.SelectedIndex = -1;

            LoadList();
            Disable(update);
        }
        int? monthFrom, monthTo, yearFrom, yearTo, deadline;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        string sort, search;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNew frmAddNew = new frmAddNew();
            //if (Type == 3)
            //{
                frmAddNew.Text = "Thêm Khoản Cho Vay";
                frmAddNew.LoanRepository = LoanRepository;
                frmAddNew.DataRepository = dataRepository;
                frmAddNew.Type = 3;
            //}
            //if (Type == 4)
            //{
            //    frmAddNew.Text = "Thêm Khoản Đi Vay";
            //    frmAddNew.BorrowRepository = BorrowRepository;
            //    frmAddNew.DataRepository = dataRepository;
            //    frmAddNew.Type = 4;
            //}

            this.Hide();
            frmAddNew.Show();
            this.Show();
            LoadList();
        }

        public Loan GetObjectLoan()
        {
            Loan m = null;
            int id;
            int.TryParse(txtID.Text, out id);
            try
            {
                m = new Loan
                {
                    Id = id,
                    Name = txtName.Text,
                    Describe = txtDescribe.Text,
                    Money = decimal.Parse(txtMoney.Text),
                    Time = DateTime.Parse(dateFrom.Text),
                    Deadline = DateTime.Parse(dateTo.Text),
                    Rate = Int32.Parse(txtRate.Text),
                    Status = ckbDone.Checked,
                    UserId = 1,
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return m;
        }
        public Borrow GetObjectBorrow()
        {
            Borrow m = null;
            int id;
            int.TryParse(txtID.Text, out id);
            try
            {
                m = new Borrow
                {
                    Id = id,
                    Name = txtName.Text,
                    Describe = txtDescribe.Text,
                    Money = decimal.Parse(txtMoney.Text),
                    Time = DateTime.Parse(dateFrom.Text),
                    Deadline = DateTime.Parse(dateTo.Text),
                    Rate = Int32.Parse(txtRate.Text),
                    Status = ckbDone.Checked,
                    UserId = 1,
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return m;
        }

        int countClickUpdate = 1;
        bool isUpdate = false;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (countClickUpdate % 2 != 0)
            {
                isUpdate = true;
                countClickUpdate++;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn update ", "update"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    UpdateExecu();
                    isUpdate = false;
                    countClickUpdate++;
                    LoadList();
                }
            }
            Disable(isUpdate);
        }
        private void UpdateExecu()
        {
            try
            {
                if (Type == 3)
                {
                    var loan = GetObjectLoan();
                    LoanRepository.Update(loan);
                }
                if (Type == 4)
                {
                    var borrow = GetObjectBorrow();
                    BorrowRepository.Update(borrow);
                }

                LoadList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa ", "delete"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int id;
                    int.TryParse(txtID.Text, out id);
                    if (Type == 3)
                        LoanRepository.Delete(id);
                    if (Type == 4)
                        BorrowRepository.Delete(id);
                    LoadList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMoneyManagement frmMoneyManagement= new frmMoneyManagement();
            this.Hide();
            frmMoneyManagement.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            LoadList();
        }

        bool? status=null;

        public void LoadList()
        {
            if (cboMonthFrom.SelectedIndex >= 0)
                monthFrom = Int32.Parse(cboMonthFrom.Text);
            else
                monthFrom = null;

            if (cboMonthTo.SelectedIndex >= 0)
                monthTo = Int32.Parse(cboMonthTo.Text);
            else
                monthTo = null;
            if (cboYearFrom.SelectedIndex >= 0 )
                yearFrom = Int32.Parse(cboYearFrom.Text);
            else
                yearFrom = null;
            if (cboYearTo.SelectedIndex >= 0)
                yearTo = Int32.Parse(cboYearTo.Text);
            else
                yearTo = null;
            if (cboSort.SelectedIndex >= 0)
                sort = cboSort.Text;
            else
                sort = null;
            if (cboStatus.SelectedIndex >= 0)
            {
                string _status = cboStatus.Text;
                if (_status.Equals("Đã trả"))
                    status = true;
                else
                    status = false;
            }
            else
                status = null;
            search = txtSearch.Text;

            var list = dataRepository.GetAllLoan(monthFrom, yearFrom, monthTo, yearTo, sort, search, status, deadline, 1);
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtDescribe.DataBindings.Clear();
                txtMoney.DataBindings.Clear();
                txtRate.DataBindings.Clear();
                dateFrom.DataBindings.Clear();
                dateTo.DataBindings.Clear();
                ckbDone.DataBindings.Clear();

                txtID.Visible = false;

                txtID.DataBindings.Add("Text", source, "Id");
                txtName.DataBindings.Add("Text", source, "Name");
                txtDescribe.DataBindings.Add("Text", source, "Describe");
                txtMoney.DataBindings.Add("Text", source, "Money");
                txtRate.DataBindings.Add("Text", source, "Rate");
                dateFrom.DataBindings.Add("Value", source, "Time");
                dateTo.DataBindings.Add("Value", source, "Deadline");
                ckbDone.DataBindings.Add("Checked", source, "Status");

                dgvData.DataSource = null;
                dgvData.DataSource = source;

                dgvData.Columns[0].Visible = false;
                dgvData.Columns[7].Visible = false;
                dgvData.Columns[9].Visible = false;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Disable(bool status)
        {
            txtID.Enabled = status;
            txtDescribe.Enabled = status;
            txtName.Enabled = status;
            txtRate.Enabled = status;
            dateFrom.Enabled = status;
            dateTo.Enabled = status;
            txtMoney.Enabled = status;
            ckbDone.Enabled = status;
        }

        private void Clear()
        {
            cboSort.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            cboMonthFrom.SelectedIndex = -1;
            cboMonthTo.SelectedIndex = -1;
            cboYearFrom.SelectedIndex = -1;
            cboYearTo.SelectedIndex = -1;
            txtSearch.Clear();
            cboDeadline.SelectedIndex = -1;
        }
    }
}
