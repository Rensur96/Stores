using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Stores.Models;
using Stores.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.Controllers
{
    //Validacion de rol
    [Authorize(Roles = "administrador")]
    public class UserController : Controller
    {
        private readonly AppDbContext _contex;
        private readonly UserManager<UsuarioApliacion> gestionUsuarios;
        private readonly RoleManager<ApplicationRole> gestionRoles;

        public UserController(RoleManager<ApplicationRole> gestionRoles , AppDbContext context, UserManager<UsuarioApliacion> gestionUsuarios)
        {
            this.gestionUsuarios = gestionUsuarios;
            this.gestionRoles = gestionRoles;
            _contex = context;
        }
        
        public IActionResult Index()
        {
            var usuarios = gestionUsuarios.Users;

            return View(usuarios);
        }

        //Formulario para agregar usuario
        [HttpGet]
        public IActionResult AddUser()
        {
            var model = new RegistroModelo();
            
            var roles = gestionRoles.Roles;
            foreach (var rol in roles)
            {
                model.Roles.Add(new SelectListItem() { Text = rol.Name, Value = rol.Name });
            }
            model.Rol = "normal";
            return View(model);
        }

        //Recibir datos POST para AGREGAR usuario
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUser(RegistroModelo user)
        {
            if (ModelState.IsValid)
            {
                var usuario = new UsuarioApliacion
                {
                    UserName = user.Email,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LasttName = user.LastName
                };

                string namerol = user.Rol;
                //Agrega usuario a la base de datos
                var resultado = await gestionUsuarios.CreateAsync(usuario, user.Password);
                //Se le asigna el rol al usuario
                var rolResutado = await gestionUsuarios.AddToRoleAsync(usuario, namerol);
                if (resultado.Succeeded)
                {
                    TempData["mensaje"] = "'" + user.Email + "'@" + namerol+" agregado correctamente.";
                    return RedirectToAction("Index");
                }
                foreach (var error in resultado.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            var model = new RegistroModelo();
            
            var roles = gestionRoles.Roles;
            foreach (var rol in roles)
            {
                model.Roles.Add(new SelectListItem() { Text = rol.Name, Value = rol.Name });
            }
            model.Rol = "normal";
            return View(model);
        }
    }
}
