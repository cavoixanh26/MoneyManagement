using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagementLibrary.Repository
{
    public class DatasRepository<T> : IDatasRepository<T> where T : class
    {

        public void Delete(int t)
        => DAO<T>.Instance.Remove(t);

        public IEnumerable<T> GetAll()
        => DAO<T>.Instance.GetAll();

        public T GetObjectByID(int id)
        => DAO<T>.Instance.GetObjectByID(id);

        public void Insert(T t)
        => DAO<T>.Instance.AddNew(t);

        public void Update(T t)
        => DAO<T>.Instance.Update(t);
    }
}
