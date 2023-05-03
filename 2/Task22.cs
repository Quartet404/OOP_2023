using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2
{
    internal class Task22
    {
        public static void Main() {
            int n;
            double[][] arr;
            string[] input_str;

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

            int local_minimum = 0;
            for (int i = 0; i < n; ++i) {
                for (int j = 0; j < n; ++j) {
                    if (i-1 > 0 && j-1 > 0  && arr[i-1][j-1] <= arr[i][j]    ||
                        i-1 > 0             && arr[i-1][j]   <= arr[i][j]    ||
                        i-1 > 0 && j+1 < n  && arr[i-1][j+1] <= arr[i][j]    ||
                        j-1 > 0             && arr[i][j-1]   <= arr[i][j]    ||
                        j+1 < n             && arr[i][j+1]   <= arr[i][j]    ||
                        i+1 < n && j-1 > 0  && arr[i+1][j-1] <= arr[i][j]    ||
                        i+1 < n             && arr[i+1][j]   <= arr[i][j]    ||
                        i+1 < n && j+1 < n  && arr[i+1][j+1] <= arr[i][j])
                    { continue; }

                    local_minimum++;
                }
            }

            Console.WriteLine($"There is {local_minimum} local minimums in matrix");
        }
    }
}
