public class AccidentReport
{
    private Dictionary<string, decimal> accidents;

    public AccidentReport()
    {
        this.accidents = new Dictionary<string, decimal>();
    }

    public AccidentReport(AccidentReport accidentReport)
    {
        this.accidents = new Dictionary<string, decimal>(accidentReport.accidents);
    }

    public void AddCarInvolved(string id, decimal damage)
    {
        accidents.Add(id, damage);
    }
    public decimal CalculateTotalDamage()
    {
        return accidents.Sum(a=>a.Value);
    }
    public decimal GetDamageForCar(string id)
    {
        return accidents[id];
    }
    public List<string> GetAllInvolvedCars()
    {
        return accidents.Keys.ToList();
    }
    public bool WasCarInvolved(string id)
    {
        return accidents.ContainsKey(id);
    }
}