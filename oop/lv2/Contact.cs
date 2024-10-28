namespace oop.lv2;

public class Contact
{
    private string? firstName;
    private string? lastName;
    private string? phoneNumber;
    private string? email;

    public string FirstName
    {
        get { return firstName ?? string.Empty; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName ?? string.Empty; }
        set { lastName = value; }
    }
    public string PhoneNumber
    {
        get { return phoneNumber ?? string.Empty; }
        set { phoneNumber = value; }
    }
    public string Email
    {
        get { return email ?? string.Empty; }
        set { email = value; }
    }

    public Contact(string firstName, string lastName, string phoneNumber, string email)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }
    
    public override string ToString() => $"First name: {firstName}\nLast name: {lastName}\nPhoneNumber: {phoneNumber}\nEmail: {email}\n";
}