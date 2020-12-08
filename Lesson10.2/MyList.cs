using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._2
{
    class MyList<T> : IMyList<T>
    {
        private T[] array; //Создание массива с типом указателя места заполнения типом
        public MyList()
        {
            array = new T[0];
        }

        public T this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public int Count => array.Count();

        public void Add(T a)
        {
            T[] tmpArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tmpArray[i] = array[i];
            }
            tmpArray[array.Length] = a;
            array = tmpArray;
        }

        public void Clear()
        {
            array = new T[0];
        }

        public bool Contains(T item)
        {
            return array.Contains(item);
        }
    }
}
