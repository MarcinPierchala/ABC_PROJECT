using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class Zamowienie
    {
        public Zamowienie()
        {

        }

        public Zamowienie(int zamowinieId)
        {
            ZamowienieId = zamowinieId;
        }

        public int ZamowienieId { get; private set; }

        public List<PozycjaZamowienia> pozycjeZamowienia { get; set; }

        public int KlientId { get; set; }

        public int AdresDostawyId { get; set; }

        public DateTimeOffset? DataZamowienia { get; set; }

        /// <summary>
        /// Pobieranie jedno zamowienie
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            return new Zamowienie();
        }

        /// <summary>
        /// Zapisanie aktualnego zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }

        /// <summary>
        /// Sprawdzenie danych zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawnaWartosc = true;

            if (DataZamowienia == null)
                poprawnaWartosc = false;

            return poprawnaWartosc;
        }

        public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieId + ")";
        }
    }
}

