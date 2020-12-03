using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._1
{
    class Demonstration
    {
        static void Main(string[] args)
        {
            int i = MyClass<int>.FactoryMethod();
            Console.WriteLine(i.GetType().Name); //Метод отображает имя типа переменной i

            Demonstration p = MyClass<Demonstration>.FactoryMethod(); //Создаем переменную типа Program

            Console.WriteLine(p.GetType().Name); //Метод отображает имя типа переменной p

        }
    }
}
