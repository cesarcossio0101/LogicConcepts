namespace Backend;

public class Square : GeometricFigures
{
    // Fields

    private double _a;

    //Constructors
    public Square(string name, double a)
        : base(name)
    {
        A = a;
    }

    // Properties

    public double A 
    { 
        get => _a; 
        set => _a = ValidateA(value); 
    }

    // Public methods

    public override double GetArea() => Math.Pow(A, 2);

    public override double GetPerimeter() => 4 * A;

    // Private methods

    private double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new Exception($"The {a} must be greater than zero.");
        }
        return a;
    }
}
