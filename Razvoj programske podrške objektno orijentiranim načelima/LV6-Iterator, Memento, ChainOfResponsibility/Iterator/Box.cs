public class Box : IProductCollection
{
    private List<Product> products;
    public Box() { this.products = new List<Product>(); }
    public Box(List<Product> products)
    {
        this.products = new List<Product>(products.ToArray());
    }
    public void AddProduct(Product product) { this.products.Add(product); }
    public void RemoveProduct(Product product) { this.products.Remove(product); }
    public int Count { get { return this.products.Count; } }

    public Product this[int index] { get { return this.products[index]; } }
    public IProductIterator GetIterator() { return new BoxIterator(this); }
}
