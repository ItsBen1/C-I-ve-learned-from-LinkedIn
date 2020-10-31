using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";
            while (code != "secret")
            {
                Console.WriteLine("What is the passcode?");
                code = Console.ReadLine();

                if (code != "secret")
                {
                    Console.WriteLine("NOT AUTHENTICATED");
                }
            }
            Console.WriteLine("AUTHENTICATED");
        }
    }
}
