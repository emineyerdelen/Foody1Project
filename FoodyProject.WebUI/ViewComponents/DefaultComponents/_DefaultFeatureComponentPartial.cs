﻿using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultFeatureComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
