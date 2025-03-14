using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
