using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._3
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        static void StructTaker(MyStruct MyStruct)
        {
            MyStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct();
            MyClass myClass = new MyClass();
            myStruct.Show();
            myClass.Show();
            myStruct.change = "не изменено";
            myClass.change = "не изменено";
            myStruct.Show();
            myClass.Show();
            StructTaker(myStruct);
            ClassTaker(myClass);
            myStruct.Show();
            myClass.Show();
        }
    }
}
