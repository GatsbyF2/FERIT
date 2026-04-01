using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Xml.Linq;

public class Program
{
    static void Main()
    {
        //TestTask2();

        //TestTask3();

        //TestPrinter();
    }

    static void TestTask2()
    {
        Quote firstQuote = new Quote("Igor", "Matanović", new DateOnly(1995, 8, 9), "Život je pun uspona i Padova je grad u Italiji");
        Console.WriteLine(firstQuote.ToString());
        firstQuote.Upvote();
        firstQuote.AddTag("Frankfurt");
        firstQuote.AddTag("Frankfurt");
        Console.WriteLine(firstQuote.ToString());

        Author brunoAuthor = new Author("Bruno", "Petković", new DateOnly(1995, 1, 1));
        Quote secondQuote = new Quote(brunoAuthor, "Bolje ispast glup nego iz aviona");
        Console.WriteLine(secondQuote.ToString());
    }
    static void TestTask3()
    {
        QuotesDatabase quotesDatabase = new QuotesDatabase();
        Console.WriteLine(string.Join("\n", quotesDatabase.GetQuotesByAuthor("Robert", "Martin")));

        Console.WriteLine(string.Join("\n", quotesDatabase.GetQuotesByAuthor("Robert", "Špikić")));
    }

    static void TestPrinter()
    {

        Author testAuthor = new Author("Danci", "Najjaci", new DateOnly(1980, 1, 1));
        Quote q1 = new Quote(testAuthor, "Prvi citat (najmanje glasova)");
        Quote q2 = new Quote(testAuthor, "Drugi citat (najviše glasova)");
        Quote q3 = new Quote(testAuthor, "Treći citat (srednje glasova)");
        Quote q4 = new Quote(testAuthor, "Četvrti citat (nula glasova)");
        Quote q5 = new Quote(testAuthor, "Peti citat (drugi po redu po glasovima)");

        q2.Upvote(); q2.Upvote(); q2.Upvote();
        q5.Upvote(); q5.Upvote();
        q3.Upvote();               

        List<Quote> testQuotes = new List<Quote> { q1, q2, q3, q4, q5 };

        QuotePrinter printer = new QuotePrinter();

        printer.PrintQuote(q2);
        Console.WriteLine();

        printer.PrintQuotes(testQuotes);
        Console.WriteLine();

        printer.SetColors(ConsoleColor.Cyan, ConsoleColor.Red);
        printer.PrintQuotes(testQuotes);
    }
}
