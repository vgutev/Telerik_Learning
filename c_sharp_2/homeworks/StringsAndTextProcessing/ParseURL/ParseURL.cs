using System;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            string address = Console.ReadLine();
            string protocol = null;
            string server = null;
            string resource = null;
            int index = 0;
            int index2 = 0;
            index = address.IndexOf(":");
            protocol = address.Substring(0, index);
            address = address.Substring(index + 3);
            index = address.IndexOf("/");
            server = address.Substring(0, index);
            resource = address.Substring(index);
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
