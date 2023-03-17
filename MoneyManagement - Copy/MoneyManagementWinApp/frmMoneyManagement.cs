using Accessibility;
using MoneyManagementLibrary.DataAccess;
using MoneyManagementLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MoneyManagementWinApp
{
    public partial class frmMoneyManagement : Form
    {

        public frmMoneyManagement()
        {
            InitializeComponent();

            // scroll year
            vScrollBarYear.Value = panelYear.VerticalScroll.Value;
            vScrollBarYear.Minimum = panelYear.VerticalScroll.Minimum;
            vScrollBarYear.Maximum = panelYear.VerticalScroll.Maximum;
            vScrollBarYear.Scroll += vScrollBarYear_Scroll;
            panelYear.ControlAdded += panelYear_ControlAdded;

            // scroll month
            vScrollBarMonth.Value = panelMonth.VerticalScroll.Value;
            vScrollBarMonth.Minimum = panelMonth.VerticalScroll.Minimum;
            vScrollBarMonth.Maximum = panelMonth.VerticalScroll.Maximum;
            vScrollBarMonth.Scroll += vScrollBarMonth_Scroll;
            panelMonth.ControlAdded += panelMonth_ControlAdded;

            Add_Month();
            Add_Year();
        }

        IUserRepository userRepository = new UserRepository();
        IDataRepository dataRepository = new DataRepository();
        public User UserInfo { get; set; }
        
        DateTime timeNow = DateTime.Now;
        public int _month;
        public int _year;

        private void frmMoneyManagement_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void LoadAll()
        {
            GetMoneySpend();
            GetMoneyIncome();
            GetMoneyLoan();
            GetMoneyBorrow();
            ChartSpend();
            ChartIncome();
            ChartLoan();
            ChartBorrow();
            lbSaving.Text = (userRepository.GetMoneyIncome(1, _month, _year) 
                + userRepository.GetMoneyLoan(1, _month, _year)
                - userRepository.GetMoneySpend(1, _month, _year) 
                - userRepository.GetMoneyLoan(1, _month, _year)).ToString("0.#");  
        }
        private void panelYear_ControlAdded(object sender, ControlEventArgs e)
        {
            vScrollBarYear.Minimum = panelYear.VerticalScroll.Minimum;
        }

        private void vScrollBarYear_Scroll(object sender, ScrollEventArgs e)
        {
            panelYear.VerticalScroll.Value = vScrollBarYear.Value;
        }

        private void panelMonth_ControlAdded(object sender, ControlEventArgs e)
        {
            vScrollBarMonth.Minimum = panelMonth.VerticalScroll.Minimum;
        }

        private void vScrollBarMonth_Scroll(object sender, ScrollEventArgs e)
        {
            panelMonth.VerticalScroll.Value = vScrollBarMonth.Value;
        }

        private void Add_Month()
        {
            _month = timeNow.Month;
            for(int i= 0; i < 12; i++)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = (i+1).ToString();
                btn.Location = new Point(3 + i%3*(47+10), 3+(i/3)*(40+3));
                btn.Size = new Size(47, 40);
                btn.BackColor = Color.White;
                panelMonth.Controls.Add(btn);
                vScrollBarMonth.Enabled = true;
                btn.Click += ButtonMonth_Clicked;

                if (_month == i+1)
                    btn.BackColor = Color.Violet;
                
            }
        }

        private void ButtonMonth_Clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            clickedButton.BackColor = Color.Violet;
            _month = int.Parse(clickedButton.Text);
            foreach (Control control in panelMonth.Controls)
            {
                if (control is System.Windows.Forms.Button && control != clickedButton)
                {
                    control.BackColor = Color.White;
                } 
                
            }
           LoadAll();
        }
        private void btnClearMonth_Click(object sender, EventArgs e)
        {
            _month = 0;
            foreach (Control control in panelMonth.Controls)
            {
                control.BackColor = Color.White;
            }
            LoadAll();
        }

        private void Add_Year()
        {
            int index = 0;
            _year = timeNow.Year;
            
                var years = userRepository.GetYears(1);
                foreach (int year in years)
                {
                    System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                    button.Text = year.ToString();
                    button.Location = new Point(3 +(index%2)*(77+6), 3+(index/2)*(36+3));
                    button.Size = new Size(77, 36);
                    button.BackColor = Color.White;
                    panelYear.Controls.Add(button);
                    vScrollBarYear.Enabled = true; 
                    button.Click += ButtonYear_Clicked;
                    index++;

                    if (_year == year)
                        button.BackColor = Color.BurlyWood;
                }
            LoadAll();
        }

        private void ButtonYear_Clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            clickedButton.BackColor = Color.BurlyWood;
            _year = int.Parse(clickedButton.Text);
            
            foreach (Control control in panelYear.Controls)
            {
                if (control is System.Windows.Forms.Button && control != clickedButton)
                {
                    control.BackColor = Color.White;
                }
            }
            LoadAll();
        }

        private void ChartSpend()
        {

            chartSpend.Series.Clear();

            // Thêm đối tượng Series thứ nhất
            string nameChartSpend = "Số tiền chi";
            if (chartSpend.Titles.Count == 1)
            {
                chartSpend.Titles.Add("Biểu đồ chi tiêu");
            }
            chartSpend.Series.Add(nameChartSpend);
            chartSpend.Series[nameChartSpend].ChartType = SeriesChartType.Spline;

            var spendData = dataRepository.GetSpends(1, _month, _year);
            foreach (var data in spendData)
            {
                chartSpend.Series[nameChartSpend].Points.AddXY(data.Name, data.Money);
            }

        }

        private void ChartIncome()
        {

            chartIncome.Series.Clear();
            if (chartIncome.Titles.Count == 0)
            {
                chartIncome.Titles.Add("Biểu đồ thu nhập");
            }
            string nameChart = "các khoản thu";
            chartIncome.Series.Add(nameChart);
            chartIncome.Series[nameChart].ChartType = SeriesChartType.Pie;
            var incomeData = dataRepository.GetIncomes(1, _month, _year);
            foreach (var data in incomeData)
            {
                chartIncome.Series[nameChart].Points.AddXY(data.Name, data.Money);
            }
        }

        private void ChartLoan()
        {
            chartLoan.Series.Clear();
            if (chartLoan.Titles.Count == 0)
            {
                chartLoan.Titles.Add("Biểu đồ cho vay");
            }
            string nameChart = " ";
            chartLoan.Series.Add(nameChart);
            chartLoan.Series[nameChart].ChartType = SeriesChartType.Column;
            var loanData = userRepository.GetLoans(1, _month, _year);
            foreach (var data in loanData)
            {
                chartLoan.Series[nameChart].Points.AddXY(data.Name, data.Money);
            }
        }

        private void ChartBorrow()
        {
            chartBorrows.Series.Clear();
            if (chartBorrows.Titles.Count == 1)
            {
                chartBorrows.Titles.Add("Biểu đồ vay");
            }
            string nameChart = " ";
            chartBorrows.Series.Add(nameChart);
            chartBorrows.Series[nameChart].ChartType = SeriesChartType.Column;
            var borrowData = userRepository.GetBorrows(1, _month, _year);
            foreach (var data in borrowData)
            {
                chartBorrows.Series[nameChart].Points.AddXY(data.Name, data.Money);
            }
        }
        private void GetMoneySpend()
        {
            var moneySpend = userRepository.GetMoneySpend(1, _month, _year);
            var moneyLoan = userRepository.GetMoneyLoan(1, _month, _year);

            lbMoneySpend.Text = (moneyLoan+moneySpend).ToString("0.#");
        }
        private void GetMoneyIncome()
        {
            var income = userRepository.GetMoneyIncome(1, _month, _year);
            var borrow = userRepository.GetMoneyBorrow(1, _month, _year);

            lbMoneyIncome.Text = (income+borrow).ToString("0.#"); 
        }
        private void GetMoneyLoan()
        {
            var loan = userRepository.GetMoneyLoan(1, _month, _year);
            lbMoneyLoan.Text = loan.ToString("0.#");
        }
        private void GetMoneyBorrow()
        {
            var borrow = userRepository.GetMoneyBorrow(1, _month, _year);
            lbMoneyBorrow.Text = borrow.ToString("0.#");
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            frmDetailManagement frmDetailManagement = new frmDetailManagement
            {
                Type = 1,
                IncomeRepository = new DatasRepository<Income>(),
                SpendRepository = null,
            };
            this.Hide();
            frmDetailManagement.ShowDialog();
        }

        private void btnNewSpend_Click(object sender, EventArgs e)
        {
            frmDetailManagement frmDetailManagement = new frmDetailManagement
            {
                Type = 2,
                SpendRepository = new DatasRepository<Spend>(),
                IncomeRepository = null,
            };
            this.Hide();
            frmDetailManagement.ShowDialog();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frmDetailManagement1 frmDetailManagement1 = new frmDetailManagement1
            {
                Type = 4,
                BorrowRepository = new DatasRepository<Borrow>(),
            };
            this.Hide();
            frmDetailManagement1.ShowDialog();
        }


        private void btnLoan_Click(object sender, EventArgs e)
        {
            frmDetailManagement1 frmDetailManagement1 = new frmDetailManagement1
            {
                Type = 3,
                LoanRepository = new DatasRepository<Loan>(),
            };
            this.Hide();
            frmDetailManagement1.ShowDialog();
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {

        }
    }
}
