using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dis,c=0.2;
            Console.WriteLine("Enter Price: ");
            int p = Convert.ToInt32(Console.ReadLine());

            if (p > 500)
            {
                dis = ((p / 100) * c);
                Console.WriteLine("Discount is: "+dis);
                Console.WriteLine("Full Price is: "+(dis-p));

            }
            else
            {
                Console.WriteLine("Not eoungh to discount");
            }
        }
    }
}
