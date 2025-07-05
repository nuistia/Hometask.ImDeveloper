using Hometask.ImDeveloper.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hometask.ImDeveloper.Web.Controllers;

public class WelcomePageController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Result(WelcomePageForm model)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", model);
        }

        return View(model);
    }
}
