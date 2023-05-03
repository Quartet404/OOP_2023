using System.Threading.Tasks;

namespace OOP_LAB_2
{
    internal class Program
    {
        public static void PrintHelp()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("0 - Get help");
            Console.WriteLine("1 - Task 1.1");
            Console.WriteLine("2 - Task 1.2");
            Console.WriteLine("3 - Task 1.3");
            Console.WriteLine("4 - Task 2.1");
            Console.WriteLine("5 - Task 2.2");
            Console.WriteLine("6 - Task 2.3");
            Console.WriteLine("7 - Exits");
            
        }
        static void Main(string[] args)
        {
            int command = 0;

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
                        Task11.Main();
                        break;
                    case 2:
                        Task12.Main();
                        break;
                    case 3:
                        Task13.Main();
                        break;
                    case 4:
                        Task21.Main();
                        break;
                    case 5:
                        Task22.Main();
                        break;
                    case 6:
                        Task23.Main();
                        break;
                    case 7:
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