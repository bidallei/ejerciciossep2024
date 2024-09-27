Console.Write("Please, give the width of the rectangle in cm: ");
double width = double.Parse(Console.ReadLine());

Console.Write("Please, give the height of the rectangle in cm: ");
double height = double.Parse(Console.ReadLine());;

var Calculator = new Operations(width, height);

Console.WriteLine("For the rectangle with width {0} and height {1}, the perimeter is {2} cm, the area is {3} cm2, and the diagonal is {4} cm", width, height, Calculator.GetPerimeter(), Calculator.GetArea(), Calculator.GetDiagonal());

