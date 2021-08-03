using System;
using LearnAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearnAlgorithmsTests
{
    [TestClass]
    public class OtherAlgTest
    {
        [TestMethod]
        public void CountDayOffTest()
        {
            DateTime date1 = new DateTime(2021, 8, 3);
            DateTime date2 = new DateTime(2021, 8, 4);
            DateTime date3 = new DateTime(2021, 8, 10);
            
            int result = OtherAlgorithms.CountDayOff(date1, date1);
            Assert.IsTrue(result == 0);

            result = OtherAlgorithms.CountDayOff(date1, date2);
            Assert.IsTrue(result == 0);

            result = OtherAlgorithms.CountDayOff(date1, date3);
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void PrintForTest()
        {
            OtherAlgorithms.PrintFor(null);
        }

        [TestMethod]
        public void CaesarEncryptionTestNull()
        {
            OtherAlgorithms.CaesarEncryption(null, 1);
        }

        [TestMethod]
        public void CaesarEncryptionTest()
        {
            string text = new string(new Char[]{ 'А' });
            string newtext = OtherAlgorithms.CaesarEncryption(text, 1);
            Assert.IsTrue(newtext=="Б");
        }

        [TestMethod]
        public void CaesarEncryptionTestReverse()
        {
            string text = new string(new Char[] { 'Б' });
            string newtext = OtherAlgorithms.CaesarEncryption(text, -1);
            Assert.IsTrue(newtext == "А");
        }

        [TestMethod]
        public void CaesarEncryptionTestMin()
        {
            string text = new string(new Char[] { 'Б' });
            OtherAlgorithms.CaesarEncryption(text, int.MinValue);
        }

        [TestMethod]
        public void CaesarEncryptionTestMax()
        {
            string text = new string(new Char[] { 'Б' });
            OtherAlgorithms.CaesarEncryption(text, int.MaxValue);
        }

        [TestMethod]
        public void CaesarDecryptionTestNull()
        {
            OtherAlgorithms.CaesarDecryption(null, 1);
        }
    }
}
