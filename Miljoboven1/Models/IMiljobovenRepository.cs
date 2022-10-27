namespace Miljoboven3.Models;
/*
 *  This is the interface for the repository.
 *  It is used to get data from the fake-database.
 */

public interface IMiljobovenRepository
{
 IQueryable<Errand> Errands { get; }
 IQueryable<ErrandStatus> ErrandStatus1 { get; }
 IQueryable<Employee> Employees { get; }
 IQueryable<Department> Departments { get; }

 Errand ShowErrandData(string id);
}