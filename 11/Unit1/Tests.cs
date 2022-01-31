using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Reflection;
using NUnit.Framework;

namespace Task11
{
    [TestFixture]
    public class Tests
    {
        private SomeLogic _logic;
        private List<Particle> _particles = new List<Particle>();

        [SetUp]
        public void SetUp()
        {
            _logic = new SomeLogic();
        }

        // Condition Asserts.
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(9)]
        public void Check_IsNumberLessThan10_ReturnTrue(int value)
        {
            var condition = _logic.IsNumberLessThen10(value);
            Assert.IsTrue(condition);
        }

        [TestCase(10)]
        [TestCase(11)]
        public void Check_IsNumberLessThan10_ReturnFalse(int value)
        {
            var condition = _logic.IsNumberLessThen10(value);
            Assert.IsFalse(condition);
        }

        // Equality Assert.

        [TestCase(4, 5, 6.403)]
        [TestCase(3, 4, 5.0)]
        public void Check_GetHipotenuseOfRightTriangle_ReturnRightValue(int value1, int value2, double result)
        {
            var actual = _logic.GetHipotenuseOfRightTriangle(value1, value2);
            Assert.AreEqual(result, actual);
        }

        // Comparisons Assert and StringAssert.

        [Test]
        public void Check_GeneratesomeString_ReturnStringThatContainsSpecifiedCharacter()
        {
            var pattern = @"f+";
            var actual = _logic.GenerateSomeString('f', 4, 10);
            StringAssert.IsMatch(pattern, actual);
        }

        [Test]
        public void ResultString_IsMoreThan5Chars()
        {
            var actual = _logic.GenerateSomeString('*', 5, 12);
            Assert.Greater(actual.Length, 5);
        }

        // Exception Assert.

        [Test]
        public void Check_GenerateArgumentException()
        {
            TestDelegate testDelegate = new TestDelegate(_logic.GenerateArgumentException);
            Assert.Throws(typeof(ArgumentException), testDelegate);
        }

        // CollectionAssert.

        [TestCase(new int[] {1, 3, 5, 9}, new int[] {1, 9, 25, 81})]
        [TestCase(new int[] {-4, 0, 10,}, new int[] {16, 0, 100})]
        public void Check_GetArrayWithNumbersSquared_ReturnRightArray(int[] inputArray, int[] expectedArray)
        {
            var actual = _logic.GetArrayWithNumbersSquared(inputArray);
            CollectionAssert.AreEqual(expectedArray, actual);
        }

        // Identity Assert. Проверяем, что частица с наименьшей массой и частица с наибольшей длинной волны де Бройля - это оин и тот же объект.

        [Test]
        public void СheckThatTheObjectWithTheLowestMassHasTheLongestWavelength()
        {
            _particles.Add(new Particle(1.008665));
            _particles.Add(new Particle(0.000549));
            _particles.Add(new Particle(1.007276));

            var actual = new Particle();
            var expected = _particles[1];
            var tmp = _particles[0].GetMetterWaveslengthOfParticle();

            foreach (var particle in _particles)
            {
                if (particle.GetMetterWaveslengthOfParticle() > tmp)
                {
                    tmp = particle.GetMetterWaveslengthOfParticle();
                    actual = particle;
                }
            }

            Assert.AreSame(expected, actual);
        }

        // FieAssert.

        [TestCase("file1.txt", "file1-copy.txt")]
        public void TwoFilesWithTheSameContentsAreEqual(string fileName1, string fileName2)
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path1 = $"{basePath}{Path.DirectorySeparatorChar}{fileName1}";
            var path2 = $"{basePath}{Path.DirectorySeparatorChar}{fileName2}";
            
            FileInfo file1 = new FileInfo(path1);
            FileInfo file1copy = new FileInfo(path2);

            FileAssert.AreEqual(file1, file1copy);
        }

        // DirectoryAssert.

        [Test]
        public void TwoFolderAreEquals()
        {
            // DirectoryInfo dir1 = new DirectoryInfo(@"E:\iTechArt");
            // DirectoryInfo dir2 = new DirectoryInfo(@"E:\iTechArt");
            DirectoryInfo dir1 = new DirectoryInfo(Directory.GetCurrentDirectory());
            DirectoryInfo dir2 = new DirectoryInfo(Directory.GetCurrentDirectory());

            DirectoryAssert.AreEqual(dir1, dir2);
        }
        
        // Multiple Assert.

        [TestCase(7.5, 1.1, 2.0, 8.3)]
        public void SumTwoComplexNumbersTest(double realPart1, double imaginaryPart1, double realPart2, double imaginaryPart2)
        {
            Complex result = _logic.SumTwoComplexNumbers(new Complex(realPart1, imaginaryPart1), new Complex(realPart2, imaginaryPart2));
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual(9.5, result.Real, "Real part");
                Assert.AreEqual(9.4, result.Imaginary, "Imaginary part");
            });
        }
    }
}