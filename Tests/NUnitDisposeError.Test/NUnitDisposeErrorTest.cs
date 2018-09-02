using NUnit.Framework;
using System;

namespace NUnitDisposeError.Test
{
    [TestFixture]
    public class NUnitDisposeErrorTest : IDisposable
    {
        private Adder mSut;

        [SetUp]
        public void SetUp()
        {
            mSut = new Adder();
        }

        [TearDown]
        public void TearDown()
        {
            mSut = null;
        }

        public void Dispose()
        {
            //This will throw.
            mSut.Dispose();
        }

        [TestCase(3, 5, 8)]
        public void Add_ShouldReturnExpectedValue(int x, int y, int expectedValue)
        {
            Assert.AreEqual(expectedValue, mSut.Add(x, y));
        }
    }
}
