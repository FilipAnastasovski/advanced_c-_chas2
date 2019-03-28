using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shape
    {
        protected double a { get; set; } = 1;
        protected double b { get; set; } = 1;
        protected double r { get; set; } = 1;

        public Shape() { }
        public Shape(double x, double y)
        {
            Console.WriteLine("parent class");
            a = x;
            b = y;
        }
        public Shape(double radius)
        {
            r = radius;
        }

        public virtual double Area()
        {
            return a * b;
        }
    }

    public class Rectangle : Shape
    {
       public double a { get; set; }
       public double b { get; set; }
        public Rectangle() { }
        public Rectangle(double x, double y) : base(x,y)
        {
            Console.WriteLine("rectangle");
            a = x;
            b = y;
        }

        public override double Area()
        {
            return a*b;
        }
    }

    public class Triangle : Shape
    {
        public double a { get; set; }
        public double b { get; set; }
        public Triangle() { }
        public Triangle(double x, double y) : base(x, y)
        {
            Console.WriteLine("triangle");
            a = x;
            b = y;
        }

        public override double Area()
        {
            return a * b;
        }
    }

    public class Circle : Shape
    {
        public double a { get; set; }
        public double b { get; set; }
        public Circle() { }
        public Circle(double rad) : base(rad)
        {
            Console.WriteLine("circle");
            r = rad;
        }

        public override double Area()
        {
            return Math.Pow(r,2)*3.14;
        }
    }
}
