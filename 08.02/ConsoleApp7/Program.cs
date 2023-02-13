using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity: ");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n > 1000)
            {
                Console.WriteLine("Total Cost: "+(((n*100)/10)+n));
            }
            else
            {
                Console.WriteLine("Total Cost: " + (100 *n));
            }


        }
    }
}
