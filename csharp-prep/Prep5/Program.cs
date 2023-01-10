using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayResults();

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program! ");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name and surname: ");
            string userName= Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
        static int SquareNumber(int userNumber)
        {
           int square = userNumber * userNumber;
           return square;
        }
        static void DisplayResults()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int square = SquareNumber(userNumber);
            Console.WriteLine($"Brother {userName}, the square of your number is {square}.");
        }
        

    }
}