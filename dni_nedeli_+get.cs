using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class day 
    {
        string[] days = { "sun", "Mon", "Tues", "Wed", "Thurst", "Fri", "Sat" };
        public int this[string day]
        {
            get
            {
                for( int j=0; j<days.Length; j++)
                    if (days[j]==day) return j;
                return -1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            day week = new day();
            Console.WriteLine("Mon = {0}", week["Mon"]);
            Console.WriteLine("Other = {0}", week["Other"]);
            Console.ReadKey();
        }
    }
}
