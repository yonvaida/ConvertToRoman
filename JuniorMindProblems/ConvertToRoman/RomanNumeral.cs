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
            Assert.AreEqual("XVIII", convertNumber(18));
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
            int[] values = new int[] { 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[] { "C", "XC", "L", "XL", "X", "XI", "V", "IV", "I" };
            int units, tens;
            string numberConverted;
                numberConverted = "";
            for (int i = 0; i < 9; i++)
            {
                if (number / values[i] != 0)
                {
                    int iterations = number / values[i];
                    for (int j = 0; j < iterations; j++)
                    {
                        numberConverted = numberConverted + numerals[i];
                    }
                    number = number % values[i];
                }

            }
            return numberConverted;


        }

    }
       
      


    }

