using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson13._2
{
    class Matrix
    {
        static readonly object locker = new object();
        Random random;
        const string litters = "ABCDEFJHIJKLMNOPQRSTUVWXYZ0123456789";
        public int Column { get; set; }
        public bool NeedSecond { get; set; }
        public Matrix(int col, bool needSecond)
        {
            Column = col;
            random = new Random((int)DateTime.Now.Ticks);
            NeedSecond = needSecond;
        }
        private char GetChar() => litters.ElementAt(random.Next(0, 35));

        public void PrintLine()
        {
            int lenght, count;
            while (true)
            {
                count = random.Next(3, 6);
                lenght = 0;
                Thread.Sleep(random.Next(20, 5000));
                for (int i = 0; i < 40; i++)
                {
                    lock (locker)
                    {
                        Console.CursorTop = 0;
                        Console.ForegroundColor = ConsoleColor.Black;
                        for (int j = 0; j < i; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine(" ");
                        }
                        if (lenght < count)
                        {
                            lenght++;
                        }
                        else if (lenght == count)
                            count = 0;
                        if (NeedSecond && i < 20 && i > lenght + 2 && (random.Next(1, 5) == 3))
                        {
                            new Thread((new Matrix(Column, false)).PrintLine).Start();
                            NeedSecond = false;
                        }
                        if (39 - i < lenght)
                        {
                            lenght--;
                        }
                        
                        Console.CursorTop = i - lenght + 1;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int j = 0; j < lenght - 2; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                        }
                        if (lenght >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Column;
                            Console.WriteLine(GetChar());
                        }
                        Thread.Sleep(20);
                    }
                }
            }
            #region мой код
            //lock(locker)
            // {
            //random = new Random();
            //int length = random.Next(1, 8);
            //Console.BufferHeight = 30;
            //Console.BufferWidth = 120;
            //for (int j = 0; j < 30 - length; j++)
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition((int)nunmberOfColomn, j);
            //    for (int i = 0; i < length; i++)
            //    {
            //        if (i == 0)
            //        {
            //            Console.ForegroundColor = ConsoleColor.White;
            //            Console.WriteLine(random.Next(0, 9));
            //        }
            //        if (i == 1)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine(random.Next(0, 9));
            //        }
            //        else if (i > 1)
            //        {
            //            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //            Console.WriteLine(random.Next(0, 9));
            //        }
            //    }
            //    Thread.Sleep(50);

            //}
            //}
            #endregion

        }
    }
}
