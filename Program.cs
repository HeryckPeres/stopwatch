using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Are you ready....");
            Thread.Sleep(1000);
            Console.WriteLine("Start....");
            Thread.Sleep(1000);

            Start(time);
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Instruction: \n10s => 10 seconds \n1m => 1 minute\n");
            Console.WriteLine("S = seconds ");
            Console.WriteLine("M - minutes");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("How long do you want to count?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiply = 1;

            if (type == 'm')
            {
                multiply = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart(time * multiply);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finished");
            Thread.Sleep(2500);
        }
    }
}
