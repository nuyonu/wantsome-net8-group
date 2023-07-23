namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseOne;

public class Transaction
{
    private Transaction(string type, decimal amount)
    {
        Timestamp = DateTime.Now;
        Type = type;
        Amount = amount;
    }

    public DateTime Timestamp { get; }

    public string Type { get; }

    public decimal Amount { get; }

    // With this method we can create transaction and it's easy to modify the type because we have type specified in one place.
    public static Transaction CreateDepositTransaction(decimal amount)
    {
        // Note! Constructor is private.
        return new Transaction(TransactionConstants.Deposit, amount);
    }

    // With this method we can create transaction and it's easy to modify the type because we have type specified in one place.
    public static Transaction CreateWithdrawTransaction(decimal amount)
    {
        return new Transaction(TransactionConstants.Withdraw, amount);
    }
}