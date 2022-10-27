using Microsoft.AspNetCore.Mvc;
using Miljoboven3.Infrastructure;
using Miljoboven3.Models;

namespace Miljoboven3.Controllers;

public class CoordinatorController : Controller
{
 private readonly IMiljobovenRepository _repository;

 public CoordinatorController(IMiljobovenRepository repository)
 {
  _repository = repository;
 }

 public ViewResult StartCoordinator()
 {
  return View(_repository);
 }

 public ViewResult ReportCrime()
 {
  var GetErrandSession = HttpContext.Session.Get<Errand>("NewErrand");

  if (GetErrandSession != null)
   return View(GetErrandSession);
  return View();
 }

 public ViewResult Thanks()
 {
  HttpContext.Session.Remove("NewErrand");
  return View();
 }

 public ViewResult Validate(Errand validateErrand)
 {
  HttpContext.Session.Set("NewErrand", validateErrand);
  return View(validateErrand);
 }

 public ViewResult CrimeCoordinator(string id)
 {
  ViewBag.Id = id;
  var data = _repository.ShowErrandData(id);
  return View(data);
 }
}