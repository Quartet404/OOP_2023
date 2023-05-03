using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2
{
    internal class Task23
    {
        public static void Main() {
            int n;
            double[][] arr;
            string[] input_str;
            double sum = 0.0;

            try
            {
                Console.Write("Enter side of matrix: ");
                n = Convert.ToInt32(Console.ReadLine());
                arr = new double[n][];
                for (int i = 0; i < n; ++i)
                {
                    arr[i] = new double[n];
                }

                for (int i = 0; i < n; ++i)
                {
                    input_str = Console.ReadLine().Split();
                    for (int j = 0; j < n; ++j)
                    {
                        arr[i][j] = Convert.ToDouble(input_str[j]);
                    }
                }

            }
            catch
            {
                Console.WriteLine("Wrong input");
                return;
            }

            for (int i = 0; i < n; ++i) {
                for (int j = i+1; j < n; ++j) {
                    sum += Math.Abs(arr[i][j]);
                }
            }
            Console.WriteLine($"sum is {sum}");
        }
    }
}
