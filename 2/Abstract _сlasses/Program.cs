namespace Abstract__сlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA classA = new ClassC();
            ClassB classB = new ClassC();
            classA.XXX();
            classB.XXX();

            var classC = new ClassC();
            classC.YYY();
        }
    }
}
