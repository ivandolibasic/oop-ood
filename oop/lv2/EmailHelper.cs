namespace oop.lv2;

public static class EmailHelper
{
    public static bool CheckValidity(string email)
    {
        return email.Contains("@") && (email.EndsWith("gmail.com") || email.EndsWith("ferit.hr"));
    }

    public static bool isEmailAtFeritDomain(string email)
    {
        return email.Contains("@") && email.EndsWith("ferit.hr");
    }
}