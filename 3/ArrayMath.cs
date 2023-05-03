using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace OOP_LAB_3
{
    internal class ArrayMath: Object, ISum, IMul, IAvg
    {
        private double[] array;

        public ArrayMath(double[] array) {
            this.array = new double[array.Length];
            for (int i = 0; i < array.Length; ++i) {
                this.array[i] = array[i];
            }
        }
        
        public double Sum() {
            double sum = 0.0;
            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }
            return sum;
        }
        public double Mul() {
            double mul = 1;
            foreach(double i in array) {
                mul *= i;
            }
            return mul;
        }

        public double Avg() {
            double avg = 0.0;
            foreach (double i in array) {
                avg += i;
            }
            if (array.Length > 0) {
                avg /= array.Length;
            }
            return avg;
        }
    }
}
