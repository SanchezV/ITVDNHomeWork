using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._4
{
    public static class Extension
    {
        public static int[] Sort(this int[] array)
        {
            int[] result = array.OrderBy(x => x).ToArray();
            return result;
        }
        public static void ConsoleWrite(this int[] array)
        {
            string result = null;
            foreach (var element in array)
            {
                result += element + " ";
            }
            Console.WriteLine(result); 
        }
    }
}
