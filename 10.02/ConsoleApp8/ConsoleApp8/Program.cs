using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char con;

            int tot = 0;
         
           

            int x = 0;
          
            do {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Enter number " + i + " :");
                    int num = Convert.ToInt32(Console.ReadLine());
                    tot += num;
                }
                Console.WriteLine("Avg is: " +(tot/3));
                Console.WriteLine("Do You want to run this agin: ");
                con = Convert.ToChar(Console.ReadLine());


            }
               
            while (con=='y'|| con=='n');

            Console.WriteLine("thank you");
        }
    }
}
