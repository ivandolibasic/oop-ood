namespace oop.snippets.rppoon;

public class Student
{
    private String name;
    private String surname;

    public Student()
    {
        name = String.Empty;
        surname = String.Empty;
    }
    public Student(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }
    
    public string getName() => name;
    public string getSurname() => surname;
    public void setName(string name) => this.name = name;
    public void setSurname(string surname) => this.surname = surname;
}