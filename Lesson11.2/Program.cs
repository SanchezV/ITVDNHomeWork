using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();
            carCollection.Add(new Car("Москвич", new DateTime(1978, 12, 5)));
            carCollection.Add(new Car("Сид", new DateTime(2017, 01, 27)));
            for (int i = 0; i < carCollection.Count; i++)
            {
                Console.WriteLine(carCollection[i].ToString()); 
            }
            Console.WriteLine(carCollection.Count);
            carCollection.Clear();
            Console.WriteLine("После очискти - " + carCollection.Count);
        }
    }
}
