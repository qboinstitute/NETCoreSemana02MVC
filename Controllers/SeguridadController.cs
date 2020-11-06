using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreSemana02MVC.Controllers
{
    public class SeguridadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Bienvenida()
        {
            ViewBag.Nombre = "Gianluca";
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            string correo = form["txtCorreo"];
            string clave = form["txtClave"];

            if (correo == "lapa@qbo.com" && clave.Equals("123456"))
            {
                return RedirectToAction("Bienvenida");
            }
            else
            {
                return View("Login");
            }

        }


    }
}
