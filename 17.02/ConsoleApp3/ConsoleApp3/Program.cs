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
            /*         int[,]num = { { 12, 321, 32, 3 }, { 23, 33, 22, 56 } };

                     Console.Write("sdss  "+num[0,1]);
                     Console.WriteLine("");
                     Console.WriteLine(num.GetLength(0));
                     Console.WriteLine(num.GetLength(1));

                     for (int i=0;i<num.GetLength(0);i++)//rows
                     {
                         for(int j= 0;j < num.GetLength(1); j++)//comlns
                         {
                             Console.Write(num[i,j]+"\t");
                         }
                     }*/
            //ASP.NET Core
            int[,] num = { { 1, 2, 3 },
                           { 4, 5, 6 },
                           { 7, 8, 9 } };
            for (int i = 0; i < num.GetLength(0); i++)//rows
            {
                for (int j = 0; j < num.GetLength(1); j++)//comlns
                {
                    Console.Write(num[i, j] + "\t");
                }
            }
            */


        }
    }
}
