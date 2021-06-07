using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MihKursTest;

namespace UniTestKurs
{
    [TestClass]
    public class UnitTest1
    {
        static Class1 disk__price;
        [ClassInitialize]
        static public void Init(TestContext tc)
        {
            disk__price = new Class1();
        }
        [TestMethod]
        public void DiscountPrice()
        {
            Assert.AreEqual(disk__price.DiscountPrice(100), 1500);
        }
        [TestMethod]
        public void SalaryNotNull()
        {
            Assert.AreEqual(disk__price.SalaryNotNull(-12), "цена не может быть меньше или равана нулю  или больше 100000");
        }
        [TestMethod]
        public void LoginTrue()
        {
            Assert.AreEqual(disk__price.LoginTrue("fdsaf"), false);
        }
        [TestMethod]
        public void PasswordTrue()
        {
            Assert.AreEqual(disk__price.PasswordTrue("2222"), false);
        }
    }
}
