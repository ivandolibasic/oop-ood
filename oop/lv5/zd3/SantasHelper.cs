namespace oop.lv5.zd3;

public class SantasHelper
{
    private int christmasRods;
    private int presents;
    private INaughty childBehaviour;
    
    public SantasHelper(int christmasRods, int presents, INaughty childBehaviour)
    {
        this.christmasRods = christmasRods;
        this.presents = presents;
        this.childBehaviour = childBehaviour;
    }
    
    public int ChristmasRods { get => christmasRods; }
    public int Presents { get => presents; }
    public INaughty ChildBehaviour { get => childBehaviour; }
    
    public void SetBehaviour(INaughty childBehaviour) => this.childBehaviour = childBehaviour;

    public bool IsReadyForVisit(Child[] children)
    {
        int naughtyChildren = 0;
        int niceChildren = 0;
        foreach (var child in children)
        {
            if (childBehaviour.IsNaughty(child))
                naughtyChildren++;
            else
                niceChildren++;
        }
        return presents >= niceChildren && christmasRods >= naughtyChildren;
    }
}