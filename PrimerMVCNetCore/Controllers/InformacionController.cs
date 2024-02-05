using Microsoft.AspNetCore.Mvc;
using PrimerMVCNetCore.Models;

namespace PrimerMVCNetCore.Controllers
{
    public class InformacionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult VistaControladorPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaControladorPost(Persona persona, string Aficiones)
        {
            ViewData["DATOS"] = " Nombre: " + persona.Nombre + ", Email: " + persona.Email + ", Edad: " + persona.Edad + ", Aficiones: " + Aficiones;
            return View();
        }

        public IActionResult ControladorVista()
        {
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 24;
            ViewBag.DiaSemana = "Lunes";
            ViewData["DIASEMANA"] = "Mañana es Martes";
            Persona persona = new Persona();
            persona.Nombre = "Persona Model";
            persona.Email = "model@gmail.com";
            persona.Edad = 77;
            return View(persona);
        }

        public IActionResult VistaControladorGet(string app, int? version)
        {
            if (version is null)
            {

            }

            ViewData["DATOS"] = "Application: " + app.ToUpper() + ", Version: " + version.GetValueOrDefault();
            return View();
        }
    }
}
