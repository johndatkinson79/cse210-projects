
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // First part of the assignment where user defines the Magic Number
       //  Console.Write("What is the magic number? ");
       //  int magicNumber = int.Parse(Console.ReadLine());
        
        // For final part of assignment using a random number generator
           Random randomGenerator = new Random();
           int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {   
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {Console.WriteLine("Higher");}
            else if (magicNumber < guess)
            {Console.WriteLine("Lower");}
            else
            {Console.WriteLine($"Congratulations you guessed it! The Magic Number was {magicNumber}");}
        }                    
    }
}