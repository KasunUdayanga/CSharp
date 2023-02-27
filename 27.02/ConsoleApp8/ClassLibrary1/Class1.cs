using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        internal int id=29;
        public void Display()
        {
            Console.WriteLine(id);

        } }
        public class cc : Class1
        {
            public void display1()
            {
                Console.WriteLine(id);
            }
        }
        public class c : cc
        {
            public void display2()
            {
                Console.WriteLine(id);
            }
        }

    }
