using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._2
{
    internal class CarCollection<T> where T : class
    {
        List<T> cars = new List<T>();
        public int Count { get => cars.Count(); }
        public void Add(T car)
        {
            cars.Add(car);
        }
        public T this[int number]
        {
            get => cars.ElementAt(number);
        }
        public void Clear()
        {
            cars.Clear();
        }
    }
}
