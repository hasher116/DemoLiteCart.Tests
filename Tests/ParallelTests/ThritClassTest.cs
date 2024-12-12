﻿using FluentAssertions;
using NUnit.Framework;

namespace DemoLiteCart.nUnitTests.Tests.ParallelTests
{
    [Parallelizable(ParallelScope.Fixtures)]
    [TestFixture]
    public class ThritClassTest
    {
        [Test]
        public void FirstTest()
        {
            var numberOfIteration = 10;
            var count = GetIterator(numberOfIteration);
            count.Should().Be(numberOfIteration);
        }

        [Test]
        public void SecondTest()
        {
            var numberOfIteration = 10;
            var count = GetIterator(numberOfIteration);
            count.Should().Be(numberOfIteration);
        }

        [Test]
        public void ThirdTest()
        {
            var numberOfIteration = 10;
            var count = GetIterator(numberOfIteration);
            count.Should().Be(numberOfIteration);
        }

        private int GetIterator(int number)
        {
            var counter = 0;
            for (int i = 0; i < number; i++)
            {
                counter++;
                Thread.Sleep(500);
            }
            return counter;
        }
    }
}
