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

        [Test]
        public void GetYearFromDate_�����_1��20����() {
            var provider = new NendoProvider(1, 21);
            Assert.AreEqual(2010, provider.GetYearFromDate(new DateTime(2010, 1, 21)));
        }

        [Test]
        public void GetYearFromDate_������_1��20����() {
            var provider = new NendoProvider(1, 21);
            Assert.AreEqual(2009, provider.GetYearFromDate(new DateTime(2010, 1, 20)));
        }

        [Test]
        public void GetYearFromDate_��������v�Z_�����() {
            var provider = new NendoProvider(12, 15, NendoProvider.ReferenceAt.LastDate);
            Assert.AreEqual(2020, provider.GetYearFromDate(new DateTime(2020, 12, 15)));
        }
        [Test]
        public void GetYearFromDate_��������v�Z_������() {
            var provider = new NendoProvider(12, 15, NendoProvider.ReferenceAt.LastDate);
            Assert.AreEqual(2021, provider.GetYearFromDate(new DateTime(2020, 12, 16)));
        }
    }
}