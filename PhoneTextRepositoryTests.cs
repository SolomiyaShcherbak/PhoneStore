using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using PhoneStore;

namespace PhoneStoreTests
{
    [TestClass]
    public class PhoneTextRepositoryTests
    {
        [TestMethod]
        public void TestReadFromFile_ReadsFromFileAndUpdatesPhonesList()
        {
            Phone phone = new Phone("iPhone", "12", 1500);

            TextRepository<Phone> textRepository = new TextRepository<Phone>(fileName1);
            textRepository.ReadFromFile(fileName1);

            bool actualResult = textRepository.Size == 1
                && textRepository.GetAll()[0] == phone;

            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void TestWriteToFile_UpdatesFile()
        {
            TextRepository<Phone> textRepository = new TextRepository<Phone>(fileName2);
            textRepository.Add(new Phone("Samsung", "G7", 1000));
            textRepository.WriteToFile(fileName2);

            string expectedResult = "[{\"Brand\":\"Samsung\",\"Model\":\"G7\",\"Price\":1000.0}]";
            string actualResult = File.ReadAllText(fileName2);

            Assert.AreEqual(expectedResult, actualResult);

            File.WriteAllText(fileName2, String.Empty);
        }

        readonly string fileName1 = "C:/Users/Private/source/repos/PhoneStore/PhoneStoreTests/testFile1.json";
        readonly string fileName2 = "C:/Users/Private/source/repos/PhoneStore/PhoneStoreTests/testFile2.json";
    }
}
