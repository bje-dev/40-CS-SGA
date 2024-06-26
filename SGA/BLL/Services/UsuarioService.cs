using BLL.Contracts;
using DAL.Factory;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{

	public sealed class UsuarioService : BLLIGenericRepository<Usuario>
    {
		private readonly static UsuarioService _instance = new UsuarioService();

		public static UsuarioService Current
		{
			get
			{
				return _instance;
			}
		}

		private UsuarioService()
		{
			//Implent here the initialization of your singleton
		}

        public void Create(Usuario obj)
        {
            try
            {
                if (obj.contraseña==obj.confirma)
                {
                    Fabricacion.Current.GetUsuarioRepository().Create(obj);
                }
                else
                {

                }


            }
            catch (Exception)
            {

                throw;
            }
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
