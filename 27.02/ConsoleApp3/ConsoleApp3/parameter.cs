using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class parameter
    {
        public parameter(int i)
        {
            Console.WriteLine("parameterize const"+i);
        }


    }
    class main
    {
        static void Main(String[] args)
        {
            parameter n1 = new parameter(30);
            parameter n2 = new parameter(35);
            parameter n3 = new parameter(33);
        }
    }
}
