using Common_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Common_1Test
{
    [TestClass]
    public class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            //Arrange
            var zrodlo = "KlockiLego";
            var oczekiwana = "Klocki Lego";
            
            //Act
            var aktualna = zrodlo.WstawSpacje();

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {
            //Arrange
            var zrodlo = "Klocki Lego";
            var oczekiwana = "Klocki Lego";
            
            //Act
            var aktualna = zrodlo.WstawSpacje();

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
