using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.ViewModels
{
    public class UsuarioApliacion:IdentityUser
    {
        public UsuarioApliacion(): base(){ }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
    }
}
