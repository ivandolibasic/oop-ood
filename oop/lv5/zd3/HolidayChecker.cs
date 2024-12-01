namespace oop.lv5.zd3;

public class HolidayChecker : INaughty
{
    public bool IsNaughty(Child child)
    {
        if (child.SiblingFightsCount > child.GoodDeedsCount)
            return true;
        if (child.SiblingFightsCount == child.GoodDeedsCount)
            return !child.IsHandWashingRegular;
        return false;
    }
}