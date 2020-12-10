using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._2
{
    internal class Car
    {
        public string CarName { get; set; }
        public DateTime Date { get; set; }
        internal Car(string carName, DateTime dateTime)
        {
            CarName = carName;
            Date = dateTime;
        }
        public override string ToString()
        {
            return $"Car - {CarName}, date - {Date}.";
        }
    }
}
