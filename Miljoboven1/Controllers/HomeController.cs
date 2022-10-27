using Microsoft.AspNetCore.Mvc;
using Miljoboven3.Infrastructure;
using Miljoboven3.Models;

namespace Miljoboven3.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        //Hämta ut från sessionen för att spara i databasen
        var GetErrandSession = HttpContext.Session.Get<Errand>("NewErrand");

        if (GetErrandSession == null)
            return View();
        return View(GetErrandSession);
    }

    public ViewResult Login()
    {
        return View();
    }
}