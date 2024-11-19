namespace oop.dotnet_docs;

public class Character
{
    private string name;
    private int health;

    public Character() : this("Character", 100) { }
    public Character(string name) : this(name, 100) { }
    public Character(string name, int health) { this.name = name; this.health = health; }
    public Character(Character other) : this(other.name, other.health) { }
}