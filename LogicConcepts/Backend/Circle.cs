namespace Backend;

public class Circle : GeometricFigures
{
    // Fields

    private double _r;

    // Constructors

    public Circle(string name, double r)
        : base(name)
    {
        R = r;
    }

    // Properties

    public double R 
    { 
        get => _r; 
        set => _r = ValidateR(value); 
    }

    // Public methods

    public override double GetArea() => Math.PI * Math.Pow(R, 2);

    public override double GetPerimeter() => 2 * Math.PI * R;
   

    // Private methods 

    private double ValidateR(double r) 
    {
        if (r <= 0)
        {
            throw new Exception($"The {r} must be greater than zero.");
        }
        return r;
        }

}
