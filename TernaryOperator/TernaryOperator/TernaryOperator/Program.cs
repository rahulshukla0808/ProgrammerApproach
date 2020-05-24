using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 10;

            string result = x > y ? "x is greater than y" : x < y ?
                            "x is less than y" : x == y ?
                            "x is equal to y" : "No result";
        }
    }
}
