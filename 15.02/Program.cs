using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = new string[4];
            string[] fruits = { "mango", "apple", "banana" };
     
            string[] mobile = { "oppo", "samsung", "nokia", "windows" };

            //exercise
            int[] number = { 12, 22, 55, 44, 66 };
            //print element
            Console.WriteLine(mobile[0]);
            Console.WriteLine(mobile[3]);

            Console.WriteLine();
            //change value in array, assign new value
            mobile[0] = "iphone";
            Console.WriteLine("After Assign New Value for Mobile Array: "+mobile[0]);

           
            //insert following data into array
            string[] city = { "vavuniya", "colombo", "kandy" ,"jaffna"};

            Console.WriteLine();
            //print the length of a array
            Console.WriteLine("length of the array: "+city.GetLength(0));//way 1
            Console.WriteLine("length of the array: " + city.Length); //way 2

            Console.WriteLine();
            //declare new array as a dept
            string[] dept = { "Bio-Science", "Physical-Science", "HRM", "PM", "Accounting", "marketing", "ICT" };
            //print the array elements
            for (int i=0; i < dept.Length; i++)
            {
                Console.WriteLine(dept[i]);
            }

            Console.WriteLine();
            //way 2 for print the value in elements
            //for reachloop
            string[] department = { "Bio-Science", "Physical-Science", "HRM", "PM", "Accounting", "marketing", "ICT" };
            foreach(string val in department)
            {
                Console.WriteLine(val);
            }


      
            //sort an array(String)
            string[] subject = { "Maths", "Science", "History", "Ict", "English", "Commerce","Art" };
            Array.Sort(subject);
            foreach (string i in subject)
            {
                Console.WriteLine(i);
            }
            //sort an array(int)
            int[] num = { 2, 3, 4, 1, 5, 6, 7, 9, 8 };
            Array.Sort(num);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            //array methods
            int[] arr = { 5, 8, 9, 25, 10 };
            Console.WriteLine("max: "+arr.Max());//return largest value
            Console.WriteLine("min: " + arr.Min());//return minimum value
            Console.WriteLine("sum: " + arr.Sum());//return summation value

            //Finding index of an array element
            int[] arr2 = new int[6] { 5, 8, 9, 25,0,7 };
            Console.WriteLine("\nIndex position of 25 is: "+Array.IndexOf(arr, 25));

        }
    }
}