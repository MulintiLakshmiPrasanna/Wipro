// See https://aka.ms/new-console-template for more information
using System;

namespace Day3
{
    class Program
    {
        static void Main()
        {
            BankAccount acc =
                new BankAccount("12345", "9999", 5, "HYD");

            acc.Deposit(1000);

            Console.WriteLine("Day 3 executed successfully");
        }
    }
}

