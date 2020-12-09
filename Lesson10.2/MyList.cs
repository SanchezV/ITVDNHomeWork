using System.Linq;

namespace Lesson10._2
{
    public class MyList<T> : IMyList<T>
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
        /// <summary>
        /// Возвращает число элементов.
        /// </summary>
        public int Count => array.Count();
        /// <summary>
        /// Добавлает элемент в лист.
        /// </summary>
        /// <param name="a">Добавляемый элемент.</param>
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
        /// <summary>
        /// Очищает лист.
        /// </summary>
        public void Clear()
        {
            array = new T[0];
        }
        /// <summary>
        /// Определяет, содержит ли последовательность указанный элемент.
        /// </summary>
        /// <param name="item">"Элемент проверки.</param>
        /// <returns>true, если такой элемент есть, иначе false.</returns>
        public bool Contains(T item) => array.Contains(item); 
       
    }
}
