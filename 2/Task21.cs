using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2
{
    internal class Task21
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
                for(int i = 0; i < n; ++i){
                    arr[i] = new double[n];
                }
                
                for (int i = 0; i < n; ++i)
                {
                    input_str = Console.ReadLine().Split();
                    for (int j = 0; j < n; ++j) { 
                        arr[i][j] = Convert.ToDouble(input_str[j]);
                    }
                    
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Wrong input");
                return;
            }

            double tmp = double.NaN;
            for (int i = 1; i < n; ++i) {
                tmp = double.NaN;
                for (int j = 1; j < n+1-i; ++j) {
                    if (arr[j][j] > arr[j - 1][j - 1]) {
                        tmp = arr[j][j];
                        arr[j][j] = arr[j - 1][j - 1];
                        arr[j - 1][j - 1] = tmp;
                    }
                }
                if (double.IsNaN(tmp)) {
                    break;
                }
            }

            for (int i = 0; i < n; ++i) {
                for (int j = 0; j < n; ++j) { 
                    Console.Write($"{arr[i][j]}".PadRight(4)+"\t");
                }
                Console.WriteLine();
            }

        }
    }
}
