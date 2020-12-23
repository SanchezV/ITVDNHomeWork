using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson13._1
{
    class Program
    {
        struct car
        {
            string model;
            DateTime date;
            int power;
            internal car(string model, DateTime date, int power)
            {
                this.model = model;
                this.date = date;
                this.power = power;
            }
            public override string ToString() => $"Model - {model}, date - {date}, power - {power};";           
        }
        public static void Demonstration(object car)
        {
            for (int i = 0; i < 10; i++)
            {
                if (car is car)
                {
                    Console.WriteLine($"{(car)car}");
                }
                else Console.WriteLine("Car не является не является структурой типа \"car\"");
                Thread.Sleep(1000);
            }
            
        }
        static void Main(string[] args)
        {
            car myCar = new car("Ceed", new DateTime(2017, 09, 29), 135); 
            ParameterizedThreadStart secondary = new ParameterizedThreadStart(Demonstration);
            Thread thread = new Thread(secondary);
            thread.Start(myCar);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Главный поток!");
                Thread.Sleep(500);
            }
        }
    }
}
