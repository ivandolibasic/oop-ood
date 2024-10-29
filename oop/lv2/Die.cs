namespace oop.lv2;

public class Die
{
    private int sides;
    private int face;
    private Random random;

    public Die()
    {
        sides = 6;
        face = 1;
        random = new Random();
    }
    public Die(int face)
    {
        sides = 6;
        this.face = face;
        random = new Random();
    }

    public int GetFace() => face;
    public int SetFace(int face) => this.face = face;
    
    public void Roll() => face = random.Next(1, sides + 1);
}