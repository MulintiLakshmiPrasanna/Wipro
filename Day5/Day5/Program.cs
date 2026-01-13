// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

class FileHandlingDemo
{
    static void Main()
    {
        string filePath = "demo.txt";

        // STEP 1: Create file
        File.Create(filePath).Close();

        // STEP 2: Write data into file
        File.WriteAllText(filePath, "Hello! File handling in C#.");

        Console.WriteLine("Data written to file.");

        // STEP 3: Read data from file
        Console.WriteLine("Reading data from file...");

        string messageFromFile = File.ReadAllText(filePath);

        Console.WriteLine("Message read from file:");
        Console.WriteLine(messageFromFile);

        // STEP 4: Check if file exists
        if (File.Exists(filePath))
        {
            Console.WriteLine("File exists.");
        }

        // STEP 5: Delete file
        File.Delete(filePath);
        Console.WriteLine("File deleted.");
    }
}
