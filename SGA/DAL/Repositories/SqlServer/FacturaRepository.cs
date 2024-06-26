using DAL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{

	internal sealed class FacturaRepository : DALIGenericRepository<Factura>
    {
		private readonly static FacturaRepository _instance = new FacturaRepository();

		public static FacturaRepository Current
		{
			get
			{
				return _instance;
			}
		}

		public FacturaRepository()
		{
			//Implent here the initialization of your singleton
		}

        public void Create(Factura obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Factura obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Factura GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Factura> GetAll()
        {
            throw new NotImplementedException();
        }
    }


}
