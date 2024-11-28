namespace oop.lv5.zd3;

public class EpidemiologyChecker : INaughty
{
    public bool IsNaughty(Kid kid)
    {
        return !kid.DoesRegularlyWashHands;
    }
}