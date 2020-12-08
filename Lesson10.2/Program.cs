using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new MyList<int>();
            Console.Write("Введите размер массива: ");
            string size = Console.ReadLine();
            int sizeOfArray;
            if (int.TryParse(size, out sizeOfArray))
            {
                sizeOfArray = Int32.Parse(size);
            }
            for (int i = 0; i < sizeOfArray; i++)
            {
                Random random = new Random();
                array.Add(random.Next(DateTime.Now.Second));
            }
            Console.WriteLine("Содержание массива:");
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine($"Элемент №{i} = {array[i]}"); 
            }
            array.Add(6);
            Console.WriteLine($"В массиве есть 3 = {array.Contains(3)}");
            Console.WriteLine(new String('-', 10));
            for (int i = 0; i < array.Count; i++)
            {                
                Console.WriteLine($"Элемент №{i} = {array[i]}");
            }
            array.Clear();
            Console.WriteLine("После очистки:");
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine($"Элемент №{i} = {array[i]}");
            }
        }
    }
}
