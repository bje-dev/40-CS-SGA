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

	public sealed class ClienteService:BLLIGenericRepository<Cliente>
    {
		private readonly static ClienteService _instance = new ClienteService();

		public static ClienteService Current
		{
			get
			{
				return _instance;
			}
		}

		private ClienteService()
		{
			//Implent here the initialization of your singleton
		}

        public void Create(Cliente obj)
        {
            try
            {
                DateTime today = DateTime.Today;
                int age = today.Year - obj.nacimiento.Year;
              
                if (age > 18 )
                {
                    Fabricacion.Current.GetClienteRepository().Create(obj);
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

        public void Update(Cliente obj)
        {

           

            try
            {
                DateTime today = DateTime.Today;
                int age = today.Year - obj.nacimiento.Year;
                if (age > 18 )
                {
                    Fabricacion.Current.GetClienteRepository().Update(obj);
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

        public void Delete(int id)
        {
            try
            {
                Fabricacion.Current.GetClienteRepository().Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public Cliente GetOne(int id)
        {
            try
            {
               return Fabricacion.Current.GetClienteRepository().GetOne(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Cliente> GetAll()
        {
            try
            {
                return Fabricacion.Current.GetClienteRepository().GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

	
}
