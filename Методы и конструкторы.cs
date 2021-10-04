using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Triangle
    {

        public static double Area(int side, int height)
        {
            return (1 / 2 * side * height); 
        }
        public double Area (int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (-c));
        }
    }
    class Square
    {
        int iSide;
        public Square()
        {
            iSide = 5;
          
        }
        public Square(int _side)
        {
            this.iSide = _side;
        }
        public int GetSide() { return iSide; }
        public void SetSide(int s) { iSide = s; }
       
    }
    class Program
    {
        static void Set(int a, ref int b, out int c) { a = 10; b = 5; c = 7; }
        static void Main(string[] args)
        {
            Square square2 = new Square();
            square2.SetSide(25);
            Square square1 = new Square();
            square1.SetSide(4);
            Console.WriteLine("side= {0}", square1.GetSide());
            Console.WriteLine("side2= {0}", square2.GetSide());
            Triangle tri = new Triangle();
                                
            tri.Area(5, 6, 7);
            Console.WriteLine("tri={0}", tri );

            int A = 1;
            int B = 2;
            int C = A+B;
            
            Console.WriteLine("A={0} B= {1} C={2}", A, B,C);
            Set(A, ref B, out C);
            
            Console.WriteLine("A={0} B= {1} C={2}", A, B,C);
            Console.ReadKey();

            Console.ReadKey();
        
        }
    }
}
