using Microsoft.AspNetCore.Mvc;

namespace Valentines.Controllers
{
    public class ValentinesController : Controller
    {
        public IActionResult Valentines()
        {
            return View();
        }
    }
}
