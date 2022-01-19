using System.IO;
using NUnit.Framework;

namespace Unit2
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        // Type Assert.

        [Test]
        public void NonGenericIsInstanceOf()
        {
            ExampleClass1 exampleClass1 = new ExampleClass2();
            Assert.IsInstanceOf(typeof(ExampleClass2), exampleClass1);
        }

      
    }
}