using System;

namespace FuncWithLamda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> sum = (x, y) => x + y;
            Func<int, int, int> sub = (x, y) => x - y;
            Func<int, int, int> mul = (x, y) => x * y;
            Func<int, int, int> div = (x, y) => x / y;
            int a = 10;
            int b = 5;
            Console.WriteLine(square.Invoke(a));
            Console.WriteLine(square.Invoke(b));
            Console.WriteLine(sum.Invoke(a, b));
            Console.WriteLine(sub.Invoke(a, b));
            Console.WriteLine(mul.Invoke(a, b));
            Console.WriteLine(div.Invoke(a, b));
            Console.ReadKey();
        }
    }
}
