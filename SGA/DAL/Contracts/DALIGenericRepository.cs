using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface DALIGenericRepository<T> where T : class, new()
    {
        void Create(T obj);

        void Update(T obj);

        void Delete(int id);

        T GetOne(int id);

        IEnumerable<T> GetAll();
    }
}
