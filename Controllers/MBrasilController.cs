using master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace master.Controllers
{
    public class MBrasilController : Controller
    {
        private readonly ILogger<MBrasilController> _logger;

        public MBrasilController(ILogger<MBrasilController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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