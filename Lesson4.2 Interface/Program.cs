using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._2_Interface
{
    class Program
    {
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
