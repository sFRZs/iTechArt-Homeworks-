using System;

namespace Abstract__сlasses
{
    abstract class Shape
    {
        // Для круга примем поле side за радиус.
        protected int side;
        public abstract void GetArea();
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }
}
