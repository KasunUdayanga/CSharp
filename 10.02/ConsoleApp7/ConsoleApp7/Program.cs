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
            int cout=1;
            Console.WriteLine("Enter Number: ");
            int h = Convert.ToInt16(Console.ReadLine());
            while (cout <= h)
            {
                Console.WriteLine("Squre Number of " + cout + " is "+Math.Sqrt(cout));
                cout++;
            }
            
        }
    }
}
