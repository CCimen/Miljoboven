using Microsoft.AspNetCore.Mvc;
using Miljoboven3.Models;

namespace Miljoboven3.Components;

public class ErrandDataViewComponent : ViewComponent
{
 private readonly IMiljobovenRepository _repository;

 public ErrandDataViewComponent(IMiljobovenRepository repository)
 {
  _repository = repository;
 }

 public async Task<IViewComponentResult> InvokeAsync(string Id)
 {
  var errandData = _repository.ShowErrandData(Id);
  return View(errandData);
 }
}