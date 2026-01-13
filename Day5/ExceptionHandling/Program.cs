// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        OrderService service = new OrderService();

        try
        {
            service.PlaceOrder(0, false);   // change values to test
        }
        catch (ValidationException ex) when (LogIfRequired(ex) == false)
        {
            Console.WriteLine("Validation error handled without logging");
        }
        catch (Exception ex)
        {
            Logger.Log(ex);
        }
    }

    static bool LogIfRequired(Exception ex)
    {
        if (ex is ValidationException)
            return false;

        Logger.Log(ex);
        return true;
    }
}

