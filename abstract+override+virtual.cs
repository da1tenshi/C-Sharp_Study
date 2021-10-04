using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
       abstract class Shape
        {
            
           double r;
           double h;
           public double R {get{return r;}}
           public double H {get{return h;}}
          
           public Shape(double r, double h) {this.r=r;this.h=h;}
           public abstract void Show(); 

        }

        class Circle : Shape
        {
            public Circle(double r) : base(r, 0) { }
            public override void Show() 
            {
                Console.WriteLine("круг радиуса  ");

            }
        }
        class Square : Shape
        {
            public Square(double r, double h) : base(r, h) { }
            public override void Show() { Console.WriteLine("квадрат площадью{0}", R * H); }
            
        }
        static void Main(string[] args)
        {
            Shape[] masShape = new Shape[2];
            masShape[0] = new Square(3, 1);
            masShape[1] = new Circle(5);
            foreach (Shape elem in masShape) elem.Show();
            Console.ReadKey();
        }
    }
}
