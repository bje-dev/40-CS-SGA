using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class Cliente
    {
        public int id { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        [StringLength (50)]
        public string nombre { get; set; }
        [Required(ErrorMessage = "El apellido del cliente es obligatorio.")]
        [StringLength(50)]
        public string apellido { get; set; }
        [Required(ErrorMessage = "El nombre de la empresa es obligatorio.")]
        [StringLength(50)]
        public string empresa { get; set; }
        [Required(ErrorMessage = "El DNI del cliente es obligatorio.")]
        [StringLength(8, MinimumLength = 1)]
        public string dni { get; set; }
        [Required(ErrorMessage = "La direccion del cliente es obligatoria.")]
        [StringLength(50)]
        public string direccion { get; set; }
        [Required(ErrorMessage = "El CUIL/CUIT del cliente es obligatorio.")]
        [StringLength(50)]
        public string cuilcuit { get; set; }
        [Required(ErrorMessage = "El telefono del cliente es obligatorio.")]
        [StringLength(50)]
        public string telefono { get; set; }
        [Required(ErrorMessage = "El codigo postal del cliente es obligatorio.")]
        [StringLength(50)]
        public string codigopostal { get; set; }

        public Usuario usuario { get; set; }


       // public Cliente()
        //{
        //    usuario = new Usuario();
        //}
    }
}
