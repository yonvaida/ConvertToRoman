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
            Assert.AreEqual("number is in interval", RomanConverted(50));
        }
        public void CorectReturnedValue()
        {
            Assert.AreEqual("XI", RomanConverted(11));
        }
        string RomanConverted(int number)
        {
            if (number < 0 && number > 100)
            {
                return "Not in interval";
            }else {
                return "Number is in interval";
            };
           



        }
    }
}
