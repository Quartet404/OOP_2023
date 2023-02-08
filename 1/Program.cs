using System.Drawing;
using System;

namespace OOP_LAB_1
{

    internal class Program
    {
        public static void PrintHelp()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("0 - get this help message");
            Console.WriteLine("1 - set circle via constructor");
            Console.WriteLine("2 - set circle via method");
            Console.WriteLine("3 - print circle");
            Console.WriteLine("4 - check point for circle");
            Console.WriteLine("5 - circle`s area");
            Console.WriteLine("6 - set sphere via constructor");
            Console.WriteLine("7 - set sphere via method");
            Console.WriteLine("8 - print sphere");
            Console.WriteLine("9 - check point for sphere");
            Console.WriteLine("10 - sphere`s area");
            Console.WriteLine("11 - sphere`s volume");
            Console.WriteLine("12 - exit");
        }
        static void Main(string[] args)
        {
            String[] str;
            double r;
            int command = 0;
            TCircle circle = new();
            TBall ball = new();
            TPoint point = new();    

            PrintHelp();
            while (true) {
                Console.Write("Enter command: ");
                try
                {
                    command = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }
                switch (command) {
                    case 0:
                        PrintHelp();
                        break;
                    case 1:
                        try
                        {
                            Console.Write("Введiть радiус круга: ");
                            r = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введiть координати центру: ");
                            str = (Console.ReadLine()).Split();
                            circle = new TCircle(r, double.Parse(str[0]), double.Parse(str[1]));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            Console.WriteLine("Wrong input");
                            Environment.Exit(1);
                        };
                        break;
                    case 2:
                        circle.Input();
                        break;
                    case 3:
                        circle.Print();
                        break;
                    case 4:
                        try
                        {
                            Console.Write("Введiть координати точки: ");
                            str = (Console.ReadLine()).Split();
                            point = new TPoint(double.Parse(str[0]), double.Parse(str[1]));
                            if (circle.ContainsPoint(point)) {
                                Console.WriteLine("Круг мiстить точку");
                            } else {
                                Console.WriteLine("Круг не мiстить точку");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            Console.WriteLine("Wrong input");
                            Environment.Exit(1);
                        };
                        break;
                    case 5:
                        Console.WriteLine($"Circles area is {circle.Area()} sq. un.");
                        break;
                    case 6:
                        try
                        {
                            Console.Write("Введiть радiус кулi: ");
                            r = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введiть координати центру: ");
                            str = (Console.ReadLine()).Split();
                            ball = new TBall(r, double.Parse(str[0]), double.Parse(str[1]), double.Parse(str[2]));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            Console.WriteLine("Wrong input");
                            Environment.Exit(1);
                        };
                        break;
                    case 7:
                        ball.Input();
                        break;
                    case 8:
                        ball.Print();
                        break;
                    case 9:
                        try
                        {
                            Console.Write("Введiть координати точки: ");
                            str = (Console.ReadLine()).Split();
                            point = new TPoint(double.Parse(str[0]), double.Parse(str[1]), double.Parse(str[2]));
                            if (ball.ContainsPoint(point))
                            {
                                Console.WriteLine("Куля мiстить точку");
                            }
                            else
                            {
                                Console.WriteLine("Куля не мiстить точку");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            Console.WriteLine("Wrong input");
                            Environment.Exit(1);
                        };
                        break;
                    case 10:
                        Console.WriteLine($"Sphere`s area is {ball.Area()} sq. un.");
                        break;
                    case 11:
                        Console.WriteLine($"Sphere`s volume is {ball.Volume()} cb. un.");
                        break;
                    case 12:
                        Console.WriteLine("Bye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Uknown comman, type 0 for help");
                        break;
                }
            }
        }
    }
}