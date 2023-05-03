using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2
{
    internal class Task11
    {
        public static void Main() {
            int n;
            double[] arr;
            string[] input_str;
            int index_max;
            double element_max;

            
            try {
                Console.Write("Enter quantity of elements in array: ");
                n = Convert.ToInt32(Console.ReadLine());
                arr = new double[n];
                input_str = Console.ReadLine().Split();
                for (int i = 0; i < n; ++i) { 
                    arr[i] = Convert.ToDouble(input_str[i]);
                }
            }
            catch {
                Console.WriteLine("Wrong input");
                return;
            }

            index_max = 0;
            element_max = arr[0];

            for (int i = 0; i < n; i += 2) {
                if (arr[i] > element_max) {
                    index_max = i;
                    element_max = arr[i];
                }
            }

            Console.WriteLine($"Maximum element is {element_max}, index is {index_max}\n");
        }

    }
}
