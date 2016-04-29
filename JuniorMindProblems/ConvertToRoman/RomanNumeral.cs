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
            Assert.AreEqual("XXI", convertNumber(21));
        }
        [TestMethod]
        public void convertNumberTestfor10()
        {
            Assert.AreEqual("X", convertNumber(10));
        }
        [TestMethod]
        public void convertNumberTestfor1()
        {
            Assert.AreEqual("I", convertNumber(1));
        }
        [TestMethod]
        public void convertNumberTestfor5()
        {
            Assert.AreEqual("V", convertNumber(5));
        }
        [TestMethod]
        public void convertNumberTestfor23()
        {
            Assert.AreEqual("XXIII", convertNumber(23));
        }
        [TestMethod]
        public void convertNumberTestfor100()
        {
            Assert.AreEqual("C", convertNumber(100));
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
            
            string[] numerals = new string[] {"", "I","II","III","IV","V","VI","VII","VIII","IX","","X","XX","XXX","XL","L","LX","LXX","LXXX","XC","C" };
            int units, tens;
            string numberConverted;
                numberConverted = "";
            units = number % 10;
            tens = number / 10;
            numberConverted = numerals[10+ tens];
            numberConverted = numberConverted + numerals[units];
            return numberConverted;


        }

    }
       
      


    }

