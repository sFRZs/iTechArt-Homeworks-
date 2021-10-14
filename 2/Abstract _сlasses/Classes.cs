using System;

namespace Abstract__сlasses
{
    abstract class ClassA
    {
        public int a;
        public virtual void XXX()
        {
            Console.WriteLine("ClassA XXX");
        }

        public abstract void YYY();
    }

    abstract class ClassB : ClassA
    {
        public new abstract void XXX();
    }

    class ClassC : ClassB
    {
        public override void XXX()
        {
            Console.WriteLine("ClassC XXX");
        }
        public override void YYY()
        {
            a = 19;
            Console.WriteLine("ClassC YYY {a}");
        }
    }
}
