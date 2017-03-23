using NUnit.Framework;
using System;
using static Task1.Task1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask1
{
    [TestFixture]
    public class TestClass
    {
        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(-5, 10, 5, 20, 25, ExpectedResult = 5)]
        [TestCase(-5453763, 167895430, ExpectedResult = 1)]
        [TestCase(-50265, 1083173889, ExpectedResult = 3351)]
        [TestCase(50265, 1083173889, ExpectedResult = 3351)]
        [TestCase(5, 1, ExpectedResult = 1)]
        [TestCase(5, 0, ExpectedResult = 5)]
        [TestCase(0, 8, ExpectedResult = 8)]
        public int Euclidean_test(params int[] arr)
        {
            return EuclidMethod(arr);
        }

        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(-5453763, 167895430, ExpectedResult = 1)]
        [TestCase(-50265, 1083173889, ExpectedResult = 3351)]
        [TestCase(50265, 1083173889, ExpectedResult = 3351)]
        [TestCase(5, 1, ExpectedResult = 1)]
        [TestCase(5, 0, ExpectedResult = 5)]
        [TestCase(0, 8, ExpectedResult = 8)]
        public int Euclidean_test_twoargs(int a, int b)
        {
            return EuclidMethod(a, b);
        }


        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(-5453763, 167895430, ExpectedResult = 1)]
        [TestCase(-50265, 1083173889, ExpectedResult = 3351)]
        [TestCase(50265, 1083173889, ExpectedResult = 3351)]
        [TestCase(5, 1, ExpectedResult = 1)]
        [TestCase(5, 0, ExpectedResult = 5)]
        [TestCase(0, 8, ExpectedResult = 8)]
        public int Steine_test(int a, int b)
        {
            return SteinMethod(a, b);
        }

        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(-5, 10, 5, 20, 25, ExpectedResult = 5)]
        public int Steine_arr_test(params int[] arr)
        {
            return SteinMethod(arr);
        }
    }
}
