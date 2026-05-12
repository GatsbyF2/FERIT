
using System.Text;

public class Box : IShipable
{
    private List<IShipable> items;
    private string name;
    public Box(string name)
    {
        this.items = new List<IShipable>();
        this.name = name;
    }
    public void Add(IShipable item)
    {
        this.items.Add(item);
    }
    public void Remove(IShipable item)
    {
        this.items.Remove(item);
    }
    public double Price
    {
        get
        {
            double totalPrice = 0;
            foreach (IShipable item in items)
            {
                totalPrice += item.Price;
            }
            return totalPrice;
        }
    }
    public double Weight
    {
        get
        {
            double totalWeight = 0;
            foreach (IShipable item in items)
            {
                totalWeight += item.Weight;
            }
            return totalWeight;
        }
    }
    public string Description(int depth = 0)
    {
        StringBuilder builder =
       new StringBuilder(new string(' ', depth) + this.name + "\n");
        foreach (IShipable item in items)
        {
            builder.Append(item.Description(depth + 2)).Append("\n");
        }
        return builder.ToString();
    }
}
