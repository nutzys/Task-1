using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Activity.Profile;

namespace Activity1.Tests
{
    [TestClass]
    public class ComputeAgeTests
    {
        [TestMethod]
        public void TestAgeEugene_BirthdayInMonth()
        {
            int currentAge = 0;
            int ageAfterBirthday = 1;
            DateTime birthday = DateTime.Now.AddYears(ageAfterBirthday * -1).AddMonths(1);
            var eugene = new PlayerProfile("Eugene", PlayerProfile.MALE, new DateTime(birthday.Year, birthday.Month, birthday.Day));

            Assert.AreEqual(currentAge, eugene.ComputeAge());
        }

        [TestMethod]
        public void TestAgeJohn_BirthdayTomorow()
        {
            int currentAge = 0;
            int ageAfterBirthday = 1;
            DateTime birthday = DateTime.Now.AddYears(ageAfterBirthday * -1).AddDays(1);
            var john = new PlayerProfile("John", PlayerProfile.FEMALE, new DateTime(birthday.Year, birthday.Month, birthday.Day));

            Assert.AreEqual(currentAge, john.ComputeAge());
        }

        [TestMethod]
        public void TestAgeTony_BirthdayToday()
        {
            int currentAge = 1;
            int ageAfterBirthday = 1;
            DateTime birthday = DateTime.Now.AddYears(ageAfterBirthday * -1);
            var tony = new PlayerProfile("Tony", PlayerProfile.MALE, new DateTime(birthday.Year, birthday.Month, birthday.Day));

            Assert.AreEqual(currentAge, tony.ComputeAge());
        }

        [TestMethod]
        public void TestAgeZero_WasBornToday()
        {
            int currentAge = 0;
            int ageAfterBirthday = 0;
            DateTime birthday = DateTime.Now;
            var now = new PlayerProfile("The Zero", PlayerProfile.MALE, new DateTime(birthday.Year, birthday.Month, birthday.Day));

            Assert.AreEqual(currentAge, now.ComputeAge());
        }

        [TestMethod]
        public void TestAgeNadja_BirthdayYesterday()
        {
            int currentAge = 1;
            int ageAfterBirthday = 1;
            DateTime birthday = DateTime.Now.AddYears(ageAfterBirthday * -1).AddDays(-1);
            var nadja = new PlayerProfile("Nadja", PlayerProfile.FEMALE, new DateTime(birthday.Year, birthday.Month, birthday.Day));

            Assert.AreEqual(currentAge, nadja.ComputeAge());
        }

        [TestMethod]
        public void TestAgeBob_BirthdayLastMonth()
        {
            int currentAge = 1;
            int ageAfterBirthday = 1;
            DateTime birthday = DateTime.Now.AddYears(ageAfterBirthday * -1).AddMonths(-1);
            var bob = new PlayerProfile("Bob", PlayerProfile.MALE, new DateTime(birthday.Year, birthday.Month, birthday.Day));

            Assert.AreEqual(currentAge, bob.ComputeAge());
        }

        [TestMethod]
        public void TestAgeChris_Immortal()
        {
            int currentAge = DateTime.Now.Year-1;
            int ageAfterBirthday = DateTime.Now.Year-1;
            DateTime birthday = DateTime.Now.AddYears(ageAfterBirthday * -1);
            var chris = new PlayerProfile("Chris", PlayerProfile.MALE, new DateTime(DateTime.MinValue.Year, birthday.Month, birthday.Day));

            Assert.AreEqual(currentAge, chris.ComputeAge());
        }
    }
}
