using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ZSK_Beispiel.Models;

namespace ZSK_Beispiel.Controllers {
    public class HomeController : Controller {
        public ViewResult Index() {
            return View();
        }

        [HttpGet]
        public ViewResult Euro2ZSK() { 
            return View(); 
        }

        [HttpPost]
        public ViewResult Euro2ZSK(Eurowert e) {
            int zahl = Convert.ToInt32(e.Euro);

            ZSK zsk = Waehrungsrechner.Euro2ZSK(zahl);

            // Ergebnis weitergeben
            return View("ZSKErgebnis", zsk);
        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger) {
        //    _logger = logger;
        //}

        //public IActionResult Index() {
        //    return View();
        //}

        //public IActionResult Privacy() {
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error() {
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}