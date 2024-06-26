using DAL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{

	internal sealed class PagoRepository : DALIGenericRepository<Pago>
    {
		private readonly static PagoRepository _instance = new PagoRepository();

		public static PagoRepository Current
		{
			get
			{
				return _instance;
			}
		}

		public PagoRepository()
		{
			//Implent here the initialization of your singleton
		}

        public void Create(Pago obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Pago obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pago GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pago> GetAll()
        {
            throw new NotImplementedException();
        }
    }

	
}
