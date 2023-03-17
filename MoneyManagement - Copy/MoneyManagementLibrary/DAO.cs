using MoneyManagementLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagementLibrary
{
    public class DAO<T> where T : class
    {
        private static DAO<T> instance = null;
        private static readonly object instanceLock = new object();
        public static DAO<T> Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DAO<T>();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                using var context = new MoneyManagementContext();
                var t = context.Set<T>().ToList();
                return t;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public T GetObjectByID(int tID)
        {
            T t = null;
            try
            {
                using var context = new MoneyManagementContext();
                t = context.Set<T>().Find(tID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return t;
        }

        

        public void Remove(int tID)
        {
            try
            {
                T _t = GetObjectByID(tID);
                if (_t != null)
                {
                    using var context = new MoneyManagementContext();
                    context.Set<T>().Remove(_t);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Income does not already exists");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(T t)
        {
            try
            {
                using var context = new MoneyManagementContext();
                context.Set<T>().Update(t);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddNew(T t)
        {
            try
            {
                using var context = new MoneyManagementContext();
                context.Set<T>().Add(t);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
