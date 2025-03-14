using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.ViewComponents.LayoutComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
