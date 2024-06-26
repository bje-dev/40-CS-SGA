using DAL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{

	internal class UnidadService : DALIGenericRepository<Unidad>
    {
		private readonly static UnidadService _instance = new UnidadService();

		public static UnidadService Current
		{
			get
			{
				return _instance;
			}
		}

		private UnidadService()
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
