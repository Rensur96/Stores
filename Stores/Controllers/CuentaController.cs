using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stores.Models;
using Stores.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.Controllers
{
    public class CuentaController : Controller
    {
        private readonly AppDbContext _contex;
        private readonly SignInManager<UsuarioApliacion> gestionLogin;
        public CuentaController(AppDbContext context, SignInManager<UsuarioApliacion> gestionLogin)
        {
            this.gestionLogin = gestionLogin;
            _contex = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        //POST para recibi datos de login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel modelo)
        {
            if (ModelState.IsValid)
            {
                var result = await gestionLogin.PasswordSignInAsync(
                    modelo.Email, modelo.Password, modelo.Recuerdame, false
                    );
                if (result.Succeeded)
                {
                    return RedirectToAction("index","Store");
                }
                ModelState.AddModelError(string.Empty, "Credenciales invalidas.");
            }
            return RedirectToAction("Index", "Cuenta");
        }
        //Cerrar sesion
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await gestionLogin.SignOutAsync();
            return RedirectToAction("Index","Cuenta");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccesoDenegado()
        {
            return View();
        }
    }
}
