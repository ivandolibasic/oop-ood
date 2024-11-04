namespace oop.pr.ex;

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