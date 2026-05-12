public class ShippingService
{
    double pricePerKg;

    public ShippingService(double pricePerKg)
    {
        this.pricePerKg = pricePerKg;
    }

    public double CalculateDeliveryCost(IShipable shipment)
    {
        return pricePerKg * shipment.Weight;
    }
}

