using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)   
        {
            //touch typing
            /*   String[] val = new string[5];
               Console.WriteLine("Enter String: ");
               for(int i = 0; i < val.Length; i++)
               {
                   val[i]=Console.ReadLine();
               }
               Console.WriteLine("*************************************");
               for (int i = 0; i < val.Length; i++)
               {
                   Console.WriteLine(val[i]);
               }
               Console.WriteLine("*************************************");*/
            /*   int[] num = new int[10];
               Console.WriteLine("Enter Integer: ");
               for (int i = 0; i < num.Length; i++)
               {
                   num[i] = Convert.ToInt32(Console.ReadLine());
               }
               Console.WriteLine("*************************************");
               for (int i = 0; i < num.Length; i++)
               {
                   Console.WriteLine(num[i]);
               }
               Console.WriteLine("*************************************");*/
            /*  val[0] = Console.ReadLine();
              Console.WriteLine("*************************************");
              String[] furits = { "apple", "Orange", "Pineapple", "Banana" };
              Console.WriteLine(furits[0]);
              Console.WriteLine("*************************************");
              Console.WriteLine(furits.Length);
              Console.WriteLine("*************************************");
              for (int i = 0; i < furits.Length; i++)
              {
                  Console.WriteLine(furits[i]);
              }
              Console.WriteLine("*************************************");

              Array.Sort(furits);

              foreach (String I in furits)
              {
                  Console.WriteLine(I);
              }
              Console.WriteLine("*************************************");*/
            /*    int[] num2 = { 2, 4, 6, 1, 2, 5, 9, 4, 6 };
                Array.Sort(num2);
                foreach (int i in num2)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine(num2.Max());
                Console.WriteLine(num2.Min());
                Console.WriteLine(num2.Sum());*/


            int[] num = new int[5];
            Console.WriteLine("Enter Integer: ");
            foreach(int i in num) { 
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("*************************************");
            foreach (int i in num)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("*************************************");
            Array.Sort(num);
            foreach(int i in num) 
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("*************************************");
        }
    }
}
