namespace ood.rppoon.lv2;

public class Logger
{
    private string type;
    private string filePath;

    public Logger(string type, string filePath)
    {
        this.type = type;
        this.filePath = filePath;
    }

    public void Log(string message)
    {
        if (type.Equals("Console"))
        {
            Console.WriteLine(message);
        }
        else if (type.Equals("File"))
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(message);
            }
        }
        else
        {
            throw new ArgumentException("Unknown type");
        }
    }
}