namespace oop.pr.examples;

public class Game
{
    private Character character;
    private Shrine shrine;

    // Composition
    public Game()
    {
        character = new Character("Unnamed", 100, new Sword(1));
        shrine = new Shrine();
    }
}