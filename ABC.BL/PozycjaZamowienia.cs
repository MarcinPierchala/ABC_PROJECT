using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {

        }

        public PozycjaZamowienia(int pozycjaZamowieniaId)
        {
            PozycjaZamowieniaId = pozycjaZamowieniaId;
        }

        public int PozycjaZamowieniaId { get; private set; }
        public int Ilosc { get; set; }
        public int ProduktId { get; set; }
        public decimal? CenaZakupu { get; set; }

        /// <summary>
        /// Pobieranie jednej pozycji zamowienia
        /// </summary>
        /// <param name="pozycjaZamowieniaId"></param>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            return new PozycjaZamowienia();
        }

        /// <summary>
        /// Zapisanie aktualnego elementu zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }

        /// <summary>
        /// Sprawdzenie danych pozycji zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawnaWartosc = true;

            if (Ilosc <= 0)
                poprawnaWartosc = false;
            if (ProduktId <= 0)
                poprawnaWartosc = false;
            if (CenaZakupu == null)
                poprawnaWartosc = false;

            return poprawnaWartosc;
        }
    }
}

