using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests
{
    [TestClass]
    public class UtmTests
    {
        private const string Result = "https://victorschlindwein.com/" +
                                      "?utm_source=source" +
                                      "&utm_medium=medium" +
                                      "&utm_campaign=name" +
                                      "&utm_id=id" +
                                      "&utm_term=term" +
                                      "&utm_content=content";

        private readonly Url _url = new("https://victorschlindwein.com/");
        private readonly Campaign _campaign = new(
            "source",
            "medium",
            "name",
            "id",
            "term",
            "content"
        );

        [TestMethod]
        public void ShouldReturnUrlFromUtm()
        {
            var utm = new Utm(_url, _campaign);
            
            Assert.AreEqual(Result, utm.ToString());
            Assert.AreEqual(Result, (string)utm);
        }

        [TestMethod]
        public void ShouldReturnUtmFromUrl()
        {
            Utm utm = Result;
            Assert.AreEqual("https://victorschlindwein.com/", utm.Url.Address);
            Assert.AreEqual("source", utm.Campaign.Source);
            Assert.AreEqual("medium", utm.Campaign.Medium);
            Assert.AreEqual("name", utm.Campaign.Name);
            Assert.AreEqual("id", utm.Campaign.Id);
            Assert.AreEqual("term", utm.Campaign.Term);
            Assert.AreEqual("content", utm.Campaign.Content);
        }
    }
}
