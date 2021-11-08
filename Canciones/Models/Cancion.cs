using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Canciones.Models
{
    public class Cancion
    {
        [Key]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public string Autor { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Animo { get; set; }
        [Url]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Enlace { get; set; }

    }
}
