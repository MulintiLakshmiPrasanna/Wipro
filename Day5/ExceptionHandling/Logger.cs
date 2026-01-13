using System;

class Logger
{
    public static void Log(Exception ex)
    {
        Console.WriteLine($"[{DateTime.Now}] {ex.GetType().Name} : {ex.Message}");
    }
}
