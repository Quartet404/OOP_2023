using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_1
{
    internal class TCircle
    {
        

        //----Fields----
        protected double radius;
        protected TPoint center;

        public TCircle() {
            radius = 0.0;
            center = new TPoint(0.0, 0.0);
        }

        public TCircle(double radius, double x, double y) {
            this.radius = radius;
            this.center = new TPoint(x,y);
        }

        public TCircle(in TCircle obj) { 
            this.radius = obj.radius;
            this.center = new TPoint(obj.center);
        }

        public virtual void Input() {
            try
            {
                String[] str;

                Console.Write("Введiть радiус круга: ");
                radius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введiть координати центру: ");
                str = (Console.ReadLine()).Split();
                center = new TPoint(double.Parse(str[0]), double.Parse(str[1]));
            }
            catch
            {
                Console.WriteLine("Wrong input");
                Environment.Exit(1);
            }
        }

        public virtual void Print() {
            Console.WriteLine($"Круг з центром в ({center.x}, {center.y}) має радiус {radius}");
        }

        public virtual double Area() { 
            return Math.PI * radius * radius;
        }

        public virtual bool ContainsPoint(TPoint point) {
            return (point.x - center.x) * (point.x - center.x) + 
                   (point.y - center.y) * (point.y - center.y) <= radius * radius;
        }

        public static TCircle operator +(TCircle circle1, TCircle circle2) {
            TCircle newCircle = new()
            {
                radius = circle1.radius + circle2.radius,
                center = new TPoint(circle1.center)
            };
            return newCircle;
        }

        public static TCircle operator -(TCircle circle1, TCircle circle2) {
            TCircle newCircle = new()
            {
                radius = circle1.radius - circle2.radius,
                center = new TPoint(circle1.center)
            };
            return newCircle;
        }

        public static TCircle operator *(TCircle circle1, double number)
        {
            TCircle newCircle = new()
            {
                radius = circle1.radius * number,
                center = new TPoint(circle1.center)
            };
            return newCircle;
        }

        public static TCircle operator *(double number, TCircle circle1)
        {
            return circle1 * number;
        }
    }
}
