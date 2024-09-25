using Microsoft.AspNetCore.Mvc;

namespace web_asp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
