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
            
                CopyConstructor obj1 = new CopyConstructor(10);
                obj1.Display();
                CopyConstructor obj2 = new CopyConstructor(obj1);
                obj2.Display();
                Console.ReadKey();//for freeze cmd

            
        }
    }
}
