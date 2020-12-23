using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Lesson12._3
{
    class Model
    {
        private int s;
        public string Tick()
        {
            s++;
            return s > 60 ? $"{s / 60} минут {s % 60} секунд" : $"{s % 60} секунд";
        }

        public void Reset()
        {
            s = 0;
        }
    }
}
