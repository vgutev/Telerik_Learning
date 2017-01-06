using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Timer
{
    public delegate void Repeater(int seconds);
    class Timer
    {
        public static void Test(int seconds)
        {
            Stopwatch interval = new Stopwatch();
            interval.Start();

            while (true)
            {
                if (interval.ElapsedMilliseconds == seconds * 999)
                {
                    Console.WriteLine("Something Here ...");
                    interval.Restart();
                }
            }

        }
        
    }
}
