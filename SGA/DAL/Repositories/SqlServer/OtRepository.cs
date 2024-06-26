using DAL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{

	internal sealed class OtRepository : DALIGenericRepository<Ot>
    {
		private readonly static OtRepository _instance = new OtRepository();

		public static OtRepository Current
		{
			get
			{
				return _instance;
			}
		}

		public OtRepository()
		{
			//Implent here the initialization of your singleton
		}

        public void Create(Ot obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Ot obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Ot GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ot> GetAll()
        {
            throw new NotImplementedException();
        }
    }

	
}
