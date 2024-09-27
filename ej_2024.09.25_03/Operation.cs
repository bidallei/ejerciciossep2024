public class Operations
{
    
    private double width;
    private double height;

    public Operations(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    
    public double GetPerimeter()
    {
        return 2 * (height + width);
    }
    
    public double GetArea()
    {
        return height * width;
    }

    public double GetDiagonal()
    {
        return Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width, 2));
    }
}
