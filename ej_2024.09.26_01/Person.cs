public class Person
{
    private int age;

    public void SetAge(int n)
    {
        age = n;
    }
    public int GetAge()
    {
        return age;
    }
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }
}