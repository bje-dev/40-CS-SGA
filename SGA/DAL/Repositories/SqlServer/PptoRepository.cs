using DAL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{

	internal sealed class PptoRepository : DALIGenericRepository<Ppto>
    {
		private readonly static PptoRepository _instance = new PptoRepository();

		public static PptoRepository Current
		{
			get
			{
				return _instance;
			}
		}

		public PptoRepository()
		{
			//Implent here the initialization of your singleton
		}

        public void Create(Ppto obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Ppto obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Ppto GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ppto> GetAll()
        {
            throw new NotImplementedException();
        }
    }

	
}
