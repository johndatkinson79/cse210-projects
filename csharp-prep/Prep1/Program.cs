using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string forename = Console.ReadLine();

        Console.Write("What is your last name? ");
        string surname = Console.ReadLine();

        Console.WriteLine($"Your name is {surname}, {forename} {surname}.");
    }
}