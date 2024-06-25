using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    internal interface BLLIGenericRepository<T>
    {
        void Create(T obj);

        void Update(T obj);

        void Delete(Guid id);

        T GetOne(Guid id);

        IEnumerable<T> GetAll();
    }
}
