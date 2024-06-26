using DAL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{

	internal class UnidadRepository : DALIGenericRepository<Unidad>
    {
		private readonly static UnidadRepository _instance = new UnidadRepository();

		public static UnidadRepository Current
		{
			get
			{
				return _instance;
			}
		}

		private UnidadRepository()
		{
			//Implent here the initialization of your singleton
		}

        public void Create(Unidad obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Unidad obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Unidad GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Unidad> GetAll()
        {
            throw new NotImplementedException();
        }
    }

	
}
