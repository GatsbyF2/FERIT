public class Car
{
    public string VehicleId { get; private set; }
    public string Make { get; private set; }
    public string Model { get; private set; }
    public int Kilometrage { get; private set; }
    public int BuildYear { get; private set; }

    public Car(string vehicleId, string brand, string type, int kilometrage, int buildYear)
    {
        VehicleId = vehicleId;
        Make = brand;
        Model = type;
        Kilometrage = kilometrage;
        BuildYear = buildYear;
    }

    public override string ToString() =>
        $"{Make} - {Model} - {Kilometrage} - {BuildYear}";

    public override int GetHashCode() =>
        HashCode.Combine(VehicleId, Make, Model, BuildYear);

    public override bool Equals(object other)
    {
        Car car = other as Car;
        if (car is null) return false;
        return this.Equals(car);
    }

    public bool Equals(Car other)
    {
        return this.Make == other.Make &&
               this.Model == other.Model &&
               this.BuildYear == other.BuildYear &&
               this.Kilometrage == other.Kilometrage;
    }
}
