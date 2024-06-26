using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class Usuario
    {
        public int id { get; set; }

        public string idioma { get; set; }
        [Required(ErrorMessage = "El alias del usuario es obligatorio.")]
        [StringLength(50)]
        public string alias { get; set; }
        [Required(ErrorMessage = "El email del usuario es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido.")]
        [StringLength(50)]
        public string email { get; set; }
        [Required(ErrorMessage = "La contraseña del usuario es obligatoria.")]
        [StringLength(50)]
        public string contraseña { get; set; }
       
        //public List<Familia> Familia { get; set; }
    }
}
