using NendoViewer;
using NUnit.Framework;
using System;

namespace NendoViewerTest {
    public class NendoProviderTest {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void GetYearFromDate_ŠúŽñ“ú() {
            var provider = new NendoProvider();
            Assert.AreEqual(2019, provider.GetYearFromDate(new DateTime(2019, 4, 1)));
        }
    }
}