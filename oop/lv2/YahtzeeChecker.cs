namespace oop.lv2;

public class YahtzeeChecker
{
    private Die[] dice;

    public YahtzeeChecker(int diceCount)
    {
        dice = new Die[diceCount];
        for (int i = 0; i < diceCount; i++)
            dice[i] = new Die();
    }
    
    public bool IsYahtzee()
    {
        int firstNumberRolled = dice[0].GetFace();
        for (int i = 0; i < dice.Length; i++)
            if (dice[i].GetFace() != firstNumberRolled)
                return false;
        return true;
    }

    public void RollAll()
    {
        foreach (var die in dice)
            die.Roll();
    }

    public void PrintRollResult()
    {
        foreach (var die in dice)
            Console.Write(die.GetFace() + "\t");
        Console.WriteLine("");
    }
}