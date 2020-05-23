using System;
using System.Collections.Generic;
using System.Linq;

namespace ConertIntegerToIntegerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;
            int res;

            Console.WriteLine("Input from user: ");
            val = Console.ReadLine();

            // convert to integer
            res = Convert.ToInt32(val);
           int[] yourArray= IntToIntArray(res);
            yourArray.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            Console.WriteLine("[{0}]", string.Join(", ", yourArray));
            Console.ReadLine();
            // display the line
            //foreach (var item in yourArray)
            //{
            //    Console.WriteLine(item.ToString());
            //    Console.ReadLine();
            //}
        }
        public static int[] IntToIntArray(int num)
        {
            if (num == 0)
                return new int[1] { 0 };

            List<int> digits = new List<int>();

            for (; num != 0; num /= 10)
                digits.Add(num % 10);

            int[] array = digits.ToArray();
            System.Array.Reverse(array);

            return array;
        }
    }
}
