using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_2
{
    internal class TVector
    {
        private double[] _values;
        public TVector(double[] arr)
        {
            _values = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                _values[i] = arr[i];
            }
        }

        public static TVector operator +(TVector left, TVector right)
        {
            double[] result = new double[left._values.Length];
            for (int i = 0; i < left._values.Length; ++i)
            {
                result[i] = left._values[i] + right._values[i];
            }
            return new TVector(result);
        }

        public static TVector operator *(TVector left, TVector right)
        {
            double[] result = new double[left._values.Length];
            for (int i = 0; i < left._values.Length; ++i)
            {
                result[i] = left._values[i] * right._values[i];
            }
            return new TVector(result);
        }

        public static TVector operator -(TVector left, TVector right)
        {
            double[] result = new double[left._values.Length];
            for (int i = 0; i < left._values.Length; ++i)
            {
                result[i] = left._values[i] - right._values[i];
            }
            return new TVector(result);
        }

        public static TVector operator *(double left, TVector right)
        {
            double[] result = new double[right._values.Length];
            for (int i = 0; i < right._values.Length; ++i)
            {
                result[i] = left * right._values[i];
            }
            return new TVector(result);
        }

        public static TVector operator *(TVector left, double right)
        {
            double[] result = new double[left._values.Length];
            for (int i = 0; i < left._values.Length; ++i)
            {
                result[i] = left._values[i] * right;
            }
            return new TVector(result);
        }

        public override string ToString()
        {
            return $"<{string.Join(", ", _values)}>";
        }
    }
}
