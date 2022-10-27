using Microsoft.AspNetCore.Mvc;
using Miljoboven3.Infrastructure;
using Miljoboven3.Models;

namespace Miljoboven3.Controllers;

public class CitizenController : Controller
{
    /*
     * TODO: Create a database connection
     */
    //private readonly MiljobovenDbContext _db;

    //public CitizenController(MiljobovenDbContext db)
    //{
    //    _db = db;
    //}

    private readonly IMiljobovenRepository _repository;

    public CitizenController(IMiljobovenRepository repository)
    {
        _repository = repository;
    }


    public ViewResult Services()
    {
        return View();
    }

    public ViewResult Contact()
    {
        return View();
    }

    public ViewResult Faq()
    {
        return View();
    }

    public ViewResult Thanks()
    {
        HttpContext.Session.Remove("NewErrand");
        return View();
    }

    [HttpPost]
    public ViewResult Validate(Errand validateErrand)
    {
        HttpContext.Session.Set("NewErrand", validateErrand);
        return View(validateErrand);
    }
}