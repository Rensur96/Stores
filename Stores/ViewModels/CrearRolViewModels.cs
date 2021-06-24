using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.ViewModels
{
    public class CrearRolViewModels
    {
        [Required(ErrorMessage ="Campo obligatorio")]
        [Display(Name ="Rol")]
        public string NameRol { get; set; }
    }
}
