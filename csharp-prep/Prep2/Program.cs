using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is your grade percentage?");
        int gradePercentage = int.Parse(Console.ReadLine());

        if (gradePercentage >= 90 )
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else if (gradePercentage < 60)
        {
            letter = "F";
        }
        Console.Write($"Your grade is '{letter}' ");
        if ( gradePercentage >= 70)
        {
            Console.Write("Congratulations! You passed the class.");
        }
        else
        {
            Console.Write("Under achieved. You can do better next time.");
        } 
    }
}