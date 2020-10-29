using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._2
{
    
    class Program
    {
        delegate double Operation(double x, double y);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите поочередно два числа:");
            double a, b;
            a = Double.Parse(Console.ReadLine());
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите арифметическую операцию:");
            string oper = Console.ReadLine();
            Operation operation = null;            
            switch (oper)
            {
                case "+":
                    operation = (x, y) => x + y;
                    break;
                case "-":
                    operation = (x, y) => x - y;
                    break;
                case "/":
                    operation = (x, y) =>
                    {
                        if (y != 0)
                        {
                            return x / y;
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                            return 0;
                        }
                    };
                    break;
                case "*":
                    operation = (x, y) => x * y;
                    break;

                default:
                    Console.WriteLine("Вы ввели несуществующую операцию!");
                    break;
            }
            if (operation != null)
            {
                Console.WriteLine("Результат операции: {0}", operation(a, b));
            }
            
        }
    }
}
