using Microsoft.Extensions.Caching.Memory;

namespace Miljoboven3.Models;

public class EFMiljobovenRepository : IMiljobovenRepository
{
 private readonly ApplicationDbContext _context;
 private readonly IMemoryCache _memoryCache;


 public EFMiljobovenRepository(ApplicationDbContext context, IMemoryCache memoryCache)
 {
  _context = context;
 }

 public IQueryable<Picture> Pictures => _context.Pictures;
 public IQueryable<Sample> Samples => _context.Samples;
 public IQueryable<Sequence> Sequences => _context.Sequences;

 public IQueryable<Errand> Errands => _context.Errands;
 public IQueryable<ErrandStatus> ErrandStatus1 => _context.ErrandStatus1;
 public IQueryable<Employee> Employees => _context.Employees;
 public IQueryable<Department> Departments => _context.Departments;

 public Errand ShowErrandData(string id)
 {
  return Errands.FirstOrDefault(e => e.RefNumber == id);
 }
}