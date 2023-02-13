using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Salary: ");
            int s=Convert.ToInt32(Console.ReadLine());
            if (30000 > s)
            {
                Console.WriteLine(s);
            }else 
            {
                int ot = (int)((s / 100) * 0.25);
                Console.WriteLine("Salary "+(ot+s+250));
            }
            
        }
    }
}
