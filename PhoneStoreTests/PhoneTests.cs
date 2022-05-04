using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhoneStore;

namespace PhoneStoreTests
{
    [TestClass]
    public class PhoneTests
    {
        [TestMethod]
        public void TestPhoneConstructorWithInvalidPrice_ThrowsException()
        {
            Assert.ThrowsException<Error>(() => new Phone("Xiaomi", "Mi 5", -300));
        }

        [TestMethod]
        public void TestPhonesEquality_ReturnsTrue()
        {
            Phone phone1 = new Phone("iPhone", "12", 1500);
            Phone phone2 = new Phone("iPhone", "12", 1500);

            bool expectedResult = true;

            bool actualResult = phone1 == phone2;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestPhonesInequality_ReturnsTrue()
        {
            Phone phone1 = new Phone("iPhone", "12", 1500);
            Phone phone2 = new Phone("Nokia", "3310", 15);

            bool expectedResult = true;

            bool actualResult = phone1 != phone2;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestPhoneToStringMethod_ReturnsPhoneBrandModelPrice()
        {
            Phone phone = new Phone("Huawei", "AC10", 500);

            string expectedResult = "Phone: Huawei AC10 500$";

            string actualResult = phone.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
