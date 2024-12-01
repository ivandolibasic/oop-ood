using ood.rppoon.lv2;
using ood.design_patterns.structural.adapter;
using ood.solid_principles.single_responsibility;

namespace ood;

public static class Test
{
    public static void Srp()
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

    public static void Lv2()
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
    
    public static void Adapter() // https://refactoring.guru/design-patterns/adapter/csharp/example
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        Console.WriteLine("Adaptee interface is incompatible with the client.");
        Console.WriteLine("But with adapter client can call its method.");

        Console.WriteLine(target.GetRequest());
    }
}