using System.Reflection.Metadata;

namespace oop.lv5.zd3;

public class HolidayChecker : INaughty
{
    public bool IsNaughty(Kid kid)
    {
        if (kid.SiblingFights > kid.GoodDeeds)
            return true;
        if (kid.SiblingFights == kid.GoodDeeds)
            return !kid.DoesRegularlyWashHands;
        return false;
    }
}