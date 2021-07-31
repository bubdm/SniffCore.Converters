using System.Globalization;
using System.Windows;
using NUnit.Framework;

namespace SniffCore.Converters.Tests
{
    [TestFixture]
    public class InverseBooleanConverterTests
    {
        [SetUp]
        public void Setup()
        {
            _target = new InverseBooleanConverter();
        }

        private InverseBooleanConverter _target;

        [Test]
        public void Convert_CalledWithTrue_ReturnsFalse()
        {
            var tmp = true;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.False);
        }

        [Test]
        public void Convert_CalledWithFalse_ReturnsTrue()
        {
            var tmp = false;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Convert_CalledWithNullableTrue_ReturnsFalse()
        {
            bool? tmp = true;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.False);
        }

        [Test]
        public void Convert_CalledWithNullableFalse_ReturnsTrue()
        {
            bool? tmp = false;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Convert_CalledWithNullableNull_ReturnsTrue()
        {
            bool? tmp = null;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Convert_CalledWithAString_ReturnsTrue()
        {
            var tmp = "Hans";

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Convert_CalledWithANumber_ReturnsTrue()
        {
            var tmp = 13;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Convert_CalledWithNull_ReturnsTrue()
        {
            var result = _target.Convert(null, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.True);
        }
    }
}