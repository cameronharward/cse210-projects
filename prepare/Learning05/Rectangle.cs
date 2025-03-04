public class Rectangle : Shape{
    double _width;
    double _height;

    public Rectangle(){

    }
    public Rectangle(string color, double width, double height) : base(color){
        _width = width;
        _height = height;
    }

    public override double GetArea()
    {
        return _width * _height;
    }
}