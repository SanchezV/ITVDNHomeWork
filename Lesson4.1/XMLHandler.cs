using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._1
{
    public class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("File.Open(\"Открыт файл XMLHandler\")");
        }
        public override void Create()
        {
            Console.WriteLine("File.Create(\"Path to XMLFile\")");
        }
        public override void Chenge()
        {
            Console.WriteLine("File.WriteAllText(\"Path to XMLFile\") for change");
        }

        public override void Save()
        {
            Console.WriteLine("File.WriteAllText(\"Path to XMLFile\") for save");
        }
    }
}
