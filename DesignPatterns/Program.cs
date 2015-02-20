using System;
using System.Net.Mime;
using System.Runtime.ExceptionServices;

namespace DesignPatterns
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var option = new ConsoleKeyInfo();

            while (option.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Select a dessign pattern to test:");
                Console.WriteLine("1 - Strategy");
                Console.WriteLine("2 - Observer");
                Console.WriteLine("Esc - Exit");
                option = Console.ReadKey();
                Console.Clear();

                switch (option.Key)
                {
                    case ConsoleKey.D1:
                        Strategy.Test.Run();
                        break;

                    case ConsoleKey.D2:
                        Observer.Test.Run();
                        break;

                    case ConsoleKey.Escape:
                        Exit(); 
                        break;
                }

                Console.WriteLine("\nPress any key to continue or ESC to finish.");
                option = Console.ReadKey();
                if(option.Key==ConsoleKey.Escape) Exit();
                Console.Clear();
            }
        }

        private static void Exit()
        {
            Console.WriteLine("\nGoodbye :)");
            System.Threading.Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}