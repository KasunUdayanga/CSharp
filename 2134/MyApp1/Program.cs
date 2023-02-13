using System;

namespace MyApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,num3;
            double avg;
            Console.WriteLine("enter number 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 3 : ");
            num3 = Convert.ToInt32(Console.ReadLine());
            avg = (num1 + num2 + num3) / 3;
     
            Console.WriteLine("******************************");
            Console.WriteLine("Avg is: "+avg);
            if (avg==100)
            {
                Console.WriteLine("Congratulates you Earn prefect score");
            }
            else
            {
                Console.WriteLine("Bad luck you not Earn prefect score");
            }



        }
    }
}
