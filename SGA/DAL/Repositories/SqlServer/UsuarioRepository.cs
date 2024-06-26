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




    internal class UsuarioRepository : DALIGenericRepository<Usuario>
    {


        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Usuarios] (alias, email, contraseña, perfil ) VALUES (@alias, @email, @contraseña, @perfil)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Usuarios] SET (alias, email, contraseña, perfil) WHERE id = @id";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Usuarios] WHERE id = @id";
        }

        private string SelectOneStatement
        {
            get => "SELECT id, alias, email, contraseña, perfil FROM [dbo].[Usuarios] WHERE id = @id";
        }

        private string SelectAllStatement
        {
            get => "SELECT id, alias, email, contraseña, perfil FROM [dbo].[Usuarios]";
        }
        #endregion

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
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {

                    new SqlParameter("@alias",obj.alias),
                    new SqlParameter("@email",obj.email),
                    new SqlParameter("@contraseña",obj.contraseña),
                    new SqlParameter("@perfil",obj.perfil)
                    

                };

                SqlHelper.ExecuteNonQuery(InsertStatement, System.Data.CommandType.Text, parameters);
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
