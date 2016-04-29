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
            
            string[] numerals = new string[] { "I","II","III","IV","V","VI","VII","VIII","IX","X","XX","XXX","XL","L","LX","LXX","LXXX","XC","C" };
            int units, tens;
            string numberConverted;
                numberConverted = "";
            units = number % 10;
            tens = number / 10;
            numberConverted = numerals[8 + tens];
            numberConverted = numberConverted + numerals[units - 1];

            return numberConverted;


        }

    }
       
      


    }

