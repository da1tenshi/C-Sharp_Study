using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        class Complex
        {
            public double Re { get; private set; }
            public double Im { get; private set; }
            public Complex(double r, double i) { Re = r; Im = i; }
            public static Complex operator +(Complex x, Complex y)
            {
                return new Complex (x.Re +y.Re, x.Im + y.Im);// 1 вариант
                
            }
            public static Complex operator +(double v, Complex x)// 2 вариант
            {
                return new Complex(x.Re + v, x.Im);

            }
            public static Complex operator +(Complex x, double v) // 3 вариант
            {
                return new Complex(x.Re + v, x.Im);
            }
            public static bool operator ==(Complex x, double v)
            {
                return (x.Re == v);
            }

            public static bool operator !=(Complex x, double v)
            {
                return (x.Re != v);
            }
            public static bool operator ==(Complex x, Complex v)
            {
                return (x.Re == v.Re);
            }

            public static bool operator !=(Complex x, Complex v)
            {
                return (x.Re != v.Re);
            }

            public static bool operator ==(double x, Complex v)
            {
                return (x == v.Re);
            }

            public static bool operator !=(double x, Complex v)
            {
                return (x != v.Re);
            }
            public static implicit operator Complex(double d) // неявное преобразование ?
            {
                return new Complex(d, 0);
            }

            public static implicit operator double(Complex x) // неявное преобразование ?
            {
                return Math.Sqrt(x.Re * x.Re + x.Im * x.Im);
            }

        }
        static void Main(string[] args)
        {
            Complex number1 = new Complex(-22, 22);
            Complex number2 = new Complex(-22, 22);
            if(  number1 == number2)
            {
                Console.WriteLine("{0} == {1} ", number1.Im, number2.Im);
            }

            if (number1 != number2)
            {
                Console.WriteLine("{0} != {1} ", number1.Im, number2.Im);
            }

            Console.WriteLine("ниже пример неявного и явнго преобразования");
            
            double t = (double)number1; // пререобразование в дабл тип данных
            double y = 15.1;
            double c = (Complex)y; // переобразование в комплекс тип данных ??
            Console.WriteLine("{0}  {1} ", t, c);
            Console.ReadKey();

        }
    }
}
