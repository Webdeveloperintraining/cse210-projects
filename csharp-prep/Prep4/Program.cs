using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        bool stop = false;
        while(stop == false)
        { 
            
            Console.WriteLine("Enter a number: ");
            string sInput= Console.ReadLine();
            int intInput = int.Parse(sInput);

            if (intInput == 0)
            {
                stop = true;
            }
            else
            {
                numberList.Add(intInput);
            }
        }


        int totalSum = 0;
        float average = 0;
        int largest = 0;
        foreach(int num in numberList)
        {
            totalSum += num;
            average = totalSum/numberList.Count;

            if (num > largest)
            {
                largest = num;
            }

            
        }

        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}