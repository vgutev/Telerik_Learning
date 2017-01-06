using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    
    class Timer
    {
        public delegate int Repeater<T>(T item);

        public static void TimePrint()
        {
            Console.WriteLine(DateTime.Now);
        }
        public static void ExecutionDelay(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }
    }
}
