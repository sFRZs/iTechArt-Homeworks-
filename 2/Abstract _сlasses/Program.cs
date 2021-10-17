namespace Abstract__сlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            square.Draw();
            square.GetArea();

            var triangle = new Triangle(4, 6, 7, 5);
            triangle.Draw();
            triangle.GetArea();
            triangle.GetPerimeter();

            var circle = new Circle(5, 1, 3);
            circle.Draw();
            circle.GetArea();
        }
    }
}
