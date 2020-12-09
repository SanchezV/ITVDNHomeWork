using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>(5);
            myDictionary.Add(0, 0, "first");
            myDictionary.Add(1, 1, "second");
            Console.WriteLine($"First element - {myDictionary[0]}");
        }
    }
}
