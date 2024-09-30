public class StudentAndTeacherTest
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.Greet();

        Student student = new Student();
        student.SetAge(21);
        student.Greet();
        student.ShowAge();

        Teacher teacher = new Teacher("Mathematics");
        teacher.SetAge(30);
        teacher.Greet();
        teacher.Explain();
    }
}