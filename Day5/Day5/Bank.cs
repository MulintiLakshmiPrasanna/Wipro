using System;

// User-defined exception
public class TransactionLimitException : Exception
{
    public TransactionLimitException(string msg) : base(msg)
    {
    }
}

// Business logic class
class AccountService
{
    private decimal maxLimit = 1000;
    private decimal todayTotal = 0;

    public void Withdraw(decimal amt)
    {
        if (todayTotal + amt > maxLimit)
        {
            throw new TransactionLimitException("Cannot withdraw. Daily limit reached.");
        }

        todayTotal += amt;
        Console.WriteLine("Withdrawal successful : " + amt);
    }
}

// Execution class
class TestBank
{
    static void Main()
    {
        AccountService acc = new AccountService();

        try
        {
            acc.Withdraw(600);
            acc.Withdraw(300);
            acc.Withdraw(200); // exceeds limit
        }
        catch (TransactionLimitException e)
        {
            Console.WriteLine("Error : " + e.Message);
        }
    }
}
