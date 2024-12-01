namespace oop.msdn_examples.class_relationships;

public class Aggregation
{
    public class Engine
    {
        public string? Model { get; set; }
    }

    public class Car
    {
        public Engine Engine { get; set; }

        public Car(Engine engine)
        {
            Engine = engine;
        }
    }

    /*
    Aggregation is a weaker "has-a" relationship.
    The contained object can exist independently of the containing object.
    For example, if you have a Car class that has an Engine class, an Engine can exist separately from a Car.
    The lifetime of the Engine is not strictly tied to the Car object.
    */
}