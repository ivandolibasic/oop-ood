namespace oop.lv5.zd3;

public class Kid
{
    private int siblingFights;
    private int goodDeeds;
    private bool doesRegularlyWashHands;

    public Kid(int siblingFights, int goodDeeds, bool doesRegularlyWashHands)
    {
        this.siblingFights = siblingFights;
        this.goodDeeds = goodDeeds;
        this.doesRegularlyWashHands = doesRegularlyWashHands;
    }
    
    public int SiblingFights { get { return siblingFights; } }
    public int GoodDeeds { get { return goodDeeds; } }
    public bool DoesRegularlyWashHands { get { return doesRegularlyWashHands; } }

    public override string ToString()
    {
        return $"Conflicts with siblings: {SiblingFights}, " +
               $"Deeds of kindness: {goodDeeds}, " +
               $"Regularly wash hands: {doesRegularlyWashHands}";
    }
}