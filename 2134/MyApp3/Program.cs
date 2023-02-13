using System;

namespace MyApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int payr = 42000,r;
            double d = 1.5;
            Console.WriteLine("Enter Working Hours:");
            int h=Convert.ToInt16(Console.ReadLine());
            if (h > 40)
            {
                r= (int)((h - 40) * ((payr/100)*d));
                Console.WriteLine("Salary with OT: " + (r+payr));
            }
            else
            {
                Console.WriteLine("not OT");
            }


        }
    }
}
