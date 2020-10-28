using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your string:");
                string stroka = Console.ReadLine();
                Console.WriteLine("Enter number of color:");               
                if (int.TryParse(Console.ReadLine(), out int numberOfColor))
                {
                    Color.Print(stroka, numberOfColor);
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Number of color is incorrect!");
                    Console.ResetColor();                   
                }
            }
            
        }
    }
}
