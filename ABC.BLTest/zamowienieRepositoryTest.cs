using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BL;
using System;

namespace ABC.BLTest
{
    [TestClass]
    public class ZamowienieRepositoryTest
    {
        [TestMethod]

        public void PobierzZamowienie()
        {
            var zamowienieRepository = new ZamowienieRepository();

            var oczekiwanaWartosc = new Zamowienie(10)
            {
                DataZamowienia = new DateTimeOffset(2022, 3, 22, 22, 22, 22, new TimeSpan(7, 0, 0))
            };

            var aktualnaWartosc = zamowienieRepository.Pobierz(10);

            Assert.AreEqual(oczekiwanaWartosc.ZamowienieId, aktualnaWartosc.ZamowienieId);
            Assert.AreEqual(oczekiwanaWartosc.DataZamowienia, aktualnaWartosc.DataZamowienia);
        }
    }
}
