using System;

namespace Abstract__сlasses
{
    class Square : Shape
    {
        public Square() { }
        public Square(int s)
        {
            side = s;
        }

        public override void GetArea()
        {
            var result = Math.Pow(side, 2);
            Console.WriteLine($"Area of square: {result}.");
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }
}
