namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseOne;

// Note: This class is internal and can be used only inside the OOP.Advanced.Homework.Solution.ClassLibrary proejct
internal static class AccountNumberGenerator
{
    private static readonly Random random = new();

    public static int GenerateAccountNumber()
    {
        // Generate a random 6-digit account number. In real life we will write better logic to always generate a unique identifier.
        var accountNumber = random.Next(100000, 999999);

        return accountNumber;
    }
}