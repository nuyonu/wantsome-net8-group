namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseFive;

public static class Bank
{
    // An example of computed property
    public static double InterestRate => 0.01;

    public static int NumAccounts { get; set; } = 0;

    public static double CalculateInterest(double balance)
    {
        return balance * InterestRate;
    }

    public static int GetNumAccounts()
    {
        return NumAccounts;
    }
}