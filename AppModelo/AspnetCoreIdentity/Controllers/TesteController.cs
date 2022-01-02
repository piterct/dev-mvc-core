using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspnetCoreIdentity.Controllers
{
    public class TesteController : Controller
    {
        private readonly ILogger<TesteController> _logger;

        public TesteController(ILogger<TesteController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogError("Esse erro aconteceu!");

            return View();
        }
    }
}
