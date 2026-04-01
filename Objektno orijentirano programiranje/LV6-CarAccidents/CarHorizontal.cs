public class CarHorizontal
{
    List<AccidentReport> reports;
    public CarHorizontal()
    {
        reports = new List<AccidentReport>();
    }
    public void AddReports(AccidentReport report)
    {
        reports.Add(new AccidentReport(report));
    }
    public List<AccidentReport> GetAllReportsForCar(Car car)
    {
        return reports.Where(c=>c.WasCarInvolved(car.VehicleId)).ToList<AccidentReport>();
    }
    public Dictionary<string, int> GetAllNumbersOfAccidentsById()
    {
        return reports.SelectMany(r => r.GetAllInvolvedCars())
              .GroupBy(id => id)
              .ToDictionary(g => g.Key, g => g.Count());
    }

}