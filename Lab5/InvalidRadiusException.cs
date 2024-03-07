namespace Lab5;

public class InvalidRadiusException : Exception
{
    public double Radius { get; set; }
    public InvalidRadiusException() : base("Invalid Radius, must be greater than 0") { }

    public InvalidRadiusException(double radius) : base($"Invalid Radius {radius} is not greater than 0") { }
}