using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using src.Services;

namespace src.Controllers
{
    public class HomeController : Controller
    {
        private INameService nameService = new NameService();
        public IActionResult Index()
        {
            ViewData["Name"] = this.nameService.GetName(null);
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}