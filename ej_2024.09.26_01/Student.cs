public class Student : Person
{
    public void GoToClasses()
    {
        Console.WriteLine("I'm go to class");
    }
    
    public void ShowAge()
    {
        Console.WriteLine("My age is {0} years old", GetAge());
    }
}
