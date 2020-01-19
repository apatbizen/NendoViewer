using NendoViewer;
using NUnit.Framework;
using System;

namespace NendoViewerTest {
    public class NendoProviderTest {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void GetYearFromDate_�����_3������() {
            var provider = new NendoProvider(4, 1);
            Assert.AreEqual(2019, provider.GetYearFromDate(new DateTime(2019, 4, 1)));
        }

        [Test]
        public void GetYearFromDate_������_3������() {
            var provider = new NendoProvider(4, 1);
            Assert.AreEqual(2019, provider.GetYearFromDate(new DateTime(2020, 3, 31)));
        }
    }
}