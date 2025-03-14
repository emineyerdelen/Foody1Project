using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
