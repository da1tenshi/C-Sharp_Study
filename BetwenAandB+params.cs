using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    
       
    }
    class Program
    {

        static int BetwenAandB(params int[] values)
        {
            int min = int.MaxValue;
            int a = 8;
            int b = 4;

            for (int i = 0; i < values.Length; i++)
                if (values[i] < a && values[i]>b) min = values[i];
            return min;
        }
      

        static void Main(string[] args)
        {
          
            Console.WriteLine(BetwenAandB(6, 2, -4, 10,-3,15));
            Console.ReadKey();
        
        }
    }


