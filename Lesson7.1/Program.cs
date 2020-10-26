using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook myNotebook = new Notebook("acer", "china", 500);
            Console.WriteLine(myNotebook.ToString());
        }
    }
}
