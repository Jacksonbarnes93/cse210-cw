
public class Square : Rectangle
{
    public Square(double side) : base(side, side)
    {
        Console.WriteLine($"I am a new square with length {side}");
    }
}