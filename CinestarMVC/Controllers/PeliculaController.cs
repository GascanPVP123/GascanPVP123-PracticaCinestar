using Microsoft.AspNetCore.Mvc;

namespace CinestarMVC.Controllers
{
    public class PeliculaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
