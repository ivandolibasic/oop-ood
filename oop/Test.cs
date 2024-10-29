using oop.lv2;
using oop.pr;

namespace oop;

public static class Test
{
    public static void RunRectangleTask()
    {
        var rectangle1 = new Rectangle();
        Console.WriteLine(rectangle1.ToString() + "\tcreated by default constructor");
        
        var rectangle2 = new Rectangle(13.2, 2.8);
        Console.WriteLine(rectangle2.ToString() + "\tcreated by double-value parameter constructor");
        
        var rectangle3 = new Rectangle(5.7);
        Console.WriteLine(rectangle3.ToString() + "\tcreated by single-value parameter constructor");
        
        var rectangle4 = new Rectangle(rectangle2);
        Console.WriteLine(rectangle4.ToString() + "\tcreated by copy constructor");

        rectangle4.Length = 3.7;
        Console.WriteLine(rectangle4.ToString());

        Console.Write("Area: {0}\tPerimeter: {1}", rectangle4.CalculateArea(), rectangle4.CalculatePerimeter());
    }

    public static void RunCircleTask()
    {
        var circle1 = new Circle();
        Console.WriteLine(circle1.ToString() + "\tcreated by default constructor");
        
        var circle2 = new Circle(2.9);
        Console.WriteLine(circle2.ToString() + "\tcreated by parameter constructor");
        
        var circle3 = new Circle(circle2);
        Console.WriteLine(circle3.ToString() + "\tcreated by copy constructor");

        circle3.Radius = 8.2;
        Console.WriteLine(circle3.ToString());
    }

    public static void RunVideoTask()
    {
        var video = new YouTubeVideo
        (
            "Outdoor Boys",
            "10 days stranded in Alaska's wilderness without a tent",
            50
        );
        
        Console.Write("Write down your impression on the video (like/dislike): ");
        string impression1 = Console.ReadLine();
        video.React(impression1);
        Console.WriteLine($"Total impressions on the video: {video.TotalImpressions()}");
        
        Console.Write("Write down your impression on the video (like/dislike): ");
        string impression2 = Console.ReadLine();
        video.React(impression2);
        Console.WriteLine($"Total impressions on the video: {video.TotalImpressions()}");

        if (impression1 == "like")
            for (int i = 1; i <= 8; i++)
                video.React(impression1);
        if (impression2 == "dislike")
            for (int i = 1; i <= 6; i++)
                video.React(impression2);
        
        Console.WriteLine($"Total impressions on the video: {video.TotalImpressions()}");
    }

    public static void RunCounterTask()
    {
        var counter = new Counter(3);
        Console.WriteLine(counter.Format());
        // for (int i = 1; i <= (3 * 60 * 60); i++)
        //     counter.Tick();
        counter.Tick();
        Console.WriteLine(counter.Format());
    }
    
    public static void StringFormatter(string text) // The ways of formatting string
    {
        Console.WriteLine("Some text " + text); // concatenation
        Console.WriteLine($"Some text {text}"); // interpolation
        Console.WriteLine("Some text {0}", text); // composition (composite formatting)
    }
    
    public static void RunContactTask()
    {
        Console.Write("Define a number of contacts stored in the address book: ");
        int contactCount = int.Parse(Console.ReadLine());
        Contact[] contacts = new Contact[contactCount];
        for (int i = 0; i < contacts.Length; i++)
        {
            Console.WriteLine("Enter contact details:");
            Console.Write("Enter first name: ");
            string? firstName =  Console.ReadLine();
            Console.Write("Enter last name: ");
            string? lastName = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string? phoneNumber = Console.ReadLine();
            Console.Write("Enter email: ");
            string? email = Console.ReadLine();
            while (EmailHelper.CheckValidity(email) == false)
            {
                Console.Write("Invalid email. Please enter valid email: ");
                email = Console.ReadLine();
            }
            contacts[i] = new Contact(firstName, lastName, phoneNumber, email);
        }
        Console.Write("Define a file name: ");
        string? fileName = Console.ReadLine();
        using StreamWriter writer = new StreamWriter(fileName);
        foreach (var contact in contacts)
        {
            writer.WriteLine(contact.ToString());
        }
    }
    
    public static void RunVector3DTask()
    {
        var nulVector = new Vector3D();
        Console.WriteLine(nulVector.ToString());
        var vector1 = nulVector;
        vector1.I = 2.7;
        vector1.J = 7.1;
        vector1.K = -5.4;
        Console.WriteLine(vector1.ToString());
        var vector2 = new Vector3D(0.3, 6.2, 1.2);
        nulVector = vector1 + vector2;
        Console.WriteLine(nulVector.ToString());
        Console.WriteLine(vector2.Modulus());
    }

    public static void RunDiceTest()
    {
        YahtzeeChecker yahtzee = new(5);
        int numberOfRolls = 0;
        do
        {
            yahtzee.RollAll();
            yahtzee.PrintRollResult();
            numberOfRolls++;
        } while (!yahtzee.IsYahtzee());
        Console.WriteLine("Yahtzee achieved after {0} rolls.", numberOfRolls);
    }
}