using DAL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{

	internal class ClienteRepository : DALIGenericRepository<Cliente>
    {
		private readonly static ClienteRepository _instance = new ClienteRepository();

		public static ClienteRepository Current
		{
			get
			{
				return _instance;
			}
		}

		public ClienteRepository()
		{
			//Implent here the initialization of your singleton
		}

        public void Create(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }
    }


	
}
