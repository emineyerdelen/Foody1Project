using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
