using DAL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{


	public class Fabricacion
    {
		private readonly static Fabricacion _instance = new Fabricacion();

		public static Fabricacion Current
		{
			get
			{
				return _instance;
			}
		}
        private readonly string datasource;

        private Fabricacion()
		{
            datasource = ConfigurationManager.AppSettings["backend"];
        }




        public DALIGenericRepository<Cliente> GetClienteRepository()
        {
            try
            {
                if (datasource.ToLower() == "sql")
                {
                
                    return new Repositories.SqlServer.ClienteRepository();
                }
                else
                {
                    
                    throw new ArgumentException($"Data source '{datasource}' not supported.");

                }
            }
            catch (Exception ex)
            {
                // Registra el error, por ejemplo, en un log
                //LogError("Error al crear ProductoRepository", ex);
                throw;
            }
        }


        public DALIGenericRepository<Usuario> GetUsuarioRepository()
        {
            try
            {
                if (datasource.ToLower() == "sql")
                {

                    return new Repositories.SqlServer.UsuarioRepository();
                }
                else
                {

                    throw new ArgumentException($"Data source '{datasource}' not supported.");

                }
            }
            catch (Exception ex)
            {
                // Registra el error, por ejemplo, en un log
                //LogError("Error al crear ProductoRepository", ex);
                throw;
            }
        }


        public DALIGenericRepository<Factura> GetFacturaRepository()
        {
            try
            {
                if (datasource.ToLower() == "sql")
                {

                    return new Repositories.SqlServer.FacturaRepository();
                }
                else
                {

                    throw new ArgumentException($"Data source '{datasource}' not supported.");

                }
            }
            catch (Exception ex)
            {
                // Registra el error, por ejemplo, en un log
                //LogError("Error al crear ProductoRepository", ex);
                throw;
            }
        }

        public DALIGenericRepository<Ot> GetOtRepository()
        {
            try
            {
                if (datasource.ToLower() == "sql")
                {

                    return new Repositories.SqlServer.OtRepository();
                }
                else
                {

                    throw new ArgumentException($"Data source '{datasource}' not supported.");

                }
            }
            catch (Exception ex)
            {
                // Registra el error, por ejemplo, en un log
                //LogError("Error al crear ProductoRepository", ex);
                throw;
            }
        }

        public DALIGenericRepository<Pago> GetPagoRepository()
        {
            try
            {
                if (datasource.ToLower() == "sql")
                {

                    return new Repositories.SqlServer.PagoRepository();
                }
                else
                {

                    throw new ArgumentException($"Data source '{datasource}' not supported.");

                }
            }
            catch (Exception ex)
            {
                // Registra el error, por ejemplo, en un log
                //LogError("Error al crear ProductoRepository", ex);
                throw;
            }
        }

        public DALIGenericRepository<Solicitud> GetSolicitudRepository()
        {
            try
            {
                if (datasource.ToLower() == "sql")
                {

                    return new Repositories.SqlServer.SolicitudRepository();
                }
                else
                {

                    throw new ArgumentException($"Data source '{datasource}' not supported.");

                }
            }
            catch (Exception ex)
            {
                // Registra el error, por ejemplo, en un log
                //LogError("Error al crear ProductoRepository", ex);
                throw;
            }
        }

        public DALIGenericRepository<Ppto> GetPptoRepository()
        {
            try
            {
                if (datasource.ToLower() == "sql")
                {

                    return new Repositories.SqlServer.PptoRepository();
                }
                else
                {

                    throw new ArgumentException($"Data source '{datasource}' not supported.");

                }
            }
            catch (Exception ex)
            {
                // Registra el error, por ejemplo, en un log
                //LogError("Error al crear ProductoRepository", ex);
                throw;
            }
        }

    }

	
}
