//Felipe Ruiz
//iteration statements and loops 


using System;
using System.Collections.Generic;

namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //done

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0
            var myNumber = 0;

            //done w do while loop             
            do
            {
                //increment the variable by 1
                myNumber++;
                //then add your variable to numbers - numbers.Add(var name goes here)
                numbers.Add(myNumber);

            } while (myNumber < 100);


            //done with while loop
            while (myNumber < 200)
            {
                // Increment your variable by 1
                myNumber++;
                // Then add your variable to "numbers"
                numbers.Add(myNumber);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            foreach (var item in numbers)

            {
                // Write your variable to the console
                //Console.WriteLine(item);
                // write your variable to the console using iterpolation 
                Console.WriteLine($"{item}");
                //add text with concatination string 
                //Console.WriteLine(item + "is a number");
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // done for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                // Write to the console "numbers" at index i
                Console.WriteLine($"{numbers[i]}");
            }
        }
    }
}