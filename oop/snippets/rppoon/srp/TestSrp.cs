namespace oop_design.srp;

public class TestSrp
{
    public static void RunDemo()
    {
        StandardMessages.WelcomeMessage();

        Person user = PersonDataCapture.Capture();

        bool isUserValid = PersonValidator.Validate(user);

        if (isUserValid == false)
        {
            StandardMessages.EndApplication();
            return;
        }

        AccountGenerator.CreateAccount(user);

        StandardMessages.EndApplication();
    }
}