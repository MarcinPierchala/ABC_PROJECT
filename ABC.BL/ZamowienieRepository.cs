using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class ZamowienieRepository
    {
        /// <summary>
        /// Pobieranie jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            Zamowienie zamowienie = new Zamowienie(zamowienieId);

            if(zamowienieId == 10)
            {
                zamowienie.DataZamowienia = new DateTimeOffset(2022, 3, 22, 22, 22, 22, new TimeSpan(7, 0, 0));
            }
            return zamowienie;
        }

        public WyswietanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId)
        {
            WyswietanieZamowienia wyswietlenieZamowienia = new WyswietanieZamowienia();

            if(zamowienieId == 10)
            {
                wyswietlenieZamowienia.Imie = "Marcin";
                wyswietlenieZamowienia.Nazwisko = "Pierchala";
                wyswietlenieZamowienia.DataZamowienia = new DateTimeOffset(2022, 3, 28, 21, 20, 00, new TimeSpan(7, 0, 0));
                wyswietlenieZamowienia.AdresDostawy = new Adres()
                {
                    AdresTyp = 1,
                    Ulica = "Ofiar NWO",
                    Miasto = "Deep_London",
                    Kraj = "Polin",
                    KodPocztowy = "321-00"
                };
            }

            wyswietlenieZamowienia.WyswPozycjiZamLista = new List<WyswPozycjiZam>();

            if(zamowienieId == 10)
            {
                var wyswietlaniePozycjiZamowienia = new WyswPozycjiZam()
                {
                    NazwaProduktu = "KBKAKMS",
                    IloscZamowienia = 100,
                    CenaZakupu = 321.22M
                };
                wyswietlenieZamowienia.WyswPozycjiZamLista.Add(wyswietlaniePozycjiZamowienia);

                wyswietlaniePozycjiZamowienia = new WyswPozycjiZam()
                {
                    NazwaProduktu = "MArgolin",
                    IloscZamowienia = 500,
                    CenaZakupu = 22.32M
                };
                wyswietlenieZamowienia.WyswPozycjiZamLista.Add(wyswietlaniePozycjiZamowienia);
            }

            return wyswietlenieZamowienia;
        }

        /// <summary>
        /// Zapisanie aktualnego zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Zamowienie zamowienie)
        {
            var sukces = true;

            if (zamowienie.MaZmiany && zamowienie.DaneSaPrawidlowe)
            {
                if (zamowienie.JestNowy)
                {
                    //trzeba wywołać insert
                }
                else
                {
                    //trzeba wywołać update
                }
            }

            return sukces;
        }
    }
}
