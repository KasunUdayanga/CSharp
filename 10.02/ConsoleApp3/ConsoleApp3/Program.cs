using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number in the range 1 - 100: ");
             number = Convert.ToInt32(Console.ReadLine()); //102
            while (number < 1 || number > 100)
            {
                Console.WriteLine("Enter a number in the range 1 - 100: ");
                number = Convert.ToInt32(Console.ReadLine()); //100
            }
            Console.WriteLine("Number is: "+number);

        }
    }
}
