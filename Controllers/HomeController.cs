using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETCoreSemana02MVC.Models;

namespace NETCoreSemana02MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Services()
        {
            Persona persona1 = new Persona();
            persona1.personaID = 1;
            persona1.personaNombre = "Paolo Guerrero";
            persona1.personaCorreo = "paolo@qbo.com";

            Persona persona2 = new Persona(2, "Jefferson Farfarn", "farfan@qbo.com");

            List<Persona> listado = new List<Persona>();
            listado.Add(persona1);
            listado.Add(persona2);
            listado.Add(new Persona(3, "Gianluca Lapadula", "lapa@qbo.com"));

            ViewBag.ListadoPersonas = listado;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
