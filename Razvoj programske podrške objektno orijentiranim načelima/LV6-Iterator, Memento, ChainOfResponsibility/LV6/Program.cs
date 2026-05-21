using System.Security.Cryptography.X509Certificates;

static class Program
{
    static void Main()
    {
        TestIterator();
        TestMemento();
        TestChainOfResponsibility();
    }
    static void TestIterator()
    {
        Console.WriteLine("-------------------First Task---------------------------");
        Notebook notebook = new Notebook();

        notebook.AddNote(new Note("title1", "text1"));
        notebook.AddNote(new Note("title2", "text2"));
        notebook.AddNote(new Note("title3", "text3"));

        IAbstractIterator iterator = notebook.GetIterator();


        while (!iterator.IsDone)
        {
            iterator.Current.Show();
            iterator.Next();
        }
        Console.WriteLine("-------------------Second Task---------------------------");

        Box box = new Box();
        box.AddProduct(new Product("Product1", 1250.00));
        box.AddProduct(new Product("Product2", 45.50));
        box.AddProduct(new Product("Product3", 70.00));

        IProductIterator iterator2 = box.GetIterator();

        while (!iterator2.IsDone)
        {
            Console.WriteLine(iterator2.Current);
            iterator2.Next();
        }
    }
    static void TestMemento()
    {
        Console.WriteLine("-------------------Third Task---------------------------");
        ToDoItem task = new ToDoItem("Title 1", "Do Task 1!", DateTime.Now.AddDays(1));
        CareTaker storage = new CareTaker();

        storage.Add(task.StoreState());
        Console.WriteLine(task);

        task.ChangeTask("Now do task 2!");
        Console.WriteLine(task);

        Memento previous = storage.PreviousState();
        task.RestoreState(previous);

        Console.WriteLine(task);

        previous = storage.PreviousState();
        task.RestoreState(previous);

        Console.WriteLine("-------------------Fourth Task---------------------------");

        BankAccount account = new BankAccount("owner", "owner adress 102", 120);
        BankAccountCareTaker bankAccountStorage = new BankAccountCareTaker();
        bankAccountStorage.Add(account.StoreState());

        Console.WriteLine(account);
        account.UpdateBalance(100);



        Console.WriteLine("Account after deposit: " + account);

        var previous2 = bankAccountStorage.PreviousState();

        account.RestoreState(previous2);

        Console.WriteLine("Account after undo: " + account);


    }
    static void TestChainOfResponsibility()
    {
        Console.WriteLine("-------------------Fifth Task---------------------------");

        AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
        FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "logFile.txt");

        logger.SetNextLogger(fileLogger);

        logger.Log("Info message.", MessageType.INFO);
        logger.Log("Warning message.", MessageType.WARNING);
        logger.Log("Error message.", MessageType.ERROR);

        Console.WriteLine("-------------------Sixth Task---------------------------");

        StringChecker lengthChecker = new StringLengthChecker(8);
        StringChecker digitChecker = new StringDigitChecker();
        StringChecker lowerCaseChecker = new StringLowerCaseChecker();
        StringChecker upperCaseChecker = new StringUpperCaseChecker();

        lengthChecker.SetNext(digitChecker);
        digitChecker.SetNext(lowerCaseChecker);
        lowerCaseChecker.SetNext(upperCaseChecker);

        string password1 = "aA123456";
        Console.WriteLine($"Password {password1} valid = {lengthChecker.Check(password1)}");

        string password2 = "a234";
        Console.WriteLine($"Password {password2} valid = {lengthChecker.Check(password2)}");

        string password3 = "aaaaa";
        Console.WriteLine($"Password {password3} valid = {lengthChecker.Check(password3)}");

        Console.WriteLine("-------------------Sixth Task---------------------------");

        PasswordValidator validator = new PasswordValidator(8);

        Console.WriteLine($"Password {password1} valid = {validator.IsValid(password1)}");
        Console.WriteLine($"Password {password2} valid = {validator.IsValid(password2)}");
        Console.WriteLine($"Password {password3} valid = {validator.IsValid(password3)}");
    }

    
    
}