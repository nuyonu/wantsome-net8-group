namespace OOP.Advanced.Homework.Solution.ClassLibrary.ExerciseFour;

public static class EmailHelper
{
    public static string ConstructEmailFromName(string name)
    {
        // Remove any leading or trailing spaces from the name
        name = name.Trim();

        // Replace spaces with dots and convert to lowercase
        var email = name.Replace(" ", ".").ToLower();

        // Append the domain
        email += "@company.com";

        return email;
    }
}