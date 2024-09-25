using Microsoft.AspNetCore.Mvc;

namespace web_asp2.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            ViewData["Title"] = "Login";
            return View();
        }
    }
}
