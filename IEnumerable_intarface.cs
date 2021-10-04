using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static IEnumerable Range(int init, int upTo)
        {
            Console.WriteLine("Начало выполнения итератора");
            for (int i = init; i < upTo; i++)
                yield return i; // разрыв функции
            Console.WriteLine("Конец выполнения итератора..");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("начало программы");
            var iter = Range(0, 5);//итератор Ienumerable
            Console.WriteLine("начало цикла..");
            foreach (int j in iter)
                Console.Write("{0} ", j);
            Console.WriteLine("завершение цикла..");
            Console.ReadKey();
        }
    }
}
