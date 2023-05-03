using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2
{
    
    internal class Task12
    {
        public static void Main()
        {
            int n;
            TVector a;
            TVector b;
            TVector c;
            double[] tmp_arr;
            string[] input_str;

            try
            {
                Console.Write("Enter quantity of elements in array: ");
                n = Convert.ToInt32(Console.ReadLine());
                tmp_arr = new double[n];

                Console.WriteLine($"Enter {n} real values for vector a:");
                input_str = Console.ReadLine().Split();
                for (int i = 0; i < n; ++i)
                {
                    tmp_arr[i] = Convert.ToDouble(input_str[i]);
                }
                a = new TVector(tmp_arr);

                Console.WriteLine($"Enter {n} real values for vector b");
                input_str = Console.ReadLine().Split();
                for (int i = 0; i < n; ++i)
                {
                    tmp_arr[i] = Convert.ToDouble(input_str[i]);
                }
                b = new TVector(tmp_arr);

                Console.WriteLine($"Enter {n} real values for vector c");
                input_str = Console.ReadLine().Split();
                for (int i = 0; i < n; ++i)
                {
                    tmp_arr[i] = Convert.ToDouble(input_str[i]);
                }
                c = new TVector(tmp_arr);
            }
            catch (Exception ex){
                Console.WriteLine("Wrong input");
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine($"{ex.StackTrace}");
                return;
            }

            c = 2 * (a + c) - b;
            Console.WriteLine($"Vector c is {c.ToString()}\n");
         }
    }
}
