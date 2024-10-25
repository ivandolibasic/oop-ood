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
        Console.WriteLine("Some text " + text); // concatination
        Console.WriteLine($"Some text {text}"); // interpolation
        Console.WriteLine("Some text {0}", text); // composition (composite formatting)
    }
}