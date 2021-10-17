using System;

namespace Abstract__сlasses
{
    class Circle : Shape
    {
        // Координаты центра круга.
        private int _x;
        private int _y;

        public Circle() { }
        public Circle(int s, int x, int y)
        {
            side = s;
            _x = x;
            _y = y;
        }

        public override void GetArea()
        {
            var result = Math.PI * Math.Pow(side, 2);
            Console.WriteLine($"Area of circle: {result}.");
        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle with the center at the point ({_x}, {_y}) and the radius {side}.");
        }
    }
}
