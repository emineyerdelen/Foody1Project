using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultCarouselComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
