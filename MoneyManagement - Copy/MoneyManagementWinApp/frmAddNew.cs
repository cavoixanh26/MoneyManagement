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
    public partial class frmAddNew : Form
    {
        public frmAddNew()
        {
            InitializeComponent();
        }

        public IDatasRepository<Income> IncomeRepository { get; set; }
        public IDatasRepository<Spend> SpendRepository { get; set; }
        public IDatasRepository<Loan> LoanRepository { get; set; }  
        public IDatasRepository<Borrow> BorrowRepository { get; set; }  
        public IUserRepository userRepository { get; set; }
        public IDataRepository DataRepository { get; set; }
        public int Type { get; set; }

        private void frmAddNew_Load(object sender, EventArgs e)
        {
            txtUserID.Visible = false;
            if (Type == 1)
            {
                Disable(false);
                cboCate.DataSource = null;
                cboCate.DataSource = DataRepository.GetCateIncome();
                cboCate.SelectedIndex = 0;
            }
            if (Type == 2)
            {
                Disable(false);
                cboCate.DataSource = null;
                cboCate.DataSource = DataRepository.GetCateSpend();
                cboCate.SelectedIndex = 0;
            }
            if (Type == 3)
            {
                Disable(true);

            }


        }

        private void Disable(bool status)
        {
            txtMoTa.Enabled = status;
            txtRate.Enabled = status;
            dateDeadline.Enabled = status;
            cboCate.Enabled = !status;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckNull(txtDescribe.Text) || CheckNull(txtMoney.Text))
            {
                MessageBox.Show("Điền đủ thông tin.");
            }
            else
            {
                try
                {
                    if (Type == 1)
                    {
                        var income = new Income
                        {
                            Describe = txtDescribe.Text,
                            Money = Decimal.Parse(txtMoney.Text),
                            Time = DateTime.Parse(dateTime.Text),
                            UserId = 1,
                            CateId = DataRepository.GetIDByNameCateIncome(cboCate.Text),
                        };
                        IncomeRepository.Insert(income);
                    }
                    else if (Type == 2)
                    {
                        var spend = new Spend
                        {
                            Describe = txtDescribe.Text,
                            Money = Decimal.Parse(txtMoney.Text),
                            Time = DateTime.Parse(dateTime.Text),
                            UserId = 1,
                            CateId = DataRepository.GetIDByNameCateSpend(cboCate.Text),
                        };
                        SpendRepository.Insert(spend);
                    }
                    else if (Type == 3)
                    {
                        var loan = new Loan
                        {
                            Describe = txtMoTa.Text,
                            Money = Decimal.Parse(txtMoney.Text),
                            Time = DateTime.Parse(dateTime.Text),
                            Deadline = DateTime.Parse(dateDeadline.Text),
                            UserId = 1,
                            Name = txtDescribe.Text,
                            Rate = int.Parse(txtRate.Text),
                        };
                        LoanRepository.Insert(loan);
                    }
                    else if (Type == 4)
                    {
                        var borrow = new Borrow
                        {
                            Describe = txtMoTa.Text,
                            Money = Decimal.Parse(txtMoney.Text),
                            Time = DateTime.Parse(dateTime.Text),
                            Deadline = DateTime.Parse(dateDeadline.Text),
                            UserId = 1,
                            Name = txtDescribe.Text,
                            Rate = int.Parse(txtRate.Text),
                        };
                        BorrowRepository.Insert(borrow);
                    }
                    MessageBox.Show("thêm vào thành công");
                    Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Nhập số vào số tiền");
                }

            }
        }

        private bool CheckNull(string st)
            => st.IsNullOrEmpty() ? true : false;
        private void btnCancel_Click(object sender, EventArgs e)
        => Close();

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
