using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class StaticConstructor
    {
        int i;
        static int j;
        static StaticConstructor()
        {
            j = 100;//allowed
            /*i = 50;//not allowed*/
            Console.WriteLine("Static Constructor Executed!");
        }
 
           
public StaticConstructor(){
      i=500;
        j=250;//allowed
}
    static void Main(string[] args)
    {
        Console.WriteLine("Main Method Exceution Started...");
        Console.ReadKey();
       
    }
}
}

