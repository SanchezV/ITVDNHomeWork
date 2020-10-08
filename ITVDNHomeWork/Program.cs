using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDNHomeWork
{
    public class Printer
    {
        public void Print(string value)
        {
            Console.WriteLine($"{value}");
        }
    }
    public class ColorPrinter : Printer
    { 
        
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
