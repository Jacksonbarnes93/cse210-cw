public class Rectangle
{
    protected double _length;
    protected double _width;

    public Rectangle(double length, double width)
    {
        _length = length > 0 ? length : 1;
        _width = width > 0 ? width : 1;
        Console.WriteLine($"I am a new rectangle with length {_length} and width {_width}");
    }

    public double Area()
    {
        return _length * _width;
    }

    public double Perimeter()
    {
        return 2 * _length + 2 * _width;
    }
    
}