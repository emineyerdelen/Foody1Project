using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutSidebarComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
