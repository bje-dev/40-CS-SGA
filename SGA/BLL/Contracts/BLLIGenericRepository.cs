using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface BLLIGenericRepository<T>
    {
        void Create(T obj);

        void Update(T obj);

        void Delete(int id);

        T GetOne(int id);

        IEnumerable<T> GetAll();
    }
}
