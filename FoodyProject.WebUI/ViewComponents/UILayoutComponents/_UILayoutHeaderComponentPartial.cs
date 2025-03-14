using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutHeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
