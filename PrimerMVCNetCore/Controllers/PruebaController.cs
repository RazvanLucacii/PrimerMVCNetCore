using Microsoft.AspNetCore.Mvc;

namespace PrimerMVCNetCore.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult PrimeraPagina()
        {
            return View();
        }
    }
}
