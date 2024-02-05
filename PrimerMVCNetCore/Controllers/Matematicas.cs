using Microsoft.AspNetCore.Mvc;

namespace PrimerMVCNetCore.Controllers
{
    public class Matematicas : Controller
    {
        [HttpGet]
        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosGet(int Numero1, int Numero2)
        {
            for (int i = 0; i < Numero2; i++)
            {
                ViewData[i.ToString()] = Numero1;
            }
            ViewBag.Numero1 = Numero1;
            ViewBag.Numero2 = Numero2;
            ViewData["DATOSSUMA"] = Numero1 + Numero2;
            return View();
        }

        [HttpGet]
        public IActionResult TablaMultiplicarSimple()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarSimple(int numero)
        {
            List<int> numeros = new List<int>();
            while ()
            {
                
            }
            return View(numeros);
        }
    }
}
