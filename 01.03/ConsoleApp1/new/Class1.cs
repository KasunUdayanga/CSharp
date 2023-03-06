using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace @new
{
    public class Ass1
    {
        public int ID=2;
        public void display()
        {
            Console.WriteLine(ID);
        }
    }
    public class Ass2 : Ass1
    {
        public void display1()
        {
            Console.WriteLine(ID);
        }
    }
    public class Ass3 
    {
        public void display3()
        {
            Ass1 ob=new Ass1();
            Console.WriteLine(ob.ID);
        }
    }

}
