using CoreLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CoreLibTest
{
    [TestClass]
    public class UtilsTest
    {
        Utils utils = new Utils();
        [TestMethod]
        public void TestPupkin1()
        {
            DateTime dateTime = DateTime.Parse("12.02.2011 20:32");
            string result = utils.DateNameConverter("Пупкин Василий Алексеевич", dateTime);
            Assert.AreEqual(result, "Пупкин_В.А._02.12.2011_20_32");
        }

        [TestMethod]
        public void TestPupkin2()
        {
            DateTime dateTime = DateTime.Parse("12.02.2011 20:32");
            string result = utils.DateNameConverter("Пупкин", "Василий", "Алексеевич", dateTime);
            Assert.AreEqual(result, "Пупкин_В.А._02.12.2011_20_32");
        }

        [TestMethod]
        public void TestNull1()
        {
            DateTime dateTime = DateTime.Parse("12.02.2011 20:32");
            string result = utils.DateNameConverter(" ", dateTime);
            Assert.AreEqual(result, "Ошибка, имя не распознано");
        }


        [TestMethod]
        public void TestNull2()
        {
            DateTime dateTime = DateTime.Parse("12.02.2011 20:32");
            string result = utils.DateNameConverter(" ", " ", " ", dateTime);
            Assert.AreEqual(result, "Ошибка, фамилия не распознана");
        }
    }
}
