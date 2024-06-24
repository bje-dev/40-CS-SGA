using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class Cliente
    {
        private string nombre { get; set; }
        private string dni { get; set; }
        private string direccion { get; set; }
        private string email { get; set; }
        private string telefono { get; set; }
        private Usuario usuario { get; set; }


        public Cliente()
        {
            usuario = new Usuario();
        }
    }
}
