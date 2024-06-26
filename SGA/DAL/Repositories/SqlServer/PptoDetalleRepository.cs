using DAL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{

	internal sealed class PptoDetalleRepository : DALIGenericRepository<PptoDetalle>
    {
		private readonly static PptoDetalleRepository _instance = new PptoDetalleRepository();

		public static PptoDetalleRepository Current
		{
			get
			{
				return _instance;
			}
		}

		public PptoDetalleRepository()
		{
			//Implent here the initialization of your singleton
		}

        public void Create(PptoDetalle obj)
        {
            throw new NotImplementedException();
        }

        public void Update(PptoDetalle obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PptoDetalle GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PptoDetalle> GetAll()
        {
            throw new NotImplementedException();
        }
    }

	
}
