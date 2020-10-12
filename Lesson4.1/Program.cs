using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler txt = new TXTHandler();
            AbstractHandler xml = new XMLHandler();
            txt.Create();
            txt.Open();
            txt.Chenge();
            txt.Save();
            xml.Create();
            xml.Open();
            xml.Chenge();
            xml.Save();
        }
    }
}
