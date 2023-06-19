using Identity.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterDTO registerDTO)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
