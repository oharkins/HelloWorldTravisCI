//using Xunit;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Get_5th_number()
        {
            var generator = new FibonacciGenerator();

            Assert.AreEqual(generator.Fibonacci(5), 5);
        }

        [TestMethod]
        public void Get_6th_number()
        {
            var generator = new FibonacciGenerator();

            Assert.AreEqual(generator.Fibonacci(6), 8);
        }
        [TestMethod]
        public void Get_7th_number()
        {
            var generator = new FibonacciGenerator();
            Assert.AreEqual(generator.Fibonacci(7), 13);
        }
    }
}
