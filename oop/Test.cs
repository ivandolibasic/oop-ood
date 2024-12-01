using oop.msdn_examples;
using oop.msdn_examples.class_relationships;
using oop.pr;
using oop.pr.examples;
using Character = oop.pr.examples.Character;

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
    
    public static void RunCharacterTask() // Association
    {
        Character theAshenOne = new("Ashen One", 100);
        theAshenOne.TakeDamage(47);
        Console.WriteLine(theAshenOne.ToString());
        Shrine anorLondoBonfire = new();
        anorLondoBonfire.Heal(theAshenOne);
        Console.WriteLine(theAshenOne.ToString());
    }

    public static void RandomList() // Basic handling with List<T> type
    {
        int count;
        Random generator = new();
        List<int> numbers = new();

        count = 10;
        for (int i = 0; i < count; i++)
        {
            numbers.Add(generator.Next(1, 10));
        }
        
        Console.WriteLine(string.Join(",", numbers));
        foreach (var number in numbers)
        {
            Console.Write(number + "\t");
        }
        
        
        if (numbers.Count != 0)
        {
            Console.WriteLine();
            int first = numbers[0];
            Console.WriteLine($"The first number is {first}");
        }
        
        numbers.RemoveAt(0);
        Console.WriteLine(string.Join(",", numbers));

        numbers.Remove(9);
        Console.WriteLine(string.Join(",", numbers));

        List<int> evenNumbers = new();
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
                evenNumbers.Add(number);
        }
        Console.WriteLine(string.Join(",", evenNumbers));
    }
    
    public static void DateAndTime()
    {
        TimeSpan duration = new TimeSpan(5, 2, 37, 44);
        Console.WriteLine(duration);
        DateTime date = DateTime.Now;
        Console.WriteLine(date.ToString("dd/MM/yyyy"));
        string dateString = "22/10/2024";
        try
        {
            DateTime dateValue = DateTime.Parse(dateString);
            Console.WriteLine("{0} is converted to {1}", dateString, dateValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Unable to convert {0}", dateString);
        }
    }
    
    public static void ClassRelationships()
    {
        var dog = new Inheritance.Dog();
        dog.Bark();
        dog.Eat();
        dog.Eat("Željko");
    }
    
    public static void TestRandomCollection()
    {
        int count = 10;
        const int UPPER_LIMIT = 10;
        var randomNumbers = RandomCollection.generateRandomNaturalNumbers(count, UPPER_LIMIT); // [1, 10>
        Console.WriteLine(RandomCollection.numbersToString(randomNumbers));
        randomNumbers.Sort();
        Console.WriteLine(RandomCollection.numbersToString(randomNumbers));
    }

    public static void StringInitialization()
    {
        // Absence of a value
        string? test1 = null;
        string? test2 = default; // same thing as = null
        
        // A starter value
        string? test3 = string.Empty;
        string? test4 = ""; // this empty string is a constant
        
    }
    
    public static void LinqPlayground()
    {
        // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // // var eventNumbers = numbers.Where(x => x % 2 == 0).ToList();
        // // var eventNumbers = from num in numbers 
        // //                                     where num % 2 == 0
        // //                                         select num;
        // var eventNumbers = numbers.Where(num => num % 2 != 0);
        // foreach (var num in eventNumbers)
        //     Console.WriteLine(num);

        // List<int> scores = [3, 45, 82, 97, 92, 100, 81, 60];
        // IEnumerable<int> scoresLinqMethod = scores.Where(s => s > 80);
        // foreach (int score in scoresLinqMethod)
        // {
        //     Console.Write($"{score}\t");
        // }
        
        // Func<int, int, int> add = (x , y) => x + y;
        // Console.WriteLine(add(3, 4));
        
        // Func<string, string> greet = name => $"Hello, my name is {name}!";
        // Console.WriteLine(greet("Ivan"));
        
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(5));
    }
    
    public static void ArrayUtilsTestInterface()
    {
        int[] days = [11, 12, 13, 14];
        Console.WriteLine(String.Join("\t", days));
        ArrayUtilities.Reverse(days);
        Console.WriteLine(String.Join("\t", days));
        int largestDayPosition = ArrayUtilities.FindLargestIndex(days);
        Console.WriteLine(days[largestDayPosition]);

        double[] temperatures = [24.12, 17.6, 7.46, 10.8, 11.3];
        Console.WriteLine(String.Join("\t", temperatures));
        ArrayUtilities.Reverse<double>(temperatures);
        Console.WriteLine(String.Join("\t", temperatures));
    }
}