using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._1
{
    public class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("File.Open(\"Открыт файл TXTHandler\")");
        }
        public override void Create()
        {
            Console.WriteLine("File.Create(\"Path to TXTFile\")");
        }
        public override void Chenge()
        {
            Console.WriteLine("File.WriteAllText(\"Path to TXTFile\") for change");
        }

        public override void Save()
        {
            Console.WriteLine("File.WriteAllText(\"Path to TXTFile\") for save");
        }
    }
}
