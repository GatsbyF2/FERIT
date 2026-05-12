using System.Data;

public class Program
{
    static void Main()
    {
        TestBridge();
    }
    static void TestComposit()
    {
        Product firstProduct = new Product("first", 10, 10);
        Product secondProduct = new Product("second", 20, 20);


        Box box = new Box("NewBox");
        box.Add(firstProduct);
        box.Add(secondProduct);

        ShippingService shippingService = new ShippingService(100);
        Console.WriteLine(firstProduct.Description());
        Console.WriteLine(shippingService.CalculateDeliveryCost(firstProduct));
        Console.WriteLine(box.Description());
        Console.WriteLine(shippingService.CalculateDeliveryCost(box));
    }
    static void TestProxy()
    {
        DataConsolePrinter printer = new DataConsolePrinter();

        Console.WriteLine("Virtual Proxy");

        IDataset virtualProxy = new VirtualProxyDataset("Data.csv");
        printer.Print(virtualProxy.GetData());

        Console.WriteLine("\nAuthorized User");

        User authorizedUser = User.GenerateUser("User1");
        IDataset protectionProxy = new ProtectionProxyDataset(authorizedUser);
        printer.Print(protectionProxy.GetData());

        Console.WriteLine("\nUnauthorized User");

        User unauthorizedUser = User.GenerateUser("User2");
        IDataset protectionProxy2 = new ProtectionProxyDataset(unauthorizedUser);
        printer.Print(protectionProxy2.GetData());

        Console.WriteLine("\nLogger Proxy");
        IDataset loggerProxy = new LoggingProxyData("Data.csv");
        printer.Print(loggerProxy.GetData());
    }
    static void TestBridge()
    {
        ITheme lightTheme = new LightTheme();
        ITheme hackerTheme = new HackerTheme();

        GroupNotes groupNotes = new GroupNotes(new List<string> { "John", "Mark", "James" }, "Note!!", lightTheme);
        groupNotes.AddMember("Mark2");
        groupNotes.RemoveMember("John");
        groupNotes.Show();

        GroupNotes groupNotes2 = new GroupNotes(new List<string> { "John", "Mark", "James" }, "Note2!!", hackerTheme);
        groupNotes2.Show();

        Console.WriteLine("\nNotebook:\n");

        Notebook notebook = new Notebook(hackerTheme);
        notebook.AddNote(groupNotes);
        notebook.AddNote(groupNotes2);
        notebook.Display();
    }
}