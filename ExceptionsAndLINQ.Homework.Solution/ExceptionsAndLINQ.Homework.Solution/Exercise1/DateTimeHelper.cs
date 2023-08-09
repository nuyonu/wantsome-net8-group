namespace ExceptionsAndLINQ.Homework.Solution.Exercise1;

public class DateTimeHelper
{
    public static void ParseAndCheckIfDateIsInTheFuture(string date)
    {
        if (!DateTime.TryParse(date, out DateTime dateTime))
        {
            throw new InvalidDateException("You date is not in the correct format.");
        }

        CheckIfDateIsInTheFuture(dateTime);
    }

    private static void CheckIfDateIsInTheFuture(DateTime date)
    {
        if (date > DateTime.Now)
        {
            return;
        }

        throw new InvalidDateException("The entered date is in the past.");
    }
}
