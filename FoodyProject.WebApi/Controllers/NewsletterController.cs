using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebApi.Controllers
{
    public class NewsletterController : Controller
    {
      
            [HttpPost]
            public ActionResult Subscribe(string email)
            {
                if (!string.IsNullOrEmpty(email))
                {
                 

                    TempData["Success"] = "Thanks for subscribing!";
                }
                else
                {
                    TempData["Error"] = "Please enter a valid email.";
                }

                return RedirectToAction("Index", "Default");
            }
        }

    }
