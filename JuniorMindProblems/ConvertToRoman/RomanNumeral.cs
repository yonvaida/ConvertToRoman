using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertToRoman
{
    [TestClass]
    public class RomanNumeral
    {
        [TestMethod]
        public void ValidNumber()
        {
            Assert.AreEqual("Are in interval", RomanConverted(50));
        }
        string RomanConverted(int number)
        {
            if (number < 0 && number > 100)
            {
                return "Not in interval";
            }else {
                return "Are in interval";
            }
        }
    }
}
