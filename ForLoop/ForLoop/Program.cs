using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args) {

            for (int x = 0; x < 5; x++)
            {
                for (int i = 1; i <= 10; i++)
                {
                  Console.WriteLine(i);
                }
                for (int i = 10; i >= 1; i--)
                {
                  Console.WriteLine(i);
                }
            }
            }
        }
    }
