namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseOne;

public class BankAccount
{

    private readonly List<Transaction> transactions;
    private string accountHolder;
    private int accountNumber;

    public BankAccount(string accountHolder)
    {
        AccountNumber = AccountNumberGenerator.GenerateAccountNumber();
        AccountHolder = accountHolder;
        // First we need to create an account for someone with balance 0 and after we can make a deposit.
        Balance = 0;
        transactions = new List<Transaction>();
    }

    public BankAccount(string accountHolder, int initialBalance)
    {
        AccountNumber = AccountNumberGenerator.GenerateAccountNumber();
        AccountHolder = accountHolder;
        // First we need to create an account for someone with balance 0 and after we can make a deposit.
        Balance = 0;
        transactions = new List<Transaction>();

        Deposit(initialBalance);
    }

    // Private set will let us to modify the property inside the class but not from outside.
    public decimal Balance { get; private set; }

    public int AccountNumber { get; }

    public string AccountHolder { get; set; }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount can't be negative.");
        }

        Balance += amount;
        transactions.Add(Transaction.CreateDepositTransaction(amount));

        // Another solution is to have constructor public and we can do something like this:
        // Transactions.Add(new Transaction("deposit", amount));
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount can't be negative.");
        }

        if (Balance >= amount)
        {
            Balance -= amount;
            transactions.Add(Transaction.CreateWithdrawTransaction(amount));
        }
        else
        {
            throw new ArgumentException("Insufficient balance.");
        }
    }

    // We can keep only the Property. This is just another example how we can read an internal value.
    public decimal GetBalance()
    {
        return Balance;
    }

    public List<Transaction> GetTransactionHistory()
    {
        // Sort transactions by timestamp in ascending order before returning
        transactions.Sort((t1, t2) => t1.Timestamp.CompareTo(t2.Timestamp));

        return transactions;
    }
}