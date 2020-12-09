using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._3
{
    class MyDictionary<TKey, TValue>
    {
        private readonly TKey[] keys;
        private readonly TValue[] values;
        private readonly int lenght;
        public MyDictionary(int lenght)
        {
            keys = new TKey[lenght];
            values = new TValue[lenght];
            this.lenght = lenght;
        }
        public void Add(int number, TKey key, TValue value)
        {
            keys[number] = key;
            values[number] = value;
        }
        public int Lenght { get => lenght; }
        public string this[int number]
        {
            get 
            {
                if (number >= 0 && number < lenght)
                {
                    return $"Key - {keys[number]}, value - {values[number]}.";
                }
                else return "Индекс выходит за рамки словаря!";
            }
        }
    }
}
