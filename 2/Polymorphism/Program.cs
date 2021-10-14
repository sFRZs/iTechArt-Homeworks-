namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var overload = new Overload();
            overload.DisplayOverload(28);
            overload.DisplayOverload("Zlaya tarelka");
            overload.DisplayOverload("Zlaya tarelka", 28);
            overload.Display();
            overload.Display1();
            overload.DisplayInt();
        }
    }
}
