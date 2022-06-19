using System;
using HRLibrary;
using NUnit.Framework;
namespace HRLibrary.UnitTests
{
    [TestFixture]
    public class ShowUnitTests
    {

        private Show CreateTestMedicine()
        {
            return new Show("Gooslings", "Райан Гослинг", "Новое \"маппет шоу\"!");
        }



        [Test]
        public void ConstructorTest()
        {
            var gooslings = CreateTestMedicine();
            Assert.AreEqual("Gooslings", gooslings.Name);
            Assert.AreEqual("Райан Гослинг", gooslings.Host);
            Assert.AreEqual("Новое \"маппет шоу\"!", gooslings.Discribing);
        }

        [Test]
        public void ToString_Person_Name()
        {
            var gooslings = CreateTestMedicine();
            Assert.AreEqual("Gooslings", gooslings.ToString());
        }

    }
}
