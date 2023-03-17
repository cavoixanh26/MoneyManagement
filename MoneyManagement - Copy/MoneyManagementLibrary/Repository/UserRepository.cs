using MoneyManagementLibrary.DataAccess;
using MoneyManagementLibrary.DataAccess.DAO;
using MoneyManagementLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagementLibrary.Repository
{
    public class UserRepository : IUserRepository
    {

        public UserRepository()
        {
        }

        public decimal GetMoneySpend(int userID, int month, int year)
        => UserDAO.Instance.GetMoneySpend(userID, month, year);
        public decimal GetMoneyLoan(int userID, int month, int year)
        => UserDAO.Instance.GetMoneyLoan(userID, month, year);
        public User GetUserByName(string username)
        => UserDAO.Instance.GetUserByName(username);

        public User GetUserByNameAndPass(string username, string pass)
        => UserDAO.Instance.GetUserByNameAndPass(username, pass);

        public IEnumerable<int> GetYears(int userID)
        => UserDAO.Instance.GetYears(userID);

        public void InsertUser(User user)
        => UserDAO.Instance.AddNew(user);

        public void UpdateUser(User user)
        => UserDAO.Instance.Update(user);

        public decimal GetMoneyIncome(int userID, int month, int year)
        => UserDAO.Instance.GetMoneyIncome(userID, month, year);

        

        public decimal GetMoneyBorrow(int userID, int month, int year)
        => UserDAO.Instance.GetMoneyBorrow(userID, month, year);

        public IEnumerable<Loan> GetLoans(int userID, int month, int year)
        => UserDAO.Instance.GetLoans(userID, month, year);

        public IEnumerable<Borrow> GetBorrows(int userID, int month, int year)
        => UserDAO.Instance.GetBorrows(userID, month, year);
    }
}
