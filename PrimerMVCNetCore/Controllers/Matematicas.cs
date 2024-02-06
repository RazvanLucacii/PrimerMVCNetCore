using Microsoft.AspNetCore.Mvc;
using PrimerMVCNetCore.Models;

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
            List<int> resultado = new List<int>();
            for(int i = 1; i <= 10; i++)
            {
                int operacion = numero * i;
                resultado.Add(operacion);
            }
            return View(resultado);
        }

        [HttpGet]
        public IActionResult TablaMultiplicarModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarModel(int numero)
        {
            List<FilaTablaMultiplicar> resultados = new List<FilaTablaMultiplicar>();
            for (int i = 1; i <= 10; i++)
            {
                string operacion = numero + " * " + i;
                int result = numero * i;
                FilaTablaMultiplicar fila = new FilaTablaMultiplicar();
                fila.Resultado = result;
                fila.Operacion = operacion;
                resultados.Add(fila);
            }
            return View(resultados);
        }
    }
}
