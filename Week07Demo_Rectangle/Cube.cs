public class Cube : Square
{
    public Cube(double side) : base(side)
    {
        Console.WriteLine($"I am a new cube with side of length {side}");
    }

    public double SurfaceArea()
    {
        double areaFace = base.Area();
        return areaFace * 6;
    }

    public double Volume()
    {
        // double areaFace = base.Area();
        // return areaFace * side;
        return _length * _length * _length;
    }
}