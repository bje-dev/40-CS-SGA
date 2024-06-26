using DAL.Contracts;
using DAL.Tools;
using DOM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{

	internal sealed class ClienteRepository : DALIGenericRepository<Cliente>
    {

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Cliente] (nombre, apellido, empresa, dni, direccion, cuilcuit, telefono, codigopostal, nacimiento ) VALUES (@nombre, @apellido, @empresa, @dni, @direccion, @cuitcuil, @telefono, @codigopostal, @nacimiento)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Cliente] SET (nombre, apellido, empresa, dni, direccion, cuilcuit, telefono, codigopostal, nacimiento ) WHERE id = @id";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Cliente] WHERE id = @id";
        }

        private string SelectOneStatement
        {
            get => "SELECT id, nombre, apellido, empresa, dni, direccion, cuilcuit, telefono, codigopostal, nacimiento  FROM [dbo].[Cliente] WHERE id = @id";
        }

        private string SelectAllStatement
        {
            get => "SELECT id, nombre, apellido, empresa, dni, direccion, cuilcuit, telefono, codigopostal, nacimiento  FROM [dbo].[Cliente]";
        }
        #endregion


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
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {

                    new SqlParameter("@nombre",obj.nombre),
                    new SqlParameter("@apellido",obj.apellido),
                    new SqlParameter("@empresa",obj.empresa),
                    new SqlParameter("@dni",obj.dni),
                    new SqlParameter("@direccion",obj.direccion),
                    new SqlParameter("@telefono",obj.telefono),
                    new SqlParameter("@cuilcuit",obj.cuilcuit),
                    new SqlParameter("@codigopostal",obj.codigopostal),
                    new SqlParameter("@nacimiento",obj.nacimiento)
                    

                };

                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, parameters);
            }
            catch (Exception)
            {

                throw;
            }

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
