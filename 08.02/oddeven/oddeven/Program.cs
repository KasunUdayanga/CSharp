using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int odd = Convert.ToInt32(Console.ReadLine());
            if (odd % 2 == 1)
            {
                Console.WriteLine("this is odd number");
            }
            else
            {
                Console.WriteLine("this is even number");
            }
           
        }
    }
}
