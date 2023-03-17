using MoneyManagementLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagementLibrary.Repository
{
    public interface IDatasRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetObjectByID(int id);
        void Insert(T t);
        void Update(T t);
        void Delete(int t);
        
    }
}
