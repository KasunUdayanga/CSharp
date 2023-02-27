using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        string n ="kas";
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.n);
            mobail ob = new mobail(20);
            Console.WriteLine(ob.band);

        }
    }
}
