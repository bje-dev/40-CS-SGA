using DAL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{

	internal sealed class SolicitudRepository : DALIGenericRepository<Solicitud>
    {
		private readonly static SolicitudRepository _instance = new SolicitudRepository();

		public static SolicitudRepository Current
		{
			get
			{
				return _instance;
			}
		}

		public SolicitudRepository()
		{
			//Implent here the initialization of your singleton
		}

        public void Create(Solicitud obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Solicitud obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Solicitud GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Solicitud> GetAll()
        {
            throw new NotImplementedException();
        }
    }

	
}
