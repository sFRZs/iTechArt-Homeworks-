namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.DisplayOverload(28);
            overload.DisplayOverload("Zlaya tarelka");
            overload.DisplayOverloadInt(6, 129, 94);

            var classA = new ClassA();
            classA.DisplayOverload("Zlaya tarelka", 28);
            classA.Display();

            var classB = new ClassB();
            classB.Display();
            classB.DisplayInt();
        }
    }
}
