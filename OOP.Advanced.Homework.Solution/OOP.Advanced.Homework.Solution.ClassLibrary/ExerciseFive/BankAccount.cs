namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseFive;

public class BankAccount
{
    private double balance;

    public BankAccount(string accountNumber, string accountHolder, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
        Bank.NumAccounts++;
    }

    public string AccountNumber { get; set; }

    public string AccountHolder { get; set; }

    public double Balance
    {
        get => balance;
        set
        {
            if (value >= 0)
            {
                balance = value;
            }
            else
            {
                throw new ArgumentException("Balance cannot be set lower than 0.");
            }
        }
    }

    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount can't be negative.");
        }

        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount can't be negative.");
        }

        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            throw new ArgumentException("Insufficient balance.");
        }
    }

    public double GetInterest()
    {
        return Bank.CalculateInterest(Balance);
    }
}