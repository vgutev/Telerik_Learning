using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Timer
{
    class StartUp
    {
        static void Main()
        {
            Repeater repeater = new Repeater(Timer.Test);
            repeater(2);
        }
    }
}
