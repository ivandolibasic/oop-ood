namespace ood.solid_principles.single_responsibility;

public class PersonDataCapture
{
    public static Person Capture()
    {
        Person output = new Person();
        
        StandardMessages.DisplayValidationError("first name");
        output.FirstName = Console.ReadLine();

        StandardMessages.DisplayValidationError("last name");
        output.LastName = Console.ReadLine();

        return output;
    }
}