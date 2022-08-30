using System;

namespace ConsoleDocker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<1000)
            {
                Console.WriteLine("Hello World "+i);
                System.Threading.Thread.Sleep(500);
                i++;
            }
            Console.WriteLine("Hello World!");
        }
    }
}
