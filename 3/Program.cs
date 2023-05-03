namespace OOP_LAB_3
{
    internal class Program
    {
        public static void PrintHelp() {
            Console.WriteLine("Commands:");
            Console.WriteLine("0 - get this help message");
            Console.WriteLine("1 - set array");
            Console.WriteLine("2 - set object via consturtor");
            Console.WriteLine("3 - sum");
            Console.WriteLine("4 - mul");
            Console.WriteLine("5 - avg");
            Console.WriteLine("6 - exit");
        }
        public static void Main(string[] args) {
            int command;
            int n;
            string[] input_str;
            double[]? arr = null;
            ArrayMath? am = null;


            PrintHelp();
            while (true) {
                Console.Write("\nEnter command: ");
                try {
                    command = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Wrong input!");
                    continue;
                }
                switch (command) {
                    case 0:
                        PrintHelp();
                        break;
                    case 1:
                        try
                        {
                            Console.Write("Enter quantity of elements in array: ");
                            n = Convert.ToInt32(Console.ReadLine());
                            arr = new double[n];
                            input_str = Console.ReadLine().Split();
                            for (int i = 0; i < n; ++i)
                            {
                                arr[i] = Convert.ToDouble(input_str[i]);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Wrong input");
                        }
                        break;
                    case 2:
                        if (arr != null) {
                            am = new ArrayMath(arr);
                        } else {
                            Console.WriteLine("Set array first!");
                        }
                        break;
                    case 3:
                        if (am != null) {
                            Console.WriteLine($"\nSum is {am.Sum()}\n");
                        } else { 
                            Console.WriteLine("\nSet object firs!\n");
                        }
                        break;
                    case 4:
                        if (am != null) {
                            Console.WriteLine($"\nMul is {am.Mul()}\n");
                        } else { 
                            Console.WriteLine("\nSet object firs!\n");
                        }
                        break;
                    case 5:
                        if (am != null) {
                            Console.WriteLine($"\nAvg is {am.Avg()}\n");
                        } else { 
                            Console.WriteLine("\nSet object firs!\n");
                        }
                        break;
                    case 6:
                        Console.WriteLine("\n\nBye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nUknown command, type 0 for help\n");
                        break;
                }
            }
            


        }
    }
}