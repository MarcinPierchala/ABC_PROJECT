using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BL;

namespace ABC.BLTest
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlienta()
        {
            var klientRepository = new KlientRepository();

            var oczekiwanaWartosc = new Klient(1)
            {
                Email = "macintecmarcin@gmail.com",
                Imie = "Marcin",
                Nazwisko = "Pierchala"
            };

            var aktualnaWartosc = klientRepository.Pobierz(1);

            //Assert.AreEqual(oczekiwanaWartosc, aktualnaWartosc);
            Assert.AreEqual(oczekiwanaWartosc.KlientId, aktualnaWartosc.KlientId);
            Assert.AreEqual(oczekiwanaWartosc.Email, aktualnaWartosc.Email);
            Assert.AreEqual(oczekiwanaWartosc.Imie, aktualnaWartosc.Imie);
            Assert.AreEqual(oczekiwanaWartosc.Nazwisko, aktualnaWartosc.Nazwisko);

        }
    }
}
