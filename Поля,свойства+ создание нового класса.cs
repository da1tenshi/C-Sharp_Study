using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{

    class Circle
    {
        private double iR;
        private double iX = 0;
        private double iY = 0;
      
        private const double pi = 3.14;
        private double iS = -2;
        private double length;



        public Circle(double x, double y, double r)
        {
            iX = x; iY = y; iR = r;
            length = 2 * pi * r;
        }

        public double X { 
        get {return iX;}
            set
            {
                if (value >= 0 && value <= 100) iX = value;
                else throw new ExecutionEngineException("input value is not valid");

        }
        }
        public double S
        {
            get{return S;}
            set
            {
                if (value > 0) iS = value;
                else throw new ExecutionEngineException("cheto ti namudril s ploshadyou");
            }
             
        }

        class Program
        {
            static void Main(string[] args)
            {
                var c1 = new Circle(0, 0, 8);

                c1.X = 25;
                c1.iR = 5;
                c1.length = 2 * Math.PI * c1.iR;
                c1.iS = c1.iR * 2; 
                Console.WriteLine(c1.length);
                Console.WriteLine(c1.X);
                Console.WriteLine(c1.iS);
                
                Console.ReadKey();
            }
        }
        
    }
}
