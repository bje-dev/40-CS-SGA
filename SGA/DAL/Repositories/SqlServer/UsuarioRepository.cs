using DAL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{

	internal class UsuarioRepository : DALIGenericRepository<Usuario>
    {
		private readonly static UsuarioRepository _instance = new UsuarioRepository();

		public static UsuarioRepository Current
		{
			get
			{
				return _instance;
			}
		}

		public UsuarioRepository()
		{
			//Implent here the initialization of your singleton
		}

        public void Create(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }
    }

	
}
