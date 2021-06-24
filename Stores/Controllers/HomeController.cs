using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Stores.Models;
using Stores.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly AppDbContext _contex;
        private readonly UserManager<UsuarioApliacion> gestionUsuarios;
        private readonly SignInManager<UsuarioApliacion> gestionLogin;
        private readonly RoleManager<IdentityRole> gestionRoles;
        public HomeController(RoleManager<IdentityRole> gestionRoles ,AppDbContext context,UserManager<UsuarioApliacion> gestionUsuarios,SignInManager<UsuarioApliacion> gestionLogin)
        {
            this.gestionRoles = gestionRoles; 
            this.gestionUsuarios = gestionUsuarios;
            this.gestionLogin = gestionLogin;
            _contex = context;

        }

        public IActionResult Index()
        {
            IEnumerable<Store> liststores = _contex.Store;
            return View(liststores);
        }

        [Authorize(Roles = "administrador")]
        public IActionResult AddStore()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "administrador")]
        public IActionResult AddStore(Store model)
        {
            if (ModelState.IsValid)
            {
                _contex.Store.Add(model);
                _contex.SaveChanges();
                string nombre = model.Nombre;
                TempData["mensaje"] = "Store '" + nombre + "' agregada correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

       
        [Authorize(Roles = "administrador")]
        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //Get store
            var store = _contex.Store.Find(id);
            if (store == null)
            {
                return NotFound();
            }
            return View(store);
        }

        [HttpPost]
        [Authorize(Roles = "administrador")]
        public IActionResult Update(Store store)
        {
            if (ModelState.IsValid)
            {
                _contex.Store.Update(store);
                _contex.SaveChanges();
                string nombre = store.Nombre;
                TempData["mensaje"] = "Store '" + nombre + "' actualizada correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }
        // get Delete
        [HttpGet]
        [Authorize(Roles = "administrador")]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //Get store
            var store = _contex.Store.Find(id);
            if (store == null)
            {
                return NotFound();
            }
            return View(store);
        }
        //post DeleteStore
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "administrador")]
        public IActionResult DeleteStore(int? id)
        {
            var store = _contex.Store.Find(id);
            string nombre = store.Nombre.ToString();
            if (store == null)
            {
                return NotFound();
            }

            _contex.Store.Remove(store);
            _contex.SaveChanges();

            TempData["mensaje"] = "Store '" + nombre + "' eliminada correctamente";
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "administrador")]
        public IActionResult Users()
        {
            
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "administrador")]
        public IActionResult AddUser()
        {
            var model = new RegistroModelo();
            model.Rol = "";
            var roles = gestionRoles.Roles;
            foreach(var rol in roles)
            {
                model.Roles.Add(new SelectListItem() { Text = rol.Name, Value = rol.Name });
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "administrador")]
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

                string idrol = user.Rol;
                //Agrega usuario a la base de datos
                var resultado = await gestionUsuarios.CreateAsync(usuario, user.Password);
                var rolResutado = await gestionUsuarios.AddToRoleAsync(usuario, idrol);
                if (resultado.Succeeded)
                {
                    TempData["mensaje"] = "Usuario '" +user.Email + "' agregado correctamente.";
                    return RedirectToAction("Users");
                }
                foreach(var error in resultado.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await gestionLogin.SignOutAsync();
            return RedirectToAction("login");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel modelo)
        {
            if (ModelState.IsValid)
            {
                var result = await gestionLogin.PasswordSignInAsync(
                    modelo.Email, modelo.Password, modelo.Recuerdame, false
                    );
                if (result.Succeeded)
                {
                    return RedirectToAction("index");
                }
                ModelState.AddModelError(string.Empty, "Credenciales invalidas.");
            }
            return RedirectToAction("Login", "Home");
        }

        [HttpGet]
        [Authorize(Roles = "administrador")]
        public IActionResult AddRol()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRol(CrearRolViewModels model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.NameRol
                };
                IdentityResult result = await gestionRoles.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
