using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    class Program
    {
        private Program()
        {
            Console.WriteLine("This is private constructor");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Main method");
            Console.ReadKey();
        }
    }
}
public class Person
    {
        private string last;
        private string first;
        public Person(string lastName, string firstName)
        {
            last = lastName;
            first = firstName;
        }
        // Remaining implementation of Person class.
    }

