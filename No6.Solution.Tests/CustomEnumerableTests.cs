using System;
using System.Linq;
using No6.Solution.Tests.Helpers;
using NUnit.Framework;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            int[] actual = Generator.Generate<int>(Algoritnms.GenerateFirstSequence, 1, 1, 10).ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            int[] actual = Generator.Generate<int>(Algoritnms.GenerateSeconfSequence, 1, 2, 10).ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            double[] actual = Generator.Generate<double>(Algoritnms.GenerateThirdSequence, 1, 2, 10).ToArray();
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.001);
            }
        }
    }
}
