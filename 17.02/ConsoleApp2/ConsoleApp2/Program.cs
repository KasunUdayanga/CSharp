using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Length: ");
            int c=Convert.ToInt32(Console.ReadLine());
            int[] num = new int[c];
            Console.WriteLine("Enter Integers: ");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("*************************************");
            for (int i=0;i<num.Length;i++)
            {
                Console.WriteLine(num[i]);
            }
         
            Console.WriteLine("*************************************");
           /* Array.Sort(num);
            foreach (int i in num)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("*************************************");*/
        }
    }
}
