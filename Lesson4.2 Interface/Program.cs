using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._2_Interface
{
    class Program
    {
        interface IPlayable
        {
            void Play();
            void Pause();
            void Stop();
        }
        interface IRecordable
        {
            void Recod();
            void Pause();
            void Stop();
        }
        public class Player : IPlayable, IRecordable
        {
            void IPlayable.Play()
            {
                Console.WriteLine("Играет музыка!");
            }
            
            void IPlayable.Pause()
            {
                Console.WriteLine("Музыка ставится на паузу!");
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
        static void Main(string[] args)
        {
            Player myPlayer = new Player();
            ((IRecordable)myPlayer).Recod();
            ((IRecordable)myPlayer).Pause();
            ((IRecordable)myPlayer).Stop();
            ((IPlayable)myPlayer).Play();
            ((IPlayable)myPlayer).Pause();
            ((IPlayable)myPlayer).Stop();

        }
    }
}
