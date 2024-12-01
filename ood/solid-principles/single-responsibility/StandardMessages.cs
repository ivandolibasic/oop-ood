namespace ood.solid_principles.single_responsibility;

public class StandardMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to my application!");
    }
    public static void EndApplication()
    {
        Console.Write("Press enter to close...");
        Console.ReadLine();
    }
    public static void DisplayValidationError(string fieldName)
    {
        Console.WriteLine($"What is your {fieldName}: ");
    }
}