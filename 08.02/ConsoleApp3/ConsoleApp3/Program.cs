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
            Console.WriteLine("Enter your Score:");
            int Score = Convert.ToInt32(Console.ReadLine());
            if (Score >= 90 && Score <= 100)
            {
                Console.WriteLine("Grade A");
            }
            else if (Score >= 80 && Score < 90)
            {
                Console.WriteLine("Grade B");
            }
            else if (Score >= 70 && Score < 80)
            {
                Console.WriteLine("Grade c");
            }
            else if (Score >= 60 && Score < 70)
            {
                Console.WriteLine("Grade D");
            }
            else if (Score >= 0 && Score < 60)
            {
                Console.WriteLine("Grade F");
            }
            else
            {
                Console.WriteLine("Don't Enter negetive numbers");
            }

        }
    }
}
