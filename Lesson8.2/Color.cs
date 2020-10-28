using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._2
{
    static class Color
    {
        enum MyColor
        {
            Yellow = 1,
            Green,
            Blue,
            NumberOfColor
        }
        public static void Print(string stroka, int color)
        {
            if (color >= 0 && color < (int)MyColor.NumberOfColor)
            {
                string fontColor = Enum.GetName(typeof(MyColor), color);
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), fontColor); 
                Console.WriteLine(stroka);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Current color is not exsist! Enter another color number.");
                Console.ResetColor();
            }
            
        }
    }
}
