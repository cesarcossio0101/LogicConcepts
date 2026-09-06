namespace Backend;

public class Rectangle : Square
{
    // Fields

    private double _b;

    // Constructors

    public Rectangle(string name, double a, double b)
        : base(name, a)
    {
        B = b;
    }

    // Properties

    public double B 
    { 
        get => _b; 
        set => _b = ValidateB(value); 
    }

    // Public methods

    public override double GetArea() => A * B;

    public override double GetPerimeter() => 2 * (A + B);

    // Private methods

    private double ValidateB(double B)
    {
        if (B <= 0)
        {
            throw new Exception($"The {B} must be greater than zero.");
        }
        return B;

    }

}
