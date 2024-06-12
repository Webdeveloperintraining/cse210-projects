using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");



        //Console.Write("What is the magic number? ");
        //string secretNumber= Console.ReadLine();
        //int actualSecretNumber= int.Parse(secretNumber);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        
        bool end = false;

        while (end == false ){
            Console.Write("What is your guess? ");
            string guess= Console.ReadLine();
            int intGuess= int.Parse(guess);
        
            if ( intGuess == number)
            {
                end = true;
                Console.WriteLine("You guessed it!");
            }
            else if (intGuess > number)
            {   
                Console.WriteLine("Lower");
            }
            else if (intGuess < number)
            {   
                Console.WriteLine("Higher");
            }

        
        }
    }
}
