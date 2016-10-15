using System;

namespace PrintASCII
{
    class PrintASCII
    {
        static void Main(string[] args)
        {
            char character;
            for(int i=33;i<127;i++)
            {
                character = (char)i;
                Console.Write(character);
            }
        }
    }
}
