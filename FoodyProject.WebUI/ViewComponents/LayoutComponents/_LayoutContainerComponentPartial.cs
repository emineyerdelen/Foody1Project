using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutContainerComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
