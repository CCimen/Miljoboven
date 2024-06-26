﻿using Microsoft.AspNetCore.Mvc;
using Miljoboven3.Models;

namespace Miljoboven3.Controllers;

public class InvestigatorController : Controller
{
    private readonly IMiljobovenRepository _repository;

    public InvestigatorController(IMiljobovenRepository repository)
    {
        _repository = repository;
    }

    public ViewResult CrimeInvestigator(string id)
    {
        ViewBag.ID = id;
        return View(_repository);
    }

    public ViewResult StartInvestigator()
    {
        return View(_repository);
    }
}