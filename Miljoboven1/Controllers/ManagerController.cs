using Microsoft.AspNetCore.Mvc;
using Miljoboven3.Models;

namespace Miljoboven3.Controllers;

public class ManagerController : Controller
{
    private readonly IMiljobovenRepository _repository;

    public ManagerController(IMiljobovenRepository repository)
    {
        _repository = repository;
    }

    public ViewResult CrimeManager(string id)
    {
        ViewBag.Id = id;
        return View(_repository);
    }

    public ViewResult StartManager()
    {
        return View(_repository);
    }
}