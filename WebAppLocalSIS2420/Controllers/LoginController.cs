using Microsoft.AspNetCore.Mvc;

namespace WebAppLocalSIS2420.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            return RedirectToAction("Index");
        }
    }
}
