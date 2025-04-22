using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
