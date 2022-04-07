using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class Produkt
    {
        public Produkt()
        {

        }

        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }

        public int ProduktId { get; private set; }
        public Decimal? AktualnaCena { get; set; }

        public string Opis { get; set; }

        public string NazwaProduktu { get; set; }

        /// <summary>
        /// Pobieranie jednego produktu
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            return new Produkt();
        }

        /// <summary>
        /// Zapisanie aktualnego produktu
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }

        /// <summary>
        /// Sprawdzenie danych produktu
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawnaWartosc = true;

            if(string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawnaWartosc = false;

            return poprawnaWartosc;
        }

        public override string ToString()
        {
            return NazwaProduktu;
        }
    }
}
