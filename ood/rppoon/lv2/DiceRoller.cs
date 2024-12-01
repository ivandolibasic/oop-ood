using System.Collections.ObjectModel;

namespace ood.rppoon.lv2;

public class DiceRoller
{
    private List<Die> dice;
    private List<int> restultForEachRoll;
    private Logger logger;

    public DiceRoller()
    {
        dice = new List<Die>();
        restultForEachRoll = new List<int>();
        logger = new Logger("Console", null);
    }

    public void InsertDie(Die die)
    {
        dice.Add(die);
    }
    public void RollAllDice()
    {
        restultForEachRoll.Clear();
        foreach (var die in dice)
        {
            restultForEachRoll.Add(die.Roll());
        }
    }
    public IList<int> GetRollingResults()
    {
        return new ReadOnlyCollection<int>(restultForEachRoll);
    }
    public int DiceCount()
    {
        return dice.Count;
    }

    public void LogRollingResults()
    {
        foreach (int result in restultForEachRoll)
            logger.Log(result.ToString());
    }
}