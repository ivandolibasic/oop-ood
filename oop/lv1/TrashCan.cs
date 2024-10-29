namespace oop.lv1;

public class TrashCan
{
    private double amount;
    private double capacity;

    public TrashCan(double capacity)
    {
        this.capacity = capacity;
        amount = 0;
    }

    public double GetAmount() => amount;
    public double GetCapacity() => capacity;

    public bool IsFull() => amount >= capacity ? true : false;
    public void Insert(int newTrash) { if (!IsFull()) amount += newTrash; }
    public void Empty() => amount = 0;
    public double GetOverflowAmount() => amount > capacity ? amount - capacity : 0;
}