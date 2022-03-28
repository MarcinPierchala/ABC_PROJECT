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

        [TestMethod]

        public void PobierzZamowienieDoWyswietleniaTest()
        {
            var zamowienieRepository = new ZamowienieRepository();

            var oczekiwanaWartosc = new WyswietanieZamowienia()
            {
                Imie = "Marcin",
                Nazwisko = "Pierchala",
                DataZamowienia = new DateTimeOffset(2022, 3, 28, 21, 20, 00, new TimeSpan(7, 0, 0)),
                AdresDostawy = new Adres()
                {
                    AdresTyp = 1,
                    Ulica = "Ofiar NWO",
                    Miasto = "Deep_London",
                    Kraj = "Polin",
                    KodPocztowy = "321-00"
                },
                WyswPozycjiZamLista = new System.Collections.Generic.List<WyswPozycjiZam>()
                {
                    new WyswPozycjiZam()
                    {
                        NazwaProduktu = "KBKAKMS",
                        IloscZamowienia = 100,
                        CenaZakupu = 321.22M
                    },
                    new WyswPozycjiZam()
                    {
                        NazwaProduktu = "MArgolin",
                        IloscZamowienia = 500,
                        CenaZakupu = 22.32M
                    },
                }
            };

            var aktualnaWartosc = zamowienieRepository.PobierzZamowienieDoWyswietlenia(10);

            Assert.AreEqual(oczekiwanaWartosc.ZamowienieId, aktualnaWartosc.ZamowienieId);
            Assert.AreEqual(oczekiwanaWartosc.DataZamowienia, aktualnaWartosc.DataZamowienia);
            Assert.AreEqual(oczekiwanaWartosc.Imie, aktualnaWartosc.Imie);
            Assert.AreEqual(oczekiwanaWartosc.Nazwisko, aktualnaWartosc.Nazwisko);
            Assert.AreEqual(oczekiwanaWartosc.DataZamowienia, aktualnaWartosc.DataZamowienia);
            Assert.AreEqual(oczekiwanaWartosc.AdresDostawy.AdresTyp, aktualnaWartosc.AdresDostawy.AdresTyp);
            Assert.AreEqual(oczekiwanaWartosc.AdresDostawy.Ulica, aktualnaWartosc.AdresDostawy.Ulica);
            Assert.AreEqual(oczekiwanaWartosc.AdresDostawy.Miasto, aktualnaWartosc.AdresDostawy.Miasto);
            Assert.AreEqual(oczekiwanaWartosc.AdresDostawy.Kraj, aktualnaWartosc.AdresDostawy.Kraj);
            Assert.AreEqual(oczekiwanaWartosc.AdresDostawy.KodPocztowy, aktualnaWartosc.AdresDostawy.KodPocztowy);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwanaWartosc.WyswPozycjiZamLista[i].NazwaProduktu, aktualnaWartosc.WyswPozycjiZamLista[i].NazwaProduktu);
                Assert.AreEqual(oczekiwanaWartosc.WyswPozycjiZamLista[i].IloscZamowienia, aktualnaWartosc.WyswPozycjiZamLista[i].IloscZamowienia);
                Assert.AreEqual(oczekiwanaWartosc.WyswPozycjiZamLista[i].CenaZakupu, aktualnaWartosc.WyswPozycjiZamLista[i].CenaZakupu);
            }
        }
    }
}
