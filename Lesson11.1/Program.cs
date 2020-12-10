using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("string");
            arrayList.Add('c');
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]); 
            }
        }
    }
}
