using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Activity.Profile;

namespace Activity1.Tests
{
    [TestClass]
    public class GetZodiacSignTests
    {
        [DataRow(8, 23)]
        [DataRow(8, 24)]
        [DataRow(9, 21)]
        [DataRow(9, 22)]
        [DataTestMethod]
        public void TestZodiacVirgo(int month, int date)
        {
            Assert.AreEqual(Zodiac.VIRGO, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }

        [DataRow(7, 23)]
        [DataRow(7, 24)]
        [DataRow(8, 21)]
        [DataRow(8, 22)]
        [DataTestMethod]
        public void TestZodiacLeo(int month, int date)
        {
            Assert.AreEqual(Zodiac.LEO, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }

        [DataRow(4, 20)]
        [DataRow(4, 21)]
        [DataRow(5, 19)]
        [DataRow(5, 20)]
        [DataTestMethod]
        public void TestZodiacTaurus(int month, int date)
        {
            Assert.AreEqual(Zodiac.TAURUS, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }

        [DataRow(3, 21)]
        [DataRow(3, 22)]
        [DataRow(4, 18)]
        [DataRow(4, 19)]
        [DataTestMethod]
        public void TestZodiacAries(int month, int date)
        {
            Assert.AreEqual(Zodiac.ARIES, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }

        [DataRow(5, 21)]
        [DataRow(5, 22)]
        [DataRow(6, 19)]
        [DataRow(6, 20)]
        [DataTestMethod]
        public void TestZodiacGemini(int month, int date)
        {
            Assert.AreEqual(Zodiac.GEMINI, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }

        [DataRow(6, 21)]
        [DataRow(6, 22)]
        [DataRow(7, 22)]
        [DataRow(7, 22)]
        [DataTestMethod]
        public void TestZodiacCancer(int month, int date)
        {
            Assert.AreEqual(Zodiac.CANCER, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }

        [DataRow(9, 23)]
        [DataRow(9, 24)]
        [DataRow(10, 21)]
        [DataRow(10, 22)]
        [DataTestMethod]
        public void TestZodiacLibra(int month, int date)
        {
            Assert.AreEqual(Zodiac.LIBRA, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }

        [DataRow(10, 23)]
        [DataRow(10, 24)]
        [DataRow(11, 20)]
        [DataRow(11, 21)]
        [DataTestMethod]
        public void TestZodiacScorpio(int month, int date)
        {
            Assert.AreEqual(Zodiac.SCORPIO, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }

        [DataRow(11, 22)]
        [DataRow(11, 23)]
        [DataRow(12, 20)]
        [DataRow(12, 21)]
        [DataTestMethod]
        public void TestZodiacSagittarius(int month, int date)
        {
            Assert.AreEqual(Zodiac.SAGITTARIUS, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }

        [DataRow(12, 22)]
        [DataRow(12, 23)]
        [DataRow(1, 18)]
        [DataRow(1, 19)]
        [DataTestMethod]
        public void TestZodiacCapricorn(int month, int date)
        {
            Assert.AreEqual(Zodiac.CAPRICORN, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }

        [DataRow(1, 20)]
        [DataRow(1, 21)]
        [DataRow(2, 17)]
        [DataRow(2, 18)]
        [DataTestMethod]
        public void TestZodiacAquarius(int month, int date)
        {
            Assert.AreEqual(Zodiac.AQUARIUS, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }

        [DataRow(2, 19)]
        [DataRow(2, 20)]
        [DataRow(3, 19)]
        [DataRow(3, 20)]
        [DataTestMethod]
        public void TestZodiacPisces(int month, int date)
        {
            Assert.AreEqual(Zodiac.PISCES, Zodiac.GetZodiacSign(new DateTime(DateTime.Now.Year, month, date)));
        }
    }
}
