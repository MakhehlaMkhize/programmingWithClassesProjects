using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <int> myNumbers = new List<int>();

        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");

        int number = -1;

        int sumOfNumbers = 0;

        int largestNumber = 0;

        while(number != 0)
        {
            Console.Write("Enter a number: ");

            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                myNumbers.Add(number);
            }
            
            if (number > largestNumber)
            {
                largestNumber = number;
            }

            sumOfNumbers = sumOfNumbers + number;
        }
        double aveOfNumbers = (double)sumOfNumbers/myNumbers.Count;

        Console.WriteLine($"The sum is: {sumOfNumbers}");

        Console.WriteLine($"The average is: {aveOfNumbers}");

        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}