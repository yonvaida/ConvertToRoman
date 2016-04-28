using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvertToRoman
{
    [TestClass]
    public class RomanNumeral
    {
        [TestMethod]
        public void validNumberTest()
        {
            Assert.AreEqual("Number is in interval", validNumber(50));
        }

        [TestMethod]
        public void convertNumberTest()
        {
            Assert.AreEqual("Number", convertNumber(11));
        }

        string validNumber(int number)
        {
            if (number < 0 && number > 100)
            {
                return "Not in interval";
            }else {
                return "Number is in interval";
            };
           
        }
        string convertNumber(int number) {
            switch (number)
            {
                case 1:
                        return "I";
                    break;
                case 5:
                        return "V";
                    break;
                case 10:
                        return "X";
                    break;
                case 50:
                        return "L";
                    break;
                case 100:
                        return "C";
                    break;
                default:
                    return "Number";

            }


        }
    }
}
