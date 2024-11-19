namespace oop.lv2;

public class DoctorAppointment
{
    private string? patientName;
    private DateTime date;
    private TimeSpan duration;

    public DoctorAppointment(string patientName, string date)
    {
        this.patientName = patientName;
        this.date = DateTime.Parse(date);
    }
    public DoctorAppointment(string patientName, DateTime date, TimeSpan duration)
    {
        this.patientName = patientName;
        this.date = date;
        this.duration = duration;
    }
}