using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._3
{
    public struct MyStruct
    {
        public string change;
        public void Show()
        {
            Console.WriteLine($"Ii struct: {change}");
        }
    }
}
