using Microsoft.AspNetCore.Mvc;

namespace PrimerMVCNetCore.Controllers
{
    public class Collatz : Controller
    {
        [HttpGet]
        public IActionResult ConjeturaCollatzForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatzForm(int numero)
        {
            List<int> numeros = new List<int>();
            while (numero != 1)    
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            //devolvemos el model a la vista
            return View(numeros);
        }
    }
}
