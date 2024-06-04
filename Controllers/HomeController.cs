using Microsoft.AspNetCore.Mvc;
using ProjetoFinal_Myte_Grupo3.Models;
using System.Diagnostics;

namespace ProjetoFinal_Myte_Grupo3.Controllers
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

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            // L�gica adicional para a a��o Index
            return RedirectToAction("Index", "WorkingHours");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
