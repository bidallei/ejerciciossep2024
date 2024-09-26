Console.WriteLine("Please, enter the first number: ");

int numberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Please, enter the second number: ");

int numberTwo = int.Parse(Console.ReadLine());

int operation = ((numberOne-numberTwo)*2);

if (numberOne > numberTwo)
{
    Console.WriteLine("The first number is {0}. The second number is {1}. Since the first number is greater than the second, here you have the double of the difference: {2}", numberOne, numberTwo, operation);
}
else
{
    Console.WriteLine("The first number is not greater than the second.");
}
