namespace oop.lv5.zd3;

public class EpidemiologyChecker : INaughty
{
    public bool IsNaughty(Child child)
    {
        return !child.IsHandWashingRegular;
    }
}