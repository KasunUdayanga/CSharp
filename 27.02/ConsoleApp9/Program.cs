using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        int sum(int num, int num1)
        {
            return num + num1;
        }
        int sub(int num, int num1)
        {
            return num - num1;
        }
        int mul(int num, int num1)
        {
            return num * num1;
        }
        int div(int num, int num1)
        {
            return num / num1;
        }
        int mod(int num, int num1)
        {
            return num % num1;
        }
        static void Main(string[] args)
        {
            Program nn = new Program();
            char c;
            Console.WriteLine("Enter the operator that you want to perform: ");
            Console.WriteLine("+ :for summation \n- :for subtraction \n* :for Multiplication \n/ :for division \n% :modulus ");
            c =Convert.ToChar(Console.ReadLine());
            if (c == '+' || c == '*' || c == '-' || c == '/' || c == '%')
            {
                Console.WriteLine("Enter the first value: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second value: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case '+':
                        Console.WriteLine(nn.sum(num, num1));
                        break;
                    case '-':
                        Console.WriteLine(nn.sub(num, num1));
                        break;
                    case '*':
                        Console.WriteLine(nn.mul(num, num1));
                        break;
                    case '/':
                        Console.WriteLine(nn.div(num, num1));
                        break;
                    case '%':
                        Console.WriteLine(nn.mod(num, num1));
                        break;

                }
            }
            else
            {
                Console.WriteLine("select correct operation");
            }

        }
    }
}
