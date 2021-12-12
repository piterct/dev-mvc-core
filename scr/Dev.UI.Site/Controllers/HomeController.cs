using Microsoft.AspNetCore.Mvc;

namespace Dev.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
