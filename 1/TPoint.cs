using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1
{
    internal class TPoint
    {
        public double x = 0f, y = 0f, z = 0f;
        public TPoint()
        {
            x = 0.0;
            y = 0.0;
            z = 0.0;
        }

        public TPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
            z = 0.0;
        }

        public TPoint(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public TPoint(in TPoint obj)
        {
            this.x = obj.x;
            this.y = obj.y;
            this.z = obj.z;
        }
    }
}
