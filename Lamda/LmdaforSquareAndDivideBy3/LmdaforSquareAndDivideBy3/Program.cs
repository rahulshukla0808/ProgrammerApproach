using System;
using System.Collections.Generic;
using System.Linq;

namespace LmdaforSquareAndDivideBy3
{
    class Program
    {
        static void Main(string[] args)
        {

            // List to store numbers 
            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};
            // foreach loop to dislay the list 

            foreach (var value in numbers)
            {
                Console.WriteLine("{0} ", value);
             
            }
            Console.ReadLine();
            // Using lambda expression 
            // to calculate square of 
            // each value in the list 
            var square = numbers.Select(x => x * x);
            // foreach loop to display squares
            Console.WriteLine("Squares : ");
            foreach (var value in square)
            {
                Console.WriteLine("{0} ", value);
            }
            Console.ReadLine();
            // Using Lambda exression to 
            // find all numbers in the list 
            // divisible by 3 
            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);
            // foreach loop to display divBy3 
            Console.WriteLine("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.WriteLine("{0} ", value);
            }
            Console.ReadLine();
        }
    }
}
