using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class KlientRepository
    {
        private AdresRepository adresRepository { get; set; }

        public KlientRepository()
        {
            adresRepository = new AdresRepository();
        }
        public bool Zapisz()
        {
            return true;
        }

        public Klient Pobierz(int klientId)
        {
            Klient klient = new Klient(klientId);

            klient.AdresList = adresRepository.PobierzPoKlientId(klientId).ToList();

            if (klientId == 1)
            {
                klient.Email = "macintecmarcin@gmail.com";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Pierchala";

            }

            return klient;
                
        }

        public List<Klient> Pobierz()
        {
            return new List<Klient>();
        }
    }
}
