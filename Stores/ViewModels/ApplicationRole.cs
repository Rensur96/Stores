using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.ViewModels
{
    public class ApplicationRole:IdentityRole
    {
        public ApplicationRole(): base(){}
        public ApplicationRole(string roleName):base()
        {
            this.description = description;
        }
        public ApplicationRole(string roleName,string description):base(roleName)
        {

        }
        public string description { get; set; }
    }
}
