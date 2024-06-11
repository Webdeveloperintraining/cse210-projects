using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();

        int grade = int.Parse(percentage);

        string letter;

        if (grade >= 90)
        {   
            letter = "A";
            //Console.Write("You got an A!");
        }
        else if (grade >= 80)
        {
            letter = "B";
            //Console.Write("You got a B!");
        }

        else if (grade >= 70)
        {   
            letter = "C";
            //Console.Write("You got a C!");
        }

        else if (grade >= 60)
        {   
            letter = "D";
            //Console.Write("You got a D!");
        }
        else
        {   
            letter = "F";
            //Console.Write("You got an F!");
        }

        Console.WriteLine($"Your grade is {letter}");
        if (grade >= 70)
        {
            Console.Write("You passed!!!");
        }
        else
        {
            Console.Write("You got a failing Grade 😥!!!");
        }
    }
}