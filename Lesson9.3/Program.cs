using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._3
{
    delegate int Delegate1();
    delegate int MyDelegate(Delegate1[] d);

    class Program
    {

        static int MyMethod()
        {            
            return new Random().Next(100);
        }
        static void Main(string[] args)
        {
            var array = new Delegate1[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new Delegate1(MyMethod).Invoke();
               
            }
            MyDelegate midSum = delegate (Delegate1[] del)
            {
                int a = 0;
                for (int i = 0; i < del.Length; i++)
                {
                    a += del[i]();                    
                }
                int result = a / del.Length;
                return result;
            };
            Console.WriteLine(midSum(array));
        }
    }
}
