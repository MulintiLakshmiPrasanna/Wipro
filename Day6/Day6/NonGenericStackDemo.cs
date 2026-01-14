// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

class NonGenericStackDemo
{
    public static void Run()
    {
        // Create non-generic Stack
        Stack stack = new Stack();

        // Push different types
        stack.Push(10);
        stack.Push("Hello");
        stack.Push(30);

        // Peek (no casting needed for printing)
        Console.WriteLine("Top element: " + stack.Peek());

        // Pop
        Console.WriteLine("Popped element: " + stack.Pop());

        // Check Contains
        Console.WriteLine("Stack contains Hello: " + stack.Contains("Hello"));

        // Count
        Console.WriteLine("Current Count: " + stack.Count);

        // Clear stack
        stack.Clear();
        Console.WriteLine("Count after clear: " + stack.Count);
    }
}


