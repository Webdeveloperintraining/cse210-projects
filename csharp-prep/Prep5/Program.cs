using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sNumber = SquareNumber(number);

        DisplayResult(name, sNumber);

   
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;   
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string snumber = Console.ReadLine();
        int intNumber = int.Parse(snumber);
        return intNumber;   
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;

        return numberSquared;   
    }


    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {number}");
    }
 

}