using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Pobieranie jednego produktu
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            Produkt produkt = new Produkt(produktId);
            Object mojObiekt = new Object();
            Console.WriteLine("Ten obiekt : " + mojObiekt.ToString());
            Console.WriteLine("Ten produkt : " + produkt.ToString());

            if(produktId == 2)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "LEGO, NR_98765";
                produkt.AktualnaCena = 987.65M;
            }
            return produkt;
        }

        /// <summary>
        /// Zapisanie aktualnego produktu
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }
    }
}
