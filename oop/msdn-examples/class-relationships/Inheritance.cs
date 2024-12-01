namespace oop.msdn_examples.class_relationships;

public class Inheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }

    public class Dog : Animal
    {
        public string? Name { get; set; }
    
        public void Bark() => Console.WriteLine("Woof! Woof!");

        public void Eat(string name)
        {
            Name = name;
            Console.WriteLine($"{Name} is eating...");
        }
    }

    /*
    Inheritance in C# represents an "is-a" type relationship.
    It is used to establish a parent-child relationship between two classes,
    where the child (or derived) class inherits the properties, methods, and behaviors of the parent (or base) class.
    The child class "is a" specific type of the parent class.

    Dog inherits from Animal.
    Since Dog "is an" Animal, it inherits the Eat() method from the Animal class but can also have its own specific methods, like Bark().
    */
}