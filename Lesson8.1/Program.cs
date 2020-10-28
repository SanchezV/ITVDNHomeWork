using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._1
{
    class Program
    {
        public static int GetDaysUntilBirthday(DateTime birthday)
        {
            var nextBirthday = birthday.AddYears(DateTime.Today.Year - birthday.Year);
            if (nextBirthday < DateTime.Today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            return (nextBirthday - DateTime.Today).Days;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("My happy birthday after " + GetDaysUntilBirthday(DateTime.Parse("30.12.1995")) +  " days!");
        }
    }
}
