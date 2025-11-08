

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rectangle:");

        Rectangle r = new Rectangle(5, 8);
        Console.WriteLine($"Area: {r.Area()}");
        Console.WriteLine($"Perimeter: {r.Perimeter()}");


        Console.WriteLine("\n\nSquare:");
        Square s = new Square(5);
        Console.WriteLine($"Area: {s.Area()}");
        Console.WriteLine($"Perimeter: {s.Perimeter()}");

        Console.WriteLine("\n\nCube:");
        Cube c = new Cube(5);
        Console.WriteLine($"SurfaceArea: {c.SurfaceArea()}");
        Console.WriteLine($"Volume: {c.Volume()}");

    }
}
