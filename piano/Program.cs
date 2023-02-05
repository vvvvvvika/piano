using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piano
{
    internal class Program
    {
        class octavs
        {
            public int[] octav1 = new int[] { 100, 200, 300 };
            public int[] octav2 = new int[] { 400, 500, 600 };
        }

        static void Main(string[] args)
        {
            bool stop = true;

            octavs o = new octavs();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите октаву F1, F2");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    stop = true;
                    while (stop)
                    {
                        Console.Clear();
                        Console.WriteLine("q w e");
                        ConsoleKeyInfo k = Console.ReadKey();
                        switch (k.Key)
                        {
                            case ConsoleKey.Q:
                                Console.Beep(o.octav1[0], 200);
                                break;
                            case ConsoleKey.W:
                                Console.Beep(o.octav1[1], 200);
                                break;
                            case ConsoleKey.E:
                                Console.Beep(o.octav1[2], 200);
                                break;
                            case ConsoleKey.Escape:
                                {
                                    stop = false;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (key.Key == ConsoleKey.F2)
                {
                    stop = true;
                    while (stop)
                    {
                        Console.Clear();
                        Console.WriteLine("r t y");
                        ConsoleKeyInfo k = Console.ReadKey();
                        switch (k.Key)
                        {
                            case ConsoleKey.R:
                                Console.Beep(o.octav1[0], 200);
                                break;
                            case ConsoleKey.T:
                                Console.Beep(o.octav1[1], 200);
                                break;
                            case ConsoleKey.Y:
                                Console.Beep(o.octav1[2], 200);
                                break;
                            case ConsoleKey.Escape:
                                {
                                    stop = false;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

        }
    }
}
