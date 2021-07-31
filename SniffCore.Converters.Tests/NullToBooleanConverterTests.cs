using System.Globalization;
using System.Windows;
using NUnit.Framework;

namespace SniffCore.Converters.Tests
{
    [TestFixture]
    public class NullToBooleanConverterTests
    {
        [SetUp]
        public void Setup()
        {
            _target = new NullToBooleanConverter();
        }

        private NullToBooleanConverter _target;

        [Test]
        public void Convert_CalledWithNull_ReturnsFalse()
        {
            object tmp = null;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.False);
        }

        [Test]
        public void Convert_CalledWithNotNull_ReturnsTrue()
        {
            object tmp = "Hans";

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Convert_CalledWithNullAndNullIsFalse_ReturnsFalse()
        {
            object tmp = null;

            var result = _target.Convert(tmp, typeof(Visibility), NullToBooleanDirection.NullIsFalse, CultureInfo.CurrentCulture);

            Assert.That(result, Is.False);
        }

        [Test]
        public void Convert_CalledWithNotNullAndNullIsFalse_ReturnsTrue()
        {
            object tmp = "Hans";

            var result = _target.Convert(tmp, typeof(Visibility), NullToBooleanDirection.NullIsFalse, CultureInfo.CurrentCulture);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Convert_CalledWithNullAndNullIsTrue_ReturnsFalse()
        {
            object tmp = null;

            var result = _target.Convert(tmp, typeof(Visibility), NullToBooleanDirection.NullIsTrue, CultureInfo.CurrentCulture);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Convert_CalledWithNotNullAndNullIsTrue_ReturnsTrue()
        {
            object tmp = "Hans";

            var result = _target.Convert(tmp, typeof(Visibility), NullToBooleanDirection.NullIsTrue, CultureInfo.CurrentCulture);

            Assert.That(result, Is.False);
        }
    }
}