using Microsoft.AspNetCore.Identity;
using Stores.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.Models
{
     
    public class DummyData
    {
        public static async Task Initialize(AppDbContext context, UserManager<UsuarioApliacion> userManager, RoleManager<ApplicationRole> roleManeger)
        {
            context.Database.EnsureCreated();
            String adminId1 = "";
            string password = "Pa55w0rd.1234";

            string role1 = "administrador";
            string description1 = "Administrador de sistema";
            string role2 = "normal";

            string description2 = "Usuario normal";
            if (await roleManeger.FindByNameAsync(role1) == null)
            {
                await roleManeger.CreateAsync(new ApplicationRole(role1, description1));
            }
            if (await roleManeger.FindByNameAsync(role2) == null)
            {
                await roleManeger.CreateAsync(new ApplicationRole(role2, description2));
            }
            if (await userManager.FindByNameAsync("admin@admin.com") == null)
            {
                var user = new UsuarioApliacion
                {
                    UserName = "admin@admin.com",
                    Email = "admin@admin.com",
                    FirstName = "administrador",
                    LasttName = "administrador"
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }
        }
    }
}
