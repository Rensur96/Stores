using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.ViewModels
{
    public class RegistroModelo
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [Display(Name = "Repetir contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
        public string PasswordValidar { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(20, ErrorMessage = "Longitud de caracteres entre {2} y {1} para el campo {0}", MinimumLength = 1)]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(20, ErrorMessage = "Longitud de caracteres entre {2} y {1} para el campo {0}", MinimumLength = 1)]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        public string Rol { get; set; }

        public List<SelectListItem> Roles { get; set; } = new List<SelectListItem>();
        
            //new SelectListItem { Value = "id", Text = "Normal" },
            //new SelectListItem { Value = "id2", Text = "Administrador" },
       
    }
}
