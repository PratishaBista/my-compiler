using System;
using System.ComponentModel.Design;

namespace mc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("> ");
                var line = Console.ReadLine();

                if (string.IsNullOrEmpty(line))
                    return;

                if (line == "1 + 2 * 3")
                    Console.WriteLine("7");
                else
                    Console.WriteLine("I don't know how to answer that.");
            }
        }
    }
}