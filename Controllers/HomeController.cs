using Microsoft.AspNetCore.Mvc;
using Projeto_Financeiro.Models;
using System.Diagnostics;

namespace Projeto_Financeiro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Pagina_Inicial()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Quem_sou_eu()
        {
            return View();
        }

        public IActionResult O_que_fazemos()
        {
            return View();
        }

        public IActionResult Serviços()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}