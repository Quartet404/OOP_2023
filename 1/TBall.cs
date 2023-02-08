using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1
{
    internal class TBall : TCircle
    {
        public TBall()
        {
            radius = 0.0;
            center = new TPoint(0.0, 0.0, 0.0);
        }

        public TBall(double radius, double x, double y, double z)
        {
            this.radius = radius;
            this.center = new TPoint(x, y, z);
        }

        public TBall(in TBall obj)
        {
            this.radius = obj.radius;
            this.center = new TPoint(obj.center);
        }
        public override void Input()
        {
            try
            {
                String[] str;

                Console.Write("Введiть радiус кулi: ");
                radius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введiть координати центру: ");
                str = (Console.ReadLine()).Split();
                center = new TPoint(double.Parse(str[0]), double.Parse(str[1]), double.Parse(str[2]));
            }
            catch
            {
                Console.WriteLine("Wrong input");
                Environment.Exit(1);
            }
        }
        public override void Print()
        {
            Console.WriteLine($"Куля з центром в ({center.x}, {center.y}, {center.z}) має радiус {radius}");
        }
        public override double Area() {
            return 4 * Math.PI * radius * radius;
        }
        public double Volume()
        {
            return Area() * radius / 3;
        }
        public override bool ContainsPoint(TPoint point)
        {
            return (point.x - center.x) * (point.x - center.x) + (point.y - center.y) * (point.y - center.y) + (point.z - center.z) * (point.z - center.z) <= radius * radius;
        }
    }
}
