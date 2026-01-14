using System;
using System.Collections.Generic;

class GenericStackDemo
{
    public static void Run()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Top element: " + stack.Peek());
        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Stack contains 20: " + stack.Contains(20));
        Console.WriteLine("Current Count: " + stack.Count);

        stack.Clear();
        Console.WriteLine("Count after clear: " + stack.Count);
    }
}
