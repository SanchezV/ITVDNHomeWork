using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._4
{
    class Program
    {
      
        static void Main(string[] args)
        {

            int[] array = new int[] { 4, 1, 8, 3, 9 };
            array.ConsoleWrite();
            int[] sorted = array.Sort();
            sorted.ConsoleWrite();
        }
    }
}
