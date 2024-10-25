namespace oop.pr;

public class Counter
{
    private int hours;
    private int minutes;
    private int seconds;

    public Counter(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
        // here I could handle the incorrect input data with some kind of CoordinateTime() method
    }
    public Counter(int hours) : this(hours, 0, 0) { }

    public void Tick()
    {
        if (hours == 0 && minutes == 0 && seconds == 0)
            return;
        seconds--;
        if (seconds < 0)
        {
            seconds = 59;
            minutes--;
            if (minutes < 0)
            {
                minutes = 59;
                hours--;
            }
        }
    }

    public string Format()
    {
        return $"{hours:D2}:{minutes:D2}:{seconds:D2}"; // D represents a decimal format within string
    }
}