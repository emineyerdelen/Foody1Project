using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutHeadComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
