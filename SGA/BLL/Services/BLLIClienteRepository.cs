using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal interface BLLIClienteRepository<T>
    {
        void CrearClienteUsuario(T obj);

        void ActualizarClienteUsuario(T obj);

        void EliminarClienteUsuario(Guid id);

        T ObtenerClienteUsuario(Guid id);

        IEnumerable<T> ObtenerClientesUsuarios();
    }
}
