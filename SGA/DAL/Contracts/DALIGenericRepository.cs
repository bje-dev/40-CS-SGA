﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    internal interface DALIGenericRepository<T> where T : class, new()
    {
        void Add(T obj);

        void Update(T obj);

        void Delete(Guid id);

        T GetOne(Guid id);

        IEnumerable<T> GetAll();
    }
}
