Console.WriteLine("Until wich number do you want to know the odd numbers? ");

int maximNumber = int.Parse(Console.ReadLine());

Console.WriteLine("The odd numbers from 1 to {0} are: ", maximNumber);

for (int i = 1; i <= maximNumber; i+=2)
{
    Console.WriteLine(i);
}