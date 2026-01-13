// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

namespace demo2day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("please enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("hello" + name + "!");
            Console.WriteLine("enter the age");
            string ageinput = Console.ReadLine();
            int age = int.Parse(ageinput);
            if (age > 0)
            {
                if (age >= 18)
                {
                    Console.WriteLine("eligible");
                }
                else
                {
                    Console.WriteLine("not eligible");
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }


        }
    }
}
