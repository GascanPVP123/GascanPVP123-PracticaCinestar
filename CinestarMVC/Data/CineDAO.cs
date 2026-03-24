
using Microsoft.AspNetCore.Mvc;

namespace CinestarMVC.Data
{
    public class CineDAO : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
