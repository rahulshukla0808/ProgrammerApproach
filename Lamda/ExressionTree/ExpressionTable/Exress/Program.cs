using System;
using System.Collections.Generic;
using System.Linq;

namespace Exress
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
    {
       1,2,3,4,5,6,7,8,9,10
    };
            foreach (int ab in numbers.Where(x =>
            {
                if (x % 3 == 0)
                    return true;
                else if (x % 5 == 0)
                    return true;
                else
                    return false;
            }))
            {
                Console.WriteLine(ab);
            }
            Console.ReadKey();
        }
    }
}
