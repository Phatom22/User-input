using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name ");
            string firstname = Console.ReadLine();

            Console.WriteLine("hi " + firstname);

            Console.WriteLine("enter your age");
            string age = Console.ReadLine();
            Console.WriteLine("you have " + age + "years ");
            //freeze console
            Console.ReadLine();
        }
    }
}
