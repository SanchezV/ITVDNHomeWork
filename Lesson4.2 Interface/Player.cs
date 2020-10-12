using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._2_Interface
{
    public class Player : IPlayable, IRecordable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Играет музыка!");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Пауза!");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Воспроизведение останавливается!");
        }
        void IRecordable.Recod()
        {
            Console.WriteLine("Идет запись!");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Запись приостановлена!");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Запись прекращена!");
        }
    }
}
