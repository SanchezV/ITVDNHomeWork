using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._2
{
    public struct Train
    {
        string destination, date, number;
        public Train(string destination, string number, string date)
        {
            this.destination = destination;
            this.number = number;
            this.date = date;
        }
        public override string ToString()
        {
            string result = $"Destination: {destination}, number: {number}, date: {date}";
            return result;
        }
        public static void Display(Train[] trains, string number)
        {
            bool containTargetTrain = false;
            foreach (var train in trains)
            {
                if (train.number == number)
                {
                    Console.WriteLine(train.ToString());
                    containTargetTrain = true;
                }
            }
            if (!containTargetTrain)
            {
                Console.WriteLine("There is no train with that number!");
            }
        }
    }
}
