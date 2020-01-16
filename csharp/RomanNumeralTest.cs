using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp
{
    [TestClass]
    public class BankAccountTests
    {

        RomanNumeral rn;

        [TestInitialize ()]
        public void before ()
        {
            rn = new RomanNumeral ();
        }

        [TestMethod]
        public void TestOn1 ()
        {
            String res = rn.ConvertArabicToRomanNumeral (1);
            String exp = "I";
            Assert.AreEqual (exp, res);
        }

        [TestMethod]
        public void TestOn5 ()
        {
            String res = rn.ConvertArabicToRomanNumeral (5);
            String exp = "V";
            Assert.AreEqual (exp, res);
        }

        [TestMethod]
        public void TestOn10 ()
        {
            String res = rn.ConvertArabicToRomanNumeral (10);
            String exp = "X";
            Assert.AreEqual (exp, res);
        }

        [TestMethod]
        public void TestOn50 ()
        {
            String res = rn.ConvertArabicToRomanNumeral (50);
            String exp = "L";
            Assert.AreEqual (exp, res);
        }

        [TestMethod]
        public void TestOn100 ()
        {
            String res = rn.ConvertArabicToRomanNumeral (100);
            String exp = "C";
            Assert.AreEqual (exp, res);
        }

        [TestMethod]
        public void TestOn500 ()
        {
            String res = rn.ConvertArabicToRomanNumeral (500);
            String exp = "D";
            Assert.AreEqual (exp, res);
        }

        [TestMethod]
        public void TestOn1000 ()
        {
            String res = rn.ConvertArabicToRomanNumeral (1000);
            String exp = "M";
            Assert.AreEqual (exp, res);
        }

        [TestMethod]
        public void TestOn11 ()
        {
            String res = rn.ConvertArabicToRomanNumeral (11);
            String exp = "XI";
            Assert.AreEqual (exp, res);
        }

        [TestMethod]
        public void TestOn9 ()
        {
            String res = rn.ConvertArabicToRomanNumeral (9);
            String exp = "IX";
            Assert.AreEqual (exp, res);
        }

        [TestMethod]
        public void TestOn16 ()
        {
            String res = rn.ConvertArabicToRomanNumeral (16);
            String exp = "XVI";
            Assert.AreEqual (exp, res);
        }

        [TestMethod]
        public void TestOn1999 ()
        {
            String res = rn.ConvertArabicToRomanNumeral (1999);
            String exp = "MCMXCIX";
            Assert.AreEqual (exp, res);
        }

        [TestMethod]
        public void ThrowsIfNegative ()
        {
            Assert.ThrowsException<ArgumentException> (() => rn.ConvertArabicToRomanNumeral (-1));
        }

        [TestMethod]
        public void ThrowsIfTooLarge ()
        {
            Assert.ThrowsException<ArgumentException> (() => rn.ConvertArabicToRomanNumeral (-1));
        }

        [TestMethod]
        public void ThrowsIfZero ()
        {
            Assert.ThrowsException<ArgumentException> (() => rn.ConvertArabicToRomanNumeral (0));
        }

    }
}