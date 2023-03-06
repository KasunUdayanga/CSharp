using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using @new;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
    public class another_ass : Ass1
    {
        public void display4()
        {
            Console.WriteLine(ID);
        }
    }
    public class another_ass2
    {
        public void display5()
        {
            Ass1 ob4 =new Ass1();
            Console.WriteLine(ob4.ID);
        }
    }
}
