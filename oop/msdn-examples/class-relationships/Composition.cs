namespace oop.msdn_examples.class_relationships;

public class Composition
{
    public class Room
    {
        public string Name { get; set; }

        public Room(string name) => Name = name;
    }

    public class House
    {
        public List<Room> Rooms { get; set; } =  new List<Room>();

        public House()
        {
            Rooms.Add(new Room("Living room"));
            Rooms.Add(new Room("Bedroom"));
        }
    }

    /*
    Composition is a stronger "has-a" relationship.
    The contained object cannot exist without the containing object.
    In this case, the lifetime of the contained object depends on the containing object.
    For example, if you have a House class that has a Room class, the Room objects typically do not exist without the House.
    */
}