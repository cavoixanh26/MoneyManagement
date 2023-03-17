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
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyManagementWinApp
{
    public partial class frmDetailManagement : Form
    {
        public frmDetailManagement()
        {
            InitializeComponent();
        }
        BindingSource source;
        IDataRepository dataRepository = new DataRepository();
        IUserRepository userRepository = new UserRepository();

        public int Type { get; set; }
        public IDatasRepository<Income> IncomeRepository = new DatasRepository<Income>();
        public IDatasRepository<Spend> SpendRepository = new DatasRepository<Spend>();

        int? _month;
        int? _year;
        int? _cate;
        string? _sort;
        string? _searchText;
        bool isUpdate = false;
        private void frmDetailManagement_Load(object sender, EventArgs e)
        {
            LoadList();
            cboCate.DataSource = null;
            if (Type == 1)
            {
                cboCate.DataSource = dataRepository.GetCateIncome();
            }
            else if (Type == 2)
            {
                cboCate.DataSource = dataRepository.GetCateSpend();
            }
            cboCate.SelectedIndex = -1;

            cboYear.DataSource = null;
            cboYear.DataSource = userRepository.GetYears(1);
            cboYear.SelectedIndex = -1;
            cboYearComp.DataSource = null;
            cboYearComp.DataSource = userRepository.GetYears(1);
            cboYearComp.SelectedIndex = -1;
            cboMonthComp.Enabled = false;
            cboYearComp.Enabled = false;
            EnableDetail(isUpdate);
        }

        private void EnableDetail(bool enable)
        {
            txtDescribe.Enabled = enable;
            txtMoney.Enabled = enable;
            txtTime.Enabled = enable;
            ckbStatus.Enabled = enable;
            cboCateDetail.Enabled = false;
        }


        private void cboCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public Income GetObjectIncome()
        {
            Income m = null;
            int id;
            int.TryParse(txtID.Text, out id);
            try
            {
                m = new Income
                {
                    Id = id,
                    Describe = txtDescribe.Text,
                    Money = decimal.Parse(txtMoney.Text),
                    Time = DateTime.Parse(txtTime.Text),
                    CateId = int.Parse(cboCateDetail.Text),
                    UserId = 1,
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return m;
        }
        public Spend GetObjectSpend()
        {
            Spend m = null;
            int id;
            int.TryParse(txtID.Text, out id);
            try
            {
                m = new Spend
                {
                    Id = id,
                    Describe = txtDescribe.Text,
                    Money = decimal.Parse(txtMoney.Text),
                    Time = DateTime.Parse(txtTime.Text),
                    CateId = int.Parse(cboCateDetail.Text),
                    UserId = 1,
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return m;
        }
        public void LoadList()
        {

            ChartDetail();

            if (cboMonth.SelectedIndex >= 0)
            {
                _month = Int32.Parse(cboMonth.Text);
                cboMonthComp.Enabled = true;
            }
            else _month = null;
            if (cboYear.SelectedIndex >= 0)
            {
                _year = Int32.Parse(cboYear.Text);
                cboYearComp.Enabled = true;
            }
            else _year = null;
            if (cboCate.SelectedIndex >= 0)
            {
                if (Type == 1)
                {
                    _cate = dataRepository.GetIDByNameCateIncome(cboCate.Text);
                }
                if (Type == 2)
                {
                    _cate = dataRepository.GetIDByNameCateSpend(cboCate.Text);
                }
            }
            else _cate = null;
            if (cboSort.SelectedIndex >= 0)
                _sort = cboSort.Text;
            else _sort = null;
            if (txtSearch.Text != null) _searchText = txtSearch.Text;
            else _searchText = null;

            txtID.Visible = false;

            var data1 = dataRepository.GetAllIncome(_month, _year, _cate, _sort, _searchText, 1);

            var data2 = dataRepository.GetAllSpend(_month, _year, _cate, _sort, _searchText, 1);
            try
            {
                source = new BindingSource();
                if (Type == 1)
                    source.DataSource = data1;
                if (Type == 2)
                    source.DataSource = data2;

                txtDescribe.DataBindings.Clear();
                txtMoney.DataBindings.Clear();
                txtTime.DataBindings.Clear();
                cboCateDetail.DataBindings.Clear();
                txtID.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "ID");
                txtDescribe.DataBindings.Add("Text", source, "Describe");
                txtMoney.DataBindings.Add("Text", source, "Money");
                txtTime.DataBindings.Add("Text", source, "Time");
                cboCateDetail.DataBindings.Add("Text", source, "CateID");

                dgvData.DataSource = null;
                dgvData.DataSource = source;

                dgvData.Columns[0].Visible = false;
                dgvData.Columns[4].Visible = false;
                dgvData.Columns[5].Visible = false;
                dgvData.Columns[6].Visible = false;
                dgvData.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cboYearComp_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnApp_Click(object sender, EventArgs e)
        {
            ChartDetail();
            LoadList();
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            cboCate.SelectedIndex = -1;
            cboMonth.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
            cboYearComp.SelectedIndex = -1;
            cboMonthComp.SelectedIndex = -1;
            cboSort.SelectedIndex = -1;
            txtSearch.Clear();
            LoadList();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa ", "delete"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int id;
                    int.TryParse(txtID.Text, out id);
                    if (Type == 1)
                        IncomeRepository.Delete(id);
                    if (Type == 2)
                        SpendRepository.Delete(id);
                    LoadList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int countClickUpdate = 1;
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
            EnableDetail(isUpdate);

        }
        private void UpdateExecu()
        {
            try
            {
                if (Type == 1)
                {
                    var income = GetObjectIncome();
                    IncomeRepository.Update(income);
                }
                if (Type == 2)
                {
                    var spend = GetObjectSpend();
                    SpendRepository.Update(spend);
                }

                LoadList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNew frmAddNew = new frmAddNew();
            if (Type == 1)
            {
                frmAddNew.Text = "Thêm Khoản Thu";
                frmAddNew.IncomeRepository = IncomeRepository;
                frmAddNew.DataRepository = dataRepository;
                frmAddNew.Type = 1;
            }
            if (Type == 2)
            {
                frmAddNew.Text = "Thêm Khoản Chi";
                frmAddNew.SpendRepository = SpendRepository;
                frmAddNew.DataRepository = dataRepository;
                frmAddNew.Type = 2;
            }
            
            frmAddNew.Show();
            LoadList();
        }

        private void ChartDetail()
        {

            chartDetail.Series.Clear();
            if (chartDetail.Titles.Count == 0)
            {
                if (Type == 1)
                    chartDetail.Titles.Add("Biểu đồ thu nhập");
                if (Type == 2)
                    chartDetail.Titles.Add("Biểu đồ chi tiêu");
            }
            string nameChart = "";
            if (Type == 1)
            {
                nameChart = "các khoản thu";
            }
            if (Type == 2)
            {
                nameChart = "các chi tiêu";
            }
            if (_month == null)
                _month = 0;
            else
                nameChart += " tháng " + _month;
            if (_year == null)
                _year = 0;
            else
                nameChart += ", năm " + _year;

            chartDetail.Series.Add(nameChart);
            chartDetail.Series[nameChart].ChartType = SeriesChartType.Column;
            if (Type == 1)
            {

                var incomeData = dataRepository.GetIncomes(1, _month, _year);
                foreach (var data in incomeData)
                {
                    chartDetail.Series[nameChart].Points.AddXY(data.Name, data.Money);
                }
            }
            if (Type == 2)
            {
                var spendData = dataRepository.GetSpends(1, _month, _year);
                foreach (var data in spendData)
                {
                    chartDetail.Series[nameChart].Points.AddXY(data.Name, data.Money);
                }
            }
            int _monthComp, _yearComp;
            int.TryParse(cboMonthComp.Text, out _monthComp);
            int.TryParse(cboYearComp.Text, out _yearComp);

            if (_yearComp != 0)
            {
                if (Type == 1)
                {
                    string nameChartComp = "các khoản thu tháng " + _monthComp + " năm " + _yearComp;
                    chartDetail.Series.Add(nameChartComp);
                    chartDetail.Series[nameChartComp].ChartType = SeriesChartType.Column;
                    var incomeDataComp = dataRepository.GetIncomes(1, _monthComp, _yearComp);
                    foreach (var data in incomeDataComp)
                    {
                        chartDetail.Series[nameChartComp].Points.AddXY(data.Name, data.Money);
                    }
                }
                if (Type == 2)
                {
                    string nameChartComp = "các khoản chi tháng " + _monthComp + " năm " + _yearComp;
                    chartDetail.Series.Add(nameChartComp);
                    chartDetail.Series[nameChartComp].ChartType = SeriesChartType.Column;
                    var spendDataComp = dataRepository.GetSpends(1, _monthComp, _yearComp);
                    foreach (var data in spendDataComp)
                    {
                        chartDetail.Series[nameChartComp].Points.AddXY(data.Name, data.Money);
                    }
                }

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMoneyManagement frmMoneyManagement = new frmMoneyManagement();
            this.Hide();
            frmMoneyManagement.ShowDialog();

        }
    }
}
