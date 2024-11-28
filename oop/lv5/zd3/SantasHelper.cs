namespace oop.lv5.zd3;

public class SantasHelper
{
    private int switches;
    private int gifts;
    private INaughty behaviourChacker;

    public SantasHelper(int switches, int gifts, INaughty behaviourChacker)
    {
        this.switches = switches;
        this.gifts = gifts;
        this.behaviourChacker = behaviourChacker;
    }
    
    public int Switches { get { return switches; } }
    public int Gifts { get { return gifts; } }

    public void injectBehaviour(INaughty behaviour)
    {
        behaviourChacker = behaviour;
    }

    public bool IsSantaReadyForVisit(Kid[] kids)
    {
        int naughtyKids = 0;
        int niceKids = 0;
        foreach (var kid in kids)
        {
            if (behaviourChacker.IsNaughty(kid))
                naughtyKids++;
            else
                niceKids++;
        }
        return gifts >= niceKids && switches >= naughtyKids;
    }
}