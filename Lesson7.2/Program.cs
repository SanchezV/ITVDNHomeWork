using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numersOfTrains = 3;
            Train[] trains = new Train[numersOfTrains];
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Enter train:");
                string train = Console.ReadLine();
                Console.WriteLine("Enter number of train:");
                string number = Console.ReadLine();
                Console.WriteLine("Enter date:");
                string date = Console.ReadLine();
                trains[i] = new Train(train, number, date);
            }
            while (true)
            {
                Console.WriteLine("Enter nuber of train:");
                string number = Console.ReadLine();
                Train.Display(trains, number);
            }
        }
    }
}
