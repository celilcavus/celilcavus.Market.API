using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celilcavus.Market.Model.Interfaces
{
    public interface IBaseRepository<T> where T: class,new()
    {
        T Add(T item);
        T Delete(T item);
        T GetById(int id);
        int Update(T item);
        List<T> GetAll();
        int SaveChanges();
    }
}
