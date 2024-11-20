using oop_design.rppoon.lv2;
using oop.dotnet_docs;
using oop.dotnet_docs.class_relationships;
using oop.lv1;
using oop.lv2;
using oop.lv3.zd1;
using oop.lv3.zd2;
using oop.lv3.zd3;
using oop.lv4.zd1;
using oop.lv4.zd2;
using oop.lv4.zd3;
using Sword = oop.lv3.zd3.Sword;
using oop.pr;
using oop.pr.ex;
using Character = oop.pr.ex.Character;
using Die = oop_design.rppoon.lv2.Die;
using Shape = oop.lv4.zd2.Shape;

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

    public static void RunTrashCanTask()
    {
        var can = new TrashCan(100);
        Console.WriteLine($"Capacity: {can.GetCapacity()}");
        Console.WriteLine($"Current amount: {can.GetAmount()}");
        Console.WriteLine("==================================");
        can.Insert(95);
        Console.WriteLine("Trash inserted (95).");
        Console.WriteLine($"Current amount: {can.GetAmount()}");
        Console.WriteLine($"Is it full: {can.IsFull()}");
        Console.WriteLine("==================================");
        can.Insert(10);
        Console.WriteLine("Trash inserted (10).");
        Console.WriteLine($"Current amount: {can.GetAmount()}");
        Console.WriteLine($"Is it full: {can.IsFull()}");
        Console.WriteLine($"How much is overflowing: {can.GetOverflowAmount()}");
        Console.WriteLine("==================================");
        can.Empty();
        Console.WriteLine("Trash emptied.");
        Console.WriteLine($"Current amount: {can.GetAmount()}");
        Console.WriteLine($"Is it full: {can.IsFull()}");
        Console.WriteLine($"How much is overflowing: {can.GetOverflowAmount()}");
    }
    
    public static void RunComplexNumberTask()
    {
        Complex number1 = new();
        Console.WriteLine(number1.ToString());
        Complex number2 = new Complex(3, -4);
        Console.WriteLine(number2.ToString());
        Console.WriteLine(number2.Real);
        Console.WriteLine(number2.Conjugate());
        Console.WriteLine(number2.Modulus());
        Complex number3 = new Complex(2, 5);
        number2.Add(number3);
        Console.WriteLine(number2.ToString());
    }
    
    public static void RunWeatherTask()
    {
        Weather current = new Weather();
        current.SetTemperature(24.12);
        current.SetWindSpeed(3.5);
        current.SetHumidity(0.56);
        Console.WriteLine("Weather info:\n"
        + "\ttemperature: " + current.GetTemperature() + "\n"
        + "\thumidity: " + current.GetHumidity() + "\n"
        + "\twind speed: " + current.GetWindSpeed() + "\n");
        // Console.WriteLine("Feels like: " + current.CalculateFleesLikeTemperature());
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
        
        var generator = new Random();
        Vector3D randomVector = generator.NextVector3D(5, 10);
        Console.WriteLine(randomVector.ToString());
    }

    public static void RunDiceTask()
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

    public static void RunShoppingSystemTask()
    {
        var products = new List<Product>();
        var basket = new Basket(products);
        basket.Add(new Product(12, "T-Shirt"));
        basket.Add(new Product(40, "Shoes"));
        basket.Add(new Product(3, "Socks"));
        Console.WriteLine($"Total price without discount is: {basket.CalculateTotalPrice()}");
        var discount = new Discount(10);
        basket.CalculateTotalPrice(discount);
    }

    public static void RunRobotTask()
    {
        var robot = new Robot(35.7, "Pero");
        Console.WriteLine($"Robot's energy is: {robot.GetEnergy()}");
        Console.WriteLine($"Robot will be shut down in {robot.CalculateSecondsToShutDown(2)} seconds");
        Console.WriteLine($"Robot will be fully charged in {robot.CalculateSecondsToFullCharge(2)} seconds");
        var lowEnergyRobot = new LowEnergyRobot(55.2, "Rope", 0.5);
        Console.WriteLine($"Low energy robot's energy is: {lowEnergyRobot.GetEnergy()}");
        Console.WriteLine($"Low energy robot will be shut down in {lowEnergyRobot.CalculateSecondsToShutDown(2)} seconds");
        Console.WriteLine($"Low energy robot will be fully charged in {lowEnergyRobot.CalculateSecondsToFullCharge(2)} seconds");
    }

    public static void RunItemTask()
    {
        var items = new List<Item>()
        {
            new Sword("Phase Blade", 10, 500, 1000),
            new Shield("Monarch", 20, 1000, 250)
        };
        Console.WriteLine($"Average inventory loot is: {Inventory.GetAverageItemCost(items)}");
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
    
    public static void Lv2Task1()
    {
        var roller = new DiceRoller();
        for (int i = 0; i < 20; i++)
        {
            roller.InsertDie(new Die(6));
        }
        roller.RollAllDice();
        var results = roller.GetRollingResults();
        for (int i = 0; i < roller.DiceCount(); i++)
        {
            Console.WriteLine(i + 1 + ". die rolled: " + results[i]);
        }
    }

    public static void LinqPlayground()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // var eventNumbers = numbers.Where(x => x % 2 == 0).ToList();
        // var eventNumbers = from num in numbers 
        //                                     where num % 2 == 0
        //                                         select num;
        var eventNumbers = numbers.Where(num => num % 2 != 0);
        foreach (var num in eventNumbers)
            Console.WriteLine(num);
    }

    public static void RunWordScoreCalculator()
    {
        var calculator = new  WordScoreCalculator(2, 3);
        var calculatorPerCharacter = new WordScoreCalculatorPerChar(2, 3, 2, 1);
        Console.WriteLine("Enter three words to calculate the score:");
        // string[] input = Console.ReadLine().Split(' ');
        var words = new List<string>();
        string input;
        for (int i = 1; i <= 3; i++)
        {
            do
            {
                Console.Write($"Enter word {i}: ");
                input = Console.ReadLine();
            }
            while (input.Length < 3);
            words.Add(input);
        }
        foreach (var word in words)
        {
            Console.WriteLine("Base class calculation: " + calculator.CalculateScore(word));
            Console.WriteLine("Derived class calculation: " + calculatorPerCharacter.CalculateScore(word));
        }
    }

    public static void RunShape()
    {
        Shape[] shapes = new Shape[]
        {
            new Ellipse(semiMajorAxis: 4.3, semiMinorAxis: 5.7),
            new Ellipse(3.9, 8.4),
            new Triangle(side: 2.1),
            new Triangle(6.4)
        };
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.ToString());
        }
    }

    public static void RunTaximeter()
    {
        Random generator = new Random();
        double[] journeys = new double[generator.Next(1, 11)];
        for (int i = 0; i < journeys.Length; i++)
        {
            journeys[i] = generator.NextDouble() * 10;
        }
        var standardTaxi = new StandardTaximeter(1m, 2.3m);
        var fixedTaxi = new FixedTaximeter(5m, 3, 2.3m);
        decimal maxStandardPrice = 0;
        decimal maxFixedPrice = 0;
        int maxStandardPriceIndex = -1;
        int maxFixedPriceIndex = -1;
        for (int i = 0; i < journeys.Length; i++)
        {
            decimal standardPrice = standardTaxi.CalculatePrice(journeys[i]);
            decimal fixedPrice = fixedTaxi.CalculatePrice(journeys[i]);
            if (standardPrice > maxStandardPrice)
            {
                maxStandardPrice = standardPrice;
                maxStandardPriceIndex = i;
            }
            if (fixedPrice > maxFixedPrice)
            {
                maxFixedPrice = fixedPrice;
                maxFixedPriceIndex = i;
            }
        }
        Console.WriteLine($"Number of journeys: {journeys.Length}");
        Console.WriteLine($"Maximum standard price for journey no.{maxStandardPriceIndex + 1} amounts {maxStandardPrice:F2} euros.");
        Console.WriteLine($"Maximum fixed price for journey no.{maxFixedPriceIndex + 1} amounts {maxFixedPrice:F2} euros.");
    }
}