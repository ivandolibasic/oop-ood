namespace oop.lv5.zd3;

public class Child
{
    private int siblingFightsCount;
    private int goodDeedsCount;
    private bool isHandWashingRegular;

    public Child(int siblingFightsCount, int goodDeedsCount, bool isHandWashingRegular)
    {
        this.siblingFightsCount = siblingFightsCount;
        this.goodDeedsCount = goodDeedsCount;
        this.isHandWashingRegular = isHandWashingRegular;
    }
    
    public int SiblingFightsCount { get => siblingFightsCount; }
    public int GoodDeedsCount { get => goodDeedsCount; }
    public bool IsHandWashingRegular { get => isHandWashingRegular; }

    public override string ToString()
    {
        return $"Sibling fights: {siblingFightsCount}, good deeds: {goodDeedsCount}, regular hand washing: {isHandWashingRegular}";
    }
}