using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        int min, max;
        min = int.Parse(Console.ReadLine());
        max = int.Parse(Console.ReadLine());

        NetworkCarRepository carRepo = new NetworkCarRepository();

        IEnumerable<Car> FirstFilter = carRepo.Filter(c => c.Kilometrage > min && c.Kilometrage < max);

        string trazeniProizvodjac = Console.ReadLine();
        IEnumerable<Car> SecondFilter = carRepo.Filter(c => c.Make.ToLower() == trazeniProizvodjac.ToLower());

        foreach (Car c in SecondFilter)
        {
            Console.WriteLine(c.ToString());
        }

            Console.WriteLine("\n---------------------------------DRUGI ZADATAK---------------------------------------------------------------------\n");

        Console.WriteLine("Koji su svi dostupni proizvodaci automobila, sortirani uzlazno?\n");
        carRepo.GetAll().Select(c => c.Make).Distinct().OrderBy(proizvodjac => proizvodjac).ToList().ForEach(Console.WriteLine);

        Console.WriteLine("\nKoji je proizvođać automobila koji je prešao najviše kilometara\n");
        Console.WriteLine(carRepo.GetAll().OrderByDescending(c => c.Kilometrage).First().Make);

        Console.WriteLine("\nKoliko su prosjecno stare Dacie?\n");
        Console.WriteLine(carRepo.GetAll().Where(c => c.Make == "Dacia").Average(c => DateTime.Now.Year - c.BuildYear));

        Console.WriteLine("\nKoji je raspon godina (gggg. - gggg.) u kojem su proizvedeni svi automobili?\n");
        Console.WriteLine($"{carRepo.GetAll().Select(c => c.BuildYear).Min()}. -  {carRepo.GetAll().Select(c => c.BuildYear).Max()}");
        Console.WriteLine($"{carRepo.GetAll().Min(c => c.BuildYear)}. -  {carRepo.GetAll().Max(c => c.BuildYear)}");

        Console.WriteLine("\n---------------------------------Treci ZADATAK---------------------------------------------------------------------\n");


        List<Car> cars = new List<Car>()
        {
            new Car("JT2BF28K0X0158222","Peugeot", "308", 178000, 2011),
            new Car("1FALP5747PA186161","VolksWagen", "Passat", 129000, 2016),
            new Car("1G1BL837XNW191401","Nissan", "Qashqai", 132000, 2014),
            new Car("1XP5DB9X66D699186","VolksWagen", "Golf V", 280000, 2005),
            new Car("2G1FC3D33E9253794","Porsche", "Panamera", 73000, 2013),
        };

        Console.WriteLine("Original:");
        AccidentReport fenderbender = new AccidentReport();
        fenderbender.AddCarInvolved("JT2BF28K0X0158222", 323.99m);
        fenderbender.AddCarInvolved("1XP5DB9X66D699186", 463.22m);
        fenderbender.AddCarInvolved("2G1FC3D33E9253794", 11333.00m);
        Console.WriteLine(string.Join(",", fenderbender.GetAllInvolvedCars()));
        Console.WriteLine(fenderbender.CalculateTotalDamage());
        //Console.WriteLine(fenderbender.GetDamageForCar("FakeVinNumber"));
        Console.WriteLine(fenderbender.WasCarInvolved("2G1FC3D33E9253794"));

        Console.WriteLine("Copy:");
        AccidentReport fenderBenderDuplicate = new AccidentReport(fenderbender);
        fenderbender.AddCarInvolved("1G1BL837XNW191401", 256.54m);
        Console.WriteLine(string.Join(",", fenderbender.GetAllInvolvedCars()));
        Console.WriteLine(string.Join(",", fenderBenderDuplicate.GetAllInvolvedCars()));

        Console.WriteLine("Car horizontal checking:");
        AccidentReport recklessDriving = new AccidentReport();
        recklessDriving.AddCarInvolved("2G1FC3D33E9253794", 2312.00m);
        CarHorizontal carHorizontalCroatia = new CarHorizontal();


        carHorizontalCroatia.AddReports(recklessDriving);

        Dictionary<string, int> allaccidents = carHorizontalCroatia.GetAllNumbersOfAccidentsById();
        string porcheId = cars.Find(c => c.Make == "Porsche").VehicleId;
        Console.WriteLine(allaccidents[porcheId]);
        /*
         * TODO: Add both reports.
         * Find total accidents for the Panamera using the CarHorizontal instance.
         */

    }
}
