using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> intCollection = new List<int>();
            Console.Write(" How many items would you like add to collection: ");
            int intQty = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < intQty; i++)
            {
                Console.Write("item_{0}: ", i);
                intCollection.Add(Convert.ToInt16(Console.ReadLine()));
            }
            foreach (var item in intCollection)
            {
                Console.Write(String.Format("{0} + {1} = ", item, sum));
                sum += item;
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}
