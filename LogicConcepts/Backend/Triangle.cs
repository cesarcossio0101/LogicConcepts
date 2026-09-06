namespace Backend;

public class Triangle : Rectangle
{
    // Fields

    private double _c;
    private double _h;

    // Constructors

    public Triangle(string name, double a, double b, double c, double h)
        : base(name, a, b)
    {
        C = c;
        H = h;
    }

    // Properties

    public double C 
    { 
        get => _c; 
        set => _c = ValidateC(value); 
    }
    public double H 
    { 
        get => _h; 
        set => _h = ValidateH(value); 
    }

    // Public methods

    public override double GetArea() => (B * H) / 2;

    public override double GetPerimeter() => A + B + C;

    // Private methods

    private double ValidateC(double C)
    {
        if (C <= 0)
        {
            throw new Exception($"The {C} must be greater than zero.");
        }
        return C;

    }
    private double ValidateH(double H)
    {
        if (H <= 0)
        {
            throw new Exception($"The {H} must be greater than zero.");
        }
        return H;

    }

}
