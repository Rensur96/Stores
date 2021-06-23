using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.ViewModels
{
    public class Store
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(15, ErrorMessage = "Longitud de caracteres entre {2} y {1} para el campo {0}", MinimumLength = 1)]

        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
       [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(8, ErrorMessage = "Longitud de caracteres entre {2} y {1} para el campo {0}", MinimumLength = 8)]
        [Display(Name =  "Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public double Lat { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public double Long { get; set; }
        public string pathImage { get; set; }
    }
}
