using System.Globalization;
using System.Windows;
using NUnit.Framework;

namespace SniffCore.Converters.Tests
{
    [TestFixture]
    public class BooleanToVisibilityInvertedConverterTests
    {
        [SetUp]
        public void Setup()
        {
            _target = new BooleanToVisibilityInvertedConverter();
        }

        private BooleanToVisibilityInvertedConverter _target;

        [Test]
        public void Convert_CalledWithTrue_ReturnsCollapsed()
        {
            var tmp = true;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Collapsed));
        }

        [Test]
        public void Convert_CalledWithFalse_ReturnsVisible()
        {
            var tmp = false;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Visible));
        }

        [Test]
        public void Convert_CalledWithNullableTrue_ReturnsCollapsed()
        {
            bool? tmp = true;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Collapsed));
        }

        [Test]
        public void Convert_CalledWithNullableFalse_ReturnsVisible()
        {
            bool? tmp = false;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Visible));
        }

        [Test]
        public void Convert_CalledWithNullableNull_ReturnsVisible()
        {
            bool? tmp = null;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Visible));
        }

        [Test]
        public void Convert_CalledWithAString_ReturnsVisible()
        {
            var tmp = "Hans";

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Visible));
        }

        [Test]
        public void Convert_CalledWithANumber_ReturnsVisible()
        {
            var tmp = 13;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Visible));
        }

        [Test]
        public void Convert_CalledWithNull_ReturnsVisible()
        {
            var result = _target.Convert(null, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Visible));
        }
    }
}