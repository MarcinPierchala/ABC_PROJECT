using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    
    public class AdresRepository
    {
        Adres adres = new Adres();
        public Adres Pobierz(int adresId)
        {
            if(adresId == 1)
            {
                adres.AdresTyp = 1;
                adres.Ulica = "Sezmkowa";
                adres.Miasto = "Londyn";
                adres.Kraj = "Polin";
                adres.KodPocztowy = "54-321";
            }

            return adres;
        }

        public IEnumerable<Adres> PobierzPoKlientId(int klientId)
        {
            var adresList = new List<Adres>();

            Adres adres = new Adres(1)
            {
                AdresTyp = 1,
                Ulica = "Sezmkowa",
                Miasto = "Londyn",
                Kraj = "Polin",
                KodPocztowy = "54-321"
            };

            adresList.Add(adres);

            adres = new Adres(2)
            {
                AdresTyp = 2,
                Ulica = "Wiejska",
                Miasto = "Wars_sava",
                Kraj = "Polin",
                KodPocztowy = "12-345"
            };

            adresList.Add(adres);

            return adresList;
        }

        public bool Zapisz(Adres adres)
        {
            return true;
        }
    }
}
