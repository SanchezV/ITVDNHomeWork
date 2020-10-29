using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._1
{
    delegate double MidSum(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            MidSum midSum = (a, b, c) => (double)(a + b + c) / 3;
            Console.WriteLine(midSum(3, 6, 9));
        }
    }
}
