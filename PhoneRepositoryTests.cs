using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhoneStore;

namespace PhoneStoreTests
{
    [TestClass]
    public class PhoneRepositoryTests
    {
        [TestMethod]
        public void TestAddPhone_UpdatesPhonesList()
        {
            Repository<Phone> phoneRepository = new Repository<Phone>();
            Phone phone = new Phone("iPhone", "12", 1500);
            phoneRepository.Add(phone);

            bool actualResult = phoneRepository.Size == 1
                && phoneRepository[0] == phone;

            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void TestRemovePhone_UpdatesPhonesList()
        {
            Repository<Phone> phoneRepository = new Repository<Phone>();
            Phone phone = new Phone("iPhone", "12", 1500);
            phoneRepository.Add(phone);

            phoneRepository.Remove(0);
            bool actualResult = phoneRepository.Size == 0;

            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void TestRemovePhoneWithNegativeIndex_ThrowsException()
        {
            Repository<Phone> phoneRepository = new Repository<Phone>();

            Assert.ThrowsException<Error>(() => phoneRepository.Remove(-1));
        }

        [TestMethod]
        public void TestReplacePhone_UpdatesPhonesList()
        {
            Repository<Phone> phoneRepository = new Repository<Phone>();
            Phone phone1 = new Phone("iPhone", "12", 1500);
            phoneRepository.Add(phone1);

            Phone phone2 = new Phone("Samsung", "Galaxy X5", 1000);
            phoneRepository.Replace(phone2, 0);

            bool actualResult = phoneRepository.Size == 1
                && phoneRepository[0] == phone2;

            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void TestSortPhonesByBrand_UpdatesPhonesList()
        {
            Repository<Phone> phoneRepository = new Repository<Phone>();
            Phone phone1 = new Phone("Nokia", "3310", 15);
            Phone phone2 = new Phone("iPhone", "12", 1500);
            phoneRepository.Add(phone1);
            phoneRepository.Add(phone2);    

            phoneRepository.Sort(new BrandComparer<Phone>());

            bool actualResult = phoneRepository[0].Brand == phone2.Brand
                && phoneRepository[1].Brand == phone1.Brand;

            Assert.IsTrue(actualResult);
        }
    }
}
