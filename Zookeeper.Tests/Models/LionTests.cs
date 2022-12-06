using System;
using FluentAssertions;
using NUnit.Framework;
using Zookeeper.Enums;
using Zookeeper.Models;

namespace Zookeeper.Tests.Models
{
    [TestFixture]
    public class LionTests
    {
        private Lion _lion;
        

        [SetUp]
        public void SetUp()
        {
            _lion = new OldLion();
        }

        [Test]
        public void IsDangerousReturnsTrue()
        {
            Assert.IsTrue(_lion.IsDangerous());
        }

        [Test]
        public void SizeIsMedium()
        {
            // NUnit (classic):
            Assert.AreEqual(Size.Medium, _lion.Size);

            // NUnit (modern):
            Assert.That(_lion.Size, Is.EqualTo(Size.Medium));

            // fluent assertions:
            _lion.Size.Should().Be(Size.Medium);
        }

        [TestCase(1)]
        [TestCase(2)]
        public void act(int value)
        {
            _lion.Age = value;

            _lion.Age.Should().Be(value);
        }

        [Test]
        public void NegativeAgeThrowsArgumentNullException()
        {
            // act
            TestDelegate act = () => _lion.Age = -1;

            // assert
            Assert.Throws<ArgumentOutOfRangeException>(act);
        }


        [Test, Ignore("Tests should only have *one* act!")]
        public void LionWorks()
        {
            bool result = _lion.IsDangerous();
            result.Should().BeTrue();

            int age = _lion.Age;
            Assert.AreEqual(1, age);
        }
    }
}
