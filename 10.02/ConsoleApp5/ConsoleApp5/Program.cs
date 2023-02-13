using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            while (count <= 5)
            {
                Console.Write(count+ "\t");
                count++;
            }
            Console.Write( "\n");
            int count1 = 5;
            while (count1 > 0)
            {
                Console.Write(count1+"\t");
                count1--;
            }
            Console.Write("\n");
        }
    }
}
