using System;
namespace Program
{
    class emp
    {
        public int Id, Age;
        public string Name, Address;
        public bool IsPermanent;
        public emp()
        {
            Id = 100;
            Age = 20;
            Name = "kasun";
            Address = "No 23";
            IsPermanent = true;
        }
        public void Display()
        {
            Console.WriteLine("Employee Id is: " + Id);
            Console.WriteLine("Employee Name is: " + Name);
            Console.WriteLine("Employee Age is: " + Age);
            Console.WriteLine("Employee Address is: " + Address);
            Console.WriteLine("Is Employee Permanent: " + IsPermanent);
        }
    }
  
    class test
        {
            static void Main(String[] args)
            {
                emp e1 = new emp();
                e1.Display();
              



            }
        }
    }
