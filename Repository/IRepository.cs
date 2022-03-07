using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreCashRegister.Repository
{
    public interface IRepository<T>
    {
        List<T> SelectAll();
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        void DeleteAll();
    }
}
