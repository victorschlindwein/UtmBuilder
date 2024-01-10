using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        private const string InvalidUrl = "jakiro";
        private const string ValidUrl = "https://victorschlindwein.com";

        [TestMethod]
        [ExpectedException(typeof(InvalidUrlException))]
        public void ShoudReturnExceptionWhenInvalidUrl()
        {
            var url = new Url(InvalidUrl);
        }

        [TestMethod]
        public void ShoudNotReturnExceptionWhenInvalidUrl()
        {
            new Url(ValidUrl);
            Assert.IsTrue(true);
        }

        [TestMethod]
        [DataRow(" ", true)]
        [DataRow("http", true)]
        [DataRow(InvalidUrl, true)]
        [DataRow(ValidUrl, false)]
        public void TestUrl(
            string link,
            bool expectException)
        {
            if (expectException)
            {
                try
                {
                    new Url(link);
                    Assert.Fail();
                }
                catch (InvalidUrlException)
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                new Url(link);
                Assert.IsTrue(true);
            }
        }
    }
}
