using System.Globalization;
using System.Text.RegularExpressions;

RunDemo();
static void RunDemo()
{
    //TeamStats hajduk = new TeamStats();
    //Console.WriteLine(hajduk.ToString());
    //hajduk.Add(3, 1);
    //hajduk.Add(0, 0);
    //Console.WriteLine(hajduk.ToString());
    //TeamStats projection = new TeamStats(2, 3, 1, 6, 3);
    //TeamStats hajdukProjection = hajduk + projection;
    //Console.WriteLine(hajdukProjection.ToString());

    //TeamStats[] statistics = new TeamStats[]
    //{
    //    new TeamStats(6, 1, 2, 20, 7), 
    //    new TeamStats(7, 0, 3, 13, 6),
    //    new TeamStats(1, 4, 6, 8, 25),
    //    new TeamStats(7, 1, 2, 21, 8),
    //    new TeamStats(0, 1, 10, 7, 28),
    //    new TeamStats(4, 4, 2, 10, 7),
    //    new TeamStats(4, 3, 3, 24, 17),
    //    new TeamStats(3, 4, 3, 14, 11),
    //    new TeamStats(3, 3, 5, 14, 24),
    //    new TeamStats(3, 5, 2, 16, 14),
    // };
    //TeamStats bestTeam = statistics[0];
    //for(int i=1; i<statistics.Length; i++)
    //{
    //    if (statistics[i]>bestTeam) bestTeam=statistics[i];
    //}
    //Console.WriteLine(bestTeam.ToString());

    //Form form = new Form();
    //Console.Write("Prije: "+ form.ToString());
    //form.AddLatest(MatchOutcome.Win);
    //form.AddLatest(MatchOutcome.Win);
    //Console.Write("Poslije: "+form.ToString());
    //Console.Write(form.isGood());


    //CultureInfo croatian = CultureInfo.CreateSpecificCulture("hr-HR");

    //Form osijek = new Form();
    //Console.WriteLine(osijek.ToString());

    //osijek.AddLatest(MatchOutcome.Draw);
    //osijek.AddLatest(MatchOutcome.Draw);
    //osijek.AddLatest(MatchOutcome.Loss);
    //osijek.AddLatest(MatchOutcome.Loss);
    //osijek.AddLatest(MatchOutcome.Loss);

    //Console.WriteLine(osijek.ToString());

    //osijek[4] = MatchOutcome.Win;
    //Console.WriteLine(osijek[4]);
    //Console.WriteLine("Is in good form: " + osijek.isGood());

    //Match[] matches = new Match[]
    //{
    //        new Match(DateTime.Parse("01/10/2023 18:00", croatian), "Hajduk", "Dinamo", 1, 0),
    //        new Match(DateTime.Parse("26/08/2023 21:05", croatian), "Lokomotiva", "Osijek", 2, 2),
    //        new Match(DateTime.Parse("07/10/2023 18:00", croatian), "Rijeka", "Hajduk", 1, 0),
    //        new Match(DateTime.Parse("13/08/2023 21:05", croatian), "Hajduk", "Slaven Belupo", 1, 0),
    //};

    //MatchAnalytics analytics = new MatchAnalytics();
    //Console.WriteLine(analytics.TimeBetweenFirstAndLast(matches, "Hajduk"));
    //Form f1 = new Form(); f1.AddLatest(MatchOutcome.Win);
    //Form f2 = new Form(); f2.AddLatest(MatchOutcome.Win);
    //Console.WriteLine(analytics.AreBothInGoodForm(f1, f2));

    CultureInfo croatian = CultureInfo.CreateSpecificCulture("hr-HR");

    Match[] matches = new Match[]
    {
            new Match(DateTime.Parse("01/10/2023 18:00", croatian), "Hajduk", "Dinamo", 1, 0),
            new Match(DateTime.Parse("26/08/2023 21:05", croatian), "Lokomotiva", "Osijek", 2, 2),
            new Match(DateTime.Parse("07/10/2023 18:00", croatian), "Rijeka", "Hajduk", 1, 0),
            new Match(DateTime.Parse("13/08/2023 21:05", croatian), "Hajduk", "Slaven Belupo", 1, 0),
    };

    Team hajduk = new Team("Hajduk");
    Team dinamo = new Team("Dinamo");

    Console.WriteLine($"{hajduk.name} [{hajduk.GetAbbriviatedName()}]");
    Console.WriteLine(hajduk.ToString());


    Team better = hajduk > dinamo ? hajduk : dinamo;
    Console.WriteLine("Better team BEFORE Ferit match:");
    Console.WriteLine(better.ToString());

    Random rng = new Random();
    Match feritMatch = rng.NextMatch(better.GetAbbriviatedName(), "Ferit");
    better.AddLatest(feritMatch);

    Console.WriteLine("Better team AFTER Ferit match:");
    Console.WriteLine(better.ToString());
}
