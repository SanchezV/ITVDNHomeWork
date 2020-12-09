using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._2
{
    public static class Extra
    {
        /// <summary>
        /// Метод, конвертирующий обобщенный список в массив.
        /// </summary>
        /// <typeparam name="T">Пользовательский тип данных.</typeparam>
        /// <returns>Возвращает массив элементов.</returns>
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] tmpArray = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                tmpArray[i] = list[i];
            }
            return tmpArray;
        }
    }
}
