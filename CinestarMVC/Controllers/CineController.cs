using Microsoft.AspNetCore.Mvc;
using CinestarMVC.Data;
using CinestarMVC.Models;
using System.Linq;



namespace CinestarMVC.Controllers
{
    public class CineController : Controller
    {
        private readonly CineDAO _cineDAO = new CineDAO();

        public IActionResult Index()
        {
            var cines = _cineDAO =new CineDAO();
            return View(cines);
        }

        public IActionResult Detalle(int id)
        {
            var CinePrincipal =_cineDAO.GetCines().FirstOrDefault();                        
            return View(CinePrincipal);
        }

    }
}
