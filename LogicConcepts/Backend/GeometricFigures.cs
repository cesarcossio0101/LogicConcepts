using System.Globalization;

namespace Backend;

public abstract class GeometricFigures

{
    // Contrsuctors

    protected GeometricFigures(string name)
    {
        Name = name;
    }

    // Properties

    public string Name
    {
        get;
        set;
    } = null!;

    // Public methods

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea(),14:N5}     Perimeter: {GetPerimeter(),14:N5}";
    }

}
