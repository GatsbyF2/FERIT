public interface ICarRepository
{
    IEnumerable<Car> GetAll();
    public IEnumerable<Car> Filter(Func<Car, bool> filter);
}

public class NetworkCarRepository : ICarRepository
{
    private static List<Car> usedCars = new List<Car>
    {
        new Car("JT2BF28K0X0158222","Peugeot", "308", 178000, 2011),
        new Car("1FALP5747PA186161","Volkswagen", "Passat", 129000, 2016),
        new Car("1J4AA2D10AL156565","Volvo", "V40", 141600, 2016),
        new Car("1J4FA49S02P795977","Opel", "Insignia", 320395, 2011),
        new Car("1C6RR7MT2DS539778","Dacia", "Duster", 53509, 2015),
        new Car("1C3CCCAB0FN527140","Volkswagen", "Golf VI", 170000, 2010),
        new Car("1FMEU73E96UA79031","Volkswagen", "Golf VI", 149000, 2009),
        new Car("WBA5A5C57FD506754","Opel", "Astra", 146200, 2007),
        new Car("1N4AL21E49N496914","Peugeot", "4007", 249800, 2008),
        new Car("2GCEK19T4Y1166993","Ford", "Fiesta", 158111, 2013),
        new Car("1FTFW1ET4EKD48588","Dacia", "Sandero", 121000, 2014),
        new Car("1GF5ACVKXPD186618","Peugeot", "208", 134878, 2016),
        new Car("WDDGF4HB1EA968951","Opel", "Meriva", 128500, 2010),
        new Car("5UXZV4C5XD0G75062","Volkswagen", "Golf VII", 178000, 2013),
        new Car("SHSRD78916U429111","Opel", "Astra", 167000, 2011),
        new Car("2C8GF68454R687087","Ford", "C-Max", 1203835, 2009),
        new Car("2LNBL8CVXBX754805","Volkswagen", "Passat", 132700, 2014),
        new Car("WAUDF78E57A005138","Renault", "Megane", 186650, 2009),
        new Car("2G4WC582X81151833","Ford", "Focus", 182459, 2012),
        new Car("1HGCR2F80EA172625","Hyundai", "i30", 163258, 2013),
        new Car("KNADC125X46314035","Peugeot", "308", 148000, 2014),
        new Car("WDDGF4HB0DA755925","Renault", "Megane", 150000, 2016),
        new Car("19UUA66246A028043","Opel", "Astra", 230000, 2011),
        new Car("1GNDV23WX8D193588","Dacia", "Duster", 126000, 2015),
        new Car("2GCEK19T3Y1102766","Renault", "Clio", 118000, 2007),
        new Car("3N1AB6AP8BL669509","Volkswagen", "Polo", 102000, 2014),
        new Car("1G1BL837XNW191401","Nissan", "Qashqai", 132000, 2014),
        new Car("1XP5DB9X66D699186","Volkswagen", "Golf V", 280000, 2005),
        new Car("2G1FC3D33E9253794","Porsche", "Panamera", 73000, 2013),
        new Car("1HGCD7256VA017634","Renault", "Scenic", 98895, 2017),
    };
    public IEnumerable<Car> Filter(Func<Car,bool> filter)
    {
        List<Car> filteredCars = new List<Car>();
        for(int i=0; i< usedCars.Count; i++)
        {
            if (filter(usedCars[i])) filteredCars.Add(usedCars[i]);
        }
        return filteredCars;
    }

    public IEnumerable<Car> GetAll() => usedCars.AsReadOnly();
}