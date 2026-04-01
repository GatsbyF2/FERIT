static class Program
{
    static void Main()
    {
        TestSantasHelper();

    }
    static void TestSantasHelper()
    {
        Console.WriteLine("-----------------PRVI ZADATAK-------------------------------------------");

        Kid[] kids =
        {
            new Kid(1,3,true),
            new Kid(1,3,false),
            new Kid(3,3,true)
        };

        SantasHelper helper = new SantasHelper(1,3,new DentalChecker());
        Console.WriteLine($"Vrijeme obilaska: {helper.TimeNeeded(kids)} min");
        Console.WriteLine($"Spreman za put? {helper.IsSantaReady(kids)}");

        helper.SetNaughtinessChecker(new HolidayChecker());
        Console.WriteLine($"Vrijeme obilaska: {helper.TimeNeeded(kids)} min");
        Console.WriteLine($"Spreman za put? {helper.IsSantaReady(kids)}");

        Console.WriteLine("-----------------DRUGI ZADATAK-------------------------------------------");

        Factory factory = new Factory();
        factory.LoadGifts("gift_spec.txt", new Parsing());
        Console.WriteLine(factory.ToString());
        Console.WriteLine($"Middle: {factory.CalculateMiddle()}");

        Console.WriteLine("-----------------TRECI ZADATAK-------------------------------------------");

        List<Gift> gifts = factory.gifts;
        List<IGiftFilter> allFilter = new List<IGiftFilter>()
        {
            new CanAffordGiftFilter(3),
            new ChristmasSpiritFilter(),
            new HappyKidFilter()
        };
        List<Gift> giftsInBag = new SantaBag(gifts, allFilter).SantaGiftBag();
        Console.WriteLine($"\nPostotak u torbi od svih poklona: {((float)giftsInBag.Count/gifts.Count)*100}%");
    }
}
