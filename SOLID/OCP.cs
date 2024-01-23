// Violating OCP
public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
}

public class AreaCalculator
{
    public double CalculateRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }
}

// Applying OCP
public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class AreaCalculator
{
    public double CalculateArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}