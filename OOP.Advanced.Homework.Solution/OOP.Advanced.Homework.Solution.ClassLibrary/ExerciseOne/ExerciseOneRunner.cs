namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseOne;

public static class ExerciseOneRunner
{
    public static void Run()
    {
        var myAccount = new BankAccount("John Doe", 1000);

        myAccount.Deposit(500);
        myAccount.Withdraw(200);

        Console.WriteLine(myAccount.GetBalance()); // Outputs 1300

        var transactions = myAccount.GetTransactionHistory();
        foreach (var transaction in transactions)
        {
            Console.WriteLine($"{transaction.Timestamp}: {transaction.Type} ${transaction.Amount}");
        }

        myAccount.AccountHolder = "Jane Smith";

        Console.WriteLine(myAccount.AccountNumber); // Outputs 654321
        Console.WriteLine(myAccount.AccountHolder); // Outputs "Jane Smith"
        Console.WriteLine(myAccount.GetBalance());
    }
}