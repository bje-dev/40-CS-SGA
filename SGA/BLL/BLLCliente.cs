using BLL.Contracts;
using DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente : BLLIGenericRepository<Cliente>
    {
        public void Create(Cliente obj)
        {
            try
            {
                if (obj.nombre=="" || obj.apellido=="" || obj.dni=="" || obj.telefono=="")
                {
                    
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }

}
