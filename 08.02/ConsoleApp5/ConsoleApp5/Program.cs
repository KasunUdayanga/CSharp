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


            Console.WriteLine("Enter your Character:");
            char ch = Console.ReadLine()[0];


            if (ch >= 'A' && ch <= 'Z')
                    Console.WriteLine("\n" + ch +
                            " is an UpperCase character");
                else if (ch >= 'a' && ch <= 'z')
                    Console.WriteLine("\n" + ch +
                            " is an LowerCase character");
                else
                    Console.WriteLine("\n" + ch +
                            " is not an alphabetic character");
            }

            
      
        

    
}
}
