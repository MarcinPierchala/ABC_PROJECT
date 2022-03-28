using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BL;
using System.Collections.Generic;

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

        [TestMethod]
        public void PobierzKlientaZ_Adresami()
        {
            var klientRepository = new KlientRepository();

            var oczekiwanaWartosc = new Klient(1)
            {
                Email = "macintecmarcin@gmail.com",
                Imie = "Marcin",
                Nazwisko = "Pierchala",
                AdresList = new List<Adres>()
                {
                    new Adres(1)
                    {
                        AdresTyp = 1,
                        Ulica = "Sezmkowa",
                        Miasto = "Londyn",
                        Kraj = "Polin",
                        KodPocztowy = "54-321"
                    },

                    new Adres(2)
                    {
                        AdresTyp = 2,
                        Ulica = "Wiejska",
                        Miasto = "Wars_sava",
                        Kraj = "Polin",
                        KodPocztowy = "12-345"
                    }
                }
            };

            var aktualnaWartosc = klientRepository.Pobierz(1);

            //Assert.AreEqual(oczekiwanaWartosc, aktualnaWartosc);
            Assert.AreEqual(oczekiwanaWartosc.KlientId, aktualnaWartosc.KlientId);
            Assert.AreEqual(oczekiwanaWartosc.Email, aktualnaWartosc.Email);
            Assert.AreEqual(oczekiwanaWartosc.Imie, aktualnaWartosc.Imie);
            Assert.AreEqual(oczekiwanaWartosc.Nazwisko, aktualnaWartosc.Nazwisko);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(oczekiwanaWartosc.AdresList[i].AdresTyp, aktualnaWartosc.AdresList[i].AdresTyp);
                Assert.AreEqual(oczekiwanaWartosc.AdresList[i].Ulica, aktualnaWartosc.AdresList[i].Ulica);
                Assert.AreEqual(oczekiwanaWartosc.AdresList[i].Miasto, aktualnaWartosc.AdresList[i].Miasto);
                Assert.AreEqual(oczekiwanaWartosc.AdresList[i].KodPocztowy, aktualnaWartosc.AdresList[i].KodPocztowy);
                Assert.AreEqual(oczekiwanaWartosc.AdresList[i].Kraj, aktualnaWartosc.AdresList[i].Kraj);
            }

        }
    }
}
