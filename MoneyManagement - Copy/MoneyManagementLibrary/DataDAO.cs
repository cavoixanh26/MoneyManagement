using Microsoft.EntityFrameworkCore;
using MoneyManagementLibrary.DataAccess;
using MoneyManagementLibrary.DataAccess.DAO;
using MoneyManagementLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagementLibrary
{
    public class DataDAO
    {
        private static DataDAO instance = null;
        private static readonly object instanceLock = new object();
        private readonly MoneyManagementContext _context;

        public static DataDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DataDAO();
                    }
                    return instance;
                }
            }
        }
        public DataDAO()
        {
            _context = new MoneyManagementContext();
        }

        public IEnumerable<CateIncome> GetCateIncome()
        {
            try
            {
                using var context = new MoneyManagementContext();
                var cate = context.CateIncomes.ToList();
                return cate;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<CateSpend> GetCateSpend()
        {
            try
            {
                using var context = new MoneyManagementContext();
                var cate = context.CateSpends.ToList();
                return cate;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string GetCateIncomeById(int? id)
        {
            string name = "";
            try
            {
                using var context = new MoneyManagementContext();
                name = context.CateIncomes.Where(o => o.Id == id).Select(o => o.Name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return name;
        }

        public string GetCateSpendById(int? id)
        {
            string name = "";
            try
            {
                using var context = new MoneyManagementContext();
                name = context.CateSpends.Where(o => o.Id == id).Select(o => o.Name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return name;
        }

        public IEnumerable<ChartProp> GetSpends(int userID, int? month, int? year)
        {
            var spends = from s in _context.Spends
                         join c in _context.CateSpends
                         on s.CateId equals c.Id
                         where s.UserId == userID
                         && (s.Time.Month == month || month == 0)
                         && (s.Time.Year == year || year == 0)  
                         group s by c.Name into g
                         select new ChartProp { Name = g.Key, Money = g.Sum(s => s.Money) };
            return spends;

        }

        public IEnumerable<ChartProp> GetIncomes(int userID, int? month, int? year)
        {

            var incomes = from s in _context.Incomes
                          join c in _context.CateIncomes
                          on s.CateId equals c.Id
                          where s.UserId == userID
                          && (s.Time.Month == month || month == 0)
                          && (s.Time.Year == year || year == 0)
                          group s by c.Name into g
                          select new ChartProp { Name = g.Key, Money = g.Sum(s => s.Money) };
            return incomes;

        }

        public IEnumerable<Income> GetAllIncome(int? month, int? year, int? cateID, string? sort, string search, int userID)
        {
            try
            {
                using var context = new MoneyManagementContext();
                var incomes = context.Incomes.Where(o => o.UserId == userID).ToList();

                if (month.HasValue )
                    incomes =  incomes.Where(o => o.Time.Month == month).ToList();
                if (year.HasValue)
                    incomes = incomes.Where(o => o.Time.Year == year).ToList();
                if (cateID.HasValue)
                    incomes = incomes.Where(o => o.CateId== cateID).ToList();
                if (search != null)
                    incomes = incomes.Where(o => o.Describe.ToUpper().Contains(search.ToUpper())).ToList();
                if (sort != null)
                {
                    if (sort.Equals("asc"))
                        incomes = incomes.OrderBy(o => o.Money).ToList();
                    else
                        incomes = incomes.OrderByDescending(o => o.Money).ToList();
                }
                return incomes; 
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Income> GetAllIncome(string search, string sort, int[] cate, DateTime? from, DateTime? to, int userID)
        {
            try
            {
                using var context = new MoneyManagementContext();
                var incomes = context.Incomes.Where(o => o.UserId == userID).ToList();

                if (cate.Length > 0)
                {
                     incomes = incomes.Where(o => cate.Contains((int)o.CateId)).ToList();
                }
                
                if (search != null)
                    incomes = incomes.Where(o => o.Describe.ToUpper().Contains(search.ToUpper())).ToList();
                if (sort != null && !sort.Equals("ok"))
                {
                    if (sort.Equals("tang"))
                        incomes = incomes.OrderBy(o => o.Money).ToList();
                    else 
                        incomes = incomes.OrderByDescending(o => o.Money).ToList();
                }
                if (from.HasValue)
                {
                    incomes = incomes.Where(o => o.Time > from.Value || o.Time == from.Value).ToList();
                }
                if (to.HasValue) 
                {
                    incomes = incomes.Where(o => o.Time < to.Value || o.Time == to.Value).ToList();
                }
                return incomes;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Spend> GetAllSpend(int? month, int? year, int? cateID, string? sort, string search, int userID)
        {
            try
            {
                using var context = new MoneyManagementContext();
                var spends = context.Spends.Where(o => o.UserId == userID).ToList();

                if (month.HasValue)
                    spends = spends.Where(o => o.Time.Month == month).ToList();
                if (year.HasValue)
                    spends = spends.Where(o => o.Time.Year == year).ToList();
                if (cateID.HasValue)
                    spends = spends.Where(o => o.CateId == cateID).ToList();
                if (search != null)
                    spends = spends.Where(o => o.Describe.ToUpper().Contains(search.ToUpper())).ToList();
                if (sort != null)
                {
                    if (sort.Equals("asc"))
                        spends = spends.OrderBy(o => o.Money).ToList();
                    else
                        spends = spends.OrderByDescending(o => o.Money).ToList();
                }
                return spends;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Loan> GetAllLoan(int? monthFrom, int? yearFrom, int? monthTo,
            int? yearTo, string sort, string search, bool? status, int? deadline, int userID)
        {
            try
            {
                using var context = new MoneyManagementContext();
                var loan = context.Loans.Where(o => o.UserId == userID).ToList();
                if (monthFrom.HasValue)
                    loan = loan.Where(o => o.Time.Month == monthFrom.Value).ToList();
                if (yearFrom.HasValue)
                    loan = loan.Where(o => o.Time.Year == yearFrom.Value).ToList();
                if (monthTo.HasValue)
                    loan = loan.Where(o => o.Deadline.Month == monthTo.Value).ToList();
                if (yearTo.HasValue)
                    loan = loan.Where(o => o.Deadline.Year == yearTo.Value).ToList();
                if (sort != null)
                {
                    if (sort.Equals("Tang"))
                        loan = loan.OrderBy(o => o.Money).ToList();
                    else loan = loan.OrderByDescending(o => o.Money).ToList();
                }
                if (search != null)
                    loan = loan.Where(o => o.Name.ToUpper().Contains(search.ToUpper())
                    || o.Describe.ToUpper().Contains(search.ToUpper())).ToList();
                if (status.HasValue)
                    loan = loan.Where(o => o.Status == status.Value).ToList();
                if (deadline.HasValue)
                {

                }
                return loan;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Loan> GetAllLoan(string search, DateTime? timeFrom, DateTime? timeTo, string sortMoney,
            bool? status, bool? deadline, int userID)
        {
            try
            {
                using var context = new MoneyManagementContext();
                var loans = context.Loans.Where(o => o.UserId == userID).ToList();
                if (search != null)
                    loans = loans.Where(o => o.Name.ToUpper().Contains(search.ToUpper()) 
                    || o.Describe.ToUpper().Contains(search.ToUpper())).ToList();
                if (timeFrom.HasValue)
                    loans = loans.Where(o => o.Time >= timeFrom || o.Deadline >= timeFrom).ToList();
                if (timeTo.HasValue)
                    loans = loans.Where(o => o.Time <= timeTo || o.Deadline <= timeTo).ToList();    
                if (sortMoney != null)
                {
                    if (sortMoney.Equals("asc"))
                        loans = loans.OrderBy(o => o.Money).ToList();   
                    else 
                        loans = loans.OrderByDescending(o => o.Money).ToList(); 
                }
                if (status.HasValue)
                    loans = loans.Where(o => o.Status == status.Value).ToList();
                if (deadline.HasValue)
                {
                    if (!deadline.Value)
                        loans = loans.Where(o => o.Deadline < DateTime.Now && o.Status == deadline).ToList();
                    if (deadline.Value)
                        loans = loans.Where(o=>o.Status == deadline).ToList();
                }
                return loans;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Borrow> GetAllBorrow(int? monthFrom, int? yearFrom, int? monthTo,
            int? yearTo, string sort, string search, bool? status, int? deadline, int userID)
        {
            try
            {
                using var context = new MoneyManagementContext();
                var borrow = context.Borrows.Where(o => o.UserId == userID).ToList();
                if (monthFrom.HasValue)
                    borrow = borrow.Where(o => o.Time.Month == monthFrom.Value).ToList();
                if (yearFrom.HasValue)
                    borrow = borrow.Where(o => o.Time.Year == yearFrom.Value).ToList();
                if (monthTo.HasValue)
                    borrow = borrow.Where(o => o.Deadline.Month == monthTo.Value).ToList();
                if (yearTo.HasValue)
                    borrow = borrow.Where(o => o.Deadline.Year == yearTo.Value).ToList();
                if (sort != null)
                {
                    if (sort.Equals("Tang"))
                        borrow = borrow.OrderBy(o => o.Money).ToList();
                    else borrow = borrow.OrderByDescending(o => o.Money).ToList();
                }
                if (search != null)
                    borrow = borrow.Where(o => o.Name.ToUpper().Contains(search.ToUpper())
                    || o.Describe.ToUpper().Contains(search.ToUpper())).ToList();
                if (status.HasValue)
                    borrow = borrow.Where(o => o.Status == status.Value).ToList();
                if (deadline.HasValue)
                {

                }
                return borrow;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int GetIdByNameCateIncome(string name)
        {
            try
            {
                using var context = new MoneyManagementContext();
                return context.CateIncomes.Where(o => o.Name.Equals(name))
                    .Select(o => o.Id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int GetIdByNameCateSpend(string name)
        {
            try
            {
                using var context = new MoneyManagementContext();
                return context.CateSpends.Where(o => o.Name.Equals(name))
                    .Select(o => o.Id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
