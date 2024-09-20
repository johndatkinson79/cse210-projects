using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    { Console.WriteLine("Greetings and welcome to the program!");}

    static string PromptUserName()
    {
        Console.Write("Please enter your full name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {Console.Write("Please tell me what your favorite number is: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    { Console.WriteLine($"Dear {name}, an interesting fact about your favourite number is that its square is {square}");
    }
}