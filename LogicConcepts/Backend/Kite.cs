namespace Backend;

public class Kite : Rhombus
{
    // Fields

    private double _b;

    // Constructors

    public Kite(string name, double a, double d1, double d2, double b)
        : base(name, a, d1, d2)
    {
        B = b;
    }

    // Properties

    public double B
    {
        get => _b;
        set => _b = value;
    }

    // Public methods

    public override double GetArea() => (D1 * D2) / 2;

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
