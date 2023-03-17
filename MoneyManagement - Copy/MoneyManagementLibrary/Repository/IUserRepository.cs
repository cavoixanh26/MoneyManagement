using MoneyManagementLibrary.DataAccess;
using MoneyManagementLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagementLibrary.Repository
{
    public interface IUserRepository
    {
        User GetUserByName(string username);
        User GetUserByNameAndPass(string username, string pass);
        void InsertUser(User user);
        void UpdateUser(User user);

        IEnumerable<int> GetYears(int userID);

        decimal GetMoneySpend(int userID, int month, int year);
        decimal GetMoneyLoan(int userID, int month, int year);
        decimal GetMoneyIncome(int userID, int month, int year);
        decimal GetMoneyBorrow(int userID, int month, int year);

        
        IEnumerable<Loan> GetLoans(int userID, int month, int year);
        IEnumerable<Borrow> GetBorrows(int userID, int month, int year);
    }
}
