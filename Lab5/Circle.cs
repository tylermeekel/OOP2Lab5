namespace Lab5;

public class Circle
{
    public double Radius { get; set; }

    public void SetRadius(double radius)
    {
        if (radius > 0)
        {
            Radius = radius;
        }
        else
        {
            throw new InvalidRadiusException(radius);
        }
    }

    public override string ToString()
    {
        return $"Radius: {Radius}";
    }
}