using System.Globalization;
using System.Windows;
using NUnit.Framework;

namespace SniffCore.Converters.Tests
{
    [TestFixture]
    public class NullToVisibilityConverterTests
    {
        [SetUp]
        public void Setup()
        {
            _target = new NullToVisibilityConverter();
        }

        private NullToVisibilityConverter _target;

        [Test]
        public void Convert_CalledWithNull_ReturnsCollapsed()
        {
            object tmp = null;

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Collapsed));
        }

        [Test]
        public void Convert_CalledWithNotNull_ReturnsVisible()
        {
            object tmp = "Hans";

            var result = _target.Convert(tmp, typeof(Visibility), null, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Visible));
        }

        [Test]
        public void Convert_CalledWithNullAndNullIsCollapsed_ReturnsCollapsed()
        {
            object tmp = null;

            var result = _target.Convert(tmp, typeof(Visibility), NullToVisibilityDirection.NullIsCollapsed, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Collapsed));
        }

        [Test]
        public void Convert_CalledWithNotNullAndNullIsCollapsed_ReturnsVisible()
        {
            object tmp = "Hans";

            var result = _target.Convert(tmp, typeof(Visibility), NullToVisibilityDirection.NullIsCollapsed, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Visible));
        }

        [Test]
        public void Convert_CalledWithNullAndNotNullIsHidden_ReturnsVisible()
        {
            object tmp = null;

            var result = _target.Convert(tmp, typeof(Visibility), NullToVisibilityDirection.NotNullIsHidden, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Visible));
        }

        [Test]
        public void Convert_CalledWithNotNullAndNotNullIsHidden_ReturnsHidden()
        {
            object tmp = "Hans";

            var result = _target.Convert(tmp, typeof(Visibility), NullToVisibilityDirection.NotNullIsHidden, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Hidden));
        }

        [Test]
        public void Convert_CalledWithNullAndNullIsHidden_ReturnsCollapsed()
        {
            object tmp = null;

            var result = _target.Convert(tmp, typeof(Visibility), NullToVisibilityDirection.NullIsHidden, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Hidden));
        }

        [Test]
        public void Convert_CalledWithNotNullAndNullIsHidden_ReturnsVisible()
        {
            object tmp = "Hans";

            var result = _target.Convert(tmp, typeof(Visibility), NullToVisibilityDirection.NullIsHidden, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Visible));
        }

        [Test]
        public void Convert_CalledWithNullAndNullIsVisible_ReturnsCollapsed()
        {
            object tmp = null;

            var result = _target.Convert(tmp, typeof(Visibility), NullToVisibilityDirection.NullIsVisible, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Visible));
        }

        [Test]
        public void Convert_CalledWithNotNullAndNullIsVisible_ReturnsVisible()
        {
            object tmp = "Hans";

            var result = _target.Convert(tmp, typeof(Visibility), NullToVisibilityDirection.NullIsVisible, CultureInfo.CurrentCulture);

            Assert.That(result, Is.EqualTo(Visibility.Collapsed));
        }
    }
}