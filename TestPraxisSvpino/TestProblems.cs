using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PraxisSvpino;

namespace TestPraxisSvpino
{
    [TestClass]
    public class TestProblems
    {
        [TestMethod]
        public void TestProblem1()
        {
            var l = new List<int> { 1, 2, 3, 10 };
            var s1 = Problem1.Sum_For(l);
            var s2 = Problem1.Sum_While(l);
            var s3 = Problem1.Sum_Recursive(l);
            var s4 = Problem1.Sum_Linq(l);

            Assert.AreEqual(s1, 16);
            Assert.AreEqual(s2, 16);
            Assert.AreEqual(s3, 16);
            Assert.AreEqual(s4, 16);
        }

        [TestMethod]
        public void TestProblem2()
        {
            var l1 = new List<string> { "a", "b", "c" };
            var l2 = new List<string> { "1", "2", "3" };
            var op = new List<string> { "a", "1", "b", "2", "c", "3" };

            Assert.IsTrue(Problem2.Combine(l1, l2).SequenceEqual(op));
        }

        [TestMethod]
        public void TestProblem3()
        {
            var f = new List<ulong> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            Assert.IsTrue(Problem3.Fibonacci(10).SequenceEqual(f));
        }

        [TestMethod]
        public void TestProblem4()
        {
            Assert.AreEqual(Problem4.LargestNumber(new List<uint> { 420, 42, 423 }), "42423420");
            Assert.AreEqual(Problem4.LargestNumber(new List<uint> { 50, 2, 1, 9 }), "95021");
        }

        [TestMethod]
        public void TestProblem5()
        {
            var combinations = Problem5.GetCombinationsSummingTo100();
            Assert.IsTrue(combinations.Contains("1+2+34-5+67-8+9"));
        }
    }
}
