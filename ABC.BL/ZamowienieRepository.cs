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

        /// <summary>
        /// Zapisanie aktualnego zamowienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            return true;
        }
    }
}
