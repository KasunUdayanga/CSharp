using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter devidened:");
            int divider = Convert.ToInt32(Console.ReadLine());
            if (divisor != 0)
            {
                Console.WriteLine("result is : "+divider / divisor);
            }
            else
            {
                Console.WriteLine("can not divid by zero");
            }


        }
    }
}
