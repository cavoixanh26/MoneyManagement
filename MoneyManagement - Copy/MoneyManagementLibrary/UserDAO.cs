using Microsoft.EntityFrameworkCore;
using MoneyManagementLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MoneyManagementLibrary.DataAccess.DAO
{
    public class UserDAO
    {
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public User GetUserByID(int userId)
        {
            User user = null;
            try
            {
                using var context = new MoneyManagementContext();
                user = context.Users.SingleOrDefault(u => u.Id == userId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }
        public User GetUserByName(string name)
        {
            User user = null;
            try
            {
                using var context = new MoneyManagementContext();
                user = context.Users.Where(u => u.Name == name).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }
        public User GetUserByNameAndPass(string name, string pass)
        {
            User user = null;
            try
            {
                using var context = new MoneyManagementContext();
                user = context.Users.Where(u => u.Name == name && u.Password == pass).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }

        public void AddNew(User user)
        {
            try
            {
                User _user = GetUserByID(user.Id);
                if (_user == null)
                {
                    using var context = new MoneyManagementContext();
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The user already exists");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(User user)
        {
            try
            {
                User _user = GetUserByID(user.Id);
                if (_user != null)
                {
                    using var context = new MoneyManagementContext();
                    context.Users.Update(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The user does not already exists");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<int> GetYears(int userID)
        {
            using var context = new MoneyManagementContext();
            var yearsBorrow = (from Borrows in context.Borrows
                              where userID == Borrows.UserId
                              select (Borrows.Time.Year)).ToList();

            var yearsIncome = (from Incomes in context.Incomes
                              where userID == Incomes.UserId
                               select (Incomes.Time.Year)).ToList();

            var yearsLoan = (from Loans in context.Loans
                            where userID == Loans.UserId
                            select (Loans.Time.Year)).ToList();

            var yearsSpend = (from Spends in context.Spends
                             where userID == Spends.UserId
                             select (Spends.Time.Year)).ToList();

            var years = yearsBorrow.Union(yearsIncome)
                .Union(yearsLoan).Union(yearsSpend)
                .Distinct().ToList();

            return years;
        }

        public decimal GetMoneySpend(int userID, int month, int year)
        {
            using var context = new MoneyManagementContext();

                var moneys = (from Spends in context.Spends
                          where userID == Spends.UserId
                              && (Spends.Time.Month == month || month == 0)
                          && Spends.Time.Year == year
                          select (Spends.Money)).Sum();
                return moneys;
            
        }

        public decimal GetMoneyLoan(int userID, int month, int year)
        {
            using var context = new MoneyManagementContext();
   var moneys = (from Loans in context.Loans
                              where userID == Loans.UserId
                              && (Loans.Time.Month == month || month == 0)
                              && Loans.Time.Year == year
                              select (Loans.Money)).Sum();
                return moneys;
            
            
        }

        public decimal GetMoneyIncome(int userID, int month, int year)
        {
            using var context = new MoneyManagementContext();
                var moneys = (from Income in context.Incomes
                              where userID == Income.UserId
                              && (Income.Time.Month == month || month ==0)
                              && Income.Time.Year == year
                              select (Income.Money)).Sum();
                return moneys;
           
        }
        public decimal GetMoneyBorrow(int userID, int? month, int year)
        {
            using var context = new MoneyManagementContext();
                var moneys = (from Borrows in context.Borrows
                              where userID == Borrows.UserId
                              && (Borrows.Time.Month == month || month == 0)
                              && Borrows.Time.Year == year
                              select (Borrows.Money)).Sum();
                return moneys;
        }

        public IEnumerable<Loan> GetLoans(int userID, int month, int year)
        {
            using var context = new MoneyManagementContext();

            var loans = context.Loans
            .Where(c => c.UserId == userID
            && (c.Time.Month == month || month == 0)
                && c.Time.Year == year)
                .Select(c => c).ToList();
                return loans;
        }

        public IEnumerable<Borrow> GetBorrows(int userID, int month, int year)
        {
            using var context = new MoneyManagementContext();
            var borrows = context.Borrows
            .Where(c => c.UserId == userID
            && (c.Time.Month == month || month == 0)
                && c.Time.Year == year )
                .Select(c => c).ToList();
                return borrows;
        }
    }
}
