using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._1
{
    public abstract class  AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();
    }
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
