using System;
using System.Collections.Generic;

namespace DelegateWithLamdaExpression
{
    class Program
    {
        delegate double del(int x);
        static void Main(string[] args)
        {
            del del1 = (x) => x * x;
            del del2 = (x) => Math.Sqrt(x);
            List<int> numbers = new List<int>()
        {
        1,2,3,4,5,6,7,8,9,10
        };
            Console.WriteLine("Number Square SquareRoot");
            foreach (int ab in numbers)
            {
                Console.WriteLine("{0} {1} {2}", ab, del1(ab), del2(ab));
            }
            Console.ReadKey();
        }
    }
}
