using System;


namespace Abstract__сlasses
{
    class Triangle : Shape
    {
        private int _height;
        private int _side2;
        private int _side3;

        public Triangle() { }
        public Triangle(int s, int a, int b, int height)
        {
            side = s;
            _side2 = a;
            _side3 = b;
            _height = height;
        }

        public override void GetArea()
        {
            var result = (side * _height) / 2;
            Console.WriteLine($"Area of triangle: {result}.");
        }
        public void GetPerimeter()
        {
            var result = side + _side2 + _side3;
            Console.WriteLine($"Perimeter of triangle: {result}.");
        }


    }
}
