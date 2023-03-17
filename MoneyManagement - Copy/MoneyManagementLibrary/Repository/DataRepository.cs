using MoneyManagementLibrary.DataAccess;
using MoneyManagementLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagementLibrary.Repository
{
    public class DataRepository : IDataRepository
    {
        private readonly MoneyManagementContext _context;
        public DataRepository()
        {

        }
        public DataRepository(MoneyManagementContext context)
        {
            _context = context;
        }
        
        
        public int GetIDByNameCateIncome(string name)
        => DataDAO.Instance.GetIdByNameCateIncome(name);

        public int GetIDByNameCateSpend(string name)
        => DataDAO.Instance.GetIdByNameCateSpend(name);
        public IEnumerable<Income> GetAllIncome(int? month, int? year, int? cateID, string? sort, string search, int userID)
        => DataDAO.Instance.GetAllIncome(month, year, cateID, sort, search, userID);
        public IEnumerable<Income> GetAllIncomes(string search, string sort, int[] cate , DateTime? from, DateTime? to, int userID)
            => DataDAO.Instance.GetAllIncome(search, sort, cate, from, to, userID); 
        public IEnumerable<Spend> GetAllSpend(int? month, int? year, int? cateID, string? sort, string search, int userID)
        => DataDAO.Instance.GetAllSpend(month, year, cateID, sort, search, userID);
        public IEnumerable<Loan> GetAllLoan(int? monthFrom, int? yearFrom, int? monthTo, int? yearTo, string? sort, string search, bool? status, int? deadline, int userID)
        => DataDAO.Instance.GetAllLoan(monthFrom, yearFrom, monthTo, yearTo, sort, search, status, deadline, userID);
        public IEnumerable<ChartProp> GetSpends(int userID, int? month, int? year)
        => DataDAO.Instance.GetSpends(userID, month, year);

        public IEnumerable<ChartProp> GetIncomes(int userID, int? month, int? year)
        => DataDAO.Instance.GetIncomes(userID, month, year);

        public string GetCateIncomeById(int? id)
        => DataDAO.Instance.GetCateIncomeById(id);
        public string GetCateSpendById(int? id)
        => DataDAO.Instance.GetCateSpendById(id);
        public IEnumerable<CateIncome> GetCateIncome()
        => DataDAO.Instance.GetCateIncome();
        public IEnumerable<CateSpend> GetCateSpend ()
        => DataDAO.Instance.GetCateSpend();

        public IEnumerable<Loan> GetAllLoan(string search, DateTime? timeFrom, DateTime? timeTo, string sortMoney, bool? status, bool? deadline, int userID)
        => DataDAO.Instance.GetAllLoan(search, timeFrom, timeTo, sortMoney, status, deadline, userID);
    }
}
