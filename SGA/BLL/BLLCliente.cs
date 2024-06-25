using BLL.Contracts;
using BLL.Services;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public sealed class BLLCliente : BLLIClienteRepository<Cliente>
    {
        private readonly static BLLCliente _instance = new BLLCliente();

        public static BLLCliente Current
        {
            get
            {
                return _instance;
            }
        }

        private BLLCliente()
        {
            //Implent here the initialization of your singleton
        }

        public void CrearClienteUsuario(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void ActualizarClienteUsuario(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void EliminarClienteUsuario(Guid id)
        {
            throw new NotImplementedException();
        }

        public Cliente ObtenerClienteUsuario(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ObtenerClientesUsuarios()
        {
            throw new NotImplementedException();
        }
    }

}
