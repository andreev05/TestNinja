using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseStringWithStrongElement()
        {
            var htmlFormatter = new HtmlFormatter();

            var formattedText = htmlFormatter.FormatAsBold("test");

            Assert.That(formattedText, Is.EqualTo("<strong>test</strong>"));
        }
    }
}
