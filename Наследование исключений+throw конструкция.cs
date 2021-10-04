using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    
        class EqualToZeroException : Exception // создание наследующего нового класса исключений равно нулю
        {
            const string equalToZeroExceptionMsg = "this exception generates when some argument is equal to zero: ";
            public EqualToZeroException() : base(equalToZeroExceptionMsg) { }
            public EqualToZeroException(string customMsg) : base(string.Format("{0} {1}", equalToZeroExceptionMsg, customMsg)) { }

        }


        class LessThanZeroException : Exception // создание наследующего нового класса исключений меньше нуля
        {
            const string lessThenZeroExceptionMsg = "This exception generates when some argument is less then zero: ";
            public LessThanZeroException() : base(lessThenZeroExceptionMsg) { }
            public LessThanZeroException(string customMsg) : base(string.Format("{0} {1}", lessThenZeroExceptionMsg, customMsg)) { }
        
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            double dX = Convert.ToDouble(Console.ReadLine());
            try
            {

                if (dX < 0) throw new LessThanZeroException("x<0");  // задействование созданного класса исключений
                else if (dX == 0) throw new EqualToZeroException("x=0");
                else dX = Math.Log(dX);
            }
            catch (LessThanZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }


            catch (EqualToZeroException ex)
            {
                Console.WriteLine(ex.Message); // вывод исключение с информацией throw new 
            }
            Console.WriteLine("x= {0}", dX);

            Console.ReadKey();

    }
        }
    }

