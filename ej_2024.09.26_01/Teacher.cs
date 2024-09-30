public class Teacher : Person
{
    private string subject;

    public Teacher(string subject)
    {
        this.subject = subject;
    }

    public void Explain ()
    {
        Console.WriteLine("Explanation begins");
    }
}