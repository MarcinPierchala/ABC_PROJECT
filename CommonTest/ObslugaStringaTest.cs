using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace CommonTest
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

            var obslugaStringa = new ObslugaStringa();

            //Act
            var aktualna = obslugaStringa.InsertSpace(zrodlo);

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}
