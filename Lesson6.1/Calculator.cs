using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._1
{
    public static class Calculator
    {
        public static int Addition(this int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        public static int Multiplication(this int number1, int number2)
        {
            int result = number1 * number2;
            return result;
        }
        public static double Division(this int number1, int number2)
        {
            double result;
            if (number2 != 0)
            {
                result = number1 / number2;
                return result;
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя!");
                throw new Exception("Деление на ноль!");
            }            
        }
        public static double Division(this double number1, double number2)
        {
            double result;
            if (number2 != 0)
            {
                result = number1 / number2;
                return result;
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя!");
                throw new Exception("Деление на ноль!");
            }
        }
        public static int Sublstraction(this int number1, int number2)
        {
            int result = number1 - number2;
            return result;
        }

    }
}
