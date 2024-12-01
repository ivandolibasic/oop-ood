using oop.lv1;
using oop.lv2;
using oop.lv3.zd1;
using oop.lv3.zd2;
using oop.lv3.zd3;
using Sword = oop.lv3.zd3.Sword;
using oop.lv4.zd1;
using oop.lv4.zd2;
using Shape = oop.lv4.zd2.Shape;
using oop.lv4.zd3;
using oop.lv5.zd1;
using oop.lv5.zd2;
using oop.lv5.zd3;

namespace oop;

public static class TestLv
{
    public static void OopLv1Zd1()
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
    
    public static void OopLv1Zd2()
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
    
    public static void OopLv1Zd3()
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
    
    public static void OopLv2Zd1()
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
    
    public static void OopLv2Zd2()
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

    public static void OopLv2Zd3()
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

    public static void OopLv3Zd1()
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

    public static void OopLv3Zd2()
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

    public static void OopLv3Zd3()
    {
        var items = new List<Item>()
        {
            new Sword("Phase Blade", 10, 500, 1000),
            new Shield("Monarch", 20, 1000, 250)
        };
        Console.WriteLine($"Average inventory loot is: {Inventory.GetAverageItemCost(items)}");
    }

    public static void OopLv4Zd1()
    {
        WordScoreCalculator calculator = new  WordScoreCalculator(2, 3);
        WordScoreCalculator calculatorPerCharacter = new WordScoreCalculatorPerChar(2, 3, 2, 1);
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

    public static void OopLv4Zd2()
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

    public static void OopLv4Zd3()
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
    
    public static void OopLv5Zd1()
    {
        Random generator = new Random();
        List<int> randomNumbers = new List<int>();
        for (int i = 0; i < 100; i++)
            randomNumbers.Add(generator.Next(1, 1001));
        Console.WriteLine("Random numbers:");
        Console.WriteLine(string.Join(", ", randomNumbers));
        
        IFilter filter = new PerfectFilter();
        List<int> perfectNumbers = Filter.Apply(randomNumbers, filter);
        Console.WriteLine("Perfect numbers:");
        Console.WriteLine(string.Join(", ", perfectNumbers));
        // https://testbook.com/maths/perfect-numbers
        
        filter = new FibonacciFilter();
        List<int> fibbonacciNumbers = Filter.Apply(randomNumbers, filter);
        Console.WriteLine("Fibonacci numbers:");
        Console.WriteLine(string.Join(", ", fibbonacciNumbers));
        // https://r-knott.surrey.ac.uk/fibonacci/fibtable.html
    }

    public static void OopLv5Zd2()
    {
        Console.Write("Provide the number of days for the weather forecast: ");
        int days = Convert.ToInt32(Console.ReadLine());
        WeatherForecast[] forecast = new WeatherForecast[days];
        for (int i = 0; i < days; i++)
        {
            Console.Write($"Provide the temperature for the day {i + 1}: ");
            double dailyTemperature = Convert.ToDouble(Console.ReadLine());
            forecast[i] = new WeatherForecast(dailyTemperature);
        }
        Console.Write($"Number of weather spikes: {Utilities.CountSpikes(forecast)}");
    }

    public static void OopLv5Zd3()
    {
        Child[] children = new[]
        {
            new Child(3, 2, false),
            new Child(2, 3, false),
            new Child(0, 2, true)
        };
        
        SantasHelper santa = new SantasHelper(1, 2, new EpidemiologyChecker());
        Console.WriteLine($"Is Santa ready for visit (epidemiology checker): {santa.IsReadyForVisit(children)}");

        INaughty behaviour = new HolidayChecker();
        santa.SetBehaviour(behaviour);
        Console.WriteLine($"Is Santa ready for visit (holiday checker): {santa.IsReadyForVisit(children)}");
    }
}