using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json.Serialization;
using WebApp.Image.ExtendMagic;
using WebApp.Image.Globals;
using WebApp.Models;

namespace WebApp.Controllers
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
            var text = HttpContext.Session.Get(Key.GetText);
            if (text != null || text?.Length > 0)
            {
                ViewBag.Text = text.FromByteArray();
            }
            return View();
        }

        public IActionResult Privacy()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            HttpContext.Session.Clear();
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult StartProcessing(string id)
        {
            if (id != null && id.Trim().Length > 0)
            {
                HttpContext.Session.Set(Key.GetText, id.ToByteArray());
            }
            return RedirectToAction(nameof(Index));
        }
    }
}