using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){
      1,2,3,4,5,6,7,8,9,10
    };
            List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0).ToList();
            List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0).ToList();
            Console.WriteLine("List of Odd Numbers is");
            foreach (int ab in oddNumbers)
            {
                Console.WriteLine(ab);
            }
            Console.WriteLine("List of Even Numbers is");
            foreach (int ab in evenNumbers)
            {
                Console.WriteLine(ab);
            }
            Console.ReadKey();
        }
    }
}
