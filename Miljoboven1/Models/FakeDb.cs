namespace Miljoboven3.Models;

public class FakeDb : IMiljobovenRepository
{
 public IQueryable<ErrandStatus> ErrandStatus1 => new List<ErrandStatus>
 {
  new() { StatusId = "S_A", StatusName = "Inrapporterad" },
  new() { StatusId = "S_B", StatusName = "Ingen åtgärd" },
  new() { StatusId = "S_C", StatusName = "Påbörjad" },
  new() { StatusId = "S_D", StatusName = "Klar" }
 }.AsQueryable();

 public IQueryable<Errand> Errands => new List<Errand>
 {
  new()
  {
   ErrandId = 1, RefNumber = "2020-45-195", Place = "Skogslunden vid Jensens gård", TypeOfCrime = "Sopor",
   DateOfObservation = new DateTime(2020, 04, 24),
   Observation = "Anmälaren var på promeand i skogslunden när hon upptäckte soporna",
   InvestigatorInfo = "Undersökning har gjorts och bland soporna hittades bl.a ett brev till Gösta Olsson",
   InvestigatorAction =
    "Brev har skickats till Gösta Olsson om soporna och anmälan har gjorts till polisen 2020-05-01",
   InformerName = "Ada Bengtsson", InformerPhone = "0432-5545522", StatusId = "S_D", DepartmentId = "D05",
   EmployeeId = "E501"
  },
  new()
  {
   ErrandId = 2, RefNumber = "2020-45-196", Place = "Småstadsjön", TypeOfCrime = "Oljeutsläpp",
   DateOfObservation = new DateTime(2020, 04, 29),
   Observation = "Jag såg en oljefläck på vattnet när jag var där för att fiska",
   InvestigatorInfo = "Undersökning har gjorts på plats, ingen fläck har hittas", InvestigatorAction = "",
   InformerName = "Bengt Svensson", InformerPhone = "0432-5152255", StatusId = "S_B", DepartmentId = "D04",
   EmployeeId = "E401"
  },
  new()
  {
   ErrandId = 3, RefNumber = "2020-45-197", Place = "Ödehuset", TypeOfCrime = "Skrot",
   DateOfObservation = new DateTime(2020, 05, 02),
   Observation = "Anmälaren körde förbi ödehuset och upptäcker ett antal bilar och annat skrot",
   InvestigatorInfo = "Undersökning har gjorts och bilder har tagits", InvestigatorAction = "",
   InformerName = "Olle Pettersson", InformerPhone = "0432-5255522", StatusId = "S_C", DepartmentId = "D03",
   EmployeeId = "E301"
  },
  new()
  {
   ErrandId = 4, RefNumber = "2020-45-198", Place = "Restaurang Krögaren", TypeOfCrime = "Buller",
   DateOfObservation = new DateTime(2020, 06, 04),
   Observation = "Restaurangen hade för högt ljud på så man inte kunde sova",
   InvestigatorInfo = "Bullermätning har gjorts. Man håller sig inom riktvärden",
   InvestigatorAction = "Meddelat restaurangen att tänka på ljudet i fortsättning",
   InformerName = "Roland Jönsson", InformerPhone = "0432-5322255", StatusId = "S_D", DepartmentId = "D03",
   EmployeeId = "E302"
  },
  new()
  {
   ErrandId = 5, RefNumber = "2020-45-199", Place = "Torget", TypeOfCrime = "Klotter",
   DateOfObservation = new DateTime(2020, 07, 10),
   Observation = "Samtliga skräpkorgar och bänkar är nedklottrade", InvestigatorInfo = "",
   InvestigatorAction = "", InformerName = "Peter Svensson", InformerPhone = "0432-5322555", StatusId = "S_A"
  }
 }.AsQueryable();

 public IQueryable<Employee> Employees => new List<Employee>
 {
  new() { EmployeeId = "E001", EmployeeName = "Östen Ärling", RoleTitle = "Coordinator", DepartmentId = "D00" },
  new() { EmployeeId = "E100", EmployeeName = "Anna Åkerman", RoleTitle = "Manager", DepartmentId = "D01" },
  new() { EmployeeId = "E101", EmployeeName = "Fredrik Roos", RoleTitle = "Investigator", DepartmentId = "D01" },
  new() { EmployeeId = "E102", EmployeeName = "Gösta Qvist", RoleTitle = "Investigator", DepartmentId = "D01" },
  new() { EmployeeId = "E103", EmployeeName = "Hilda Persson", RoleTitle = "Investigator", DepartmentId = "D01" },
  new() { EmployeeId = "E200", EmployeeName = "Bengt Viik", RoleTitle = "Manager", DepartmentId = "D02" },
  new()
  {
   EmployeeId = "E201", EmployeeName = "Ivar Oscarsson", RoleTitle = "Investigator", DepartmentId = "D02"
  },
  new()
  {
   EmployeeId = "E202", EmployeeName = "Jenny Nordström", RoleTitle = "Investigator", DepartmentId = "D02"
  },
  new() { EmployeeId = "E203", EmployeeName = "Kurt Mild", RoleTitle = "Investigator", DepartmentId = "D02" },
  new() { EmployeeId = "E300", EmployeeName = "Cecilia Unosson", RoleTitle = "Manager", DepartmentId = "D03" },
  new() { EmployeeId = "E301", EmployeeName = "Lena Larsson", RoleTitle = "Investigator", DepartmentId = "D03" },
  new() { EmployeeId = "E302", EmployeeName = "Martin Kvist", RoleTitle = "Investigator", DepartmentId = "D03" },
  new() { EmployeeId = "E303", EmployeeName = "Nina Jansson", RoleTitle = "Investigator", DepartmentId = "D03" },
  new() { EmployeeId = "E400", EmployeeName = "David Trastlund", RoleTitle = "Manager", DepartmentId = "D04" },
  new()
  {
   EmployeeId = "E401", EmployeeName = "Oskar Ivarsson", RoleTitle = "Investigator", DepartmentId = "D04"
  },
  new()
  {
   EmployeeId = "E402", EmployeeName = "Petra Hermansdotter", RoleTitle = "Investigator", DepartmentId = "D04"
  },
  new()
  {
   EmployeeId = "E403", EmployeeName = "Rolf Gunnarsson", RoleTitle = "Investigator", DepartmentId = "D04"
  },
  new() { EmployeeId = "E500", EmployeeName = "Emma Svanberg", RoleTitle = "Manager", DepartmentId = "D05" },
  new() { EmployeeId = "E501", EmployeeName = "Susanne Fred", RoleTitle = "Investigator", DepartmentId = "D05" },
  new()
  {
   EmployeeId = "E502", EmployeeName = "Torsten Embjörn", RoleTitle = "Investigator", DepartmentId = "D05"
  },
  new() { EmployeeId = "E503", EmployeeName = "Ulla Davidsson", RoleTitle = "Investigator", DepartmentId = "D05" }
 }.AsQueryable();

 public IQueryable<Department> Departments => new List<Department>
 {
  new() { DepartmentId = "D00", DepartmentName = "Småstads kommun" },
  new() { DepartmentId = "D01", DepartmentName = "Tekniska Avloppshanteringen" },
  new() { DepartmentId = "D02", DepartmentName = "Klimat och Energi" },
  new() { DepartmentId = "D03", DepartmentName = "Miljö och Hälsoskydd" },
  new() { DepartmentId = "D04", DepartmentName = "Natur och Skogsvård" },
  new() { DepartmentId = "D05", DepartmentName = "Renhållning och Avfall" }
 }.AsQueryable();

 public Errand ShowErrandData(string id)
 {
  return Errands.FirstOrDefault(e => e.RefNumber == id);
 }
}