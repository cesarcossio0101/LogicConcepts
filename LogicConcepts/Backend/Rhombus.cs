namespace Backend;

public class Rhombus : Square
{
    // Fields

    private double _d1;
    private double _d2;

    //Constructors

    public Rhombus(string name, double a, double d1, double d2)
        : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    // Properties

    public double D1 
    { 
        get => _d1; 
        set => _d1 = ValidateD1(value); 
    }
    public double D2 
    { 
        get => _d2; 
        set => _d2 = ValidateD2(value); 
    }

    // Public methods

    public override double GetArea() => (D1 * D2) / 2;

    public override double GetPerimeter() => 4 * A;

    // Private methods

    private double ValidateD1(double D1)
    {
        if (D1 <= 0)
        {
            throw new Exception($"The {D1} must be greater than zero.");
        }
        return D1;
    }
    private double ValidateD2(double D2)
    {
        if (D2 <= 0)
        {
            throw new Exception($"The {D2} must be greater than zero.");
        }
        return D2;
    }
}
