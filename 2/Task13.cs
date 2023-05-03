using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2
{
    internal class Task13
    {
        public static void Main()
        {
            int n;
            string[] input_str;
            double[] arr, arr2;
            try
            {
                Console.Write("Enter quantity of elements in array: ");
                n = Convert.ToInt32(Console.ReadLine());
                arr = new double[n];
                arr2 = new double[n];
                input_str = Console.ReadLine().Split();
                for (int i = 0; i < n; ++i)
                {
                    arr[i] = Convert.ToDouble(input_str[i]);
                }
            }
            catch
            {
                Console.WriteLine("Wrong input");
                return;
            }

            for (int i = 0; i < (n + 1) / 2; ++i) {
                arr2[i] = arr[2 * i];
                if (i + (n + 1) / 2 < n) {
                    arr2[i + (n + 1) / 2] = arr[2 * i + 1];
                }
            }

            Console.WriteLine($"[{string.Join(", ", arr2)}]");
        }
    }
}
