using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            if (userNumber != 0)
            {numbers.Add(userNumber);}
        }

      
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of your list is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of your list is: {average}"); 
        int max = numbers[0];
        foreach (int number in numbers)
        {if (number > max)
            {max = number;}
        }

        Console.WriteLine($"The largest number in your list is: {max}");

        int min = numbers[0];
        foreach (int number in numbers)
        {if (number < min)
        {min = number;}}

        Console.WriteLine($"The smallest number of your list is: {min}");
    }
}