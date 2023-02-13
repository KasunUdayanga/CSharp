using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of classes held: ");
            int held = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of classes attended:");
            int att = Convert.ToInt32(Console.ReadLine());
            double pre = ((double)att /held ) * 100;
            if (pre >= 75)
            {
                Console.WriteLine("Percentage is : "+ pre + "% allowed to sit in exam ");
            }
            else
            {
                Console.WriteLine("Percentage is : " + pre + "% not allowed to sit in exam ");
            }


       
        }
    }
}
