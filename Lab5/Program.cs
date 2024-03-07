namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        Circle c1 = new Circle();
        try
        {
            c1.SetRadius(1);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Caught Exception: {e.Message}");
        }
        Circle c2 = new Circle();
        try
        {
            c1.SetRadius(-1);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Caught Exception: {e.Message}");
        }
        Circle c3 = new Circle();
        try
        {
            c1.SetRadius(0);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Caught Exception: {e.Message}");
        }

        Console.WriteLine(c1);
        Console.WriteLine(c2);
        Console.WriteLine(c3);
    }
}