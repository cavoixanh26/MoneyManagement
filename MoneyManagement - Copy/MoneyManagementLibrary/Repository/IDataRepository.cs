using MoneyManagementLibrary.DataAccess;
using MoneyManagementLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagementLibrary.Repository
{
    public interface IDataRepository
    {
        public IEnumerable<Income> GetAllIncome(int? month, int? year, int? cateID, string? sort, string search, int useID);
        public IEnumerable<Income> GetAllIncomes(string search, string sort, int[] cate, DateTime? from, DateTime? to, int userID);
        public IEnumerable<Spend> GetAllSpend(int? month, int? year, int? cateID, string? sort, string search, int useID);
        public IEnumerable<Loan> GetAllLoan(int? monthFrom, int? yearFrom, int? monthTo, int? yearTo, string? sort, string search, bool? status, int? deadline, int userID);
        public IEnumerable<Loan> GetAllLoan(string search, DateTime? timeFrom, DateTime? timeTo, string sortMoney, bool? status, bool? deadline, int userID);
        IEnumerable<ChartProp> GetSpends(int userID, int? month, int? year);
        IEnumerable<ChartProp> GetIncomes(int userID, int? month, int? year);
        int GetIDByNameCateIncome(string name);
        int GetIDByNameCateSpend(string name);
        string GetCateIncomeById(int? id);
        public string GetCateSpendById(int? id);
        IEnumerable<CateIncome> GetCateIncome();
        IEnumerable<CateSpend> GetCateSpend();
    }
}
