using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultVisitComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
